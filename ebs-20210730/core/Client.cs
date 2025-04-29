// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ebs20210730.Models;

namespace AlibabaCloud.SDK.Ebs20210730
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ebs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!AlibabaCloud.TeaUtil.Common.Empty(endpoint))
            {
                return endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(endpointMap) && !AlibabaCloud.TeaUtil.Common.Empty(endpointMap.Get(regionId)))
            {
                return endpointMap.Get(regionId);
            }
            return AlibabaCloud.EndpointUtil.Common.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a replication pair to a replication pair-consistent group. You can use a replication pair-consistent group to batch manage replication pairs. When you call this operation, you can specify parameters, such as ReplicaGroupId, ReplicaPairId, and ClientToken, in the request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>A replication pair and a replication pair-consistent group replicate in the same direction if they have the same primary region (production region), primary zone (production zone), secondary region (disaster recovery region), and secondary zone (disaster recovery zone). A replication pair can be added only to a replication pair-consistent group that replicates in the same direction as the replication pair.</description></item>
        /// <item><description>Before you can add a replication pair to a replication pair-consistent group, make sure that the pair and the group are in the <b>Created</b> (<c>created</c>) or <b>Stopped</b> (<c>stopped</c>) state.</description></item>
        /// <item><description>Up to 17 replication pairs can be added to a single replication pair-consistent group.</description></item>
        /// <item><description>After replication pairs are added to a replication pair-consistent group, the recovery point objective (RPO) of the group takes effect on the pairs in place of their original RPOs.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDiskReplicaPairResponse
        /// </returns>
        public AddDiskReplicaPairResponse AddDiskReplicaPairWithOptions(AddDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDiskReplicaPairResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a replication pair to a replication pair-consistent group. You can use a replication pair-consistent group to batch manage replication pairs. When you call this operation, you can specify parameters, such as ReplicaGroupId, ReplicaPairId, and ClientToken, in the request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>A replication pair and a replication pair-consistent group replicate in the same direction if they have the same primary region (production region), primary zone (production zone), secondary region (disaster recovery region), and secondary zone (disaster recovery zone). A replication pair can be added only to a replication pair-consistent group that replicates in the same direction as the replication pair.</description></item>
        /// <item><description>Before you can add a replication pair to a replication pair-consistent group, make sure that the pair and the group are in the <b>Created</b> (<c>created</c>) or <b>Stopped</b> (<c>stopped</c>) state.</description></item>
        /// <item><description>Up to 17 replication pairs can be added to a single replication pair-consistent group.</description></item>
        /// <item><description>After replication pairs are added to a replication pair-consistent group, the recovery point objective (RPO) of the group takes effect on the pairs in place of their original RPOs.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDiskReplicaPairResponse
        /// </returns>
        public async Task<AddDiskReplicaPairResponse> AddDiskReplicaPairWithOptionsAsync(AddDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDiskReplicaPairResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a replication pair to a replication pair-consistent group. You can use a replication pair-consistent group to batch manage replication pairs. When you call this operation, you can specify parameters, such as ReplicaGroupId, ReplicaPairId, and ClientToken, in the request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>A replication pair and a replication pair-consistent group replicate in the same direction if they have the same primary region (production region), primary zone (production zone), secondary region (disaster recovery region), and secondary zone (disaster recovery zone). A replication pair can be added only to a replication pair-consistent group that replicates in the same direction as the replication pair.</description></item>
        /// <item><description>Before you can add a replication pair to a replication pair-consistent group, make sure that the pair and the group are in the <b>Created</b> (<c>created</c>) or <b>Stopped</b> (<c>stopped</c>) state.</description></item>
        /// <item><description>Up to 17 replication pairs can be added to a single replication pair-consistent group.</description></item>
        /// <item><description>After replication pairs are added to a replication pair-consistent group, the recovery point objective (RPO) of the group takes effect on the pairs in place of their original RPOs.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDiskReplicaPairResponse
        /// </returns>
        public AddDiskReplicaPairResponse AddDiskReplicaPair(AddDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDiskReplicaPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a replication pair to a replication pair-consistent group. You can use a replication pair-consistent group to batch manage replication pairs. When you call this operation, you can specify parameters, such as ReplicaGroupId, ReplicaPairId, and ClientToken, in the request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>A replication pair and a replication pair-consistent group replicate in the same direction if they have the same primary region (production region), primary zone (production zone), secondary region (disaster recovery region), and secondary zone (disaster recovery zone). A replication pair can be added only to a replication pair-consistent group that replicates in the same direction as the replication pair.</description></item>
        /// <item><description>Before you can add a replication pair to a replication pair-consistent group, make sure that the pair and the group are in the <b>Created</b> (<c>created</c>) or <b>Stopped</b> (<c>stopped</c>) state.</description></item>
        /// <item><description>Up to 17 replication pairs can be added to a single replication pair-consistent group.</description></item>
        /// <item><description>After replication pairs are added to a replication pair-consistent group, the recovery point objective (RPO) of the group takes effect on the pairs in place of their original RPOs.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDiskReplicaPairResponse
        /// </returns>
        public async Task<AddDiskReplicaPairResponse> AddDiskReplicaPairAsync(AddDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDiskReplicaPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables CloudLens for EBS.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyLensServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyLensServiceResponse
        /// </returns>
        public ApplyLensServiceResponse ApplyLensServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyLensService",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyLensServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables CloudLens for EBS.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyLensServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyLensServiceResponse
        /// </returns>
        public async Task<ApplyLensServiceResponse> ApplyLensServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyLensService",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyLensServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables CloudLens for EBS.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <returns>
        /// ApplyLensServiceResponse
        /// </returns>
        public ApplyLensServiceResponse ApplyLensService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyLensServiceWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables CloudLens for EBS.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <returns>
        /// ApplyLensServiceResponse
        /// </returns>
        public async Task<ApplyLensServiceResponse> ApplyLensServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyLensServiceWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Bind disks into a enterprise-level snapshot policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindEnterpriseSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindEnterpriseSnapshotPolicyResponse
        /// </returns>
        public BindEnterpriseSnapshotPolicyResponse BindEnterpriseSnapshotPolicyWithOptions(BindEnterpriseSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskTargets))
            {
                query["DiskTargets"] = request.DiskTargets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindEnterpriseSnapshotPolicy",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindEnterpriseSnapshotPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Bind disks into a enterprise-level snapshot policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindEnterpriseSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindEnterpriseSnapshotPolicyResponse
        /// </returns>
        public async Task<BindEnterpriseSnapshotPolicyResponse> BindEnterpriseSnapshotPolicyWithOptionsAsync(BindEnterpriseSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskTargets))
            {
                query["DiskTargets"] = request.DiskTargets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindEnterpriseSnapshotPolicy",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindEnterpriseSnapshotPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Bind disks into a enterprise-level snapshot policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindEnterpriseSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// BindEnterpriseSnapshotPolicyResponse
        /// </returns>
        public BindEnterpriseSnapshotPolicyResponse BindEnterpriseSnapshotPolicy(BindEnterpriseSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindEnterpriseSnapshotPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Bind disks into a enterprise-level snapshot policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindEnterpriseSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// BindEnterpriseSnapshotPolicyResponse
        /// </returns>
        public async Task<BindEnterpriseSnapshotPolicyResponse> BindEnterpriseSnapshotPolicyAsync(BindEnterpriseSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindEnterpriseSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables CloudLens for EBS.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelLensServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelLensServiceResponse
        /// </returns>
        public CancelLensServiceResponse CancelLensServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelLensService",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelLensServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables CloudLens for EBS.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelLensServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelLensServiceResponse
        /// </returns>
        public async Task<CancelLensServiceResponse> CancelLensServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelLensService",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelLensServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables CloudLens for EBS.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <returns>
        /// CancelLensServiceResponse
        /// </returns>
        public CancelLensServiceResponse CancelLensService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelLensServiceWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables CloudLens for EBS.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <returns>
        /// CancelLensServiceResponse
        /// </returns>
        public async Task<CancelLensServiceResponse> CancelLensServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelLensServiceWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group to which an Elastic Block Storage (EBS) resource belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group to which an Elastic Block Storage (EBS) resource belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group to which an Elastic Block Storage (EBS) resource belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group to which an Elastic Block Storage (EBS) resource belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clears the disaster recovery drills that were initiated from the secondary disk of a replication pair and deletes the auto-created drill disks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearPairDrillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClearPairDrillResponse
        /// </returns>
        public ClearPairDrillResponse ClearPairDrillWithOptions(ClearPairDrillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrillId))
            {
                query["DrillId"] = request.DrillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PairId))
            {
                query["PairId"] = request.PairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearPairDrill",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearPairDrillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clears the disaster recovery drills that were initiated from the secondary disk of a replication pair and deletes the auto-created drill disks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearPairDrillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClearPairDrillResponse
        /// </returns>
        public async Task<ClearPairDrillResponse> ClearPairDrillWithOptionsAsync(ClearPairDrillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrillId))
            {
                query["DrillId"] = request.DrillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PairId))
            {
                query["PairId"] = request.PairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearPairDrill",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearPairDrillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clears the disaster recovery drills that were initiated from the secondary disk of a replication pair and deletes the auto-created drill disks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearPairDrillRequest
        /// </param>
        /// 
        /// <returns>
        /// ClearPairDrillResponse
        /// </returns>
        public ClearPairDrillResponse ClearPairDrill(ClearPairDrillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearPairDrillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clears the disaster recovery drills that were initiated from the secondary disk of a replication pair and deletes the auto-created drill disks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearPairDrillRequest
        /// </param>
        /// 
        /// <returns>
        /// ClearPairDrillResponse
        /// </returns>
        public async Task<ClearPairDrillResponse> ClearPairDrillAsync(ClearPairDrillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearPairDrillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clears the disaster recovery drills that were initiated from the secondary disks of a replication pair-consistent group and deletes the auto-created drill disks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearReplicaGroupDrillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClearReplicaGroupDrillResponse
        /// </returns>
        public ClearReplicaGroupDrillResponse ClearReplicaGroupDrillWithOptions(ClearReplicaGroupDrillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrillId))
            {
                query["DrillId"] = request.DrillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearReplicaGroupDrill",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearReplicaGroupDrillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clears the disaster recovery drills that were initiated from the secondary disks of a replication pair-consistent group and deletes the auto-created drill disks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearReplicaGroupDrillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClearReplicaGroupDrillResponse
        /// </returns>
        public async Task<ClearReplicaGroupDrillResponse> ClearReplicaGroupDrillWithOptionsAsync(ClearReplicaGroupDrillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrillId))
            {
                query["DrillId"] = request.DrillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearReplicaGroupDrill",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearReplicaGroupDrillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clears the disaster recovery drills that were initiated from the secondary disks of a replication pair-consistent group and deletes the auto-created drill disks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearReplicaGroupDrillRequest
        /// </param>
        /// 
        /// <returns>
        /// ClearReplicaGroupDrillResponse
        /// </returns>
        public ClearReplicaGroupDrillResponse ClearReplicaGroupDrill(ClearReplicaGroupDrillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearReplicaGroupDrillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clears the disaster recovery drills that were initiated from the secondary disks of a replication pair-consistent group and deletes the auto-created drill disks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearReplicaGroupDrillRequest
        /// </param>
        /// 
        /// <returns>
        /// ClearReplicaGroupDrillResponse
        /// </returns>
        public async Task<ClearReplicaGroupDrillResponse> ClearReplicaGroupDrillAsync(ClearReplicaGroupDrillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearReplicaGroupDrillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dedicated block storage cluster. When you call this operation, you can specify parameters, such as Azone, Capacity, Type, and PeriodUnit, in the request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>Dedicated block storage clusters are physically isolated from public block storage clusters. The owner of each dedicated block storage cluster has exclusive access to all resources in the cluster.</description></item>
        /// <item><description>Disks created in a dedicated block storage cluster can be attached only to Elastic Compute Service (ECS) instances that reside in the same zone as the cluster. Before you create a dedicated block storage cluster, decide the regions and zones in which to deploy your cloud resources.</description></item>
        /// <item><description>Dedicated block storage clusters are classified into basic and performance types. When you create a dedicated block storage cluster, select a cluster type based on your business requirements.</description></item>
        /// <item><description>You are charged for creating dedicated block storage clusters.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDedicatedBlockStorageClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDedicatedBlockStorageClusterResponse
        /// </returns>
        public CreateDedicatedBlockStorageClusterResponse CreateDedicatedBlockStorageClusterWithOptions(CreateDedicatedBlockStorageClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Azone))
            {
                query["Azone"] = request.Azone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capacity))
            {
                query["Capacity"] = request.Capacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbscId))
            {
                query["DbscId"] = request.DbscId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbscName))
            {
                query["DbscName"] = request.DbscName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDedicatedBlockStorageCluster",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedBlockStorageClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dedicated block storage cluster. When you call this operation, you can specify parameters, such as Azone, Capacity, Type, and PeriodUnit, in the request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>Dedicated block storage clusters are physically isolated from public block storage clusters. The owner of each dedicated block storage cluster has exclusive access to all resources in the cluster.</description></item>
        /// <item><description>Disks created in a dedicated block storage cluster can be attached only to Elastic Compute Service (ECS) instances that reside in the same zone as the cluster. Before you create a dedicated block storage cluster, decide the regions and zones in which to deploy your cloud resources.</description></item>
        /// <item><description>Dedicated block storage clusters are classified into basic and performance types. When you create a dedicated block storage cluster, select a cluster type based on your business requirements.</description></item>
        /// <item><description>You are charged for creating dedicated block storage clusters.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDedicatedBlockStorageClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDedicatedBlockStorageClusterResponse
        /// </returns>
        public async Task<CreateDedicatedBlockStorageClusterResponse> CreateDedicatedBlockStorageClusterWithOptionsAsync(CreateDedicatedBlockStorageClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Azone))
            {
                query["Azone"] = request.Azone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capacity))
            {
                query["Capacity"] = request.Capacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbscId))
            {
                query["DbscId"] = request.DbscId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbscName))
            {
                query["DbscName"] = request.DbscName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDedicatedBlockStorageCluster",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDedicatedBlockStorageClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dedicated block storage cluster. When you call this operation, you can specify parameters, such as Azone, Capacity, Type, and PeriodUnit, in the request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>Dedicated block storage clusters are physically isolated from public block storage clusters. The owner of each dedicated block storage cluster has exclusive access to all resources in the cluster.</description></item>
        /// <item><description>Disks created in a dedicated block storage cluster can be attached only to Elastic Compute Service (ECS) instances that reside in the same zone as the cluster. Before you create a dedicated block storage cluster, decide the regions and zones in which to deploy your cloud resources.</description></item>
        /// <item><description>Dedicated block storage clusters are classified into basic and performance types. When you create a dedicated block storage cluster, select a cluster type based on your business requirements.</description></item>
        /// <item><description>You are charged for creating dedicated block storage clusters.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDedicatedBlockStorageClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDedicatedBlockStorageClusterResponse
        /// </returns>
        public CreateDedicatedBlockStorageClusterResponse CreateDedicatedBlockStorageCluster(CreateDedicatedBlockStorageClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDedicatedBlockStorageClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dedicated block storage cluster. When you call this operation, you can specify parameters, such as Azone, Capacity, Type, and PeriodUnit, in the request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>Dedicated block storage clusters are physically isolated from public block storage clusters. The owner of each dedicated block storage cluster has exclusive access to all resources in the cluster.</description></item>
        /// <item><description>Disks created in a dedicated block storage cluster can be attached only to Elastic Compute Service (ECS) instances that reside in the same zone as the cluster. Before you create a dedicated block storage cluster, decide the regions and zones in which to deploy your cloud resources.</description></item>
        /// <item><description>Dedicated block storage clusters are classified into basic and performance types. When you create a dedicated block storage cluster, select a cluster type based on your business requirements.</description></item>
        /// <item><description>You are charged for creating dedicated block storage clusters.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDedicatedBlockStorageClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDedicatedBlockStorageClusterResponse
        /// </returns>
        public async Task<CreateDedicatedBlockStorageClusterResponse> CreateDedicatedBlockStorageClusterAsync(CreateDedicatedBlockStorageClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDedicatedBlockStorageClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>The replication pair-consistent group feature allows you to batch manage multiple disks in disaster recovery scenarios. You can restore the data of all disks in the same replication pair-consistent group to the same point in time to allow for disaster recovery of instances.
        /// Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Replication pair-consistent groups can be used to implement disaster recovery across zones within the same region and disaster recovery across regions.</description></item>
        /// <item><description>A replication pair and a replication pair-consistent group can replicate in the same direction if they have the same primary region (production region), primary zone (production zone), secondary region (disaster recovery region), and secondary zone (disaster recovery zone). A replication pair can be added to only a replication pair-consistent group that replicates in the same direction as the replication pair.</description></item>
        /// <item><description>After replication pairs are added to a replication pair-consistent group, the recovery point objective (RPO) of the group takes effect on the pairs instead of their original RPOs.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDiskReplicaGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDiskReplicaGroupResponse
        /// </returns>
        public CreateDiskReplicaGroupResponse CreateDiskReplicaGroupWithOptions(CreateDiskReplicaGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationRegionId))
            {
                query["DestinationRegionId"] = request.DestinationRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationZoneId))
            {
                query["DestinationZoneId"] = request.DestinationZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RPO))
            {
                query["RPO"] = request.RPO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceZoneId))
            {
                query["SourceZoneId"] = request.SourceZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDiskReplicaGroup",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDiskReplicaGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>The replication pair-consistent group feature allows you to batch manage multiple disks in disaster recovery scenarios. You can restore the data of all disks in the same replication pair-consistent group to the same point in time to allow for disaster recovery of instances.
        /// Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Replication pair-consistent groups can be used to implement disaster recovery across zones within the same region and disaster recovery across regions.</description></item>
        /// <item><description>A replication pair and a replication pair-consistent group can replicate in the same direction if they have the same primary region (production region), primary zone (production zone), secondary region (disaster recovery region), and secondary zone (disaster recovery zone). A replication pair can be added to only a replication pair-consistent group that replicates in the same direction as the replication pair.</description></item>
        /// <item><description>After replication pairs are added to a replication pair-consistent group, the recovery point objective (RPO) of the group takes effect on the pairs instead of their original RPOs.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDiskReplicaGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDiskReplicaGroupResponse
        /// </returns>
        public async Task<CreateDiskReplicaGroupResponse> CreateDiskReplicaGroupWithOptionsAsync(CreateDiskReplicaGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationRegionId))
            {
                query["DestinationRegionId"] = request.DestinationRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationZoneId))
            {
                query["DestinationZoneId"] = request.DestinationZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RPO))
            {
                query["RPO"] = request.RPO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceZoneId))
            {
                query["SourceZoneId"] = request.SourceZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDiskReplicaGroup",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDiskReplicaGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>The replication pair-consistent group feature allows you to batch manage multiple disks in disaster recovery scenarios. You can restore the data of all disks in the same replication pair-consistent group to the same point in time to allow for disaster recovery of instances.
        /// Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Replication pair-consistent groups can be used to implement disaster recovery across zones within the same region and disaster recovery across regions.</description></item>
        /// <item><description>A replication pair and a replication pair-consistent group can replicate in the same direction if they have the same primary region (production region), primary zone (production zone), secondary region (disaster recovery region), and secondary zone (disaster recovery zone). A replication pair can be added to only a replication pair-consistent group that replicates in the same direction as the replication pair.</description></item>
        /// <item><description>After replication pairs are added to a replication pair-consistent group, the recovery point objective (RPO) of the group takes effect on the pairs instead of their original RPOs.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDiskReplicaGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDiskReplicaGroupResponse
        /// </returns>
        public CreateDiskReplicaGroupResponse CreateDiskReplicaGroup(CreateDiskReplicaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDiskReplicaGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>The replication pair-consistent group feature allows you to batch manage multiple disks in disaster recovery scenarios. You can restore the data of all disks in the same replication pair-consistent group to the same point in time to allow for disaster recovery of instances.
        /// Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Replication pair-consistent groups can be used to implement disaster recovery across zones within the same region and disaster recovery across regions.</description></item>
        /// <item><description>A replication pair and a replication pair-consistent group can replicate in the same direction if they have the same primary region (production region), primary zone (production zone), secondary region (disaster recovery region), and secondary zone (disaster recovery zone). A replication pair can be added to only a replication pair-consistent group that replicates in the same direction as the replication pair.</description></item>
        /// <item><description>After replication pairs are added to a replication pair-consistent group, the recovery point objective (RPO) of the group takes effect on the pairs instead of their original RPOs.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDiskReplicaGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDiskReplicaGroupResponse
        /// </returns>
        public async Task<CreateDiskReplicaGroupResponse> CreateDiskReplicaGroupAsync(CreateDiskReplicaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDiskReplicaGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a replication pair to asynchronously replicate data between disks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Async replication is a feature that protects data across regions by using the data replication capability of Elastic Block Storage (EBS). This feature can be used to asynchronously replicate data from a disk in one region to a disk in another region for disaster recovery purposes. You can use this feature to implement disaster recovery for critical business to protect data in your databases and improve business continuity.
        /// Currently, the async replication feature can asynchronously replicate data only between enhanced SSDs (ESSDs). The functionality of disks in replication pairs is limited. You are charged on a subscription basis for the bandwidth that is used by the async replication feature.
        /// Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that the source disk (primary disk) from which to replicate data and the destination disk (secondary disk) to which to replicate data are created. You can call the <a href="https://help.aliyun.com/document_detail/25513.html">CreateDisk</a> operation to create disks.</description></item>
        /// <item><description>The secondary disk cannot reside the same region as the primary disk. The async replication feature is supported in the China (Hangzhou), China (Shanghai), China (Beijing), China (Shenzhen), China (Heyuan), China (Chengdu), China (Hong Kong), Singapore, US (Silicon Valley), and US (Virginia) regions.</description></item>
        /// <item><description>After you call this operation to create a replication pair, you must call the <a href="https://help.aliyun.com/document_detail/354205.html">StartDiskReplicaPair</a> operation to enable async replication to periodically replicate data from the primary disk to the secondary disk across regions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDiskReplicaPairResponse
        /// </returns>
        public CreateDiskReplicaPairResponse CreateDiskReplicaPairWithOptions(CreateDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationDiskId))
            {
                query["DestinationDiskId"] = request.DestinationDiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationRegionId))
            {
                query["DestinationRegionId"] = request.DestinationRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationZoneId))
            {
                query["DestinationZoneId"] = request.DestinationZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PairName))
            {
                query["PairName"] = request.PairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RPO))
            {
                query["RPO"] = request.RPO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceZoneId))
            {
                query["SourceZoneId"] = request.SourceZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDiskReplicaPairResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a replication pair to asynchronously replicate data between disks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Async replication is a feature that protects data across regions by using the data replication capability of Elastic Block Storage (EBS). This feature can be used to asynchronously replicate data from a disk in one region to a disk in another region for disaster recovery purposes. You can use this feature to implement disaster recovery for critical business to protect data in your databases and improve business continuity.
        /// Currently, the async replication feature can asynchronously replicate data only between enhanced SSDs (ESSDs). The functionality of disks in replication pairs is limited. You are charged on a subscription basis for the bandwidth that is used by the async replication feature.
        /// Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that the source disk (primary disk) from which to replicate data and the destination disk (secondary disk) to which to replicate data are created. You can call the <a href="https://help.aliyun.com/document_detail/25513.html">CreateDisk</a> operation to create disks.</description></item>
        /// <item><description>The secondary disk cannot reside the same region as the primary disk. The async replication feature is supported in the China (Hangzhou), China (Shanghai), China (Beijing), China (Shenzhen), China (Heyuan), China (Chengdu), China (Hong Kong), Singapore, US (Silicon Valley), and US (Virginia) regions.</description></item>
        /// <item><description>After you call this operation to create a replication pair, you must call the <a href="https://help.aliyun.com/document_detail/354205.html">StartDiskReplicaPair</a> operation to enable async replication to periodically replicate data from the primary disk to the secondary disk across regions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDiskReplicaPairResponse
        /// </returns>
        public async Task<CreateDiskReplicaPairResponse> CreateDiskReplicaPairWithOptionsAsync(CreateDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationDiskId))
            {
                query["DestinationDiskId"] = request.DestinationDiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationRegionId))
            {
                query["DestinationRegionId"] = request.DestinationRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationZoneId))
            {
                query["DestinationZoneId"] = request.DestinationZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PairName))
            {
                query["PairName"] = request.PairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RPO))
            {
                query["RPO"] = request.RPO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceZoneId))
            {
                query["SourceZoneId"] = request.SourceZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDiskReplicaPairResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a replication pair to asynchronously replicate data between disks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Async replication is a feature that protects data across regions by using the data replication capability of Elastic Block Storage (EBS). This feature can be used to asynchronously replicate data from a disk in one region to a disk in another region for disaster recovery purposes. You can use this feature to implement disaster recovery for critical business to protect data in your databases and improve business continuity.
        /// Currently, the async replication feature can asynchronously replicate data only between enhanced SSDs (ESSDs). The functionality of disks in replication pairs is limited. You are charged on a subscription basis for the bandwidth that is used by the async replication feature.
        /// Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that the source disk (primary disk) from which to replicate data and the destination disk (secondary disk) to which to replicate data are created. You can call the <a href="https://help.aliyun.com/document_detail/25513.html">CreateDisk</a> operation to create disks.</description></item>
        /// <item><description>The secondary disk cannot reside the same region as the primary disk. The async replication feature is supported in the China (Hangzhou), China (Shanghai), China (Beijing), China (Shenzhen), China (Heyuan), China (Chengdu), China (Hong Kong), Singapore, US (Silicon Valley), and US (Virginia) regions.</description></item>
        /// <item><description>After you call this operation to create a replication pair, you must call the <a href="https://help.aliyun.com/document_detail/354205.html">StartDiskReplicaPair</a> operation to enable async replication to periodically replicate data from the primary disk to the secondary disk across regions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDiskReplicaPairResponse
        /// </returns>
        public CreateDiskReplicaPairResponse CreateDiskReplicaPair(CreateDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDiskReplicaPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a replication pair to asynchronously replicate data between disks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Async replication is a feature that protects data across regions by using the data replication capability of Elastic Block Storage (EBS). This feature can be used to asynchronously replicate data from a disk in one region to a disk in another region for disaster recovery purposes. You can use this feature to implement disaster recovery for critical business to protect data in your databases and improve business continuity.
        /// Currently, the async replication feature can asynchronously replicate data only between enhanced SSDs (ESSDs). The functionality of disks in replication pairs is limited. You are charged on a subscription basis for the bandwidth that is used by the async replication feature.
        /// Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Make sure that the source disk (primary disk) from which to replicate data and the destination disk (secondary disk) to which to replicate data are created. You can call the <a href="https://help.aliyun.com/document_detail/25513.html">CreateDisk</a> operation to create disks.</description></item>
        /// <item><description>The secondary disk cannot reside the same region as the primary disk. The async replication feature is supported in the China (Hangzhou), China (Shanghai), China (Beijing), China (Shenzhen), China (Heyuan), China (Chengdu), China (Hong Kong), Singapore, US (Silicon Valley), and US (Virginia) regions.</description></item>
        /// <item><description>After you call this operation to create a replication pair, you must call the <a href="https://help.aliyun.com/document_detail/354205.html">StartDiskReplicaPair</a> operation to enable async replication to periodically replicate data from the primary disk to the secondary disk across regions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDiskReplicaPairResponse
        /// </returns>
        public async Task<CreateDiskReplicaPairResponse> CreateDiskReplicaPairAsync(CreateDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDiskReplicaPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create an enterprise-level snapshot policy</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateEnterpriseSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEnterpriseSnapshotPolicyResponse
        /// </returns>
        public CreateEnterpriseSnapshotPolicyResponse CreateEnterpriseSnapshotPolicyWithOptions(CreateEnterpriseSnapshotPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEnterpriseSnapshotPolicyShrinkRequest request = new CreateEnterpriseSnapshotPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CrossRegionCopyInfo))
            {
                request.CrossRegionCopyInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CrossRegionCopyInfo, "CrossRegionCopyInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RetainRule))
            {
                request.RetainRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RetainRule, "RetainRule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Schedule))
            {
                request.ScheduleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Schedule, "Schedule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SpecialRetainRules))
            {
                request.SpecialRetainRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SpecialRetainRules, "SpecialRetainRules", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StorageRule))
            {
                request.StorageRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StorageRule, "StorageRule", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossRegionCopyInfoShrink))
            {
                query["CrossRegionCopyInfo"] = request.CrossRegionCopyInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                query["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainRuleShrink))
            {
                query["RetainRule"] = request.RetainRuleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleShrink))
            {
                query["Schedule"] = request.ScheduleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecialRetainRulesShrink))
            {
                query["SpecialRetainRules"] = request.SpecialRetainRulesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageRuleShrink))
            {
                query["StorageRule"] = request.StorageRuleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEnterpriseSnapshotPolicy",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEnterpriseSnapshotPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create an enterprise-level snapshot policy</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateEnterpriseSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEnterpriseSnapshotPolicyResponse
        /// </returns>
        public async Task<CreateEnterpriseSnapshotPolicyResponse> CreateEnterpriseSnapshotPolicyWithOptionsAsync(CreateEnterpriseSnapshotPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEnterpriseSnapshotPolicyShrinkRequest request = new CreateEnterpriseSnapshotPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CrossRegionCopyInfo))
            {
                request.CrossRegionCopyInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CrossRegionCopyInfo, "CrossRegionCopyInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RetainRule))
            {
                request.RetainRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RetainRule, "RetainRule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Schedule))
            {
                request.ScheduleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Schedule, "Schedule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SpecialRetainRules))
            {
                request.SpecialRetainRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SpecialRetainRules, "SpecialRetainRules", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StorageRule))
            {
                request.StorageRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StorageRule, "StorageRule", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossRegionCopyInfoShrink))
            {
                query["CrossRegionCopyInfo"] = request.CrossRegionCopyInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                query["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainRuleShrink))
            {
                query["RetainRule"] = request.RetainRuleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleShrink))
            {
                query["Schedule"] = request.ScheduleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecialRetainRulesShrink))
            {
                query["SpecialRetainRules"] = request.SpecialRetainRulesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageRuleShrink))
            {
                query["StorageRule"] = request.StorageRuleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEnterpriseSnapshotPolicy",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEnterpriseSnapshotPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create an enterprise-level snapshot policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEnterpriseSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEnterpriseSnapshotPolicyResponse
        /// </returns>
        public CreateEnterpriseSnapshotPolicyResponse CreateEnterpriseSnapshotPolicy(CreateEnterpriseSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEnterpriseSnapshotPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create an enterprise-level snapshot policy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEnterpriseSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEnterpriseSnapshotPolicyResponse
        /// </returns>
        public async Task<CreateEnterpriseSnapshotPolicyResponse> CreateEnterpriseSnapshotPolicyAsync(CreateEnterpriseSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEnterpriseSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Before you can delete a replication pair-consistent group, make sure that no replication pairs exist in the group.</description></item>
        /// <item><description>The replication pair-consistent group that you want to delete must be in the <b>Created</b> (<c>created</c>), <b>Creation Failed</b> (<c>create_failed</c>), <b>Stopped</b> (<c>stopped</c>), <b>Failovered</b> (<c>failovered</c>), <b>Deleting</b> (<c>deleting</c>), <b>Deletion Failed</b> (<c>delete_failed</c>), or <b>Invalid</b> (<c>invalid</c>) state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDiskReplicaGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDiskReplicaGroupResponse
        /// </returns>
        public DeleteDiskReplicaGroupResponse DeleteDiskReplicaGroupWithOptions(DeleteDiskReplicaGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDiskReplicaGroup",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDiskReplicaGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Before you can delete a replication pair-consistent group, make sure that no replication pairs exist in the group.</description></item>
        /// <item><description>The replication pair-consistent group that you want to delete must be in the <b>Created</b> (<c>created</c>), <b>Creation Failed</b> (<c>create_failed</c>), <b>Stopped</b> (<c>stopped</c>), <b>Failovered</b> (<c>failovered</c>), <b>Deleting</b> (<c>deleting</c>), <b>Deletion Failed</b> (<c>delete_failed</c>), or <b>Invalid</b> (<c>invalid</c>) state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDiskReplicaGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDiskReplicaGroupResponse
        /// </returns>
        public async Task<DeleteDiskReplicaGroupResponse> DeleteDiskReplicaGroupWithOptionsAsync(DeleteDiskReplicaGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDiskReplicaGroup",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDiskReplicaGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Before you can delete a replication pair-consistent group, make sure that no replication pairs exist in the group.</description></item>
        /// <item><description>The replication pair-consistent group that you want to delete must be in the <b>Created</b> (<c>created</c>), <b>Creation Failed</b> (<c>create_failed</c>), <b>Stopped</b> (<c>stopped</c>), <b>Failovered</b> (<c>failovered</c>), <b>Deleting</b> (<c>deleting</c>), <b>Deletion Failed</b> (<c>delete_failed</c>), or <b>Invalid</b> (<c>invalid</c>) state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDiskReplicaGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDiskReplicaGroupResponse
        /// </returns>
        public DeleteDiskReplicaGroupResponse DeleteDiskReplicaGroup(DeleteDiskReplicaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDiskReplicaGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Before you can delete a replication pair-consistent group, make sure that no replication pairs exist in the group.</description></item>
        /// <item><description>The replication pair-consistent group that you want to delete must be in the <b>Created</b> (<c>created</c>), <b>Creation Failed</b> (<c>create_failed</c>), <b>Stopped</b> (<c>stopped</c>), <b>Failovered</b> (<c>failovered</c>), <b>Deleting</b> (<c>deleting</c>), <b>Deletion Failed</b> (<c>delete_failed</c>), or <b>Invalid</b> (<c>invalid</c>) state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDiskReplicaGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDiskReplicaGroupResponse
        /// </returns>
        public async Task<DeleteDiskReplicaGroupResponse> DeleteDiskReplicaGroupAsync(DeleteDiskReplicaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDiskReplicaGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes replication pairs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Only replication pairs that are in the <b>Stopped</b> (<c>stopped</c>), <b>Invalid</b> (<c>invalid</c>), or <b>Failovered</b> (<c>failovered</c>) state can be deleted. This operation deletes only replication pairs. The primary and secondary disks in the deleted replication pairs are retained.</description></item>
        /// <item><description>To delete a replication pair, you must call this operation in the region where the primary disk is located. After the replication pair is deleted, the functionality limits are lifted from the primary and secondary disks. For example, you can attach the secondary disk, resize the disk, or read data from or write data to the disk.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDiskReplicaPairResponse
        /// </returns>
        public DeleteDiskReplicaPairResponse DeleteDiskReplicaPairWithOptions(DeleteDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDiskReplicaPairResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes replication pairs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Only replication pairs that are in the <b>Stopped</b> (<c>stopped</c>), <b>Invalid</b> (<c>invalid</c>), or <b>Failovered</b> (<c>failovered</c>) state can be deleted. This operation deletes only replication pairs. The primary and secondary disks in the deleted replication pairs are retained.</description></item>
        /// <item><description>To delete a replication pair, you must call this operation in the region where the primary disk is located. After the replication pair is deleted, the functionality limits are lifted from the primary and secondary disks. For example, you can attach the secondary disk, resize the disk, or read data from or write data to the disk.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDiskReplicaPairResponse
        /// </returns>
        public async Task<DeleteDiskReplicaPairResponse> DeleteDiskReplicaPairWithOptionsAsync(DeleteDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDiskReplicaPairResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes replication pairs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Only replication pairs that are in the <b>Stopped</b> (<c>stopped</c>), <b>Invalid</b> (<c>invalid</c>), or <b>Failovered</b> (<c>failovered</c>) state can be deleted. This operation deletes only replication pairs. The primary and secondary disks in the deleted replication pairs are retained.</description></item>
        /// <item><description>To delete a replication pair, you must call this operation in the region where the primary disk is located. After the replication pair is deleted, the functionality limits are lifted from the primary and secondary disks. For example, you can attach the secondary disk, resize the disk, or read data from or write data to the disk.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDiskReplicaPairResponse
        /// </returns>
        public DeleteDiskReplicaPairResponse DeleteDiskReplicaPair(DeleteDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDiskReplicaPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes replication pairs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Only replication pairs that are in the <b>Stopped</b> (<c>stopped</c>), <b>Invalid</b> (<c>invalid</c>), or <b>Failovered</b> (<c>failovered</c>) state can be deleted. This operation deletes only replication pairs. The primary and secondary disks in the deleted replication pairs are retained.</description></item>
        /// <item><description>To delete a replication pair, you must call this operation in the region where the primary disk is located. After the replication pair is deleted, the functionality limits are lifted from the primary and secondary disks. For example, you can attach the secondary disk, resize the disk, or read data from or write data to the disk.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDiskReplicaPairResponse
        /// </returns>
        public async Task<DeleteDiskReplicaPairResponse> DeleteDiskReplicaPairAsync(DeleteDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDiskReplicaPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a enterprise-level snapshot policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEnterpriseSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEnterpriseSnapshotPolicyResponse
        /// </returns>
        public DeleteEnterpriseSnapshotPolicyResponse DeleteEnterpriseSnapshotPolicyWithOptions(DeleteEnterpriseSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnterpriseSnapshotPolicy",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEnterpriseSnapshotPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a enterprise-level snapshot policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEnterpriseSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEnterpriseSnapshotPolicyResponse
        /// </returns>
        public async Task<DeleteEnterpriseSnapshotPolicyResponse> DeleteEnterpriseSnapshotPolicyWithOptionsAsync(DeleteEnterpriseSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnterpriseSnapshotPolicy",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEnterpriseSnapshotPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a enterprise-level snapshot policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEnterpriseSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEnterpriseSnapshotPolicyResponse
        /// </returns>
        public DeleteEnterpriseSnapshotPolicyResponse DeleteEnterpriseSnapshotPolicy(DeleteEnterpriseSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEnterpriseSnapshotPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a enterprise-level snapshot policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEnterpriseSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEnterpriseSnapshotPolicyResponse
        /// </returns>
        public async Task<DeleteEnterpriseSnapshotPolicyResponse> DeleteEnterpriseSnapshotPolicyAsync(DeleteEnterpriseSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEnterpriseSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more disks in a dedicated block storage cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can use one of the following methods to check the responses:
        ///     *   Method 1: Use <c>NextToken</c> to configure the query token. Set the value to the <c>NextToken</c> value that is returned in the last call to the DescribeDisks operation. Then, use <c>MaxResults</c> to specify the maximum number of entries to return on each page.
        ///     *   Method 2: Use <c>PageSize</c> to specify the number of entries to return on each page and then use <c>PageNumber</c> to specify the number of the page to return.
        ///         You can use only one of the preceding methods. If a large number of entries are to be returned, we recommend that you use method 1. When <c>NextToken</c> is specified, <c>PageSize</c> and <c>PageNumber</c> do not take effect and <c>TotalCount</c> in the response is invalid.</para>
        /// <list type="bullet">
        /// <item><description>A disk that has the multi-attach feature enabled can be attached to multiple instances. You can query the attachment information of the disk based on the <c>Attachment</c> values in the response.
        /// When you call an API operation by using Alibaba Cloud CLI, you must specify request parameter values of different data types in the required formats. For more information, see <a href="https://help.aliyun.com/document_detail/110340.html">Parameter format overview</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDedicatedBlockStorageClusterDisksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDedicatedBlockStorageClusterDisksResponse
        /// </returns>
        public DescribeDedicatedBlockStorageClusterDisksResponse DescribeDedicatedBlockStorageClusterDisksWithOptions(DescribeDedicatedBlockStorageClusterDisksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbscId))
            {
                query["DbscId"] = request.DbscId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedBlockStorageClusterDisks",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedBlockStorageClusterDisksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more disks in a dedicated block storage cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can use one of the following methods to check the responses:
        ///     *   Method 1: Use <c>NextToken</c> to configure the query token. Set the value to the <c>NextToken</c> value that is returned in the last call to the DescribeDisks operation. Then, use <c>MaxResults</c> to specify the maximum number of entries to return on each page.
        ///     *   Method 2: Use <c>PageSize</c> to specify the number of entries to return on each page and then use <c>PageNumber</c> to specify the number of the page to return.
        ///         You can use only one of the preceding methods. If a large number of entries are to be returned, we recommend that you use method 1. When <c>NextToken</c> is specified, <c>PageSize</c> and <c>PageNumber</c> do not take effect and <c>TotalCount</c> in the response is invalid.</para>
        /// <list type="bullet">
        /// <item><description>A disk that has the multi-attach feature enabled can be attached to multiple instances. You can query the attachment information of the disk based on the <c>Attachment</c> values in the response.
        /// When you call an API operation by using Alibaba Cloud CLI, you must specify request parameter values of different data types in the required formats. For more information, see <a href="https://help.aliyun.com/document_detail/110340.html">Parameter format overview</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDedicatedBlockStorageClusterDisksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDedicatedBlockStorageClusterDisksResponse
        /// </returns>
        public async Task<DescribeDedicatedBlockStorageClusterDisksResponse> DescribeDedicatedBlockStorageClusterDisksWithOptionsAsync(DescribeDedicatedBlockStorageClusterDisksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbscId))
            {
                query["DbscId"] = request.DbscId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedBlockStorageClusterDisks",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedBlockStorageClusterDisksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more disks in a dedicated block storage cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can use one of the following methods to check the responses:
        ///     *   Method 1: Use <c>NextToken</c> to configure the query token. Set the value to the <c>NextToken</c> value that is returned in the last call to the DescribeDisks operation. Then, use <c>MaxResults</c> to specify the maximum number of entries to return on each page.
        ///     *   Method 2: Use <c>PageSize</c> to specify the number of entries to return on each page and then use <c>PageNumber</c> to specify the number of the page to return.
        ///         You can use only one of the preceding methods. If a large number of entries are to be returned, we recommend that you use method 1. When <c>NextToken</c> is specified, <c>PageSize</c> and <c>PageNumber</c> do not take effect and <c>TotalCount</c> in the response is invalid.</para>
        /// <list type="bullet">
        /// <item><description>A disk that has the multi-attach feature enabled can be attached to multiple instances. You can query the attachment information of the disk based on the <c>Attachment</c> values in the response.
        /// When you call an API operation by using Alibaba Cloud CLI, you must specify request parameter values of different data types in the required formats. For more information, see <a href="https://help.aliyun.com/document_detail/110340.html">Parameter format overview</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDedicatedBlockStorageClusterDisksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDedicatedBlockStorageClusterDisksResponse
        /// </returns>
        public DescribeDedicatedBlockStorageClusterDisksResponse DescribeDedicatedBlockStorageClusterDisks(DescribeDedicatedBlockStorageClusterDisksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedBlockStorageClusterDisksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more disks in a dedicated block storage cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can use one of the following methods to check the responses:
        ///     *   Method 1: Use <c>NextToken</c> to configure the query token. Set the value to the <c>NextToken</c> value that is returned in the last call to the DescribeDisks operation. Then, use <c>MaxResults</c> to specify the maximum number of entries to return on each page.
        ///     *   Method 2: Use <c>PageSize</c> to specify the number of entries to return on each page and then use <c>PageNumber</c> to specify the number of the page to return.
        ///         You can use only one of the preceding methods. If a large number of entries are to be returned, we recommend that you use method 1. When <c>NextToken</c> is specified, <c>PageSize</c> and <c>PageNumber</c> do not take effect and <c>TotalCount</c> in the response is invalid.</para>
        /// <list type="bullet">
        /// <item><description>A disk that has the multi-attach feature enabled can be attached to multiple instances. You can query the attachment information of the disk based on the <c>Attachment</c> values in the response.
        /// When you call an API operation by using Alibaba Cloud CLI, you must specify request parameter values of different data types in the required formats. For more information, see <a href="https://help.aliyun.com/document_detail/110340.html">Parameter format overview</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDedicatedBlockStorageClusterDisksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDedicatedBlockStorageClusterDisksResponse
        /// </returns>
        public async Task<DescribeDedicatedBlockStorageClusterDisksResponse> DescribeDedicatedBlockStorageClusterDisksAsync(DescribeDedicatedBlockStorageClusterDisksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedBlockStorageClusterDisksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the dedicated block storage clusters that are created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <remarks>
        /// <para> The Dedicated Block Storage Cluster feature is available only in the China (Heyuan), Indonesia (Jakarta), and China (Shenzhen) regions.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can specify multiple request parameters to be queried. Specified parameters are evaluated by using the AND operator. Only the specified parameters are included in the filter conditions.</description></item>
        /// <item><description>We recommend that you use NextToken and MaxResults to perform paged queries. We recommend that you use MaxResults to specify the maximum number of entries to return in each request. The return value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. When you call the DescribeDedicatedBlockStorageClusters operation to retrieve a new page of results, set NextToken to the NextToken value that is returned in the previous call and specify MaxResults to limit the number of entries returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDedicatedBlockStorageClustersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDedicatedBlockStorageClustersResponse
        /// </returns>
        public DescribeDedicatedBlockStorageClustersResponse DescribeDedicatedBlockStorageClustersWithOptions(DescribeDedicatedBlockStorageClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedBlockStorageClusterId))
            {
                query["DedicatedBlockStorageClusterId"] = request.DedicatedBlockStorageClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AzoneId))
            {
                body["AzoneId"] = request.AzoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedBlockStorageClusters",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedBlockStorageClustersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the dedicated block storage clusters that are created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <remarks>
        /// <para> The Dedicated Block Storage Cluster feature is available only in the China (Heyuan), Indonesia (Jakarta), and China (Shenzhen) regions.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can specify multiple request parameters to be queried. Specified parameters are evaluated by using the AND operator. Only the specified parameters are included in the filter conditions.</description></item>
        /// <item><description>We recommend that you use NextToken and MaxResults to perform paged queries. We recommend that you use MaxResults to specify the maximum number of entries to return in each request. The return value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. When you call the DescribeDedicatedBlockStorageClusters operation to retrieve a new page of results, set NextToken to the NextToken value that is returned in the previous call and specify MaxResults to limit the number of entries returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDedicatedBlockStorageClustersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDedicatedBlockStorageClustersResponse
        /// </returns>
        public async Task<DescribeDedicatedBlockStorageClustersResponse> DescribeDedicatedBlockStorageClustersWithOptionsAsync(DescribeDedicatedBlockStorageClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedBlockStorageClusterId))
            {
                query["DedicatedBlockStorageClusterId"] = request.DedicatedBlockStorageClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AzoneId))
            {
                body["AzoneId"] = request.AzoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDedicatedBlockStorageClusters",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDedicatedBlockStorageClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the dedicated block storage clusters that are created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <remarks>
        /// <para> The Dedicated Block Storage Cluster feature is available only in the China (Heyuan), Indonesia (Jakarta), and China (Shenzhen) regions.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can specify multiple request parameters to be queried. Specified parameters are evaluated by using the AND operator. Only the specified parameters are included in the filter conditions.</description></item>
        /// <item><description>We recommend that you use NextToken and MaxResults to perform paged queries. We recommend that you use MaxResults to specify the maximum number of entries to return in each request. The return value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. When you call the DescribeDedicatedBlockStorageClusters operation to retrieve a new page of results, set NextToken to the NextToken value that is returned in the previous call and specify MaxResults to limit the number of entries returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDedicatedBlockStorageClustersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDedicatedBlockStorageClustersResponse
        /// </returns>
        public DescribeDedicatedBlockStorageClustersResponse DescribeDedicatedBlockStorageClusters(DescribeDedicatedBlockStorageClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedBlockStorageClustersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the dedicated block storage clusters that are created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <remarks>
        /// <para> The Dedicated Block Storage Cluster feature is available only in the China (Heyuan), Indonesia (Jakarta), and China (Shenzhen) regions.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can specify multiple request parameters to be queried. Specified parameters are evaluated by using the AND operator. Only the specified parameters are included in the filter conditions.</description></item>
        /// <item><description>We recommend that you use NextToken and MaxResults to perform paged queries. We recommend that you use MaxResults to specify the maximum number of entries to return in each request. The return value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. When you call the DescribeDedicatedBlockStorageClusters operation to retrieve a new page of results, set NextToken to the NextToken value that is returned in the previous call and specify MaxResults to limit the number of entries returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDedicatedBlockStorageClustersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDedicatedBlockStorageClustersResponse
        /// </returns>
        public async Task<DescribeDedicatedBlockStorageClustersResponse> DescribeDedicatedBlockStorageClustersAsync(DescribeDedicatedBlockStorageClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedBlockStorageClustersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the risk events of a disk.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskEventsResponse
        /// </returns>
        public DescribeDiskEventsResponse DescribeDiskEventsWithOptions(DescribeDiskEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskCategory))
            {
                query["DiskCategory"] = request.DiskCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiskEvents",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiskEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the risk events of a disk.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskEventsResponse
        /// </returns>
        public async Task<DescribeDiskEventsResponse> DescribeDiskEventsWithOptionsAsync(DescribeDiskEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskCategory))
            {
                query["DiskCategory"] = request.DiskCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiskEvents",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiskEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the risk events of a disk.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskEventsResponse
        /// </returns>
        public DescribeDiskEventsResponse DescribeDiskEvents(DescribeDiskEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiskEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the risk events of a disk.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskEventsResponse
        /// </returns>
        public async Task<DescribeDiskEventsResponse> DescribeDiskEventsAsync(DescribeDiskEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiskEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the near real-time monitoring data of a disk.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</description></item>
        /// <item><description>Up to 400 monitoring data entries can be returned at a time. An error is returned if the value calculated based on the following formula is greater than 400: <c>(EndTime - StartTime)/Period</c>.</description></item>
        /// <item><description>You can query the monitoring data collected in the last three days. An error is returned if the time specified by <c>StartTime</c> is more than three days prior to the current time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskMonitorDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskMonitorDataResponse
        /// </returns>
        public DescribeDiskMonitorDataResponse DescribeDiskMonitorDataWithOptions(DescribeDiskMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiskMonitorData",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiskMonitorDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the near real-time monitoring data of a disk.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</description></item>
        /// <item><description>Up to 400 monitoring data entries can be returned at a time. An error is returned if the value calculated based on the following formula is greater than 400: <c>(EndTime - StartTime)/Period</c>.</description></item>
        /// <item><description>You can query the monitoring data collected in the last three days. An error is returned if the time specified by <c>StartTime</c> is more than three days prior to the current time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskMonitorDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskMonitorDataResponse
        /// </returns>
        public async Task<DescribeDiskMonitorDataResponse> DescribeDiskMonitorDataWithOptionsAsync(DescribeDiskMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiskMonitorData",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiskMonitorDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the near real-time monitoring data of a disk.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</description></item>
        /// <item><description>Up to 400 monitoring data entries can be returned at a time. An error is returned if the value calculated based on the following formula is greater than 400: <c>(EndTime - StartTime)/Period</c>.</description></item>
        /// <item><description>You can query the monitoring data collected in the last three days. An error is returned if the time specified by <c>StartTime</c> is more than three days prior to the current time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskMonitorDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskMonitorDataResponse
        /// </returns>
        public DescribeDiskMonitorDataResponse DescribeDiskMonitorData(DescribeDiskMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiskMonitorDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the near real-time monitoring data of a disk.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</description></item>
        /// <item><description>Up to 400 monitoring data entries can be returned at a time. An error is returned if the value calculated based on the following formula is greater than 400: <c>(EndTime - StartTime)/Period</c>.</description></item>
        /// <item><description>You can query the monitoring data collected in the last three days. An error is returned if the time specified by <c>StartTime</c> is more than three days prior to the current time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskMonitorDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskMonitorDataResponse
        /// </returns>
        public async Task<DescribeDiskMonitorDataResponse> DescribeDiskMonitorDataAsync(DescribeDiskMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiskMonitorDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the near real-time monitoring data of disks. You can query only the burst performance data of ESSD AutoPL disks. The data is aggregated by hour.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskMonitorDataListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskMonitorDataListResponse
        /// </returns>
        public DescribeDiskMonitorDataListResponse DescribeDiskMonitorDataListWithOptions(DescribeDiskMonitorDataListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskIds))
            {
                query["DiskIds"] = request.DiskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiskMonitorDataList",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiskMonitorDataListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the near real-time monitoring data of disks. You can query only the burst performance data of ESSD AutoPL disks. The data is aggregated by hour.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskMonitorDataListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskMonitorDataListResponse
        /// </returns>
        public async Task<DescribeDiskMonitorDataListResponse> DescribeDiskMonitorDataListWithOptionsAsync(DescribeDiskMonitorDataListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskIds))
            {
                query["DiskIds"] = request.DiskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiskMonitorDataList",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiskMonitorDataListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the near real-time monitoring data of disks. You can query only the burst performance data of ESSD AutoPL disks. The data is aggregated by hour.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskMonitorDataListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskMonitorDataListResponse
        /// </returns>
        public DescribeDiskMonitorDataListResponse DescribeDiskMonitorDataList(DescribeDiskMonitorDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiskMonitorDataListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the near real-time monitoring data of disks. You can query only the burst performance data of ESSD AutoPL disks. The data is aggregated by hour.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskMonitorDataListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskMonitorDataListResponse
        /// </returns>
        public async Task<DescribeDiskMonitorDataListResponse> DescribeDiskMonitorDataListAsync(DescribeDiskMonitorDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiskMonitorDataListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of replication pair-consistent groups in a specific region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>To perform a paged query, specify the MaxResults and NextToken parameters.
        /// During a paged query, when you call the DescribeDiskReplicaGroups operation to retrieve the first page of results, set <c>MaxResults</c> to specify the maximum number of entries to return in the call. The return value of <c>NextToken</c> is a pagination token, which can be used in the next call to retrieve a new page of results. When you call the DescribeDiskReplicaGroups operation to retrieve a new page of results, set NextToken to the NextToken value returned in the previous call and set MaxResults to specify the maximum number of entries to return in this call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskReplicaGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskReplicaGroupsResponse
        /// </returns>
        public DescribeDiskReplicaGroupsResponse DescribeDiskReplicaGroupsWithOptions(DescribeDiskReplicaGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Site))
            {
                query["Site"] = request.Site;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiskReplicaGroups",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiskReplicaGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of replication pair-consistent groups in a specific region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>To perform a paged query, specify the MaxResults and NextToken parameters.
        /// During a paged query, when you call the DescribeDiskReplicaGroups operation to retrieve the first page of results, set <c>MaxResults</c> to specify the maximum number of entries to return in the call. The return value of <c>NextToken</c> is a pagination token, which can be used in the next call to retrieve a new page of results. When you call the DescribeDiskReplicaGroups operation to retrieve a new page of results, set NextToken to the NextToken value returned in the previous call and set MaxResults to specify the maximum number of entries to return in this call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskReplicaGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskReplicaGroupsResponse
        /// </returns>
        public async Task<DescribeDiskReplicaGroupsResponse> DescribeDiskReplicaGroupsWithOptionsAsync(DescribeDiskReplicaGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Site))
            {
                query["Site"] = request.Site;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiskReplicaGroups",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiskReplicaGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of replication pair-consistent groups in a specific region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>To perform a paged query, specify the MaxResults and NextToken parameters.
        /// During a paged query, when you call the DescribeDiskReplicaGroups operation to retrieve the first page of results, set <c>MaxResults</c> to specify the maximum number of entries to return in the call. The return value of <c>NextToken</c> is a pagination token, which can be used in the next call to retrieve a new page of results. When you call the DescribeDiskReplicaGroups operation to retrieve a new page of results, set NextToken to the NextToken value returned in the previous call and set MaxResults to specify the maximum number of entries to return in this call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskReplicaGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskReplicaGroupsResponse
        /// </returns>
        public DescribeDiskReplicaGroupsResponse DescribeDiskReplicaGroups(DescribeDiskReplicaGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiskReplicaGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of replication pair-consistent groups in a specific region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>To perform a paged query, specify the MaxResults and NextToken parameters.
        /// During a paged query, when you call the DescribeDiskReplicaGroups operation to retrieve the first page of results, set <c>MaxResults</c> to specify the maximum number of entries to return in the call. The return value of <c>NextToken</c> is a pagination token, which can be used in the next call to retrieve a new page of results. When you call the DescribeDiskReplicaGroups operation to retrieve a new page of results, set NextToken to the NextToken value returned in the previous call and set MaxResults to specify the maximum number of entries to return in this call.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskReplicaGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskReplicaGroupsResponse
        /// </returns>
        public async Task<DescribeDiskReplicaGroupsResponse> DescribeDiskReplicaGroupsAsync(DescribeDiskReplicaGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiskReplicaGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the replication progress of a replication pair.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDiskReplicaPairProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskReplicaPairProgressResponse
        /// </returns>
        public DescribeDiskReplicaPairProgressResponse DescribeDiskReplicaPairProgressWithOptions(DescribeDiskReplicaPairProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiskReplicaPairProgress",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiskReplicaPairProgressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the replication progress of a replication pair.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDiskReplicaPairProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskReplicaPairProgressResponse
        /// </returns>
        public async Task<DescribeDiskReplicaPairProgressResponse> DescribeDiskReplicaPairProgressWithOptionsAsync(DescribeDiskReplicaPairProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiskReplicaPairProgress",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiskReplicaPairProgressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the replication progress of a replication pair.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDiskReplicaPairProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskReplicaPairProgressResponse
        /// </returns>
        public DescribeDiskReplicaPairProgressResponse DescribeDiskReplicaPairProgress(DescribeDiskReplicaPairProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiskReplicaPairProgressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the replication progress of a replication pair.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDiskReplicaPairProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskReplicaPairProgressResponse
        /// </returns>
        public async Task<DescribeDiskReplicaPairProgressResponse> DescribeDiskReplicaPairProgressAsync(DescribeDiskReplicaPairProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiskReplicaPairProgressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about replication pairs in a specific region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>When you call this operation for a specific region, if the primary disk (source disk) or secondary disk (destination disk) of a replication pair resides in the region, information about the replication pair is displayed in the response.</description></item>
        /// <item><description>If you want to perform a paged query, configure the <c>NextToken</c> and <c>MaxResults</c> parameters. During a paged query, when you call the DescribeDiskReplicaPairs operation to retrieve the first page of results, set <c>MaxResults</c> to limit the maximum number of entries to return in the call. The return value of NextToken is a pagination token, which can be used in the next call to retrieve a new page of results. When you call the DescribeDiskReplicaPairs operation to retrieve a new page of results, set NextToken to the NextToken value returned in the previous call and set MaxResults to specify the maximum number of entries to return in this call.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskReplicaPairsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskReplicaPairsResponse
        /// </returns>
        public DescribeDiskReplicaPairsResponse DescribeDiskReplicaPairsWithOptions(DescribeDiskReplicaPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PairIds))
            {
                query["PairIds"] = request.PairIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Site))
            {
                query["Site"] = request.Site;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiskReplicaPairs",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiskReplicaPairsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about replication pairs in a specific region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>When you call this operation for a specific region, if the primary disk (source disk) or secondary disk (destination disk) of a replication pair resides in the region, information about the replication pair is displayed in the response.</description></item>
        /// <item><description>If you want to perform a paged query, configure the <c>NextToken</c> and <c>MaxResults</c> parameters. During a paged query, when you call the DescribeDiskReplicaPairs operation to retrieve the first page of results, set <c>MaxResults</c> to limit the maximum number of entries to return in the call. The return value of NextToken is a pagination token, which can be used in the next call to retrieve a new page of results. When you call the DescribeDiskReplicaPairs operation to retrieve a new page of results, set NextToken to the NextToken value returned in the previous call and set MaxResults to specify the maximum number of entries to return in this call.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskReplicaPairsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskReplicaPairsResponse
        /// </returns>
        public async Task<DescribeDiskReplicaPairsResponse> DescribeDiskReplicaPairsWithOptionsAsync(DescribeDiskReplicaPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PairIds))
            {
                query["PairIds"] = request.PairIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Site))
            {
                query["Site"] = request.Site;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiskReplicaPairs",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiskReplicaPairsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about replication pairs in a specific region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>When you call this operation for a specific region, if the primary disk (source disk) or secondary disk (destination disk) of a replication pair resides in the region, information about the replication pair is displayed in the response.</description></item>
        /// <item><description>If you want to perform a paged query, configure the <c>NextToken</c> and <c>MaxResults</c> parameters. During a paged query, when you call the DescribeDiskReplicaPairs operation to retrieve the first page of results, set <c>MaxResults</c> to limit the maximum number of entries to return in the call. The return value of NextToken is a pagination token, which can be used in the next call to retrieve a new page of results. When you call the DescribeDiskReplicaPairs operation to retrieve a new page of results, set NextToken to the NextToken value returned in the previous call and set MaxResults to specify the maximum number of entries to return in this call.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskReplicaPairsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskReplicaPairsResponse
        /// </returns>
        public DescribeDiskReplicaPairsResponse DescribeDiskReplicaPairs(DescribeDiskReplicaPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiskReplicaPairsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about replication pairs in a specific region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>When you call this operation for a specific region, if the primary disk (source disk) or secondary disk (destination disk) of a replication pair resides in the region, information about the replication pair is displayed in the response.</description></item>
        /// <item><description>If you want to perform a paged query, configure the <c>NextToken</c> and <c>MaxResults</c> parameters. During a paged query, when you call the DescribeDiskReplicaPairs operation to retrieve the first page of results, set <c>MaxResults</c> to limit the maximum number of entries to return in the call. The return value of NextToken is a pagination token, which can be used in the next call to retrieve a new page of results. When you call the DescribeDiskReplicaPairs operation to retrieve a new page of results, set NextToken to the NextToken value returned in the previous call and set MaxResults to specify the maximum number of entries to return in this call.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiskReplicaPairsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiskReplicaPairsResponse
        /// </returns>
        public async Task<DescribeDiskReplicaPairsResponse> DescribeDiskReplicaPairsAsync(DescribeDiskReplicaPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiskReplicaPairsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about enterprise-level snapshot policies. When you call this operation, you can specify parameters, such as PolicyIds, ResourceGroupId, and Tag, in the request.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEnterpriseSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEnterpriseSnapshotPolicyResponse
        /// </returns>
        public DescribeEnterpriseSnapshotPolicyResponse DescribeEnterpriseSnapshotPolicyWithOptions(DescribeEnterpriseSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskIds))
            {
                query["DiskIds"] = request.DiskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIds))
            {
                query["PolicyIds"] = request.PolicyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEnterpriseSnapshotPolicy",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEnterpriseSnapshotPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about enterprise-level snapshot policies. When you call this operation, you can specify parameters, such as PolicyIds, ResourceGroupId, and Tag, in the request.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEnterpriseSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEnterpriseSnapshotPolicyResponse
        /// </returns>
        public async Task<DescribeEnterpriseSnapshotPolicyResponse> DescribeEnterpriseSnapshotPolicyWithOptionsAsync(DescribeEnterpriseSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskIds))
            {
                query["DiskIds"] = request.DiskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIds))
            {
                query["PolicyIds"] = request.PolicyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEnterpriseSnapshotPolicy",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEnterpriseSnapshotPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about enterprise-level snapshot policies. When you call this operation, you can specify parameters, such as PolicyIds, ResourceGroupId, and Tag, in the request.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEnterpriseSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEnterpriseSnapshotPolicyResponse
        /// </returns>
        public DescribeEnterpriseSnapshotPolicyResponse DescribeEnterpriseSnapshotPolicy(DescribeEnterpriseSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEnterpriseSnapshotPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about enterprise-level snapshot policies. When you call this operation, you can specify parameters, such as PolicyIds, ResourceGroupId, and Tag, in the request.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEnterpriseSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEnterpriseSnapshotPolicyResponse
        /// </returns>
        public async Task<DescribeEnterpriseSnapshotPolicyResponse> DescribeEnterpriseSnapshotPolicyAsync(DescribeEnterpriseSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEnterpriseSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the risk events of a disk.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventsResponse
        /// </returns>
        public DescribeEventsResponse DescribeEventsWithOptions(DescribeEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventLevel))
            {
                query["EventLevel"] = request.EventLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                query["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEvents",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the risk events of a disk.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventsResponse
        /// </returns>
        public async Task<DescribeEventsResponse> DescribeEventsWithOptionsAsync(DescribeEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventLevel))
            {
                query["EventLevel"] = request.EventLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                query["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEvents",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the risk events of a disk.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventsResponse
        /// </returns>
        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the risk events of a disk.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventsResponse
        /// </returns>
        public async Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more Elastic Block Storage (EBS) devices that you created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLensMonitorDisksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLensMonitorDisksResponse
        /// </returns>
        public DescribeLensMonitorDisksResponse DescribeLensMonitorDisksWithOptions(DescribeLensMonitorDisksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskCategory))
            {
                query["DiskCategory"] = request.DiskCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskIdPattern))
            {
                query["DiskIdPattern"] = request.DiskIdPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskIds))
            {
                query["DiskIds"] = request.DiskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LensTags))
            {
                query["LensTags"] = request.LensTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLensMonitorDisks",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLensMonitorDisksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more Elastic Block Storage (EBS) devices that you created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLensMonitorDisksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLensMonitorDisksResponse
        /// </returns>
        public async Task<DescribeLensMonitorDisksResponse> DescribeLensMonitorDisksWithOptionsAsync(DescribeLensMonitorDisksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskCategory))
            {
                query["DiskCategory"] = request.DiskCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskIdPattern))
            {
                query["DiskIdPattern"] = request.DiskIdPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskIds))
            {
                query["DiskIds"] = request.DiskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LensTags))
            {
                query["LensTags"] = request.LensTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLensMonitorDisks",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLensMonitorDisksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more Elastic Block Storage (EBS) devices that you created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLensMonitorDisksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLensMonitorDisksResponse
        /// </returns>
        public DescribeLensMonitorDisksResponse DescribeLensMonitorDisks(DescribeLensMonitorDisksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLensMonitorDisksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more Elastic Block Storage (EBS) devices that you created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLensMonitorDisksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLensMonitorDisksResponse
        /// </returns>
        public async Task<DescribeLensMonitorDisksResponse> DescribeLensMonitorDisksAsync(DescribeLensMonitorDisksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLensMonitorDisksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户开通ebs数据洞察服务状态</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLensServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLensServiceStatusResponse
        /// </returns>
        public DescribeLensServiceStatusResponse DescribeLensServiceStatusWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLensServiceStatus",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLensServiceStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户开通ebs数据洞察服务状态</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeLensServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLensServiceStatusResponse
        /// </returns>
        public async Task<DescribeLensServiceStatusResponse> DescribeLensServiceStatusWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLensServiceStatus",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLensServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户开通ebs数据洞察服务状态</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <returns>
        /// DescribeLensServiceStatusResponse
        /// </returns>
        public DescribeLensServiceStatusResponse DescribeLensServiceStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLensServiceStatusWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户开通ebs数据洞察服务状态</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>CloudLens for EBS is in invitational preview in the China (Hangzhou), China (Shanghai), China (Zhangjiakou), China (Shenzhen), and China (Hong Kong) regions. To use the feature, <a href="https://workorder-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </description>
        /// 
        /// <returns>
        /// DescribeLensServiceStatusResponse
        /// </returns>
        public async Task<DescribeLensServiceStatusResponse> DescribeLensServiceStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLensServiceStatusWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics about a metric of Elastic Block Storage (EBS) disks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMetricDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetricDataResponse
        /// </returns>
        public DescribeMetricDataResponse DescribeMetricDataWithOptions(DescribeMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggreOps))
            {
                query["AggreOps"] = request.AggreOps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggreOverLineOps))
            {
                query["AggreOverLineOps"] = request.AggreOverLineOps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetricData",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics about a metric of Elastic Block Storage (EBS) disks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMetricDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetricDataResponse
        /// </returns>
        public async Task<DescribeMetricDataResponse> DescribeMetricDataWithOptionsAsync(DescribeMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggreOps))
            {
                query["AggreOps"] = request.AggreOps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggreOverLineOps))
            {
                query["AggreOverLineOps"] = request.AggreOverLineOps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetricData",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics about a metric of Elastic Block Storage (EBS) disks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMetricDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetricDataResponse
        /// </returns>
        public DescribeMetricDataResponse DescribeMetricData(DescribeMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics about a metric of Elastic Block Storage (EBS) disks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMetricDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetricDataResponse
        /// </returns>
        public async Task<DescribeMetricDataResponse> DescribeMetricDataAsync(DescribeMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the disaster recovery drills that were performed on the replication pair whose secondary disk resides in a specific region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePairDrillsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePairDrillsResponse
        /// </returns>
        public DescribePairDrillsResponse DescribePairDrillsWithOptions(DescribePairDrillsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrillId))
            {
                query["DrillId"] = request.DrillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PairId))
            {
                query["PairId"] = request.PairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePairDrills",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePairDrillsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the disaster recovery drills that were performed on the replication pair whose secondary disk resides in a specific region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePairDrillsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePairDrillsResponse
        /// </returns>
        public async Task<DescribePairDrillsResponse> DescribePairDrillsWithOptionsAsync(DescribePairDrillsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrillId))
            {
                query["DrillId"] = request.DrillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PairId))
            {
                query["PairId"] = request.PairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePairDrills",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePairDrillsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the disaster recovery drills that were performed on the replication pair whose secondary disk resides in a specific region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePairDrillsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePairDrillsResponse
        /// </returns>
        public DescribePairDrillsResponse DescribePairDrills(DescribePairDrillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePairDrillsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the disaster recovery drills that were performed on the replication pair whose secondary disk resides in a specific region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePairDrillsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePairDrillsResponse
        /// </returns>
        public async Task<DescribePairDrillsResponse> DescribePairDrillsAsync(DescribePairDrillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePairDrillsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of regions in which Elastic Block Storage (EBS) features (such as async replication, CloudLens for EBS, and Dedicated Block Storage Cluster) are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of regions in which Elastic Block Storage (EBS) features (such as async replication, CloudLens for EBS, and Dedicated Block Storage Cluster) are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of regions in which Elastic Block Storage (EBS) features (such as async replication, CloudLens for EBS, and Dedicated Block Storage Cluster) are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of regions in which Elastic Block Storage (EBS) features (such as async replication, CloudLens for EBS, and Dedicated Block Storage Cluster) are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the disaster recovery drills that were performed on the replication pair-consistent group whose secondary disk resides in a specific region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeReplicaGroupDrillsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeReplicaGroupDrillsResponse
        /// </returns>
        public DescribeReplicaGroupDrillsResponse DescribeReplicaGroupDrillsWithOptions(DescribeReplicaGroupDrillsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrillId))
            {
                query["DrillId"] = request.DrillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeReplicaGroupDrills",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeReplicaGroupDrillsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the disaster recovery drills that were performed on the replication pair-consistent group whose secondary disk resides in a specific region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeReplicaGroupDrillsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeReplicaGroupDrillsResponse
        /// </returns>
        public async Task<DescribeReplicaGroupDrillsResponse> DescribeReplicaGroupDrillsWithOptionsAsync(DescribeReplicaGroupDrillsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrillId))
            {
                query["DrillId"] = request.DrillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeReplicaGroupDrills",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeReplicaGroupDrillsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the disaster recovery drills that were performed on the replication pair-consistent group whose secondary disk resides in a specific region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeReplicaGroupDrillsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeReplicaGroupDrillsResponse
        /// </returns>
        public DescribeReplicaGroupDrillsResponse DescribeReplicaGroupDrills(DescribeReplicaGroupDrillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeReplicaGroupDrillsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the disaster recovery drills that were performed on the replication pair-consistent group whose secondary disk resides in a specific region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeReplicaGroupDrillsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeReplicaGroupDrillsResponse
        /// </returns>
        public async Task<DescribeReplicaGroupDrillsResponse> DescribeReplicaGroupDrillsAsync(DescribeReplicaGroupDrillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeReplicaGroupDrillsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询解决方案实例默认配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSolutionInstanceConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSolutionInstanceConfigurationResponse
        /// </returns>
        public DescribeSolutionInstanceConfigurationResponse DescribeSolutionInstanceConfigurationWithOptions(DescribeSolutionInstanceConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionId))
            {
                query["SolutionId"] = request.SolutionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSolutionInstanceConfiguration",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSolutionInstanceConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询解决方案实例默认配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSolutionInstanceConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSolutionInstanceConfigurationResponse
        /// </returns>
        public async Task<DescribeSolutionInstanceConfigurationResponse> DescribeSolutionInstanceConfigurationWithOptionsAsync(DescribeSolutionInstanceConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionId))
            {
                query["SolutionId"] = request.SolutionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSolutionInstanceConfiguration",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSolutionInstanceConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询解决方案实例默认配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSolutionInstanceConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSolutionInstanceConfigurationResponse
        /// </returns>
        public DescribeSolutionInstanceConfigurationResponse DescribeSolutionInstanceConfiguration(DescribeSolutionInstanceConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSolutionInstanceConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询解决方案实例默认配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSolutionInstanceConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSolutionInstanceConfigurationResponse
        /// </returns>
        public async Task<DescribeSolutionInstanceConfigurationResponse> DescribeSolutionInstanceConfigurationAsync(DescribeSolutionInstanceConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSolutionInstanceConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Centralized Role: Query User Disk Snapshot tagKeys</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <para>Query the tag key-value pairs of user\&quot;s cloud disk and snapshot. The search scope can be narrowed down by using filterTagKey.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUserTagKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserTagKeysResponse
        /// </returns>
        public DescribeUserTagKeysResponse DescribeUserTagKeysWithOptions(DescribeUserTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagFilterKey))
            {
                body["TagFilterKey"] = request.TagFilterKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserTagKeys",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserTagKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Centralized Role: Query User Disk Snapshot tagKeys</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <para>Query the tag key-value pairs of user\&quot;s cloud disk and snapshot. The search scope can be narrowed down by using filterTagKey.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUserTagKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserTagKeysResponse
        /// </returns>
        public async Task<DescribeUserTagKeysResponse> DescribeUserTagKeysWithOptionsAsync(DescribeUserTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagFilterKey))
            {
                body["TagFilterKey"] = request.TagFilterKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserTagKeys",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserTagKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Centralized Role: Query User Disk Snapshot tagKeys</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <para>Query the tag key-value pairs of user\&quot;s cloud disk and snapshot. The search scope can be narrowed down by using filterTagKey.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUserTagKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserTagKeysResponse
        /// </returns>
        public DescribeUserTagKeysResponse DescribeUserTagKeys(DescribeUserTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserTagKeysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Centralized Role: Query User Disk Snapshot tagKeys</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <para>Query the tag key-value pairs of user\&quot;s cloud disk and snapshot. The search scope can be narrowed down by using filterTagKey.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUserTagKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserTagKeysResponse
        /// </returns>
        public async Task<DescribeUserTagKeysResponse> DescribeUserTagKeysAsync(DescribeUserTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserTagKeysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Centralized Role: Query User Disk and Snapshot tagValues</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <remarks>
        /// <para>The dedicated block storage cluster feature is currently supported in the following regions: South China 2 (Heyuan), Indonesia (Jakarta), and South China 1 (Shenzhen).</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The request parameters act as a filter, with a logical AND relationship. If any parameter is empty, the filter does not take effect.</description></item>
        /// <item><description>For paginated queries, it is recommended to use the MaxResults and NextToken parameters. Usage instructions: When querying the first page, set only MaxResults to limit the number of returned entries. The NextToken in the response will serve as the token for querying subsequent pages. When querying subsequent pages, set the NextToken parameter to the value obtained from the previous response, and set MaxResults to limit the number of returned entries.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUserTagValuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserTagValuesResponse
        /// </returns>
        public DescribeUserTagValuesResponse DescribeUserTagValuesWithOptions(DescribeUserTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagFilterValue))
            {
                body["TagFilterValue"] = request.TagFilterValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                body["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserTagValues",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserTagValuesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Centralized Role: Query User Disk and Snapshot tagValues</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <remarks>
        /// <para>The dedicated block storage cluster feature is currently supported in the following regions: South China 2 (Heyuan), Indonesia (Jakarta), and South China 1 (Shenzhen).</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The request parameters act as a filter, with a logical AND relationship. If any parameter is empty, the filter does not take effect.</description></item>
        /// <item><description>For paginated queries, it is recommended to use the MaxResults and NextToken parameters. Usage instructions: When querying the first page, set only MaxResults to limit the number of returned entries. The NextToken in the response will serve as the token for querying subsequent pages. When querying subsequent pages, set the NextToken parameter to the value obtained from the previous response, and set MaxResults to limit the number of returned entries.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUserTagValuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserTagValuesResponse
        /// </returns>
        public async Task<DescribeUserTagValuesResponse> DescribeUserTagValuesWithOptionsAsync(DescribeUserTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagFilterValue))
            {
                body["TagFilterValue"] = request.TagFilterValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                body["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserTagValues",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserTagValuesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Centralized Role: Query User Disk and Snapshot tagValues</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <remarks>
        /// <para>The dedicated block storage cluster feature is currently supported in the following regions: South China 2 (Heyuan), Indonesia (Jakarta), and South China 1 (Shenzhen).</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The request parameters act as a filter, with a logical AND relationship. If any parameter is empty, the filter does not take effect.</description></item>
        /// <item><description>For paginated queries, it is recommended to use the MaxResults and NextToken parameters. Usage instructions: When querying the first page, set only MaxResults to limit the number of returned entries. The NextToken in the response will serve as the token for querying subsequent pages. When querying subsequent pages, set the NextToken parameter to the value obtained from the previous response, and set MaxResults to limit the number of returned entries.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUserTagValuesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserTagValuesResponse
        /// </returns>
        public DescribeUserTagValuesResponse DescribeUserTagValues(DescribeUserTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserTagValuesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Centralized Role: Query User Disk and Snapshot tagValues</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <remarks>
        /// <para>The dedicated block storage cluster feature is currently supported in the following regions: South China 2 (Heyuan), Indonesia (Jakarta), and South China 1 (Shenzhen).</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The request parameters act as a filter, with a logical AND relationship. If any parameter is empty, the filter does not take effect.</description></item>
        /// <item><description>For paginated queries, it is recommended to use the MaxResults and NextToken parameters. Usage instructions: When querying the first page, set only MaxResults to limit the number of returned entries. The NextToken in the response will serve as the token for querying subsequent pages. When querying subsequent pages, set the NextToken parameter to the value obtained from the previous response, and set MaxResults to limit the number of returned entries.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUserTagValuesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserTagValuesResponse
        /// </returns>
        public async Task<DescribeUserTagValuesResponse> DescribeUserTagValuesAsync(DescribeUserTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserTagValuesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the failover feature for replication pairs in a replication pair-consistent group. When the primary disks of specific replication pairs in a replication pair-consistent group fail, you can call this operation to enable the read and write permissions on the secondary disks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group must be in the <b>One-time Syncing</b> (<c>manual_syncing</c>), <b>Syncing</b> (<c>syncing</c>), <b>Normal</b> (<c>normal</c>), <b>Stopping</b> (<c>stopping</c>), <b>Stop Failed</b> (<c>stop_failed</c>), <b>Stopped</b> (<c>stopped</c>), <b>In Failover</b> (<c>failovering</c>), <b>Failover Failed</b> (<c>failover_failed</c>), or <b>Failovered</b> (<c>failovered</c>) state.</description></item>
        /// <item><description>After a failover is performed, the replication pair-consistent group enters the <b>Failovered</b> (<c>failovered</c>) state.</description></item>
        /// <item><description>Before you perform a failover, make sure that the first full data synchronization is completed between the primary site and secondary site.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// FailoverDiskReplicaGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FailoverDiskReplicaGroupResponse
        /// </returns>
        public FailoverDiskReplicaGroupResponse FailoverDiskReplicaGroupWithOptions(FailoverDiskReplicaGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FailoverDiskReplicaGroup",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FailoverDiskReplicaGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the failover feature for replication pairs in a replication pair-consistent group. When the primary disks of specific replication pairs in a replication pair-consistent group fail, you can call this operation to enable the read and write permissions on the secondary disks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group must be in the <b>One-time Syncing</b> (<c>manual_syncing</c>), <b>Syncing</b> (<c>syncing</c>), <b>Normal</b> (<c>normal</c>), <b>Stopping</b> (<c>stopping</c>), <b>Stop Failed</b> (<c>stop_failed</c>), <b>Stopped</b> (<c>stopped</c>), <b>In Failover</b> (<c>failovering</c>), <b>Failover Failed</b> (<c>failover_failed</c>), or <b>Failovered</b> (<c>failovered</c>) state.</description></item>
        /// <item><description>After a failover is performed, the replication pair-consistent group enters the <b>Failovered</b> (<c>failovered</c>) state.</description></item>
        /// <item><description>Before you perform a failover, make sure that the first full data synchronization is completed between the primary site and secondary site.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// FailoverDiskReplicaGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FailoverDiskReplicaGroupResponse
        /// </returns>
        public async Task<FailoverDiskReplicaGroupResponse> FailoverDiskReplicaGroupWithOptionsAsync(FailoverDiskReplicaGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FailoverDiskReplicaGroup",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FailoverDiskReplicaGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the failover feature for replication pairs in a replication pair-consistent group. When the primary disks of specific replication pairs in a replication pair-consistent group fail, you can call this operation to enable the read and write permissions on the secondary disks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group must be in the <b>One-time Syncing</b> (<c>manual_syncing</c>), <b>Syncing</b> (<c>syncing</c>), <b>Normal</b> (<c>normal</c>), <b>Stopping</b> (<c>stopping</c>), <b>Stop Failed</b> (<c>stop_failed</c>), <b>Stopped</b> (<c>stopped</c>), <b>In Failover</b> (<c>failovering</c>), <b>Failover Failed</b> (<c>failover_failed</c>), or <b>Failovered</b> (<c>failovered</c>) state.</description></item>
        /// <item><description>After a failover is performed, the replication pair-consistent group enters the <b>Failovered</b> (<c>failovered</c>) state.</description></item>
        /// <item><description>Before you perform a failover, make sure that the first full data synchronization is completed between the primary site and secondary site.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// FailoverDiskReplicaGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// FailoverDiskReplicaGroupResponse
        /// </returns>
        public FailoverDiskReplicaGroupResponse FailoverDiskReplicaGroup(FailoverDiskReplicaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FailoverDiskReplicaGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the failover feature for replication pairs in a replication pair-consistent group. When the primary disks of specific replication pairs in a replication pair-consistent group fail, you can call this operation to enable the read and write permissions on the secondary disks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group must be in the <b>One-time Syncing</b> (<c>manual_syncing</c>), <b>Syncing</b> (<c>syncing</c>), <b>Normal</b> (<c>normal</c>), <b>Stopping</b> (<c>stopping</c>), <b>Stop Failed</b> (<c>stop_failed</c>), <b>Stopped</b> (<c>stopped</c>), <b>In Failover</b> (<c>failovering</c>), <b>Failover Failed</b> (<c>failover_failed</c>), or <b>Failovered</b> (<c>failovered</c>) state.</description></item>
        /// <item><description>After a failover is performed, the replication pair-consistent group enters the <b>Failovered</b> (<c>failovered</c>) state.</description></item>
        /// <item><description>Before you perform a failover, make sure that the first full data synchronization is completed between the primary site and secondary site.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// FailoverDiskReplicaGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// FailoverDiskReplicaGroupResponse
        /// </returns>
        public async Task<FailoverDiskReplicaGroupResponse> FailoverDiskReplicaGroupAsync(FailoverDiskReplicaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FailoverDiskReplicaGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the failover feature for replication pairs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair for which you want to enable failover cannot be in the <b>Invalid</b> (<c>invalid</c>) or <b>Deleted</b> (<c>deleted</c>) state.</description></item>
        /// <item><description>After a failover is performed, the replication pair enters the <b>Failovered</b> (<c>failovered</c>) state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// FailoverDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FailoverDiskReplicaPairResponse
        /// </returns>
        public FailoverDiskReplicaPairResponse FailoverDiskReplicaPairWithOptions(FailoverDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FailoverDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FailoverDiskReplicaPairResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the failover feature for replication pairs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair for which you want to enable failover cannot be in the <b>Invalid</b> (<c>invalid</c>) or <b>Deleted</b> (<c>deleted</c>) state.</description></item>
        /// <item><description>After a failover is performed, the replication pair enters the <b>Failovered</b> (<c>failovered</c>) state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// FailoverDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FailoverDiskReplicaPairResponse
        /// </returns>
        public async Task<FailoverDiskReplicaPairResponse> FailoverDiskReplicaPairWithOptionsAsync(FailoverDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FailoverDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FailoverDiskReplicaPairResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the failover feature for replication pairs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair for which you want to enable failover cannot be in the <b>Invalid</b> (<c>invalid</c>) or <b>Deleted</b> (<c>deleted</c>) state.</description></item>
        /// <item><description>After a failover is performed, the replication pair enters the <b>Failovered</b> (<c>failovered</c>) state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// FailoverDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// FailoverDiskReplicaPairResponse
        /// </returns>
        public FailoverDiskReplicaPairResponse FailoverDiskReplicaPair(FailoverDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FailoverDiskReplicaPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the failover feature for replication pairs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair for which you want to enable failover cannot be in the <b>Invalid</b> (<c>invalid</c>) or <b>Deleted</b> (<c>deleted</c>) state.</description></item>
        /// <item><description>After a failover is performed, the replication pair enters the <b>Failovered</b> (<c>failovered</c>) state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// FailoverDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// FailoverDiskReplicaPairResponse
        /// </returns>
        public async Task<FailoverDiskReplicaPairResponse> FailoverDiskReplicaPairAsync(FailoverDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FailoverDiskReplicaPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Centralized Role: Obtain User Usage Report with reportId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetReportResponse
        /// </returns>
        public GetReportResponse GetReportWithOptions(GetReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["ReportType"] = request.ReportType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                body["ReportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReport",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Centralized Role: Obtain User Usage Report with reportId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetReportResponse
        /// </returns>
        public async Task<GetReportResponse> GetReportWithOptionsAsync(GetReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["ReportType"] = request.ReportType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                body["ReportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReport",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Centralized Role: Obtain User Usage Report with reportId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetReportResponse
        /// </returns>
        public GetReportResponse GetReport(GetReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Centralized Role: Obtain User Usage Report with reportId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetReportResponse
        /// </returns>
        public async Task<GetReportResponse> GetReportAsync(GetReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Centralized Role: Query Historical Reports</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReportsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListReportsResponse
        /// </returns>
        public ListReportsResponse ListReportsWithOptions(ListReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReports",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReportsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Centralized Role: Query Historical Reports</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReportsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListReportsResponse
        /// </returns>
        public async Task<ListReportsResponse> ListReportsWithOptionsAsync(ListReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReports",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Centralized Role: Query Historical Reports</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListReportsResponse
        /// </returns>
        public ListReportsResponse ListReports(ListReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListReportsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Centralized Role: Query Historical Reports</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListReportsResponse
        /// </returns>
        public async Task<ListReportsResponse> ListReportsAsync(ListReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListReportsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to one or more Elastic Block Storage (EBS) resources, or queries the IDs and tags of resources in a specified non-default resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Specify at least one of the following parameters or parameter pairs in a request to determine a query object:</para>
        /// <list type="bullet">
        /// <item><description><c>ResourceId.N</c></description></item>
        /// <item><description><c>Tag.N</c> parameter pair (<c>Tag.N.Key</c> and <c>Tag.N.Value</c>)
        /// If you set <c>Tag.N</c> and <c>ResourceId.N</c> at the same time, the EBS resources that match both the parameters are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to one or more Elastic Block Storage (EBS) resources, or queries the IDs and tags of resources in a specified non-default resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Specify at least one of the following parameters or parameter pairs in a request to determine a query object:</para>
        /// <list type="bullet">
        /// <item><description><c>ResourceId.N</c></description></item>
        /// <item><description><c>Tag.N</c> parameter pair (<c>Tag.N.Key</c> and <c>Tag.N.Value</c>)
        /// If you set <c>Tag.N</c> and <c>ResourceId.N</c> at the same time, the EBS resources that match both the parameters are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to one or more Elastic Block Storage (EBS) resources, or queries the IDs and tags of resources in a specified non-default resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Specify at least one of the following parameters or parameter pairs in a request to determine a query object:</para>
        /// <list type="bullet">
        /// <item><description><c>ResourceId.N</c></description></item>
        /// <item><description><c>Tag.N</c> parameter pair (<c>Tag.N.Key</c> and <c>Tag.N.Value</c>)
        /// If you set <c>Tag.N</c> and <c>ResourceId.N</c> at the same time, the EBS resources that match both the parameters are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to one or more Elastic Block Storage (EBS) resources, or queries the IDs and tags of resources in a specified non-default resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Specify at least one of the following parameters or parameter pairs in a request to determine a query object:</para>
        /// <list type="bullet">
        /// <item><description><c>ResourceId.N</c></description></item>
        /// <item><description><c>Tag.N</c> parameter pair (<c>Tag.N.Key</c> and <c>Tag.N.Value</c>)
        /// If you set <c>Tag.N</c> and <c>ResourceId.N</c> at the same time, the EBS resources that match both the parameters are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改专属集群属性OpenApi</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the information of a dedicated block storage cluster. The information includes the name and description of the cluster.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDedicatedBlockStorageClusterAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDedicatedBlockStorageClusterAttributeResponse
        /// </returns>
        public ModifyDedicatedBlockStorageClusterAttributeResponse ModifyDedicatedBlockStorageClusterAttributeWithOptions(ModifyDedicatedBlockStorageClusterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbscId))
            {
                query["DbscId"] = request.DbscId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbscName))
            {
                query["DbscName"] = request.DbscName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedBlockStorageClusterAttribute",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedBlockStorageClusterAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改专属集群属性OpenApi</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the information of a dedicated block storage cluster. The information includes the name and description of the cluster.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDedicatedBlockStorageClusterAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDedicatedBlockStorageClusterAttributeResponse
        /// </returns>
        public async Task<ModifyDedicatedBlockStorageClusterAttributeResponse> ModifyDedicatedBlockStorageClusterAttributeWithOptionsAsync(ModifyDedicatedBlockStorageClusterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbscId))
            {
                query["DbscId"] = request.DbscId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbscName))
            {
                query["DbscName"] = request.DbscName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDedicatedBlockStorageClusterAttribute",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDedicatedBlockStorageClusterAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改专属集群属性OpenApi</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the information of a dedicated block storage cluster. The information includes the name and description of the cluster.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDedicatedBlockStorageClusterAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDedicatedBlockStorageClusterAttributeResponse
        /// </returns>
        public ModifyDedicatedBlockStorageClusterAttributeResponse ModifyDedicatedBlockStorageClusterAttribute(ModifyDedicatedBlockStorageClusterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedBlockStorageClusterAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改专属集群属性OpenApi</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the information of a dedicated block storage cluster. The information includes the name and description of the cluster.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDedicatedBlockStorageClusterAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDedicatedBlockStorageClusterAttributeResponse
        /// </returns>
        public async Task<ModifyDedicatedBlockStorageClusterAttributeResponse> ModifyDedicatedBlockStorageClusterAttributeAsync(ModifyDedicatedBlockStorageClusterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedBlockStorageClusterAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name, description, or recovery point objective (RPO) of a replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group must be in the <b>Created</b> (<c>created</c>) or <b>Stopped</b> (<c>stopped</c>) state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskReplicaGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskReplicaGroupResponse
        /// </returns>
        public ModifyDiskReplicaGroupResponse ModifyDiskReplicaGroupWithOptions(ModifyDiskReplicaGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RPO))
            {
                query["RPO"] = request.RPO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDiskReplicaGroup",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDiskReplicaGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name, description, or recovery point objective (RPO) of a replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group must be in the <b>Created</b> (<c>created</c>) or <b>Stopped</b> (<c>stopped</c>) state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskReplicaGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskReplicaGroupResponse
        /// </returns>
        public async Task<ModifyDiskReplicaGroupResponse> ModifyDiskReplicaGroupWithOptionsAsync(ModifyDiskReplicaGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RPO))
            {
                query["RPO"] = request.RPO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDiskReplicaGroup",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDiskReplicaGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name, description, or recovery point objective (RPO) of a replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group must be in the <b>Created</b> (<c>created</c>) or <b>Stopped</b> (<c>stopped</c>) state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskReplicaGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskReplicaGroupResponse
        /// </returns>
        public ModifyDiskReplicaGroupResponse ModifyDiskReplicaGroup(ModifyDiskReplicaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDiskReplicaGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name, description, or recovery point objective (RPO) of a replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group must be in the <b>Created</b> (<c>created</c>) or <b>Stopped</b> (<c>stopped</c>) state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskReplicaGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskReplicaGroupResponse
        /// </returns>
        public async Task<ModifyDiskReplicaGroupResponse> ModifyDiskReplicaGroupAsync(ModifyDiskReplicaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDiskReplicaGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a replication pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Only replication pairs that are in the <b>Created</b> (<c>created</c>) or <b>Stopped</b> (<c>stopped</c>) state can have their names or descriptions modified.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskReplicaPairResponse
        /// </returns>
        public ModifyDiskReplicaPairResponse ModifyDiskReplicaPairWithOptions(ModifyDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PairName))
            {
                query["PairName"] = request.PairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RPO))
            {
                query["RPO"] = request.RPO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDiskReplicaPairResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a replication pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Only replication pairs that are in the <b>Created</b> (<c>created</c>) or <b>Stopped</b> (<c>stopped</c>) state can have their names or descriptions modified.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskReplicaPairResponse
        /// </returns>
        public async Task<ModifyDiskReplicaPairResponse> ModifyDiskReplicaPairWithOptionsAsync(ModifyDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PairName))
            {
                query["PairName"] = request.PairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RPO))
            {
                query["RPO"] = request.RPO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDiskReplicaPairResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a replication pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Only replication pairs that are in the <b>Created</b> (<c>created</c>) or <b>Stopped</b> (<c>stopped</c>) state can have their names or descriptions modified.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskReplicaPairResponse
        /// </returns>
        public ModifyDiskReplicaPairResponse ModifyDiskReplicaPair(ModifyDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDiskReplicaPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a replication pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Only replication pairs that are in the <b>Created</b> (<c>created</c>) or <b>Stopped</b> (<c>stopped</c>) state can have their names or descriptions modified.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDiskReplicaPairResponse
        /// </returns>
        public async Task<ModifyDiskReplicaPairResponse> ModifyDiskReplicaPairAsync(ModifyDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDiskReplicaPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the throughput status of a dedicated block storage cluster disk which has been set through the SetDedicatedBlockStorageClusterDiskThroughput API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDedicatedBlockStorageClusterDiskThroughputStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDedicatedBlockStorageClusterDiskThroughputStatusResponse
        /// </returns>
        public QueryDedicatedBlockStorageClusterDiskThroughputStatusResponse QueryDedicatedBlockStorageClusterDiskThroughputStatusWithOptions(QueryDedicatedBlockStorageClusterDiskThroughputStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosRequestId))
            {
                body["QosRequestId"] = request.QosRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDedicatedBlockStorageClusterDiskThroughputStatus",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDedicatedBlockStorageClusterDiskThroughputStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the throughput status of a dedicated block storage cluster disk which has been set through the SetDedicatedBlockStorageClusterDiskThroughput API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDedicatedBlockStorageClusterDiskThroughputStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDedicatedBlockStorageClusterDiskThroughputStatusResponse
        /// </returns>
        public async Task<QueryDedicatedBlockStorageClusterDiskThroughputStatusResponse> QueryDedicatedBlockStorageClusterDiskThroughputStatusWithOptionsAsync(QueryDedicatedBlockStorageClusterDiskThroughputStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosRequestId))
            {
                body["QosRequestId"] = request.QosRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDedicatedBlockStorageClusterDiskThroughputStatus",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDedicatedBlockStorageClusterDiskThroughputStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the throughput status of a dedicated block storage cluster disk which has been set through the SetDedicatedBlockStorageClusterDiskThroughput API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDedicatedBlockStorageClusterDiskThroughputStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDedicatedBlockStorageClusterDiskThroughputStatusResponse
        /// </returns>
        public QueryDedicatedBlockStorageClusterDiskThroughputStatusResponse QueryDedicatedBlockStorageClusterDiskThroughputStatus(QueryDedicatedBlockStorageClusterDiskThroughputStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDedicatedBlockStorageClusterDiskThroughputStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the throughput status of a dedicated block storage cluster disk which has been set through the SetDedicatedBlockStorageClusterDiskThroughput API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDedicatedBlockStorageClusterDiskThroughputStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDedicatedBlockStorageClusterDiskThroughputStatusResponse
        /// </returns>
        public async Task<QueryDedicatedBlockStorageClusterDiskThroughputStatusResponse> QueryDedicatedBlockStorageClusterDiskThroughputStatusAsync(QueryDedicatedBlockStorageClusterDiskThroughputStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDedicatedBlockStorageClusterDiskThroughputStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query dedicated block storage cluster capacity trend data, includ available capacity size and total capacity size.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Period is the time interval between data retrieval points. When set to 60 (minute interval), a maximum of 1440 data points can be returned; when set to 3600 (hour interval), a maximum of 744 data points can be returned; and when set to 86400 (day interval), a maximum of 366 data points can be returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDedicatedBlockStorageClusterInventoryDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDedicatedBlockStorageClusterInventoryDataResponse
        /// </returns>
        public QueryDedicatedBlockStorageClusterInventoryDataResponse QueryDedicatedBlockStorageClusterInventoryDataWithOptions(QueryDedicatedBlockStorageClusterInventoryDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbscId))
            {
                body["DbscId"] = request.DbscId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDedicatedBlockStorageClusterInventoryData",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDedicatedBlockStorageClusterInventoryDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query dedicated block storage cluster capacity trend data, includ available capacity size and total capacity size.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Period is the time interval between data retrieval points. When set to 60 (minute interval), a maximum of 1440 data points can be returned; when set to 3600 (hour interval), a maximum of 744 data points can be returned; and when set to 86400 (day interval), a maximum of 366 data points can be returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDedicatedBlockStorageClusterInventoryDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDedicatedBlockStorageClusterInventoryDataResponse
        /// </returns>
        public async Task<QueryDedicatedBlockStorageClusterInventoryDataResponse> QueryDedicatedBlockStorageClusterInventoryDataWithOptionsAsync(QueryDedicatedBlockStorageClusterInventoryDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbscId))
            {
                body["DbscId"] = request.DbscId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDedicatedBlockStorageClusterInventoryData",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDedicatedBlockStorageClusterInventoryDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query dedicated block storage cluster capacity trend data, includ available capacity size and total capacity size.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Period is the time interval between data retrieval points. When set to 60 (minute interval), a maximum of 1440 data points can be returned; when set to 3600 (hour interval), a maximum of 744 data points can be returned; and when set to 86400 (day interval), a maximum of 366 data points can be returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDedicatedBlockStorageClusterInventoryDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDedicatedBlockStorageClusterInventoryDataResponse
        /// </returns>
        public QueryDedicatedBlockStorageClusterInventoryDataResponse QueryDedicatedBlockStorageClusterInventoryData(QueryDedicatedBlockStorageClusterInventoryDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDedicatedBlockStorageClusterInventoryDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query dedicated block storage cluster capacity trend data, includ available capacity size and total capacity size.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Period is the time interval between data retrieval points. When set to 60 (minute interval), a maximum of 1440 data points can be returned; when set to 3600 (hour interval), a maximum of 744 data points can be returned; and when set to 86400 (day interval), a maximum of 366 data points can be returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDedicatedBlockStorageClusterInventoryDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDedicatedBlockStorageClusterInventoryDataResponse
        /// </returns>
        public async Task<QueryDedicatedBlockStorageClusterInventoryDataResponse> QueryDedicatedBlockStorageClusterInventoryDataAsync(QueryDedicatedBlockStorageClusterInventoryDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDedicatedBlockStorageClusterInventoryDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a replication pair from a replication pair-consistent group. After a replication pair is removed from a replication pair-consistent group, the pair is disassociated from the group but is not deleted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group from which you want to remove a replication pair must be in the <b>Created</b> (<c>created</c>), <b>Stopped</b> (<c>stopped</c>), or <b>Invalid</b> (<c>invalid</c>) state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveDiskReplicaPairResponse
        /// </returns>
        public RemoveDiskReplicaPairResponse RemoveDiskReplicaPairWithOptions(RemoveDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveDiskReplicaPairResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a replication pair from a replication pair-consistent group. After a replication pair is removed from a replication pair-consistent group, the pair is disassociated from the group but is not deleted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group from which you want to remove a replication pair must be in the <b>Created</b> (<c>created</c>), <b>Stopped</b> (<c>stopped</c>), or <b>Invalid</b> (<c>invalid</c>) state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveDiskReplicaPairResponse
        /// </returns>
        public async Task<RemoveDiskReplicaPairResponse> RemoveDiskReplicaPairWithOptionsAsync(RemoveDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveDiskReplicaPairResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a replication pair from a replication pair-consistent group. After a replication pair is removed from a replication pair-consistent group, the pair is disassociated from the group but is not deleted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group from which you want to remove a replication pair must be in the <b>Created</b> (<c>created</c>), <b>Stopped</b> (<c>stopped</c>), or <b>Invalid</b> (<c>invalid</c>) state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveDiskReplicaPairResponse
        /// </returns>
        public RemoveDiskReplicaPairResponse RemoveDiskReplicaPair(RemoveDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveDiskReplicaPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a replication pair from a replication pair-consistent group. After a replication pair is removed from a replication pair-consistent group, the pair is disassociated from the group but is not deleted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group from which you want to remove a replication pair must be in the <b>Created</b> (<c>created</c>), <b>Stopped</b> (<c>stopped</c>), or <b>Invalid</b> (<c>invalid</c>) state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveDiskReplicaPairResponse
        /// </returns>
        public async Task<RemoveDiskReplicaPairResponse> RemoveDiskReplicaPairAsync(RemoveDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveDiskReplicaPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the reverse replication feature for replication pairs that belong to a replication pair-consistent group. After reverse replication is enabled, data stored on the original secondary disks is replicated to the original primary disks. When a reverse replication is being performed, the primary and secondary sites of the replication pair-consistent group remain unchanged, but data is replicated from the secondary site to the primary site.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group for which you want to enable reverse replication must be in the <b>Failovered</b> (<c>failovered</c>) state. You can call the <c>FailoverDiskReplicaPair</c> operation to enable failover.</description></item>
        /// <item><description>Before a reverse replication is performed, the primary disks must be detached from its associated Elastic Compute Service (ECS) instance and must be in the Unattached state. You can call the <a href="https://help.aliyun.com/document_detail/25516.html">DetachDisk</a> operation to detach the disks.</description></item>
        /// <item><description>After you enable reverse replication, you must call the <c>StartDiskReplicaPair</c> operation again to enable the async replication feature before data can be replicated from the original secondary disks to the original primary disks.</description></item>
        /// <item><description>You can set the ReverseReplicate parameter to false to cancel the <b>Failovered</b> (<c>failovered</c>) state and restore the original replication direction.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReprotectDiskReplicaGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReprotectDiskReplicaGroupResponse
        /// </returns>
        public ReprotectDiskReplicaGroupResponse ReprotectDiskReplicaGroupWithOptions(ReprotectDiskReplicaGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReverseReplicate))
            {
                query["ReverseReplicate"] = request.ReverseReplicate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReprotectDiskReplicaGroup",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReprotectDiskReplicaGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the reverse replication feature for replication pairs that belong to a replication pair-consistent group. After reverse replication is enabled, data stored on the original secondary disks is replicated to the original primary disks. When a reverse replication is being performed, the primary and secondary sites of the replication pair-consistent group remain unchanged, but data is replicated from the secondary site to the primary site.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group for which you want to enable reverse replication must be in the <b>Failovered</b> (<c>failovered</c>) state. You can call the <c>FailoverDiskReplicaPair</c> operation to enable failover.</description></item>
        /// <item><description>Before a reverse replication is performed, the primary disks must be detached from its associated Elastic Compute Service (ECS) instance and must be in the Unattached state. You can call the <a href="https://help.aliyun.com/document_detail/25516.html">DetachDisk</a> operation to detach the disks.</description></item>
        /// <item><description>After you enable reverse replication, you must call the <c>StartDiskReplicaPair</c> operation again to enable the async replication feature before data can be replicated from the original secondary disks to the original primary disks.</description></item>
        /// <item><description>You can set the ReverseReplicate parameter to false to cancel the <b>Failovered</b> (<c>failovered</c>) state and restore the original replication direction.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReprotectDiskReplicaGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReprotectDiskReplicaGroupResponse
        /// </returns>
        public async Task<ReprotectDiskReplicaGroupResponse> ReprotectDiskReplicaGroupWithOptionsAsync(ReprotectDiskReplicaGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReverseReplicate))
            {
                query["ReverseReplicate"] = request.ReverseReplicate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReprotectDiskReplicaGroup",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReprotectDiskReplicaGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the reverse replication feature for replication pairs that belong to a replication pair-consistent group. After reverse replication is enabled, data stored on the original secondary disks is replicated to the original primary disks. When a reverse replication is being performed, the primary and secondary sites of the replication pair-consistent group remain unchanged, but data is replicated from the secondary site to the primary site.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group for which you want to enable reverse replication must be in the <b>Failovered</b> (<c>failovered</c>) state. You can call the <c>FailoverDiskReplicaPair</c> operation to enable failover.</description></item>
        /// <item><description>Before a reverse replication is performed, the primary disks must be detached from its associated Elastic Compute Service (ECS) instance and must be in the Unattached state. You can call the <a href="https://help.aliyun.com/document_detail/25516.html">DetachDisk</a> operation to detach the disks.</description></item>
        /// <item><description>After you enable reverse replication, you must call the <c>StartDiskReplicaPair</c> operation again to enable the async replication feature before data can be replicated from the original secondary disks to the original primary disks.</description></item>
        /// <item><description>You can set the ReverseReplicate parameter to false to cancel the <b>Failovered</b> (<c>failovered</c>) state and restore the original replication direction.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReprotectDiskReplicaGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ReprotectDiskReplicaGroupResponse
        /// </returns>
        public ReprotectDiskReplicaGroupResponse ReprotectDiskReplicaGroup(ReprotectDiskReplicaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReprotectDiskReplicaGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the reverse replication feature for replication pairs that belong to a replication pair-consistent group. After reverse replication is enabled, data stored on the original secondary disks is replicated to the original primary disks. When a reverse replication is being performed, the primary and secondary sites of the replication pair-consistent group remain unchanged, but data is replicated from the secondary site to the primary site.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group for which you want to enable reverse replication must be in the <b>Failovered</b> (<c>failovered</c>) state. You can call the <c>FailoverDiskReplicaPair</c> operation to enable failover.</description></item>
        /// <item><description>Before a reverse replication is performed, the primary disks must be detached from its associated Elastic Compute Service (ECS) instance and must be in the Unattached state. You can call the <a href="https://help.aliyun.com/document_detail/25516.html">DetachDisk</a> operation to detach the disks.</description></item>
        /// <item><description>After you enable reverse replication, you must call the <c>StartDiskReplicaPair</c> operation again to enable the async replication feature before data can be replicated from the original secondary disks to the original primary disks.</description></item>
        /// <item><description>You can set the ReverseReplicate parameter to false to cancel the <b>Failovered</b> (<c>failovered</c>) state and restore the original replication direction.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReprotectDiskReplicaGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ReprotectDiskReplicaGroupResponse
        /// </returns>
        public async Task<ReprotectDiskReplicaGroupResponse> ReprotectDiskReplicaGroupAsync(ReprotectDiskReplicaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReprotectDiskReplicaGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the reverse replication feature for a replication pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair for which you want to enable reverse replication must be in the <b>Failovered</b> (<c>failovered</c>) state. You can call the <a href="https://help.aliyun.com/document_detail/354358.html">FailoverDiskReplicaPair</a> operation to enable failover.</description></item>
        /// <item><description>The primary disk must be detached from its associated Elastic Compute Service (ECS) instance and is in the Unattached state. You can call the <a href="https://help.aliyun.com/document_detail/25516.html">DetachDisk</a> operation to detach the disk.</description></item>
        /// <item><description>After you enable reverse replication, you must call the <a href="https://help.aliyun.com/document_detail/354205.html">StartDiskReplicaPair</a> operation again to activate the replication pair before data can be replicated from the original secondary disk to the original primary disk.</description></item>
        /// <item><description>You can set the ReverseReplicate parameter to false to cancel the <b>Failovered</b> (<c>failovered</c>) state and restore the original replication direction.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReprotectDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReprotectDiskReplicaPairResponse
        /// </returns>
        public ReprotectDiskReplicaPairResponse ReprotectDiskReplicaPairWithOptions(ReprotectDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReverseReplicate))
            {
                query["ReverseReplicate"] = request.ReverseReplicate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReprotectDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReprotectDiskReplicaPairResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the reverse replication feature for a replication pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair for which you want to enable reverse replication must be in the <b>Failovered</b> (<c>failovered</c>) state. You can call the <a href="https://help.aliyun.com/document_detail/354358.html">FailoverDiskReplicaPair</a> operation to enable failover.</description></item>
        /// <item><description>The primary disk must be detached from its associated Elastic Compute Service (ECS) instance and is in the Unattached state. You can call the <a href="https://help.aliyun.com/document_detail/25516.html">DetachDisk</a> operation to detach the disk.</description></item>
        /// <item><description>After you enable reverse replication, you must call the <a href="https://help.aliyun.com/document_detail/354205.html">StartDiskReplicaPair</a> operation again to activate the replication pair before data can be replicated from the original secondary disk to the original primary disk.</description></item>
        /// <item><description>You can set the ReverseReplicate parameter to false to cancel the <b>Failovered</b> (<c>failovered</c>) state and restore the original replication direction.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReprotectDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReprotectDiskReplicaPairResponse
        /// </returns>
        public async Task<ReprotectDiskReplicaPairResponse> ReprotectDiskReplicaPairWithOptionsAsync(ReprotectDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReverseReplicate))
            {
                query["ReverseReplicate"] = request.ReverseReplicate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReprotectDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReprotectDiskReplicaPairResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the reverse replication feature for a replication pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair for which you want to enable reverse replication must be in the <b>Failovered</b> (<c>failovered</c>) state. You can call the <a href="https://help.aliyun.com/document_detail/354358.html">FailoverDiskReplicaPair</a> operation to enable failover.</description></item>
        /// <item><description>The primary disk must be detached from its associated Elastic Compute Service (ECS) instance and is in the Unattached state. You can call the <a href="https://help.aliyun.com/document_detail/25516.html">DetachDisk</a> operation to detach the disk.</description></item>
        /// <item><description>After you enable reverse replication, you must call the <a href="https://help.aliyun.com/document_detail/354205.html">StartDiskReplicaPair</a> operation again to activate the replication pair before data can be replicated from the original secondary disk to the original primary disk.</description></item>
        /// <item><description>You can set the ReverseReplicate parameter to false to cancel the <b>Failovered</b> (<c>failovered</c>) state and restore the original replication direction.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReprotectDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// ReprotectDiskReplicaPairResponse
        /// </returns>
        public ReprotectDiskReplicaPairResponse ReprotectDiskReplicaPair(ReprotectDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReprotectDiskReplicaPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the reverse replication feature for a replication pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair for which you want to enable reverse replication must be in the <b>Failovered</b> (<c>failovered</c>) state. You can call the <a href="https://help.aliyun.com/document_detail/354358.html">FailoverDiskReplicaPair</a> operation to enable failover.</description></item>
        /// <item><description>The primary disk must be detached from its associated Elastic Compute Service (ECS) instance and is in the Unattached state. You can call the <a href="https://help.aliyun.com/document_detail/25516.html">DetachDisk</a> operation to detach the disk.</description></item>
        /// <item><description>After you enable reverse replication, you must call the <a href="https://help.aliyun.com/document_detail/354205.html">StartDiskReplicaPair</a> operation again to activate the replication pair before data can be replicated from the original secondary disk to the original primary disk.</description></item>
        /// <item><description>You can set the ReverseReplicate parameter to false to cancel the <b>Failovered</b> (<c>failovered</c>) state and restore the original replication direction.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReprotectDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// ReprotectDiskReplicaPairResponse
        /// </returns>
        public async Task<ReprotectDiskReplicaPairResponse> ReprotectDiskReplicaPairAsync(ReprotectDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReprotectDiskReplicaPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>In the elastic type dedicated block storage cluster, you can easily achieve the specified throughput (Bps) for the target disk. You only need to set the cloud disk ID and the target throughput, simplifying the process of configuring.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDedicatedBlockStorageClusterDiskThroughputRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDedicatedBlockStorageClusterDiskThroughputResponse
        /// </returns>
        public SetDedicatedBlockStorageClusterDiskThroughputResponse SetDedicatedBlockStorageClusterDiskThroughputWithOptions(SetDedicatedBlockStorageClusterDiskThroughputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bps))
            {
                body["Bps"] = request.Bps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                body["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDedicatedBlockStorageClusterDiskThroughput",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDedicatedBlockStorageClusterDiskThroughputResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>In the elastic type dedicated block storage cluster, you can easily achieve the specified throughput (Bps) for the target disk. You only need to set the cloud disk ID and the target throughput, simplifying the process of configuring.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDedicatedBlockStorageClusterDiskThroughputRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDedicatedBlockStorageClusterDiskThroughputResponse
        /// </returns>
        public async Task<SetDedicatedBlockStorageClusterDiskThroughputResponse> SetDedicatedBlockStorageClusterDiskThroughputWithOptionsAsync(SetDedicatedBlockStorageClusterDiskThroughputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bps))
            {
                body["Bps"] = request.Bps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                body["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDedicatedBlockStorageClusterDiskThroughput",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDedicatedBlockStorageClusterDiskThroughputResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>In the elastic type dedicated block storage cluster, you can easily achieve the specified throughput (Bps) for the target disk. You only need to set the cloud disk ID and the target throughput, simplifying the process of configuring.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDedicatedBlockStorageClusterDiskThroughputRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDedicatedBlockStorageClusterDiskThroughputResponse
        /// </returns>
        public SetDedicatedBlockStorageClusterDiskThroughputResponse SetDedicatedBlockStorageClusterDiskThroughput(SetDedicatedBlockStorageClusterDiskThroughputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDedicatedBlockStorageClusterDiskThroughputWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>In the elastic type dedicated block storage cluster, you can easily achieve the specified throughput (Bps) for the target disk. You only need to set the cloud disk ID and the target throughput, simplifying the process of configuring.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDedicatedBlockStorageClusterDiskThroughputRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDedicatedBlockStorageClusterDiskThroughputResponse
        /// </returns>
        public async Task<SetDedicatedBlockStorageClusterDiskThroughputResponse> SetDedicatedBlockStorageClusterDiskThroughputAsync(SetDedicatedBlockStorageClusterDiskThroughputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDedicatedBlockStorageClusterDiskThroughputWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the async replication feature for replication pairs that belong to a replication pair-consistent group. When the async replication feature is enabled for the pairs for the first time, the system first performs a full synchronization to synchronize all data from disks at the primary site (primary disks) to disks at the secondary site (secondary disks) and then periodically synchronizes incremental data based on the recovery point objective (RPO) of the replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>If you set the <c>OneShot</c> to <c>false</c>, the replication pair-consistent group must be in the <b>Created</b> (<c>created</c> ), <b>Synchronizing</b> (<c>syncing</c> ), <b>Normal</b> (<c>normal</c> ), or <b>Stopped</b> (<c>stopped</c>) state.</description></item>
        /// <item><description>If you set <c>OneShot</c> to <c>true</c>, the replication pair-consistent group must be in the <b>Created</b> (<c>created</c> ), <b>One-time Syncing</b> (<c>manual_syncing</c> ), or <b>Stopped</b> (<c>stopped</c>) state. The time interval between two consecutive one-time synchronizations must be longer than one half of the recovery point objective (RPO).</description></item>
        /// <item><description>After a replication pair-consistent group is activated, the group enters the <b>Initial Syncing</b> (<c>initial_syncing</c>) state and the system performs the first async replication to replicate all data from the primary disks to secondary disks.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDiskReplicaGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDiskReplicaGroupResponse
        /// </returns>
        public StartDiskReplicaGroupResponse StartDiskReplicaGroupWithOptions(StartDiskReplicaGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OneShot))
            {
                query["OneShot"] = request.OneShot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDiskReplicaGroup",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDiskReplicaGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the async replication feature for replication pairs that belong to a replication pair-consistent group. When the async replication feature is enabled for the pairs for the first time, the system first performs a full synchronization to synchronize all data from disks at the primary site (primary disks) to disks at the secondary site (secondary disks) and then periodically synchronizes incremental data based on the recovery point objective (RPO) of the replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>If you set the <c>OneShot</c> to <c>false</c>, the replication pair-consistent group must be in the <b>Created</b> (<c>created</c> ), <b>Synchronizing</b> (<c>syncing</c> ), <b>Normal</b> (<c>normal</c> ), or <b>Stopped</b> (<c>stopped</c>) state.</description></item>
        /// <item><description>If you set <c>OneShot</c> to <c>true</c>, the replication pair-consistent group must be in the <b>Created</b> (<c>created</c> ), <b>One-time Syncing</b> (<c>manual_syncing</c> ), or <b>Stopped</b> (<c>stopped</c>) state. The time interval between two consecutive one-time synchronizations must be longer than one half of the recovery point objective (RPO).</description></item>
        /// <item><description>After a replication pair-consistent group is activated, the group enters the <b>Initial Syncing</b> (<c>initial_syncing</c>) state and the system performs the first async replication to replicate all data from the primary disks to secondary disks.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDiskReplicaGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDiskReplicaGroupResponse
        /// </returns>
        public async Task<StartDiskReplicaGroupResponse> StartDiskReplicaGroupWithOptionsAsync(StartDiskReplicaGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OneShot))
            {
                query["OneShot"] = request.OneShot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDiskReplicaGroup",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDiskReplicaGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the async replication feature for replication pairs that belong to a replication pair-consistent group. When the async replication feature is enabled for the pairs for the first time, the system first performs a full synchronization to synchronize all data from disks at the primary site (primary disks) to disks at the secondary site (secondary disks) and then periodically synchronizes incremental data based on the recovery point objective (RPO) of the replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>If you set the <c>OneShot</c> to <c>false</c>, the replication pair-consistent group must be in the <b>Created</b> (<c>created</c> ), <b>Synchronizing</b> (<c>syncing</c> ), <b>Normal</b> (<c>normal</c> ), or <b>Stopped</b> (<c>stopped</c>) state.</description></item>
        /// <item><description>If you set <c>OneShot</c> to <c>true</c>, the replication pair-consistent group must be in the <b>Created</b> (<c>created</c> ), <b>One-time Syncing</b> (<c>manual_syncing</c> ), or <b>Stopped</b> (<c>stopped</c>) state. The time interval between two consecutive one-time synchronizations must be longer than one half of the recovery point objective (RPO).</description></item>
        /// <item><description>After a replication pair-consistent group is activated, the group enters the <b>Initial Syncing</b> (<c>initial_syncing</c>) state and the system performs the first async replication to replicate all data from the primary disks to secondary disks.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDiskReplicaGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDiskReplicaGroupResponse
        /// </returns>
        public StartDiskReplicaGroupResponse StartDiskReplicaGroup(StartDiskReplicaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDiskReplicaGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the async replication feature for replication pairs that belong to a replication pair-consistent group. When the async replication feature is enabled for the pairs for the first time, the system first performs a full synchronization to synchronize all data from disks at the primary site (primary disks) to disks at the secondary site (secondary disks) and then periodically synchronizes incremental data based on the recovery point objective (RPO) of the replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>If you set the <c>OneShot</c> to <c>false</c>, the replication pair-consistent group must be in the <b>Created</b> (<c>created</c> ), <b>Synchronizing</b> (<c>syncing</c> ), <b>Normal</b> (<c>normal</c> ), or <b>Stopped</b> (<c>stopped</c>) state.</description></item>
        /// <item><description>If you set <c>OneShot</c> to <c>true</c>, the replication pair-consistent group must be in the <b>Created</b> (<c>created</c> ), <b>One-time Syncing</b> (<c>manual_syncing</c> ), or <b>Stopped</b> (<c>stopped</c>) state. The time interval between two consecutive one-time synchronizations must be longer than one half of the recovery point objective (RPO).</description></item>
        /// <item><description>After a replication pair-consistent group is activated, the group enters the <b>Initial Syncing</b> (<c>initial_syncing</c>) state and the system performs the first async replication to replicate all data from the primary disks to secondary disks.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDiskReplicaGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDiskReplicaGroupResponse
        /// </returns>
        public async Task<StartDiskReplicaGroupResponse> StartDiskReplicaGroupAsync(StartDiskReplicaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDiskReplicaGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates a replication pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Only replication pairs that are in the <b>Created</b> (<c>created</c>) or <b>Stopped</b> (<c>stopped</c>) state can be activated.</description></item>
        /// <item><description>After a replication pair is activated, it enters the <b>Initial Syncing</b> (<c>initial_syncing</c>) state and the system performs the first asynchronous replication to replicate all data from the primary disk to the secondary disk.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDiskReplicaPairResponse
        /// </returns>
        public StartDiskReplicaPairResponse StartDiskReplicaPairWithOptions(StartDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OneShot))
            {
                query["OneShot"] = request.OneShot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDiskReplicaPairResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates a replication pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Only replication pairs that are in the <b>Created</b> (<c>created</c>) or <b>Stopped</b> (<c>stopped</c>) state can be activated.</description></item>
        /// <item><description>After a replication pair is activated, it enters the <b>Initial Syncing</b> (<c>initial_syncing</c>) state and the system performs the first asynchronous replication to replicate all data from the primary disk to the secondary disk.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDiskReplicaPairResponse
        /// </returns>
        public async Task<StartDiskReplicaPairResponse> StartDiskReplicaPairWithOptionsAsync(StartDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OneShot))
            {
                query["OneShot"] = request.OneShot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDiskReplicaPairResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates a replication pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Only replication pairs that are in the <b>Created</b> (<c>created</c>) or <b>Stopped</b> (<c>stopped</c>) state can be activated.</description></item>
        /// <item><description>After a replication pair is activated, it enters the <b>Initial Syncing</b> (<c>initial_syncing</c>) state and the system performs the first asynchronous replication to replicate all data from the primary disk to the secondary disk.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDiskReplicaPairResponse
        /// </returns>
        public StartDiskReplicaPairResponse StartDiskReplicaPair(StartDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDiskReplicaPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates a replication pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Only replication pairs that are in the <b>Created</b> (<c>created</c>) or <b>Stopped</b> (<c>stopped</c>) state can be activated.</description></item>
        /// <item><description>After a replication pair is activated, it enters the <b>Initial Syncing</b> (<c>initial_syncing</c>) state and the system performs the first asynchronous replication to replicate all data from the primary disk to the secondary disk.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDiskReplicaPairResponse
        /// </returns>
        public async Task<StartDiskReplicaPairResponse> StartDiskReplicaPairAsync(StartDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDiskReplicaPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a disaster recovery drill to ensure the continued replication and clone the data from the last recovery point of the secondary disk to a new disk. This helps you test the completeness and correctness of applications that are deployed on the disaster recovery site on a regular basis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After the disaster recovery drill is complete on the secondary disk, a pay-as-you-go drill disk that has the same capacity and category as the secondary disk is created in the zone where the secondary disk resides. The drill disk contains last-recovery-point data that can be used to test the completeness and correctness of applications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartPairDrillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartPairDrillResponse
        /// </returns>
        public StartPairDrillResponse StartPairDrillWithOptions(StartPairDrillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PairId))
            {
                query["PairId"] = request.PairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartPairDrill",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartPairDrillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a disaster recovery drill to ensure the continued replication and clone the data from the last recovery point of the secondary disk to a new disk. This helps you test the completeness and correctness of applications that are deployed on the disaster recovery site on a regular basis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After the disaster recovery drill is complete on the secondary disk, a pay-as-you-go drill disk that has the same capacity and category as the secondary disk is created in the zone where the secondary disk resides. The drill disk contains last-recovery-point data that can be used to test the completeness and correctness of applications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartPairDrillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartPairDrillResponse
        /// </returns>
        public async Task<StartPairDrillResponse> StartPairDrillWithOptionsAsync(StartPairDrillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PairId))
            {
                query["PairId"] = request.PairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartPairDrill",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartPairDrillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a disaster recovery drill to ensure the continued replication and clone the data from the last recovery point of the secondary disk to a new disk. This helps you test the completeness and correctness of applications that are deployed on the disaster recovery site on a regular basis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After the disaster recovery drill is complete on the secondary disk, a pay-as-you-go drill disk that has the same capacity and category as the secondary disk is created in the zone where the secondary disk resides. The drill disk contains last-recovery-point data that can be used to test the completeness and correctness of applications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartPairDrillRequest
        /// </param>
        /// 
        /// <returns>
        /// StartPairDrillResponse
        /// </returns>
        public StartPairDrillResponse StartPairDrill(StartPairDrillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartPairDrillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a disaster recovery drill to ensure the continued replication and clone the data from the last recovery point of the secondary disk to a new disk. This helps you test the completeness and correctness of applications that are deployed on the disaster recovery site on a regular basis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After the disaster recovery drill is complete on the secondary disk, a pay-as-you-go drill disk that has the same capacity and category as the secondary disk is created in the zone where the secondary disk resides. The drill disk contains last-recovery-point data that can be used to test the completeness and correctness of applications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartPairDrillRequest
        /// </param>
        /// 
        /// <returns>
        /// StartPairDrillResponse
        /// </returns>
        public async Task<StartPairDrillResponse> StartPairDrillAsync(StartPairDrillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartPairDrillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a disaster recovery drill in a replication pair-consistent group to ensure the continued replication and restores data from the latest recovery point of secondary disks to new disks. This helps test the completeness and correctness of applications that are deployed on the disaster recovery site on a regular basis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After the disaster recovery drill is complete on secondary disks, a pay-as-you-go drill disk is created in the zone where the secondary disk of each replication pair resides. The latest-recovery-point data is restored to the drill disks to test the completeness and correctness of applications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartReplicaGroupDrillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartReplicaGroupDrillResponse
        /// </returns>
        public StartReplicaGroupDrillResponse StartReplicaGroupDrillWithOptions(StartReplicaGroupDrillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartReplicaGroupDrill",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartReplicaGroupDrillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a disaster recovery drill in a replication pair-consistent group to ensure the continued replication and restores data from the latest recovery point of secondary disks to new disks. This helps test the completeness and correctness of applications that are deployed on the disaster recovery site on a regular basis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After the disaster recovery drill is complete on secondary disks, a pay-as-you-go drill disk is created in the zone where the secondary disk of each replication pair resides. The latest-recovery-point data is restored to the drill disks to test the completeness and correctness of applications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartReplicaGroupDrillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartReplicaGroupDrillResponse
        /// </returns>
        public async Task<StartReplicaGroupDrillResponse> StartReplicaGroupDrillWithOptionsAsync(StartReplicaGroupDrillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartReplicaGroupDrill",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartReplicaGroupDrillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a disaster recovery drill in a replication pair-consistent group to ensure the continued replication and restores data from the latest recovery point of secondary disks to new disks. This helps test the completeness and correctness of applications that are deployed on the disaster recovery site on a regular basis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After the disaster recovery drill is complete on secondary disks, a pay-as-you-go drill disk is created in the zone where the secondary disk of each replication pair resides. The latest-recovery-point data is restored to the drill disks to test the completeness and correctness of applications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartReplicaGroupDrillRequest
        /// </param>
        /// 
        /// <returns>
        /// StartReplicaGroupDrillResponse
        /// </returns>
        public StartReplicaGroupDrillResponse StartReplicaGroupDrill(StartReplicaGroupDrillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartReplicaGroupDrillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a disaster recovery drill in a replication pair-consistent group to ensure the continued replication and restores data from the latest recovery point of secondary disks to new disks. This helps test the completeness and correctness of applications that are deployed on the disaster recovery site on a regular basis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After the disaster recovery drill is complete on secondary disks, a pay-as-you-go drill disk is created in the zone where the secondary disk of each replication pair resides. The latest-recovery-point data is restored to the drill disks to test the completeness and correctness of applications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartReplicaGroupDrillRequest
        /// </param>
        /// 
        /// <returns>
        /// StartReplicaGroupDrillResponse
        /// </returns>
        public async Task<StartReplicaGroupDrillResponse> StartReplicaGroupDrillAsync(StartReplicaGroupDrillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartReplicaGroupDrillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a replication pair-consistent group. This operation stops all replication pairs in the replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group that you want to stop must be in the <b>One-time Syncing</b> (<c>manual_syncing</c>), <b>Syncing</b> (<c>syncing</c>), <b>Normal</b> (<c>normal</c>), <b>Stopping</b> (<c>stopping</c>), <b>Stop Failed</b> (<c>stop_failed</c>), or <b>Stopped</b> (<c>stopped</c>) state.</description></item>
        /// <item><description>When a replication pair-consistent group is stopped, it enters the <b>Stopped</b> (<c>stopped</c>) state. If a replication pair-consistent group cannot be stopped, the state of the group remains unchanged or changes to <b>Stop Failed</b> (<c>stop_failed</c>). In this case, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDiskReplicaGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDiskReplicaGroupResponse
        /// </returns>
        public StopDiskReplicaGroupResponse StopDiskReplicaGroupWithOptions(StopDiskReplicaGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDiskReplicaGroup",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDiskReplicaGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a replication pair-consistent group. This operation stops all replication pairs in the replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group that you want to stop must be in the <b>One-time Syncing</b> (<c>manual_syncing</c>), <b>Syncing</b> (<c>syncing</c>), <b>Normal</b> (<c>normal</c>), <b>Stopping</b> (<c>stopping</c>), <b>Stop Failed</b> (<c>stop_failed</c>), or <b>Stopped</b> (<c>stopped</c>) state.</description></item>
        /// <item><description>When a replication pair-consistent group is stopped, it enters the <b>Stopped</b> (<c>stopped</c>) state. If a replication pair-consistent group cannot be stopped, the state of the group remains unchanged or changes to <b>Stop Failed</b> (<c>stop_failed</c>). In this case, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDiskReplicaGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDiskReplicaGroupResponse
        /// </returns>
        public async Task<StopDiskReplicaGroupResponse> StopDiskReplicaGroupWithOptionsAsync(StopDiskReplicaGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaGroupId))
            {
                query["ReplicaGroupId"] = request.ReplicaGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDiskReplicaGroup",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDiskReplicaGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a replication pair-consistent group. This operation stops all replication pairs in the replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group that you want to stop must be in the <b>One-time Syncing</b> (<c>manual_syncing</c>), <b>Syncing</b> (<c>syncing</c>), <b>Normal</b> (<c>normal</c>), <b>Stopping</b> (<c>stopping</c>), <b>Stop Failed</b> (<c>stop_failed</c>), or <b>Stopped</b> (<c>stopped</c>) state.</description></item>
        /// <item><description>When a replication pair-consistent group is stopped, it enters the <b>Stopped</b> (<c>stopped</c>) state. If a replication pair-consistent group cannot be stopped, the state of the group remains unchanged or changes to <b>Stop Failed</b> (<c>stop_failed</c>). In this case, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDiskReplicaGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDiskReplicaGroupResponse
        /// </returns>
        public StopDiskReplicaGroupResponse StopDiskReplicaGroup(StopDiskReplicaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDiskReplicaGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a replication pair-consistent group. This operation stops all replication pairs in the replication pair-consistent group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which the replication pair-consistent group feature is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>The replication pair-consistent group that you want to stop must be in the <b>One-time Syncing</b> (<c>manual_syncing</c>), <b>Syncing</b> (<c>syncing</c>), <b>Normal</b> (<c>normal</c>), <b>Stopping</b> (<c>stopping</c>), <b>Stop Failed</b> (<c>stop_failed</c>), or <b>Stopped</b> (<c>stopped</c>) state.</description></item>
        /// <item><description>When a replication pair-consistent group is stopped, it enters the <b>Stopped</b> (<c>stopped</c>) state. If a replication pair-consistent group cannot be stopped, the state of the group remains unchanged or changes to <b>Stop Failed</b> (<c>stop_failed</c>). In this case, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDiskReplicaGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDiskReplicaGroupResponse
        /// </returns>
        public async Task<StopDiskReplicaGroupResponse> StopDiskReplicaGroupAsync(StopDiskReplicaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDiskReplicaGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a replication pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Only replication pairs that are in the <b>Initial Syncing</b> (<c>initial_syncing</c>), <b>Syncing</b> (<c>syncing</c>), <b>One-time Syncing</b> (<c>manual_syncing</c>), or <b>Normal</b> (<c>normal</c>) state can be stopped. When a replication pair is stopped, it enters the Stopped (<c>stopped</c>) state. The secondary disk rolls back to the point in time when the last async replication was complete and drops all the data that is being replicated from the primary disk.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDiskReplicaPairResponse
        /// </returns>
        public StopDiskReplicaPairResponse StopDiskReplicaPairWithOptions(StopDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDiskReplicaPairResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a replication pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Only replication pairs that are in the <b>Initial Syncing</b> (<c>initial_syncing</c>), <b>Syncing</b> (<c>syncing</c>), <b>One-time Syncing</b> (<c>manual_syncing</c>), or <b>Normal</b> (<c>normal</c>) state can be stopped. When a replication pair is stopped, it enters the Stopped (<c>stopped</c>) state. The secondary disk rolls back to the point in time when the last async replication was complete and drops all the data that is being replicated from the primary disk.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDiskReplicaPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDiskReplicaPairResponse
        /// </returns>
        public async Task<StopDiskReplicaPairResponse> StopDiskReplicaPairWithOptionsAsync(StopDiskReplicaPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaPairId))
            {
                query["ReplicaPairId"] = request.ReplicaPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDiskReplicaPair",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDiskReplicaPairResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a replication pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Only replication pairs that are in the <b>Initial Syncing</b> (<c>initial_syncing</c>), <b>Syncing</b> (<c>syncing</c>), <b>One-time Syncing</b> (<c>manual_syncing</c>), or <b>Normal</b> (<c>normal</c>) state can be stopped. When a replication pair is stopped, it enters the Stopped (<c>stopped</c>) state. The secondary disk rolls back to the point in time when the last async replication was complete and drops all the data that is being replicated from the primary disk.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDiskReplicaPairResponse
        /// </returns>
        public StopDiskReplicaPairResponse StopDiskReplicaPair(StopDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDiskReplicaPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a replication pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>For information about the regions in which async replication is available, see <a href="https://help.aliyun.com/document_detail/314563.html">Overview</a>.</description></item>
        /// <item><description>Only replication pairs that are in the <b>Initial Syncing</b> (<c>initial_syncing</c>), <b>Syncing</b> (<c>syncing</c>), <b>One-time Syncing</b> (<c>manual_syncing</c>), or <b>Normal</b> (<c>normal</c>) state can be stopped. When a replication pair is stopped, it enters the Stopped (<c>stopped</c>) state. The secondary disk rolls back to the point in time when the last async replication was complete and drops all the data that is being replicated from the primary disk.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDiskReplicaPairRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDiskReplicaPairResponse
        /// </returns>
        public async Task<StopDiskReplicaPairResponse> StopDiskReplicaPairAsync(StopDiskReplicaPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDiskReplicaPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags and adds the tags to Elastic Block Storage (EBS) resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you add tags to a resource, Alibaba Cloud checks the number of existing tags of the resource. If the maximum number of tags is reached, an error message is returned. For more information, see the &quot;Tag limits&quot; section in <a href="https://help.aliyun.com/document_detail/25412.html">Limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags and adds the tags to Elastic Block Storage (EBS) resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you add tags to a resource, Alibaba Cloud checks the number of existing tags of the resource. If the maximum number of tags is reached, an error message is returned. For more information, see the &quot;Tag limits&quot; section in <a href="https://help.aliyun.com/document_detail/25412.html">Limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags and adds the tags to Elastic Block Storage (EBS) resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you add tags to a resource, Alibaba Cloud checks the number of existing tags of the resource. If the maximum number of tags is reached, an error message is returned. For more information, see the &quot;Tag limits&quot; section in <a href="https://help.aliyun.com/document_detail/25412.html">Limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags and adds the tags to Elastic Block Storage (EBS) resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you add tags to a resource, Alibaba Cloud checks the number of existing tags of the resource. If the maximum number of tags is reached, an error message is returned. For more information, see the &quot;Tag limits&quot; section in <a href="https://help.aliyun.com/document_detail/25412.html">Limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbind disks from a enterprise-level snapshot policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindEnterpriseSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindEnterpriseSnapshotPolicyResponse
        /// </returns>
        public UnbindEnterpriseSnapshotPolicyResponse UnbindEnterpriseSnapshotPolicyWithOptions(UnbindEnterpriseSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskTargets))
            {
                query["DiskTargets"] = request.DiskTargets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindEnterpriseSnapshotPolicy",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindEnterpriseSnapshotPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbind disks from a enterprise-level snapshot policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindEnterpriseSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindEnterpriseSnapshotPolicyResponse
        /// </returns>
        public async Task<UnbindEnterpriseSnapshotPolicyResponse> UnbindEnterpriseSnapshotPolicyWithOptionsAsync(UnbindEnterpriseSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskTargets))
            {
                query["DiskTargets"] = request.DiskTargets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindEnterpriseSnapshotPolicy",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindEnterpriseSnapshotPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbind disks from a enterprise-level snapshot policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindEnterpriseSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindEnterpriseSnapshotPolicyResponse
        /// </returns>
        public UnbindEnterpriseSnapshotPolicyResponse UnbindEnterpriseSnapshotPolicy(UnbindEnterpriseSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindEnterpriseSnapshotPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbind disks from a enterprise-level snapshot policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindEnterpriseSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindEnterpriseSnapshotPolicyResponse
        /// </returns>
        public async Task<UnbindEnterpriseSnapshotPolicyResponse> UnbindEnterpriseSnapshotPolicyAsync(UnbindEnterpriseSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindEnterpriseSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from specified Elastic Block Storage (EBS) resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can remove up to 20 tags at a time.</para>
        /// <list type="bullet">
        /// <item><description>After a tag is removed from an EBS resource, the tag is automatically deleted if the tag is not added to any instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from specified Elastic Block Storage (EBS) resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can remove up to 20 tags at a time.</para>
        /// <list type="bullet">
        /// <item><description>After a tag is removed from an EBS resource, the tag is automatically deleted if the tag is not added to any instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from specified Elastic Block Storage (EBS) resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can remove up to 20 tags at a time.</para>
        /// <list type="bullet">
        /// <item><description>After a tag is removed from an EBS resource, the tag is automatically deleted if the tag is not added to any instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from specified Elastic Block Storage (EBS) resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can remove up to 20 tags at a time.</para>
        /// <list type="bullet">
        /// <item><description>After a tag is removed from an EBS resource, the tag is automatically deleted if the tag is not added to any instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Search for a enterprise-level snapshot policy.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateEnterpriseSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEnterpriseSnapshotPolicyResponse
        /// </returns>
        public UpdateEnterpriseSnapshotPolicyResponse UpdateEnterpriseSnapshotPolicyWithOptions(UpdateEnterpriseSnapshotPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEnterpriseSnapshotPolicyShrinkRequest request = new UpdateEnterpriseSnapshotPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CrossRegionCopyInfo))
            {
                request.CrossRegionCopyInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CrossRegionCopyInfo, "CrossRegionCopyInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RetainRule))
            {
                request.RetainRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RetainRule, "RetainRule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Schedule))
            {
                request.ScheduleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Schedule, "Schedule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SpecialRetainRules))
            {
                request.SpecialRetainRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SpecialRetainRules, "SpecialRetainRules", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StorageRule))
            {
                request.StorageRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StorageRule, "StorageRule", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossRegionCopyInfoShrink))
            {
                query["CrossRegionCopyInfo"] = request.CrossRegionCopyInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                query["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainRuleShrink))
            {
                query["RetainRule"] = request.RetainRuleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleShrink))
            {
                query["Schedule"] = request.ScheduleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecialRetainRulesShrink))
            {
                query["SpecialRetainRules"] = request.SpecialRetainRulesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageRuleShrink))
            {
                query["StorageRule"] = request.StorageRuleShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnterpriseSnapshotPolicy",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEnterpriseSnapshotPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Search for a enterprise-level snapshot policy.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateEnterpriseSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEnterpriseSnapshotPolicyResponse
        /// </returns>
        public async Task<UpdateEnterpriseSnapshotPolicyResponse> UpdateEnterpriseSnapshotPolicyWithOptionsAsync(UpdateEnterpriseSnapshotPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEnterpriseSnapshotPolicyShrinkRequest request = new UpdateEnterpriseSnapshotPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CrossRegionCopyInfo))
            {
                request.CrossRegionCopyInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CrossRegionCopyInfo, "CrossRegionCopyInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RetainRule))
            {
                request.RetainRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RetainRule, "RetainRule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Schedule))
            {
                request.ScheduleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Schedule, "Schedule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SpecialRetainRules))
            {
                request.SpecialRetainRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SpecialRetainRules, "SpecialRetainRules", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StorageRule))
            {
                request.StorageRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StorageRule, "StorageRule", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossRegionCopyInfoShrink))
            {
                query["CrossRegionCopyInfo"] = request.CrossRegionCopyInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                query["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainRuleShrink))
            {
                query["RetainRule"] = request.RetainRuleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleShrink))
            {
                query["Schedule"] = request.ScheduleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecialRetainRulesShrink))
            {
                query["SpecialRetainRules"] = request.SpecialRetainRulesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageRuleShrink))
            {
                query["StorageRule"] = request.StorageRuleShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnterpriseSnapshotPolicy",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEnterpriseSnapshotPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Search for a enterprise-level snapshot policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEnterpriseSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEnterpriseSnapshotPolicyResponse
        /// </returns>
        public UpdateEnterpriseSnapshotPolicyResponse UpdateEnterpriseSnapshotPolicy(UpdateEnterpriseSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEnterpriseSnapshotPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Search for a enterprise-level snapshot policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEnterpriseSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEnterpriseSnapshotPolicyResponse
        /// </returns>
        public async Task<UpdateEnterpriseSnapshotPolicyResponse> UpdateEnterpriseSnapshotPolicyAsync(UpdateEnterpriseSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEnterpriseSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新解决方案实例属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSolutionInstanceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSolutionInstanceAttributeResponse
        /// </returns>
        public UpdateSolutionInstanceAttributeResponse UpdateSolutionInstanceAttributeWithOptions(UpdateSolutionInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionInstanceId))
            {
                query["SolutionInstanceId"] = request.SolutionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSolutionInstanceAttribute",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSolutionInstanceAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新解决方案实例属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSolutionInstanceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSolutionInstanceAttributeResponse
        /// </returns>
        public async Task<UpdateSolutionInstanceAttributeResponse> UpdateSolutionInstanceAttributeWithOptionsAsync(UpdateSolutionInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionInstanceId))
            {
                query["SolutionInstanceId"] = request.SolutionInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSolutionInstanceAttribute",
                Version = "2021-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSolutionInstanceAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新解决方案实例属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSolutionInstanceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSolutionInstanceAttributeResponse
        /// </returns>
        public UpdateSolutionInstanceAttributeResponse UpdateSolutionInstanceAttribute(UpdateSolutionInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSolutionInstanceAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新解决方案实例属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSolutionInstanceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSolutionInstanceAttributeResponse
        /// </returns>
        public async Task<UpdateSolutionInstanceAttributeResponse> UpdateSolutionInstanceAttributeAsync(UpdateSolutionInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSolutionInstanceAttributeWithOptionsAsync(request, runtime);
        }

    }
}
