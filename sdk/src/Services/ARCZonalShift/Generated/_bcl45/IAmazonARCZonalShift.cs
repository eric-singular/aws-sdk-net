/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ARCZonalShift.Model;

namespace Amazon.ARCZonalShift
{
    /// <summary>
    /// Interface for accessing ARCZonalShift
    ///
    /// This is the API Reference Guide for the zonal shift feature of Amazon Route 53 Application
    /// Recovery Controller. This guide is for developers who need detailed information about
    /// zonal shift API actions, data types, and errors.
    /// 
    ///  
    /// <para>
    /// Zonal shift is in preview release for Amazon Route 53 Application Recovery Controller
    /// and is subject to change.
    /// </para>
    ///  
    /// <para>
    /// Zonal shift in Route 53 ARC enables you to move traffic for a load balancer resource
    /// away from an Availability Zone. Starting a zonal shift helps your application recover
    /// immediately, for example, from a developer's bad code deployment or from an AWS infrastructure
    /// failure in a single Availability Zone, reducing the impact and time lost from an issue
    /// in one zone. 
    /// </para>
    ///  
    /// <para>
    /// Supported AWS resources are automatically registered with Route 53 ARC. Resources
    /// that are registered for zonal shifts in Route 53 ARC are managed resources in Route
    /// 53 ARC. You can start a zonal shift for any managed resource in your account in a
    /// Region. At this time, you can only start a zonal shift for Network Load Balancers
    /// and Application Load Balancers with cross-zone load balancing turned off.
    /// </para>
    ///  
    /// <para>
    /// Zonal shifts are temporary. You must specify an expiration when you start a zonal
    /// shift, of up to three days initially. If you want to still keep traffic away from
    /// an Availability Zone, you can update the zonal shift and set a new expiration. You
    /// can also cancel a zonal shift, before it expires, for example, if you're ready to
    /// restore traffic to the Availability Zone.
    /// </para>
    ///  
    /// <para>
    /// For more information about using zonal shift, see the <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/what-is-route53-recovery.html">Amazon
    /// Route 53 Application Recovery Controller Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonARCZonalShift : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IARCZonalShiftPaginatorFactory Paginators { get; }

        
        #region  CancelZonalShift


        /// <summary>
        /// Cancel a zonal shift in Amazon Route 53 Application Recovery Controller that you've
        /// started for a resource in your AWS account in an AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelZonalShift service method.</param>
        /// 
        /// <returns>The response from the CancelZonalShift service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CancelZonalShift">REST API Reference for CancelZonalShift Operation</seealso>
        CancelZonalShiftResponse CancelZonalShift(CancelZonalShiftRequest request);



        /// <summary>
        /// Cancel a zonal shift in Amazon Route 53 Application Recovery Controller that you've
        /// started for a resource in your AWS account in an AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelZonalShift service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelZonalShift service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/CancelZonalShift">REST API Reference for CancelZonalShift Operation</seealso>
        Task<CancelZonalShiftResponse> CancelZonalShiftAsync(CancelZonalShiftRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetManagedResource


        /// <summary>
        /// Get information about a resource that's been registered for zonal shifts with Amazon
        /// Route 53 Application Recovery Controller in this AWS Region. Resources that are registered
        /// for zonal shifts are managed resources in Route 53 ARC.
        /// 
        ///  
        /// <para>
        /// At this time, you can only start a zonal shift for Network Load Balancers and Application
        /// Load Balancers with cross-zone load balancing turned off.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedResource service method.</param>
        /// 
        /// <returns>The response from the GetManagedResource service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/GetManagedResource">REST API Reference for GetManagedResource Operation</seealso>
        GetManagedResourceResponse GetManagedResource(GetManagedResourceRequest request);



        /// <summary>
        /// Get information about a resource that's been registered for zonal shifts with Amazon
        /// Route 53 Application Recovery Controller in this AWS Region. Resources that are registered
        /// for zonal shifts are managed resources in Route 53 ARC.
        /// 
        ///  
        /// <para>
        /// At this time, you can only start a zonal shift for Network Load Balancers and Application
        /// Load Balancers with cross-zone load balancing turned off.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedResource service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/GetManagedResource">REST API Reference for GetManagedResource Operation</seealso>
        Task<GetManagedResourceResponse> GetManagedResourceAsync(GetManagedResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListManagedResources


        /// <summary>
        /// Lists all the resources in your AWS account in this AWS Region that are managed for
        /// zonal shifts in Amazon Route 53 Application Recovery Controller, and information about
        /// them. The information includes their Amazon Resource Names (ARNs), the Availability
        /// Zones the resources are deployed in, and the resource name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedResources service method.</param>
        /// 
        /// <returns>The response from the ListManagedResources service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListManagedResources">REST API Reference for ListManagedResources Operation</seealso>
        ListManagedResourcesResponse ListManagedResources(ListManagedResourcesRequest request);



        /// <summary>
        /// Lists all the resources in your AWS account in this AWS Region that are managed for
        /// zonal shifts in Amazon Route 53 Application Recovery Controller, and information about
        /// them. The information includes their Amazon Resource Names (ARNs), the Availability
        /// Zones the resources are deployed in, and the resource name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedResources service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListManagedResources">REST API Reference for ListManagedResources Operation</seealso>
        Task<ListManagedResourcesResponse> ListManagedResourcesAsync(ListManagedResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListZonalShifts


        /// <summary>
        /// Lists all the active zonal shifts in Amazon Route 53 Application Recovery Controller
        /// in your AWS account in this AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListZonalShifts service method.</param>
        /// 
        /// <returns>The response from the ListZonalShifts service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListZonalShifts">REST API Reference for ListZonalShifts Operation</seealso>
        ListZonalShiftsResponse ListZonalShifts(ListZonalShiftsRequest request);



        /// <summary>
        /// Lists all the active zonal shifts in Amazon Route 53 Application Recovery Controller
        /// in your AWS account in this AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListZonalShifts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListZonalShifts service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/ListZonalShifts">REST API Reference for ListZonalShifts Operation</seealso>
        Task<ListZonalShiftsResponse> ListZonalShiftsAsync(ListZonalShiftsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartZonalShift


        /// <summary>
        /// You start a zonal shift to temporarily move load balancer traffic away from an Availability
        /// Zone in a AWS Region, to help your application recover immediately, for example, from
        /// a developer's bad code deployment or from an AWS infrastructure failure in a single
        /// Availability Zone. You can start a zonal shift in Route 53 ARC only for managed resources
        /// in your account in an AWS Region. Resources are automatically registered with Route
        /// 53 ARC by AWS services.
        /// 
        ///  
        /// <para>
        /// At this time, you can only start a zonal shift for Network Load Balancers and Application
        /// Load Balancers with cross-zone load balancing turned off.
        /// </para>
        ///  
        /// <para>
        /// When you start a zonal shift, traffic for the resource is no longer routed to the
        /// Availability Zone. The zonal shift is created immediately in Route 53 ARC. However,
        /// it can take a short time, typically up to a few minutes, for existing, in-progress
        /// connections in the Availability Zone to complete.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.html">Zonal
        /// shift</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartZonalShift service method.</param>
        /// 
        /// <returns>The response from the StartZonalShift service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/StartZonalShift">REST API Reference for StartZonalShift Operation</seealso>
        StartZonalShiftResponse StartZonalShift(StartZonalShiftRequest request);



        /// <summary>
        /// You start a zonal shift to temporarily move load balancer traffic away from an Availability
        /// Zone in a AWS Region, to help your application recover immediately, for example, from
        /// a developer's bad code deployment or from an AWS infrastructure failure in a single
        /// Availability Zone. You can start a zonal shift in Route 53 ARC only for managed resources
        /// in your account in an AWS Region. Resources are automatically registered with Route
        /// 53 ARC by AWS services.
        /// 
        ///  
        /// <para>
        /// At this time, you can only start a zonal shift for Network Load Balancers and Application
        /// Load Balancers with cross-zone load balancing turned off.
        /// </para>
        ///  
        /// <para>
        /// When you start a zonal shift, traffic for the resource is no longer routed to the
        /// Availability Zone. The zonal shift is created immediately in Route 53 ARC. However,
        /// it can take a short time, typically up to a few minutes, for existing, in-progress
        /// connections in the Availability Zone to complete.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.html">Zonal
        /// shift</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartZonalShift service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartZonalShift service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/StartZonalShift">REST API Reference for StartZonalShift Operation</seealso>
        Task<StartZonalShiftResponse> StartZonalShiftAsync(StartZonalShiftRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateZonalShift


        /// <summary>
        /// Update an active zonal shift in Amazon Route 53 Application Recovery Controller in
        /// your AWS account. You can update a zonal shift to set a new expiration, or edit or
        /// replace the comment for the zonal shift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateZonalShift service method.</param>
        /// 
        /// <returns>The response from the UpdateZonalShift service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateZonalShift">REST API Reference for UpdateZonalShift Operation</seealso>
        UpdateZonalShiftResponse UpdateZonalShift(UpdateZonalShiftRequest request);



        /// <summary>
        /// Update an active zonal shift in Amazon Route 53 Application Recovery Controller in
        /// your AWS account. You can update a zonal shift to set a new expiration, or edit or
        /// replace the comment for the zonal shift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateZonalShift service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateZonalShift service method, as returned by ARCZonalShift.</returns>
        /// <exception cref="Amazon.ARCZonalShift.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ResourceNotFoundException">
        /// The input requested a resource that was not found.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ARCZonalShift.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/arc-zonal-shift-2022-10-30/UpdateZonalShift">REST API Reference for UpdateZonalShift Operation</seealso>
        Task<UpdateZonalShiftResponse> UpdateZonalShiftAsync(UpdateZonalShiftRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}