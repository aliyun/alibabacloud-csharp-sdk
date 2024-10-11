// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.DBFS20200418.Models;

namespace AlibabaCloud.SDK.DBFS20200418
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "dbfs.aliyuncs.com"},
                {"cn-beijing-finance-1", "dbfs.aliyuncs.com"},
                {"cn-beijing-finance-pop", "dbfs.aliyuncs.com"},
                {"cn-beijing-gov-1", "dbfs.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "dbfs.aliyuncs.com"},
                {"cn-edge-1", "dbfs.aliyuncs.com"},
                {"cn-fujian", "dbfs.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "dbfs.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "dbfs.aliyuncs.com"},
                {"cn-hangzhou-finance", "dbfs.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "dbfs.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "dbfs.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "dbfs.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "dbfs.aliyuncs.com"},
                {"cn-hangzhou-test-306", "dbfs.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "dbfs.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "dbfs.aliyuncs.com"},
                {"cn-north-2-gov-1", "dbfs.aliyuncs.com"},
                {"cn-qingdao-nebula", "dbfs.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "dbfs.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "dbfs.aliyuncs.com"},
                {"cn-shanghai-finance-1", "dbfs.aliyuncs.com"},
                {"cn-shanghai-inner", "dbfs.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "dbfs.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "dbfs.aliyuncs.com"},
                {"cn-shenzhen-inner", "dbfs.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "dbfs.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "dbfs.aliyuncs.com"},
                {"cn-wuhan", "dbfs.aliyuncs.com"},
                {"cn-wulanchabu", "dbfs.aliyuncs.com"},
                {"cn-yushanfang", "dbfs.aliyuncs.com"},
                {"cn-zhangbei", "dbfs.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "dbfs.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "dbfs.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "dbfs.aliyuncs.com"},
                {"eu-west-1-oxs", "dbfs.aliyuncs.com"},
                {"rus-west-1-pop", "dbfs.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("dbfs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <param name="request">
        /// AddTagsBatchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTagsBatchResponse
        /// </returns>
        public AddTagsBatchResponse AddTagsBatchWithOptions(AddTagsBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbfsList))
            {
                query["DbfsList"] = request.DbfsList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTagsBatch",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTagsBatchResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AddTagsBatchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTagsBatchResponse
        /// </returns>
        public async Task<AddTagsBatchResponse> AddTagsBatchWithOptionsAsync(AddTagsBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbfsList))
            {
                query["DbfsList"] = request.DbfsList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTagsBatch",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTagsBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AddTagsBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTagsBatchResponse
        /// </returns>
        public AddTagsBatchResponse AddTagsBatch(AddTagsBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTagsBatchWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AddTagsBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTagsBatchResponse
        /// </returns>
        public async Task<AddTagsBatchResponse> AddTagsBatchAsync(AddTagsBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTagsBatchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ApplyAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyAutoSnapshotPolicyResponse
        /// </returns>
        public ApplyAutoSnapshotPolicyResponse ApplyAutoSnapshotPolicyWithOptions(ApplyAutoSnapshotPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyAutoSnapshotPolicyShrinkRequest request = new ApplyAutoSnapshotPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DbfsIds))
            {
                request.DbfsIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DbfsIds, "DbfsIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbfsIdsShrink))
            {
                query["DbfsIds"] = request.DbfsIdsShrink;
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
                Action = "ApplyAutoSnapshotPolicy",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyAutoSnapshotPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ApplyAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyAutoSnapshotPolicyResponse
        /// </returns>
        public async Task<ApplyAutoSnapshotPolicyResponse> ApplyAutoSnapshotPolicyWithOptionsAsync(ApplyAutoSnapshotPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyAutoSnapshotPolicyShrinkRequest request = new ApplyAutoSnapshotPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DbfsIds))
            {
                request.DbfsIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DbfsIds, "DbfsIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbfsIdsShrink))
            {
                query["DbfsIds"] = request.DbfsIdsShrink;
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
                Action = "ApplyAutoSnapshotPolicy",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyAutoSnapshotPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyAutoSnapshotPolicyResponse
        /// </returns>
        public ApplyAutoSnapshotPolicyResponse ApplyAutoSnapshotPolicy(ApplyAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyAutoSnapshotPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyAutoSnapshotPolicyResponse
        /// </returns>
        public async Task<ApplyAutoSnapshotPolicyResponse> ApplyAutoSnapshotPolicyAsync(ApplyAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AttachDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachDbfsResponse
        /// </returns>
        public AttachDbfsResponse AttachDbfsWithOptions(AttachDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachMode))
            {
                query["AttachMode"] = request.AttachMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachPoint))
            {
                query["AttachPoint"] = request.AttachPoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ECSInstanceId))
            {
                query["ECSInstanceId"] = request.ECSInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerUrl))
            {
                query["ServerUrl"] = request.ServerUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachDbfsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AttachDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachDbfsResponse
        /// </returns>
        public async Task<AttachDbfsResponse> AttachDbfsWithOptionsAsync(AttachDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachMode))
            {
                query["AttachMode"] = request.AttachMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachPoint))
            {
                query["AttachPoint"] = request.AttachPoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ECSInstanceId))
            {
                query["ECSInstanceId"] = request.ECSInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerUrl))
            {
                query["ServerUrl"] = request.ServerUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachDbfsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AttachDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachDbfsResponse
        /// </returns>
        public AttachDbfsResponse AttachDbfs(AttachDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachDbfsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AttachDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachDbfsResponse
        /// </returns>
        public async Task<AttachDbfsResponse> AttachDbfsAsync(AttachDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachDbfsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CancelAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelAutoSnapshotPolicyResponse
        /// </returns>
        public CancelAutoSnapshotPolicyResponse CancelAutoSnapshotPolicyWithOptions(CancelAutoSnapshotPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CancelAutoSnapshotPolicyShrinkRequest request = new CancelAutoSnapshotPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DbfsIds))
            {
                request.DbfsIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DbfsIds, "DbfsIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbfsIdsShrink))
            {
                query["DbfsIds"] = request.DbfsIdsShrink;
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
                Action = "CancelAutoSnapshotPolicy",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAutoSnapshotPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CancelAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelAutoSnapshotPolicyResponse
        /// </returns>
        public async Task<CancelAutoSnapshotPolicyResponse> CancelAutoSnapshotPolicyWithOptionsAsync(CancelAutoSnapshotPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CancelAutoSnapshotPolicyShrinkRequest request = new CancelAutoSnapshotPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DbfsIds))
            {
                request.DbfsIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DbfsIds, "DbfsIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbfsIdsShrink))
            {
                query["DbfsIds"] = request.DbfsIdsShrink;
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
                Action = "CancelAutoSnapshotPolicy",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAutoSnapshotPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelAutoSnapshotPolicyResponse
        /// </returns>
        public CancelAutoSnapshotPolicyResponse CancelAutoSnapshotPolicy(CancelAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelAutoSnapshotPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelAutoSnapshotPolicyResponse
        /// </returns>
        public async Task<CancelAutoSnapshotPolicyResponse> CancelAutoSnapshotPolicyAsync(CancelAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAutoSnapshotPolicyResponse
        /// </returns>
        public CreateAutoSnapshotPolicyResponse CreateAutoSnapshotPolicyWithOptions(CreateAutoSnapshotPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAutoSnapshotPolicyShrinkRequest request = new CreateAutoSnapshotPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RepeatWeekdays))
            {
                request.RepeatWeekdaysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RepeatWeekdays, "RepeatWeekdays", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TimePoints))
            {
                request.TimePointsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TimePoints, "TimePoints", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatWeekdaysShrink))
            {
                query["RepeatWeekdays"] = request.RepeatWeekdaysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePointsShrink))
            {
                query["TimePoints"] = request.TimePointsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAutoSnapshotPolicy",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAutoSnapshotPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAutoSnapshotPolicyResponse
        /// </returns>
        public async Task<CreateAutoSnapshotPolicyResponse> CreateAutoSnapshotPolicyWithOptionsAsync(CreateAutoSnapshotPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAutoSnapshotPolicyShrinkRequest request = new CreateAutoSnapshotPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RepeatWeekdays))
            {
                request.RepeatWeekdaysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RepeatWeekdays, "RepeatWeekdays", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TimePoints))
            {
                request.TimePointsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TimePoints, "TimePoints", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatWeekdaysShrink))
            {
                query["RepeatWeekdays"] = request.RepeatWeekdaysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePointsShrink))
            {
                query["TimePoints"] = request.TimePointsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAutoSnapshotPolicy",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAutoSnapshotPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAutoSnapshotPolicyResponse
        /// </returns>
        public CreateAutoSnapshotPolicyResponse CreateAutoSnapshotPolicy(CreateAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAutoSnapshotPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAutoSnapshotPolicyResponse
        /// </returns>
        public async Task<CreateAutoSnapshotPolicyResponse> CreateAutoSnapshotPolicyAsync(CreateAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDbfsResponse
        /// </returns>
        public CreateDbfsResponse CreateDbfsWithOptions(CreateDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvancedFeatures))
            {
                query["AdvancedFeatures"] = request.AdvancedFeatures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteSnapshot))
            {
                query["DeleteSnapshot"] = request.DeleteSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRaid))
            {
                query["EnableRaid"] = request.EnableRaid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encryption))
            {
                query["Encryption"] = request.Encryption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsName))
            {
                query["FsName"] = request.FsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KMSKeyId))
            {
                query["KMSKeyId"] = request.KMSKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PerformanceLevel))
            {
                query["PerformanceLevel"] = request.PerformanceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RaidStripeUnitNumber))
            {
                query["RaidStripeUnitNumber"] = request.RaidStripeUnitNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SizeG))
            {
                query["SizeG"] = request.SizeG;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedScene))
            {
                query["UsedScene"] = request.UsedScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDbfsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDbfsResponse
        /// </returns>
        public async Task<CreateDbfsResponse> CreateDbfsWithOptionsAsync(CreateDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvancedFeatures))
            {
                query["AdvancedFeatures"] = request.AdvancedFeatures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteSnapshot))
            {
                query["DeleteSnapshot"] = request.DeleteSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRaid))
            {
                query["EnableRaid"] = request.EnableRaid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encryption))
            {
                query["Encryption"] = request.Encryption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsName))
            {
                query["FsName"] = request.FsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KMSKeyId))
            {
                query["KMSKeyId"] = request.KMSKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PerformanceLevel))
            {
                query["PerformanceLevel"] = request.PerformanceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RaidStripeUnitNumber))
            {
                query["RaidStripeUnitNumber"] = request.RaidStripeUnitNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SizeG))
            {
                query["SizeG"] = request.SizeG;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedScene))
            {
                query["UsedScene"] = request.UsedScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDbfsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDbfsResponse
        /// </returns>
        public CreateDbfsResponse CreateDbfs(CreateDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDbfsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDbfsResponse
        /// </returns>
        public async Task<CreateDbfsResponse> CreateDbfsAsync(CreateDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDbfsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateServiceLinkedRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleResponse
        /// </returns>
        public CreateServiceLinkedRoleResponse CreateServiceLinkedRoleWithOptions(CreateServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceLinkedRole",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateServiceLinkedRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleResponse
        /// </returns>
        public async Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleWithOptionsAsync(CreateServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceLinkedRole",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateServiceLinkedRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleResponse
        /// </returns>
        public CreateServiceLinkedRoleResponse CreateServiceLinkedRole(CreateServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceLinkedRoleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateServiceLinkedRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleResponse
        /// </returns>
        public async Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleAsync(CreateServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceLinkedRoleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSnapshotResponse
        /// </returns>
        public CreateSnapshotResponse CreateSnapshotWithOptions(CreateSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotName))
            {
                query["SnapshotName"] = request.SnapshotName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSnapshot",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSnapshotResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSnapshotResponse
        /// </returns>
        public async Task<CreateSnapshotResponse> CreateSnapshotWithOptionsAsync(CreateSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotName))
            {
                query["SnapshotName"] = request.SnapshotName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSnapshot",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSnapshotResponse
        /// </returns>
        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSnapshotWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSnapshotResponse
        /// </returns>
        public async Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSnapshotWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAutoSnapshotPolicyResponse
        /// </returns>
        public DeleteAutoSnapshotPolicyResponse DeleteAutoSnapshotPolicyWithOptions(DeleteAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteAutoSnapshotPolicy",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAutoSnapshotPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAutoSnapshotPolicyResponse
        /// </returns>
        public async Task<DeleteAutoSnapshotPolicyResponse> DeleteAutoSnapshotPolicyWithOptionsAsync(DeleteAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteAutoSnapshotPolicy",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAutoSnapshotPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAutoSnapshotPolicyResponse
        /// </returns>
        public DeleteAutoSnapshotPolicyResponse DeleteAutoSnapshotPolicy(DeleteAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAutoSnapshotPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAutoSnapshotPolicyResponse
        /// </returns>
        public async Task<DeleteAutoSnapshotPolicyResponse> DeleteAutoSnapshotPolicyAsync(DeleteAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDbfsResponse
        /// </returns>
        public DeleteDbfsResponse DeleteDbfsWithOptions(DeleteDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
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
                Action = "DeleteDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDbfsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDbfsResponse
        /// </returns>
        public async Task<DeleteDbfsResponse> DeleteDbfsWithOptionsAsync(DeleteDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
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
                Action = "DeleteDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDbfsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDbfsResponse
        /// </returns>
        public DeleteDbfsResponse DeleteDbfs(DeleteDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDbfsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDbfsResponse
        /// </returns>
        public async Task<DeleteDbfsResponse> DeleteDbfsAsync(DeleteDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDbfsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotResponse
        /// </returns>
        public DeleteSnapshotResponse DeleteSnapshotWithOptions(DeleteSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSnapshot",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSnapshotResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotResponse
        /// </returns>
        public async Task<DeleteSnapshotResponse> DeleteSnapshotWithOptionsAsync(DeleteSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSnapshot",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotResponse
        /// </returns>
        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSnapshotWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotResponse
        /// </returns>
        public async Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSnapshotWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteTagsBatchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTagsBatchResponse
        /// </returns>
        public DeleteTagsBatchResponse DeleteTagsBatchWithOptions(DeleteTagsBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbfsList))
            {
                query["DbfsList"] = request.DbfsList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTagsBatch",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTagsBatchResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteTagsBatchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTagsBatchResponse
        /// </returns>
        public async Task<DeleteTagsBatchResponse> DeleteTagsBatchWithOptionsAsync(DeleteTagsBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbfsList))
            {
                query["DbfsList"] = request.DbfsList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTagsBatch",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTagsBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteTagsBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTagsBatchResponse
        /// </returns>
        public DeleteTagsBatchResponse DeleteTagsBatch(DeleteTagsBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTagsBatchWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteTagsBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTagsBatchResponse
        /// </returns>
        public async Task<DeleteTagsBatchResponse> DeleteTagsBatchAsync(DeleteTagsBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTagsBatchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询DBFS支持的ECS实例类型，根据ECS实例规格返回ECS可挂载的最大DBFS数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDbfsSpecificationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDbfsSpecificationsResponse
        /// </returns>
        public DescribeDbfsSpecificationsResponse DescribeDbfsSpecificationsWithOptions(DescribeDbfsSpecificationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceType))
            {
                query["EcsInstanceType"] = request.EcsInstanceType;
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
                Action = "DescribeDbfsSpecifications",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDbfsSpecificationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询DBFS支持的ECS实例类型，根据ECS实例规格返回ECS可挂载的最大DBFS数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDbfsSpecificationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDbfsSpecificationsResponse
        /// </returns>
        public async Task<DescribeDbfsSpecificationsResponse> DescribeDbfsSpecificationsWithOptionsAsync(DescribeDbfsSpecificationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceType))
            {
                query["EcsInstanceType"] = request.EcsInstanceType;
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
                Action = "DescribeDbfsSpecifications",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDbfsSpecificationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询DBFS支持的ECS实例类型，根据ECS实例规格返回ECS可挂载的最大DBFS数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDbfsSpecificationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDbfsSpecificationsResponse
        /// </returns>
        public DescribeDbfsSpecificationsResponse DescribeDbfsSpecifications(DescribeDbfsSpecificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDbfsSpecificationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询DBFS支持的ECS实例类型，根据ECS实例规格返回ECS可挂载的最大DBFS数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDbfsSpecificationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDbfsSpecificationsResponse
        /// </returns>
        public async Task<DescribeDbfsSpecificationsResponse> DescribeDbfsSpecificationsAsync(DescribeDbfsSpecificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDbfsSpecificationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询DBFS实例规格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceTypesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceTypesResponse
        /// </returns>
        public DescribeInstanceTypesResponse DescribeInstanceTypesWithOptions(DescribeInstanceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeInstanceTypes",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceTypesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询DBFS实例规格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceTypesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceTypesResponse
        /// </returns>
        public async Task<DescribeInstanceTypesResponse> DescribeInstanceTypesWithOptionsAsync(DescribeInstanceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeInstanceTypes",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceTypesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询DBFS实例规格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceTypesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceTypesResponse
        /// </returns>
        public DescribeInstanceTypesResponse DescribeInstanceTypes(DescribeInstanceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceTypesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询DBFS实例规格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceTypesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceTypesResponse
        /// </returns>
        public async Task<DescribeInstanceTypesResponse> DescribeInstanceTypesAsync(DescribeInstanceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceTypesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DetachDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachDbfsResponse
        /// </returns>
        public DetachDbfsResponse DetachDbfsWithOptions(DetachDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ECSInstanceId))
            {
                query["ECSInstanceId"] = request.ECSInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
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
                Action = "DetachDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachDbfsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DetachDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachDbfsResponse
        /// </returns>
        public async Task<DetachDbfsResponse> DetachDbfsWithOptionsAsync(DetachDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ECSInstanceId))
            {
                query["ECSInstanceId"] = request.ECSInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
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
                Action = "DetachDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachDbfsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DetachDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachDbfsResponse
        /// </returns>
        public DetachDbfsResponse DetachDbfs(DetachDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachDbfsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DetachDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachDbfsResponse
        /// </returns>
        public async Task<DetachDbfsResponse> DetachDbfsAsync(DetachDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachDbfsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询某条自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAutoSnapshotPolicyResponse
        /// </returns>
        public GetAutoSnapshotPolicyResponse GetAutoSnapshotPolicyWithOptions(GetAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetAutoSnapshotPolicy",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoSnapshotPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询某条自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAutoSnapshotPolicyResponse
        /// </returns>
        public async Task<GetAutoSnapshotPolicyResponse> GetAutoSnapshotPolicyWithOptionsAsync(GetAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetAutoSnapshotPolicy",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoSnapshotPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询某条自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAutoSnapshotPolicyResponse
        /// </returns>
        public GetAutoSnapshotPolicyResponse GetAutoSnapshotPolicy(GetAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAutoSnapshotPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询某条自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAutoSnapshotPolicyResponse
        /// </returns>
        public async Task<GetAutoSnapshotPolicyResponse> GetAutoSnapshotPolicyAsync(GetAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDbfsResponse
        /// </returns>
        public GetDbfsResponse GetDbfsWithOptions(GetDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
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
                Action = "GetDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDbfsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDbfsResponse
        /// </returns>
        public async Task<GetDbfsResponse> GetDbfsWithOptionsAsync(GetDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
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
                Action = "GetDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDbfsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDbfsResponse
        /// </returns>
        public GetDbfsResponse GetDbfs(GetDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDbfsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDbfsResponse
        /// </returns>
        public async Task<GetDbfsResponse> GetDbfsAsync(GetDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDbfsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetServiceLinkedRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceLinkedRoleResponse
        /// </returns>
        public GetServiceLinkedRoleResponse GetServiceLinkedRoleWithOptions(GetServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetServiceLinkedRole",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceLinkedRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetServiceLinkedRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceLinkedRoleResponse
        /// </returns>
        public async Task<GetServiceLinkedRoleResponse> GetServiceLinkedRoleWithOptionsAsync(GetServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetServiceLinkedRole",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceLinkedRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetServiceLinkedRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceLinkedRoleResponse
        /// </returns>
        public GetServiceLinkedRoleResponse GetServiceLinkedRole(GetServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceLinkedRoleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetServiceLinkedRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceLinkedRoleResponse
        /// </returns>
        public async Task<GetServiceLinkedRoleResponse> GetServiceLinkedRoleAsync(GetServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceLinkedRoleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取快照链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSnapshotLinkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSnapshotLinkResponse
        /// </returns>
        public GetSnapshotLinkResponse GetSnapshotLinkWithOptions(GetSnapshotLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSnapshotLink",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSnapshotLinkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取快照链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSnapshotLinkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSnapshotLinkResponse
        /// </returns>
        public async Task<GetSnapshotLinkResponse> GetSnapshotLinkWithOptionsAsync(GetSnapshotLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSnapshotLink",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSnapshotLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取快照链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSnapshotLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSnapshotLinkResponse
        /// </returns>
        public GetSnapshotLinkResponse GetSnapshotLink(GetSnapshotLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSnapshotLinkWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取快照链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSnapshotLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSnapshotLinkResponse
        /// </returns>
        public async Task<GetSnapshotLinkResponse> GetSnapshotLinkAsync(GetSnapshotLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSnapshotLinkWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAutoSnapshotPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAutoSnapshotPoliciesResponse
        /// </returns>
        public ListAutoSnapshotPoliciesResponse ListAutoSnapshotPoliciesWithOptions(ListAutoSnapshotPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterKey))
            {
                query["FilterKey"] = request.FilterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValue))
            {
                query["FilterValue"] = request.FilterValue;
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
                Action = "ListAutoSnapshotPolicies",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAutoSnapshotPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAutoSnapshotPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAutoSnapshotPoliciesResponse
        /// </returns>
        public async Task<ListAutoSnapshotPoliciesResponse> ListAutoSnapshotPoliciesWithOptionsAsync(ListAutoSnapshotPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterKey))
            {
                query["FilterKey"] = request.FilterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValue))
            {
                query["FilterValue"] = request.FilterValue;
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
                Action = "ListAutoSnapshotPolicies",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAutoSnapshotPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAutoSnapshotPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAutoSnapshotPoliciesResponse
        /// </returns>
        public ListAutoSnapshotPoliciesResponse ListAutoSnapshotPolicies(ListAutoSnapshotPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAutoSnapshotPoliciesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAutoSnapshotPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAutoSnapshotPoliciesResponse
        /// </returns>
        public async Task<ListAutoSnapshotPoliciesResponse> ListAutoSnapshotPoliciesAsync(ListAutoSnapshotPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAutoSnapshotPoliciesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出已设置自动快照策略的DBFS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAutoSnapshotPolicyAppliedDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAutoSnapshotPolicyAppliedDbfsResponse
        /// </returns>
        public ListAutoSnapshotPolicyAppliedDbfsResponse ListAutoSnapshotPolicyAppliedDbfsWithOptions(ListAutoSnapshotPolicyAppliedDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterKey))
            {
                query["FilterKey"] = request.FilterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValue))
            {
                query["FilterValue"] = request.FilterValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListAutoSnapshotPolicyAppliedDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAutoSnapshotPolicyAppliedDbfsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出已设置自动快照策略的DBFS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAutoSnapshotPolicyAppliedDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAutoSnapshotPolicyAppliedDbfsResponse
        /// </returns>
        public async Task<ListAutoSnapshotPolicyAppliedDbfsResponse> ListAutoSnapshotPolicyAppliedDbfsWithOptionsAsync(ListAutoSnapshotPolicyAppliedDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterKey))
            {
                query["FilterKey"] = request.FilterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValue))
            {
                query["FilterValue"] = request.FilterValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListAutoSnapshotPolicyAppliedDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAutoSnapshotPolicyAppliedDbfsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出已设置自动快照策略的DBFS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAutoSnapshotPolicyAppliedDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAutoSnapshotPolicyAppliedDbfsResponse
        /// </returns>
        public ListAutoSnapshotPolicyAppliedDbfsResponse ListAutoSnapshotPolicyAppliedDbfs(ListAutoSnapshotPolicyAppliedDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAutoSnapshotPolicyAppliedDbfsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出已设置自动快照策略的DBFS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAutoSnapshotPolicyAppliedDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAutoSnapshotPolicyAppliedDbfsResponse
        /// </returns>
        public async Task<ListAutoSnapshotPolicyAppliedDbfsResponse> ListAutoSnapshotPolicyAppliedDbfsAsync(ListAutoSnapshotPolicyAppliedDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAutoSnapshotPolicyAppliedDbfsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出未设置自动快照策略的DBFS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAutoSnapshotPolicyUnappliedDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAutoSnapshotPolicyUnappliedDbfsResponse
        /// </returns>
        public ListAutoSnapshotPolicyUnappliedDbfsResponse ListAutoSnapshotPolicyUnappliedDbfsWithOptions(ListAutoSnapshotPolicyUnappliedDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterKey))
            {
                query["FilterKey"] = request.FilterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValue))
            {
                query["FilterValue"] = request.FilterValue;
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
                Action = "ListAutoSnapshotPolicyUnappliedDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAutoSnapshotPolicyUnappliedDbfsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出未设置自动快照策略的DBFS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAutoSnapshotPolicyUnappliedDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAutoSnapshotPolicyUnappliedDbfsResponse
        /// </returns>
        public async Task<ListAutoSnapshotPolicyUnappliedDbfsResponse> ListAutoSnapshotPolicyUnappliedDbfsWithOptionsAsync(ListAutoSnapshotPolicyUnappliedDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterKey))
            {
                query["FilterKey"] = request.FilterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValue))
            {
                query["FilterValue"] = request.FilterValue;
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
                Action = "ListAutoSnapshotPolicyUnappliedDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAutoSnapshotPolicyUnappliedDbfsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出未设置自动快照策略的DBFS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAutoSnapshotPolicyUnappliedDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAutoSnapshotPolicyUnappliedDbfsResponse
        /// </returns>
        public ListAutoSnapshotPolicyUnappliedDbfsResponse ListAutoSnapshotPolicyUnappliedDbfs(ListAutoSnapshotPolicyUnappliedDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAutoSnapshotPolicyUnappliedDbfsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出未设置自动快照策略的DBFS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAutoSnapshotPolicyUnappliedDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAutoSnapshotPolicyUnappliedDbfsResponse
        /// </returns>
        public async Task<ListAutoSnapshotPolicyUnappliedDbfsResponse> ListAutoSnapshotPolicyUnappliedDbfsAsync(ListAutoSnapshotPolicyUnappliedDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAutoSnapshotPolicyUnappliedDbfsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDbfsResponse
        /// </returns>
        public ListDbfsResponse ListDbfsWithOptions(ListDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterKey))
            {
                query["FilterKey"] = request.FilterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValue))
            {
                query["FilterValue"] = request.FilterValue;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKey))
            {
                query["SortKey"] = request.SortKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDbfsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDbfsResponse
        /// </returns>
        public async Task<ListDbfsResponse> ListDbfsWithOptionsAsync(ListDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterKey))
            {
                query["FilterKey"] = request.FilterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValue))
            {
                query["FilterValue"] = request.FilterValue;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKey))
            {
                query["SortKey"] = request.SortKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDbfsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDbfsResponse
        /// </returns>
        public ListDbfsResponse ListDbfs(ListDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDbfsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDbfsResponse
        /// </returns>
        public async Task<ListDbfsResponse> ListDbfsAsync(ListDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDbfsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListDbfsAttachableEcsInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDbfsAttachableEcsInstancesResponse
        /// </returns>
        public ListDbfsAttachableEcsInstancesResponse ListDbfsAttachableEcsInstancesWithOptions(ListDbfsAttachableEcsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterKey))
            {
                query["FilterKey"] = request.FilterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValue))
            {
                query["FilterValue"] = request.FilterValue;
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
                Action = "ListDbfsAttachableEcsInstances",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDbfsAttachableEcsInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListDbfsAttachableEcsInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDbfsAttachableEcsInstancesResponse
        /// </returns>
        public async Task<ListDbfsAttachableEcsInstancesResponse> ListDbfsAttachableEcsInstancesWithOptionsAsync(ListDbfsAttachableEcsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterKey))
            {
                query["FilterKey"] = request.FilterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValue))
            {
                query["FilterValue"] = request.FilterValue;
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
                Action = "ListDbfsAttachableEcsInstances",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDbfsAttachableEcsInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListDbfsAttachableEcsInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDbfsAttachableEcsInstancesResponse
        /// </returns>
        public ListDbfsAttachableEcsInstancesResponse ListDbfsAttachableEcsInstances(ListDbfsAttachableEcsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDbfsAttachableEcsInstancesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListDbfsAttachableEcsInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDbfsAttachableEcsInstancesResponse
        /// </returns>
        public async Task<ListDbfsAttachableEcsInstancesResponse> ListDbfsAttachableEcsInstancesAsync(ListDbfsAttachableEcsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDbfsAttachableEcsInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据库文件系统被挂载的ECS实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDbfsAttachedEcsInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDbfsAttachedEcsInstancesResponse
        /// </returns>
        public ListDbfsAttachedEcsInstancesResponse ListDbfsAttachedEcsInstancesWithOptions(ListDbfsAttachedEcsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
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
                Action = "ListDbfsAttachedEcsInstances",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDbfsAttachedEcsInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据库文件系统被挂载的ECS实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDbfsAttachedEcsInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDbfsAttachedEcsInstancesResponse
        /// </returns>
        public async Task<ListDbfsAttachedEcsInstancesResponse> ListDbfsAttachedEcsInstancesWithOptionsAsync(ListDbfsAttachedEcsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
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
                Action = "ListDbfsAttachedEcsInstances",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDbfsAttachedEcsInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据库文件系统被挂载的ECS实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDbfsAttachedEcsInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDbfsAttachedEcsInstancesResponse
        /// </returns>
        public ListDbfsAttachedEcsInstancesResponse ListDbfsAttachedEcsInstances(ListDbfsAttachedEcsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDbfsAttachedEcsInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据库文件系统被挂载的ECS实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDbfsAttachedEcsInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDbfsAttachedEcsInstancesResponse
        /// </returns>
        public async Task<ListDbfsAttachedEcsInstancesResponse> ListDbfsAttachedEcsInstancesAsync(ListDbfsAttachedEcsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDbfsAttachedEcsInstancesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSnapshotResponse
        /// </returns>
        public ListSnapshotResponse ListSnapshotWithOptions(ListSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterKey))
            {
                query["FilterKey"] = request.FilterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValue))
            {
                query["FilterValue"] = request.FilterValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotIds))
            {
                query["SnapshotIds"] = request.SnapshotIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotName))
            {
                query["SnapshotName"] = request.SnapshotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotType))
            {
                query["SnapshotType"] = request.SnapshotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKey))
            {
                query["SortKey"] = request.SortKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
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
                Action = "ListSnapshot",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSnapshotResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSnapshotResponse
        /// </returns>
        public async Task<ListSnapshotResponse> ListSnapshotWithOptionsAsync(ListSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterKey))
            {
                query["FilterKey"] = request.FilterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValue))
            {
                query["FilterValue"] = request.FilterValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotIds))
            {
                query["SnapshotIds"] = request.SnapshotIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotName))
            {
                query["SnapshotName"] = request.SnapshotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotType))
            {
                query["SnapshotType"] = request.SnapshotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKey))
            {
                query["SortKey"] = request.SortKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
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
                Action = "ListSnapshot",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSnapshotResponse
        /// </returns>
        public ListSnapshotResponse ListSnapshot(ListSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSnapshotWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSnapshotResponse
        /// </returns>
        public async Task<ListSnapshotResponse> ListSnapshotAsync(ListSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSnapshotWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出快照链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSnapshotLinksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSnapshotLinksResponse
        /// </returns>
        public ListSnapshotLinksResponse ListSnapshotLinksWithOptions(ListSnapshotLinksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterKey))
            {
                query["FilterKey"] = request.FilterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValue))
            {
                query["FilterValue"] = request.FilterValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsIds))
            {
                query["FsIds"] = request.FsIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkIds))
            {
                query["LinkIds"] = request.LinkIds;
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
                Action = "ListSnapshotLinks",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSnapshotLinksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出快照链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSnapshotLinksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSnapshotLinksResponse
        /// </returns>
        public async Task<ListSnapshotLinksResponse> ListSnapshotLinksWithOptionsAsync(ListSnapshotLinksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterKey))
            {
                query["FilterKey"] = request.FilterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValue))
            {
                query["FilterValue"] = request.FilterValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsIds))
            {
                query["FsIds"] = request.FsIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkIds))
            {
                query["LinkIds"] = request.LinkIds;
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
                Action = "ListSnapshotLinks",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSnapshotLinksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出快照链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSnapshotLinksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSnapshotLinksResponse
        /// </returns>
        public ListSnapshotLinksResponse ListSnapshotLinks(ListSnapshotLinksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSnapshotLinksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出快照链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSnapshotLinksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSnapshotLinksResponse
        /// </returns>
        public async Task<ListSnapshotLinksResponse> ListSnapshotLinksAsync(ListSnapshotLinksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSnapshotLinksWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListTagKeys",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListTagKeys",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagKeysWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public async Task<ListTagKeysResponse> ListTagKeysAsync(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagKeysWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListTagValuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagValuesResponse
        /// </returns>
        public ListTagValuesResponse ListTagValuesWithOptions(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "ListTagValues",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagValuesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListTagValuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagValuesResponse
        /// </returns>
        public async Task<ListTagValuesResponse> ListTagValuesWithOptionsAsync(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "ListTagValues",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagValuesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListTagValuesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagValuesResponse
        /// </returns>
        public ListTagValuesResponse ListTagValues(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagValuesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListTagValuesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagValuesResponse
        /// </returns>
        public async Task<ListTagValuesResponse> ListTagValuesAsync(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagValuesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAutoSnapshotPolicyResponse
        /// </returns>
        public ModifyAutoSnapshotPolicyResponse ModifyAutoSnapshotPolicyWithOptions(ModifyAutoSnapshotPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAutoSnapshotPolicyShrinkRequest request = new ModifyAutoSnapshotPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RepeatWeekdays))
            {
                request.RepeatWeekdaysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RepeatWeekdays, "RepeatWeekdays", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TimePoints))
            {
                request.TimePointsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TimePoints, "TimePoints", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatWeekdaysShrink))
            {
                query["RepeatWeekdays"] = request.RepeatWeekdaysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePointsShrink))
            {
                query["TimePoints"] = request.TimePointsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAutoSnapshotPolicy",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAutoSnapshotPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyAutoSnapshotPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAutoSnapshotPolicyResponse
        /// </returns>
        public async Task<ModifyAutoSnapshotPolicyResponse> ModifyAutoSnapshotPolicyWithOptionsAsync(ModifyAutoSnapshotPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAutoSnapshotPolicyShrinkRequest request = new ModifyAutoSnapshotPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RepeatWeekdays))
            {
                request.RepeatWeekdaysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RepeatWeekdays, "RepeatWeekdays", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TimePoints))
            {
                request.TimePointsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TimePoints, "TimePoints", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatWeekdaysShrink))
            {
                query["RepeatWeekdays"] = request.RepeatWeekdaysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePointsShrink))
            {
                query["TimePoints"] = request.TimePointsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAutoSnapshotPolicy",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAutoSnapshotPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAutoSnapshotPolicyResponse
        /// </returns>
        public ModifyAutoSnapshotPolicyResponse ModifyAutoSnapshotPolicy(ModifyAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAutoSnapshotPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自动快照策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAutoSnapshotPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAutoSnapshotPolicyResponse
        /// </returns>
        public async Task<ModifyAutoSnapshotPolicyResponse> ModifyAutoSnapshotPolicyAsync(ModifyAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改快照属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySnapshotAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySnapshotAttributeResponse
        /// </returns>
        public ModifySnapshotAttributeResponse ModifySnapshotAttributeWithOptions(ModifySnapshotAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotName))
            {
                query["SnapshotName"] = request.SnapshotName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySnapshotAttribute",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySnapshotAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改快照属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySnapshotAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySnapshotAttributeResponse
        /// </returns>
        public async Task<ModifySnapshotAttributeResponse> ModifySnapshotAttributeWithOptionsAsync(ModifySnapshotAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotName))
            {
                query["SnapshotName"] = request.SnapshotName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySnapshotAttribute",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySnapshotAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改快照属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySnapshotAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySnapshotAttributeResponse
        /// </returns>
        public ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySnapshotAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改快照属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySnapshotAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySnapshotAttributeResponse
        /// </returns>
        public async Task<ModifySnapshotAttributeResponse> ModifySnapshotAttributeAsync(ModifySnapshotAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySnapshotAttributeWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RenameDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenameDbfsResponse
        /// </returns>
        public RenameDbfsResponse RenameDbfsWithOptions(RenameDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsName))
            {
                query["FsName"] = request.FsName;
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
                Action = "RenameDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameDbfsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RenameDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenameDbfsResponse
        /// </returns>
        public async Task<RenameDbfsResponse> RenameDbfsWithOptionsAsync(RenameDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsName))
            {
                query["FsName"] = request.FsName;
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
                Action = "RenameDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameDbfsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RenameDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// RenameDbfsResponse
        /// </returns>
        public RenameDbfsResponse RenameDbfs(RenameDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenameDbfsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RenameDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// RenameDbfsResponse
        /// </returns>
        public async Task<RenameDbfsResponse> RenameDbfsAsync(RenameDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenameDbfsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ResizeDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResizeDbfsResponse
        /// </returns>
        public ResizeDbfsResponse ResizeDbfsWithOptions(ResizeDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSizeG))
            {
                query["NewSizeG"] = request.NewSizeG;
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
                Action = "ResizeDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResizeDbfsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ResizeDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResizeDbfsResponse
        /// </returns>
        public async Task<ResizeDbfsResponse> ResizeDbfsWithOptionsAsync(ResizeDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSizeG))
            {
                query["NewSizeG"] = request.NewSizeG;
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
                Action = "ResizeDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResizeDbfsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ResizeDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// ResizeDbfsResponse
        /// </returns>
        public ResizeDbfsResponse ResizeDbfs(ResizeDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeDbfsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ResizeDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// ResizeDbfsResponse
        /// </returns>
        public async Task<ResizeDbfsResponse> ResizeDbfsAsync(ResizeDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeDbfsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// TagDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagDbfsResponse
        /// </returns>
        public TagDbfsResponse TagDbfsWithOptions(TagDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbfsId))
            {
                query["DbfsId"] = request.DbfsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagDbfsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// TagDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagDbfsResponse
        /// </returns>
        public async Task<TagDbfsResponse> TagDbfsWithOptionsAsync(TagDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbfsId))
            {
                query["DbfsId"] = request.DbfsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagDbfsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// TagDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// TagDbfsResponse
        /// </returns>
        public TagDbfsResponse TagDbfs(TagDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagDbfsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// TagDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// TagDbfsResponse
        /// </returns>
        public async Task<TagDbfsResponse> TagDbfsAsync(TagDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagDbfsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改DBFS实例，包括使用场景、实例规格等。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDbfsResponse
        /// </returns>
        public UpdateDbfsResponse UpdateDbfsWithOptions(UpdateDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvancedFeatures))
            {
                query["AdvancedFeatures"] = request.AdvancedFeatures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedScene))
            {
                query["UsedScene"] = request.UsedScene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDbfsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改DBFS实例，包括使用场景、实例规格等。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDbfsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDbfsResponse
        /// </returns>
        public async Task<UpdateDbfsResponse> UpdateDbfsWithOptionsAsync(UpdateDbfsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvancedFeatures))
            {
                query["AdvancedFeatures"] = request.AdvancedFeatures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FsId))
            {
                query["FsId"] = request.FsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedScene))
            {
                query["UsedScene"] = request.UsedScene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDbfs",
                Version = "2020-04-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDbfsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改DBFS实例，包括使用场景、实例规格等。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDbfsResponse
        /// </returns>
        public UpdateDbfsResponse UpdateDbfs(UpdateDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDbfsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改DBFS实例，包括使用场景、实例规格等。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDbfsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDbfsResponse
        /// </returns>
        public async Task<UpdateDbfsResponse> UpdateDbfsAsync(UpdateDbfsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDbfsWithOptionsAsync(request, runtime);
        }

    }
}
