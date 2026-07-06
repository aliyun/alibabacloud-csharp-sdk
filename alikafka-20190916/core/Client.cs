// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Alikafka20190916.Models;

namespace AlibabaCloud.SDK.Alikafka20190916
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"us-west-1", "alikafka.us-west-1.aliyuncs.com"},
                {"us-east-1", "alikafka.us-east-1.aliyuncs.com"},
                {"na-south-1", "alikafka.na-south-1.aliyuncs.com"},
                {"me-east-1", "alikafka.me-east-1.aliyuncs.com"},
                {"me-central-1", "alikafka.me-central-1.aliyuncs.com"},
                {"eu-west-1", "alikafka.eu-west-1.aliyuncs.com"},
                {"eu-central-1", "alikafka.eu-central-1.aliyuncs.com"},
                {"cn-zhangjiakou", "alikafka.cn-zhangjiakou.aliyuncs.com"},
                {"cn-wulanchabu", "alikafka.cn-wulanchabu.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "alikafka.cn-shenzhen-finance-1.aliyuncs.com"},
                {"cn-shenzhen", "alikafka.cn-shenzhen.aliyuncs.com"},
                {"cn-shanghai-finance-1", "alikafka.cn-shanghai-finance-1.aliyuncs.com"},
                {"cn-shanghai", "alikafka.cn-shanghai.aliyuncs.com"},
                {"cn-qingdao", "alikafka.cn-qingdao.aliyuncs.com"},
                {"cn-huhehaote", "alikafka.cn-huhehaote.aliyuncs.com"},
                {"cn-hongkong", "alikafka.cn-hongkong.aliyuncs.com"},
                {"cn-heyuan", "alikafka.cn-heyuan.aliyuncs.com"},
                {"cn-hangzhou-finance", "alikafka.cn-hangzhou-finance.aliyuncs.com"},
                {"cn-hangzhou", "alikafka.cn-hangzhou.aliyuncs.com"},
                {"cn-guangzhou", "alikafka.cn-guangzhou.aliyuncs.com"},
                {"cn-chengdu", "alikafka.cn-chengdu.aliyuncs.com"},
                {"cn-beijing-finance-1", "alikafka.cn-beijing-finance-1.aliyuncs.com"},
                {"cn-beijing", "alikafka.cn-beijing.aliyuncs.com"},
                {"ap-southeast-7", "alikafka.ap-southeast-7.aliyuncs.com"},
                {"ap-southeast-5", "alikafka.ap-southeast-5.aliyuncs.com"},
                {"ap-southeast-3", "alikafka.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-2", "alikafka.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-1", "alikafka.ap-southeast-1.aliyuncs.com"},
                {"ap-northeast-2", "alikafka.ap-northeast-2.aliyuncs.com"},
                {"ap-northeast-1", "alikafka.ap-northeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("alikafka", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>AddUserDefinedSg</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddUserDefinedSgRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUserDefinedSgResponse
        /// </returns>
        public AddUserDefinedSgResponse AddUserDefinedSgWithOptions(AddUserDefinedSgRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddUserDefinedSgShrinkRequest request = new AddUserDefinedSgShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SgIdList))
            {
                request.SgIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SgIdList, "SgIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SgIdListShrink))
            {
                query["SgIdList"] = request.SgIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserDefinedSg",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserDefinedSgResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AddUserDefinedSg</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddUserDefinedSgRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUserDefinedSgResponse
        /// </returns>
        public async Task<AddUserDefinedSgResponse> AddUserDefinedSgWithOptionsAsync(AddUserDefinedSgRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddUserDefinedSgShrinkRequest request = new AddUserDefinedSgShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SgIdList))
            {
                request.SgIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SgIdList, "SgIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SgIdListShrink))
            {
                query["SgIdList"] = request.SgIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserDefinedSg",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserDefinedSgResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AddUserDefinedSg</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUserDefinedSgRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUserDefinedSgResponse
        /// </returns>
        public AddUserDefinedSgResponse AddUserDefinedSg(AddUserDefinedSgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserDefinedSgWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AddUserDefinedSg</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUserDefinedSgRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUserDefinedSgResponse
        /// </returns>
        public async Task<AddUserDefinedSgResponse> AddUserDefinedSgAsync(AddUserDefinedSgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserDefinedSgWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moves a resource to a different resource group.</para>
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2019-09-16",
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
        /// <para>Moves a resource to a different resource group.</para>
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2019-09-16",
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
        /// <para>Moves a resource to a different resource group.</para>
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
        /// <para>Moves a resource to a different resource group.</para>
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
        /// <para>Converts a pay-as-you-go instance to a subscription instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConvertPostPayOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConvertPostPayOrderResponse
        /// </returns>
        public ConvertPostPayOrderResponse ConvertPostPayOrderWithOptions(ConvertPostPayOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
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
                Action = "ConvertPostPayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertPostPayOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a pay-as-you-go instance to a subscription instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConvertPostPayOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConvertPostPayOrderResponse
        /// </returns>
        public async Task<ConvertPostPayOrderResponse> ConvertPostPayOrderWithOptionsAsync(ConvertPostPayOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
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
                Action = "ConvertPostPayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertPostPayOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a pay-as-you-go instance to a subscription instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConvertPostPayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// ConvertPostPayOrderResponse
        /// </returns>
        public ConvertPostPayOrderResponse ConvertPostPayOrder(ConvertPostPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConvertPostPayOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a pay-as-you-go instance to a subscription instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConvertPostPayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// ConvertPostPayOrderResponse
        /// </returns>
        public async Task<ConvertPostPayOrderResponse> ConvertPostPayOrderAsync(ConvertPostPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConvertPostPayOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation is used to create an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAclResponse
        /// </returns>
        public CreateAclResponse CreateAclWithOptions(CreateAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationType))
            {
                query["AclOperationType"] = request.AclOperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationTypes))
            {
                query["AclOperationTypes"] = request.AclOperationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclPermissionType))
            {
                query["AclPermissionType"] = request.AclPermissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceName))
            {
                query["AclResourceName"] = request.AclResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourcePatternType))
            {
                query["AclResourcePatternType"] = request.AclResourcePatternType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceType))
            {
                query["AclResourceType"] = request.AclResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAcl",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAclResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation is used to create an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAclResponse
        /// </returns>
        public async Task<CreateAclResponse> CreateAclWithOptionsAsync(CreateAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationType))
            {
                query["AclOperationType"] = request.AclOperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationTypes))
            {
                query["AclOperationTypes"] = request.AclOperationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclPermissionType))
            {
                query["AclPermissionType"] = request.AclPermissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceName))
            {
                query["AclResourceName"] = request.AclResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourcePatternType))
            {
                query["AclResourcePatternType"] = request.AclResourcePatternType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceType))
            {
                query["AclResourceType"] = request.AclResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAcl",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation is used to create an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAclRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAclResponse
        /// </returns>
        public CreateAclResponse CreateAcl(CreateAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAclWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation is used to create an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAclRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAclResponse
        /// </returns>
        public async Task<CreateAclResponse> CreateAclAsync(CreateAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAclWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call CreateConsumerGroup to create a consumer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConsumerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConsumerGroupResponse
        /// </returns>
        public CreateConsumerGroupResponse CreateConsumerGroupWithOptions(CreateConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
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
                Action = "CreateConsumerGroup",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConsumerGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call CreateConsumerGroup to create a consumer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConsumerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConsumerGroupResponse
        /// </returns>
        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupWithOptionsAsync(CreateConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
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
                Action = "CreateConsumerGroup",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConsumerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call CreateConsumerGroup to create a consumer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConsumerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConsumerGroupResponse
        /// </returns>
        public CreateConsumerGroupResponse CreateConsumerGroup(CreateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConsumerGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call CreateConsumerGroup to create a consumer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConsumerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConsumerGroupResponse
        /// </returns>
        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupAsync(CreateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConsumerGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation creates a pay-as-you-go instance and returns the instance ID and order ID.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePostPayInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePostPayInstanceResponse
        /// </returns>
        public CreatePostPayInstanceResponse CreatePostPayInstanceWithOptions(CreatePostPayInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePostPayInstanceShrinkRequest request = new CreatePostPayInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ServerlessConfig))
            {
                request.ServerlessConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ServerlessConfig, "ServerlessConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessConfigShrink))
            {
                query["ServerlessConfig"] = request.ServerlessConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
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
                Action = "CreatePostPayInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePostPayInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation creates a pay-as-you-go instance and returns the instance ID and order ID.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePostPayInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePostPayInstanceResponse
        /// </returns>
        public async Task<CreatePostPayInstanceResponse> CreatePostPayInstanceWithOptionsAsync(CreatePostPayInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePostPayInstanceShrinkRequest request = new CreatePostPayInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ServerlessConfig))
            {
                request.ServerlessConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ServerlessConfig, "ServerlessConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessConfigShrink))
            {
                query["ServerlessConfig"] = request.ServerlessConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
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
                Action = "CreatePostPayInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePostPayInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation creates a pay-as-you-go instance and returns the instance ID and order ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePostPayInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePostPayInstanceResponse
        /// </returns>
        public CreatePostPayInstanceResponse CreatePostPayInstance(CreatePostPayInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePostPayInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation creates a pay-as-you-go instance and returns the instance ID and order ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePostPayInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePostPayInstanceResponse
        /// </returns>
        public async Task<CreatePostPayInstanceResponse> CreatePostPayInstanceAsync(CreatePostPayInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePostPayInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pay-as-you-go instances are billed based on actual usage. This billing method is ideal for testing or short-term scenarios with unpredictable traffic peaks. This topic describes how to call the CreatePostPayOrder operation to create a pay-as-you-go instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure you understand the billing methods and pricing of pay-as-you-go instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePostPayOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePostPayOrderResponse
        /// </returns>
        public CreatePostPayOrderResponse CreatePostPayOrderWithOptions(CreatePostPayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePostPayOrderShrinkRequest request = new CreatePostPayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ServerlessConfig))
            {
                request.ServerlessConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ServerlessConfig, "ServerlessConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessConfigShrink))
            {
                query["ServerlessConfig"] = request.ServerlessConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePostPayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePostPayOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pay-as-you-go instances are billed based on actual usage. This billing method is ideal for testing or short-term scenarios with unpredictable traffic peaks. This topic describes how to call the CreatePostPayOrder operation to create a pay-as-you-go instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure you understand the billing methods and pricing of pay-as-you-go instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePostPayOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePostPayOrderResponse
        /// </returns>
        public async Task<CreatePostPayOrderResponse> CreatePostPayOrderWithOptionsAsync(CreatePostPayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePostPayOrderShrinkRequest request = new CreatePostPayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ServerlessConfig))
            {
                request.ServerlessConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ServerlessConfig, "ServerlessConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessConfigShrink))
            {
                query["ServerlessConfig"] = request.ServerlessConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePostPayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePostPayOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pay-as-you-go instances are billed based on actual usage. This billing method is ideal for testing or short-term scenarios with unpredictable traffic peaks. This topic describes how to call the CreatePostPayOrder operation to create a pay-as-you-go instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure you understand the billing methods and pricing of pay-as-you-go instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePostPayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePostPayOrderResponse
        /// </returns>
        public CreatePostPayOrderResponse CreatePostPayOrder(CreatePostPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePostPayOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pay-as-you-go instances are billed based on actual usage. This billing method is ideal for testing or short-term scenarios with unpredictable traffic peaks. This topic describes how to call the CreatePostPayOrder operation to create a pay-as-you-go instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure you understand the billing methods and pricing of pay-as-you-go instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePostPayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePostPayOrderResponse
        /// </returns>
        public async Task<CreatePostPayOrderResponse> CreatePostPayOrderAsync(CreatePostPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePostPayOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a subscription instance and returns the instance ID and order ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before calling this operation, ensure you understand the billing methods and pricing of subscription instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">billing overview</a>.</description></item>
        /// <item><description>By default, a subscription instance created using this operation has a one-month subscription period and is set to auto-renew monthly. To change the renewal period or disable auto-renewal, go to the <a href="https://renew.console.aliyun.com/#/ecs">renewal management</a> page in the Alibaba Cloud Management Console.&lt;props=&quot;china&quot;&gt; For more information, see <a href="https://help.aliyun.com/document_detail/37128.html">Set up auto-renewal</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePrePayInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrePayInstanceResponse
        /// </returns>
        public CreatePrePayInstanceResponse CreatePrePayInstanceWithOptions(CreatePrePayInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePrePayInstanceShrinkRequest request = new CreatePrePayInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfluentConfig))
            {
                request.ConfluentConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfluentConfig, "ConfluentConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfluentConfigShrink))
            {
                query["ConfluentConfig"] = request.ConfluentConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
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
                Action = "CreatePrePayInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrePayInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a subscription instance and returns the instance ID and order ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before calling this operation, ensure you understand the billing methods and pricing of subscription instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">billing overview</a>.</description></item>
        /// <item><description>By default, a subscription instance created using this operation has a one-month subscription period and is set to auto-renew monthly. To change the renewal period or disable auto-renewal, go to the <a href="https://renew.console.aliyun.com/#/ecs">renewal management</a> page in the Alibaba Cloud Management Console.&lt;props=&quot;china&quot;&gt; For more information, see <a href="https://help.aliyun.com/document_detail/37128.html">Set up auto-renewal</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePrePayInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrePayInstanceResponse
        /// </returns>
        public async Task<CreatePrePayInstanceResponse> CreatePrePayInstanceWithOptionsAsync(CreatePrePayInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePrePayInstanceShrinkRequest request = new CreatePrePayInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfluentConfig))
            {
                request.ConfluentConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfluentConfig, "ConfluentConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfluentConfigShrink))
            {
                query["ConfluentConfig"] = request.ConfluentConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
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
                Action = "CreatePrePayInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrePayInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a subscription instance and returns the instance ID and order ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before calling this operation, ensure you understand the billing methods and pricing of subscription instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">billing overview</a>.</description></item>
        /// <item><description>By default, a subscription instance created using this operation has a one-month subscription period and is set to auto-renew monthly. To change the renewal period or disable auto-renewal, go to the <a href="https://renew.console.aliyun.com/#/ecs">renewal management</a> page in the Alibaba Cloud Management Console.&lt;props=&quot;china&quot;&gt; For more information, see <a href="https://help.aliyun.com/document_detail/37128.html">Set up auto-renewal</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePrePayInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrePayInstanceResponse
        /// </returns>
        public CreatePrePayInstanceResponse CreatePrePayInstance(CreatePrePayInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePrePayInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a subscription instance and returns the instance ID and order ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before calling this operation, ensure you understand the billing methods and pricing of subscription instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">billing overview</a>.</description></item>
        /// <item><description>By default, a subscription instance created using this operation has a one-month subscription period and is set to auto-renew monthly. To change the renewal period or disable auto-renewal, go to the <a href="https://renew.console.aliyun.com/#/ecs">renewal management</a> page in the Alibaba Cloud Management Console.&lt;props=&quot;china&quot;&gt; For more information, see <a href="https://help.aliyun.com/document_detail/37128.html">Set up auto-renewal</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePrePayInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrePayInstanceResponse
        /// </returns>
        public async Task<CreatePrePayInstanceResponse> CreatePrePayInstanceAsync(CreatePrePayInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePrePayInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Subscription instances require prepayment for resources and are ideal for long-term, stable business scenarios. This topic describes how to call the CreatePrePayOrder operation to create a subscription instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, ensure that you understand the billing method and pricing of subscription instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// <item><description>By default, when you call this operation, the subscription duration is one month and auto-renewal is enabled with a Unified Auto Renewal Cycle of one month. To modify the Unified Auto Renewal Cycle or disable auto-renewal, go to the <a href="https://renew.console.aliyun.com/#/ecs">Renewal Management</a> page in the Alibaba Cloud Management Console. For more information, see <a href="https://help.aliyun.com/document_detail/37128.html">Configure auto-renewal</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePrePayOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrePayOrderResponse
        /// </returns>
        public CreatePrePayOrderResponse CreatePrePayOrderWithOptions(CreatePrePayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePrePayOrderShrinkRequest request = new CreatePrePayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfluentConfig))
            {
                request.ConfluentConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfluentConfig, "ConfluentConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfluentConfigShrink))
            {
                query["ConfluentConfig"] = request.ConfluentConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePrePayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrePayOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Subscription instances require prepayment for resources and are ideal for long-term, stable business scenarios. This topic describes how to call the CreatePrePayOrder operation to create a subscription instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, ensure that you understand the billing method and pricing of subscription instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// <item><description>By default, when you call this operation, the subscription duration is one month and auto-renewal is enabled with a Unified Auto Renewal Cycle of one month. To modify the Unified Auto Renewal Cycle or disable auto-renewal, go to the <a href="https://renew.console.aliyun.com/#/ecs">Renewal Management</a> page in the Alibaba Cloud Management Console. For more information, see <a href="https://help.aliyun.com/document_detail/37128.html">Configure auto-renewal</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePrePayOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrePayOrderResponse
        /// </returns>
        public async Task<CreatePrePayOrderResponse> CreatePrePayOrderWithOptionsAsync(CreatePrePayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePrePayOrderShrinkRequest request = new CreatePrePayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfluentConfig))
            {
                request.ConfluentConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfluentConfig, "ConfluentConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfluentConfigShrink))
            {
                query["ConfluentConfig"] = request.ConfluentConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePrePayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrePayOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Subscription instances require prepayment for resources and are ideal for long-term, stable business scenarios. This topic describes how to call the CreatePrePayOrder operation to create a subscription instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, ensure that you understand the billing method and pricing of subscription instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// <item><description>By default, when you call this operation, the subscription duration is one month and auto-renewal is enabled with a Unified Auto Renewal Cycle of one month. To modify the Unified Auto Renewal Cycle or disable auto-renewal, go to the <a href="https://renew.console.aliyun.com/#/ecs">Renewal Management</a> page in the Alibaba Cloud Management Console. For more information, see <a href="https://help.aliyun.com/document_detail/37128.html">Configure auto-renewal</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePrePayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrePayOrderResponse
        /// </returns>
        public CreatePrePayOrderResponse CreatePrePayOrder(CreatePrePayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePrePayOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Subscription instances require prepayment for resources and are ideal for long-term, stable business scenarios. This topic describes how to call the CreatePrePayOrder operation to create a subscription instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, ensure that you understand the billing method and pricing of subscription instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// <item><description>By default, when you call this operation, the subscription duration is one month and auto-renewal is enabled with a Unified Auto Renewal Cycle of one month. To modify the Unified Auto Renewal Cycle or disable auto-renewal, go to the <a href="https://renew.console.aliyun.com/#/ecs">Renewal Management</a> page in the Alibaba Cloud Management Console. For more information, see <a href="https://help.aliyun.com/document_detail/37128.html">Configure auto-renewal</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePrePayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrePayOrderResponse
        /// </returns>
        public async Task<CreatePrePayOrderResponse> CreatePrePayOrderAsync(CreatePrePayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePrePayOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation creates a SASL user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSaslUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSaslUserResponse
        /// </returns>
        public CreateSaslUserResponse CreateSaslUserWithOptions(CreateSaslUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mechanism))
            {
                query["Mechanism"] = request.Mechanism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSaslUser",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSaslUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation creates a SASL user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSaslUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSaslUserResponse
        /// </returns>
        public async Task<CreateSaslUserResponse> CreateSaslUserWithOptionsAsync(CreateSaslUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mechanism))
            {
                query["Mechanism"] = request.Mechanism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSaslUser",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSaslUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation creates a SASL user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSaslUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSaslUserResponse
        /// </returns>
        public CreateSaslUserResponse CreateSaslUser(CreateSaslUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSaslUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation creates a SASL user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSaslUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSaslUserResponse
        /// </returns>
        public async Task<CreateSaslUserResponse> CreateSaslUserAsync(CreateSaslUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSaslUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you deploy a serverless instance, you can use this API to create a scheduled scaling rule for the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h6>This operation supports only serverless instances.</h6>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateScheduledScalingRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledScalingRuleResponse
        /// </returns>
        public CreateScheduledScalingRuleResponse CreateScheduledScalingRuleWithOptions(CreateScheduledScalingRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScheduledScalingRuleShrinkRequest request = new CreateScheduledScalingRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WeeklyTypes))
            {
                request.WeeklyTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WeeklyTypes, "WeeklyTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationMinutes))
            {
                query["DurationMinutes"] = request.DurationMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstScheduledTime))
            {
                query["FirstScheduledTime"] = request.FirstScheduledTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedPubFlow))
            {
                query["ReservedPubFlow"] = request.ReservedPubFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedSubFlow))
            {
                query["ReservedSubFlow"] = request.ReservedSubFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleType))
            {
                query["ScheduleType"] = request.ScheduleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["TimeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WeeklyTypesShrink))
            {
                query["WeeklyTypes"] = request.WeeklyTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledScalingRule",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you deploy a serverless instance, you can use this API to create a scheduled scaling rule for the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h6>This operation supports only serverless instances.</h6>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateScheduledScalingRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledScalingRuleResponse
        /// </returns>
        public async Task<CreateScheduledScalingRuleResponse> CreateScheduledScalingRuleWithOptionsAsync(CreateScheduledScalingRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScheduledScalingRuleShrinkRequest request = new CreateScheduledScalingRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WeeklyTypes))
            {
                request.WeeklyTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WeeklyTypes, "WeeklyTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationMinutes))
            {
                query["DurationMinutes"] = request.DurationMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstScheduledTime))
            {
                query["FirstScheduledTime"] = request.FirstScheduledTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedPubFlow))
            {
                query["ReservedPubFlow"] = request.ReservedPubFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedSubFlow))
            {
                query["ReservedSubFlow"] = request.ReservedSubFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleType))
            {
                query["ScheduleType"] = request.ScheduleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["TimeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WeeklyTypesShrink))
            {
                query["WeeklyTypes"] = request.WeeklyTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledScalingRule",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you deploy a serverless instance, you can use this API to create a scheduled scaling rule for the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h6>This operation supports only serverless instances.</h6>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateScheduledScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledScalingRuleResponse
        /// </returns>
        public CreateScheduledScalingRuleResponse CreateScheduledScalingRule(CreateScheduledScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScheduledScalingRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you deploy a serverless instance, you can use this API to create a scheduled scaling rule for the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h6>This operation supports only serverless instances.</h6>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateScheduledScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledScalingRuleResponse
        /// </returns>
        public async Task<CreateScheduledScalingRuleResponse> CreateScheduledScalingRuleAsync(CreateScheduledScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScheduledScalingRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a topic.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Each user can send up to 20 queries per second (QPS).</description></item>
        /// <item><description>The maximum number of topics for an instance depends on its instance type.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTopicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTopicResponse
        /// </returns>
        public CreateTopicResponse CreateTopicWithOptions(CreateTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompactTopic))
            {
                query["CompactTopic"] = request.CompactTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalTopic))
            {
                query["LocalTopic"] = request.LocalTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinInsyncReplicas))
            {
                query["MinInsyncReplicas"] = request.MinInsyncReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationFactor))
            {
                query["ReplicationFactor"] = request.ReplicationFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTopic",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTopicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a topic.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Each user can send up to 20 queries per second (QPS).</description></item>
        /// <item><description>The maximum number of topics for an instance depends on its instance type.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTopicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTopicResponse
        /// </returns>
        public async Task<CreateTopicResponse> CreateTopicWithOptionsAsync(CreateTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompactTopic))
            {
                query["CompactTopic"] = request.CompactTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalTopic))
            {
                query["LocalTopic"] = request.LocalTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinInsyncReplicas))
            {
                query["MinInsyncReplicas"] = request.MinInsyncReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationFactor))
            {
                query["ReplicationFactor"] = request.ReplicationFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTopic",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTopicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a topic.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Each user can send up to 20 queries per second (QPS).</description></item>
        /// <item><description>The maximum number of topics for an instance depends on its instance type.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTopicRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTopicResponse
        /// </returns>
        public CreateTopicResponse CreateTopic(CreateTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTopicWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a topic.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Each user can send up to 20 queries per second (QPS).</description></item>
        /// <item><description>The maximum number of topics for an instance depends on its instance type.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTopicRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTopicResponse
        /// </returns>
        public async Task<CreateTopicResponse> CreateTopicAsync(CreateTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTopicWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAclResponse
        /// </returns>
        public DeleteAclResponse DeleteAclWithOptions(DeleteAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationType))
            {
                query["AclOperationType"] = request.AclOperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationTypes))
            {
                query["AclOperationTypes"] = request.AclOperationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclPermissionType))
            {
                query["AclPermissionType"] = request.AclPermissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceName))
            {
                query["AclResourceName"] = request.AclResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourcePatternType))
            {
                query["AclResourcePatternType"] = request.AclResourcePatternType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceType))
            {
                query["AclResourceType"] = request.AclResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAcl",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAclResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAclResponse
        /// </returns>
        public async Task<DeleteAclResponse> DeleteAclWithOptionsAsync(DeleteAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationType))
            {
                query["AclOperationType"] = request.AclOperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationTypes))
            {
                query["AclOperationTypes"] = request.AclOperationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclPermissionType))
            {
                query["AclPermissionType"] = request.AclPermissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceName))
            {
                query["AclResourceName"] = request.AclResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourcePatternType))
            {
                query["AclResourcePatternType"] = request.AclResourcePatternType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceType))
            {
                query["AclResourceType"] = request.AclResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAcl",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAclRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAclResponse
        /// </returns>
        public DeleteAclResponse DeleteAcl(DeleteAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAclWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control list (ACL).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAclRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAclResponse
        /// </returns>
        public async Task<DeleteAclResponse> DeleteAclAsync(DeleteAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAclWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteConsumerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConsumerGroupResponse
        /// </returns>
        public DeleteConsumerGroupResponse DeleteConsumerGroupWithOptions(DeleteConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteConsumerGroup",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConsumerGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteConsumerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConsumerGroupResponse
        /// </returns>
        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupWithOptionsAsync(DeleteConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteConsumerGroup",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConsumerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteConsumerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConsumerGroupResponse
        /// </returns>
        public DeleteConsumerGroupResponse DeleteConsumerGroup(DeleteConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConsumerGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteConsumerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConsumerGroupResponse
        /// </returns>
        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupAsync(DeleteConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConsumerGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The DeleteInstance operation deletes an instance after a subscription instance or a pay-as-you-go instance is released.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The DeleteInstance operation deletes an instance after a subscription instance or a pay-as-you-go instance is released.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The DeleteInstance operation deletes an instance after a subscription instance or a pay-as-you-go instance is released.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The DeleteInstance operation deletes an instance after a subscription instance or a pay-as-you-go instance is released.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the DeleteSaslUser operation to delete a Simple Authentication and Security Layer (SASL) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSaslUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSaslUserResponse
        /// </returns>
        public DeleteSaslUserResponse DeleteSaslUserWithOptions(DeleteSaslUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mechanism))
            {
                query["Mechanism"] = request.Mechanism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSaslUser",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSaslUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the DeleteSaslUser operation to delete a Simple Authentication and Security Layer (SASL) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSaslUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSaslUserResponse
        /// </returns>
        public async Task<DeleteSaslUserResponse> DeleteSaslUserWithOptionsAsync(DeleteSaslUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mechanism))
            {
                query["Mechanism"] = request.Mechanism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSaslUser",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSaslUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the DeleteSaslUser operation to delete a Simple Authentication and Security Layer (SASL) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSaslUserRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSaslUserResponse
        /// </returns>
        public DeleteSaslUserResponse DeleteSaslUser(DeleteSaslUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSaslUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the DeleteSaslUser operation to delete a Simple Authentication and Security Layer (SASL) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSaslUserRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSaslUserResponse
        /// </returns>
        public async Task<DeleteSaslUserResponse> DeleteSaslUserAsync(DeleteSaslUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSaslUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After a Serverless instance is deployed, you can call this API operation to delete its scheduled scaling policy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h6>This operation applies only to Serverless instances.</h6>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteScheduledScalingRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledScalingRuleResponse
        /// </returns>
        public DeleteScheduledScalingRuleResponse DeleteScheduledScalingRuleWithOptions(DeleteScheduledScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScheduledScalingRule",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduledScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After a Serverless instance is deployed, you can call this API operation to delete its scheduled scaling policy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h6>This operation applies only to Serverless instances.</h6>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteScheduledScalingRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledScalingRuleResponse
        /// </returns>
        public async Task<DeleteScheduledScalingRuleResponse> DeleteScheduledScalingRuleWithOptionsAsync(DeleteScheduledScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScheduledScalingRule",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduledScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After a Serverless instance is deployed, you can call this API operation to delete its scheduled scaling policy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h6>This operation applies only to Serverless instances.</h6>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteScheduledScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledScalingRuleResponse
        /// </returns>
        public DeleteScheduledScalingRuleResponse DeleteScheduledScalingRule(DeleteScheduledScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScheduledScalingRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After a Serverless instance is deployed, you can call this API operation to delete its scheduled scaling policy configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h6>This operation applies only to Serverless instances.</h6>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteScheduledScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledScalingRuleResponse
        /// </returns>
        public async Task<DeleteScheduledScalingRuleResponse> DeleteScheduledScalingRuleAsync(DeleteScheduledScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScheduledScalingRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTopicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTopicResponse
        /// </returns>
        public DeleteTopicResponse DeleteTopicWithOptions(DeleteTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTopic",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTopicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTopicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTopicResponse
        /// </returns>
        public async Task<DeleteTopicResponse> DeleteTopicWithOptionsAsync(DeleteTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTopic",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTopicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTopicRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTopicResponse
        /// </returns>
        public DeleteTopicResponse DeleteTopic(DeleteTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTopicWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTopicRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTopicResponse
        /// </returns>
        public async Task<DeleteTopicResponse> DeleteTopicAsync(DeleteTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTopicWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteUserDefinedSg</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteUserDefinedSgRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserDefinedSgResponse
        /// </returns>
        public DeleteUserDefinedSgResponse DeleteUserDefinedSgWithOptions(DeleteUserDefinedSgRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteUserDefinedSgShrinkRequest request = new DeleteUserDefinedSgShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SgIdList))
            {
                request.SgIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SgIdList, "SgIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SgIdListShrink))
            {
                query["SgIdList"] = request.SgIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserDefinedSg",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserDefinedSgResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteUserDefinedSg</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteUserDefinedSgRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserDefinedSgResponse
        /// </returns>
        public async Task<DeleteUserDefinedSgResponse> DeleteUserDefinedSgWithOptionsAsync(DeleteUserDefinedSgRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteUserDefinedSgShrinkRequest request = new DeleteUserDefinedSgShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SgIdList))
            {
                request.SgIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SgIdList, "SgIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SgIdListShrink))
            {
                query["SgIdList"] = request.SgIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserDefinedSg",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserDefinedSgResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteUserDefinedSg</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserDefinedSgRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserDefinedSgResponse
        /// </returns>
        public DeleteUserDefinedSgResponse DeleteUserDefinedSg(DeleteUserDefinedSgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserDefinedSgWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteUserDefinedSg</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserDefinedSgRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserDefinedSgResponse
        /// </returns>
        public async Task<DeleteUserDefinedSgResponse> DeleteUserDefinedSgAsync(DeleteUserDefinedSgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserDefinedSgWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access control list (ACL) resource names.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAclResourceNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAclResourceNameResponse
        /// </returns>
        public DescribeAclResourceNameResponse DescribeAclResourceNameWithOptions(DescribeAclResourceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourcePatternType))
            {
                query["AclResourcePatternType"] = request.AclResourcePatternType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceType))
            {
                query["AclResourceType"] = request.AclResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DescribeAclResourceName",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAclResourceNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access control list (ACL) resource names.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAclResourceNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAclResourceNameResponse
        /// </returns>
        public async Task<DescribeAclResourceNameResponse> DescribeAclResourceNameWithOptionsAsync(DescribeAclResourceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourcePatternType))
            {
                query["AclResourcePatternType"] = request.AclResourcePatternType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceType))
            {
                query["AclResourceType"] = request.AclResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DescribeAclResourceName",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAclResourceNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access control list (ACL) resource names.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAclResourceNameRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAclResourceNameResponse
        /// </returns>
        public DescribeAclResourceNameResponse DescribeAclResourceName(DescribeAclResourceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAclResourceNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access control list (ACL) resource names.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAclResourceNameRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAclResourceNameResponse
        /// </returns>
        public async Task<DescribeAclResourceNameResponse> DescribeAclResourceNameAsync(DescribeAclResourceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAclResourceNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access control lists (ACLs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAclsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAclsResponse
        /// </returns>
        public DescribeAclsResponse DescribeAclsWithOptions(DescribeAclsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationType))
            {
                query["AclOperationType"] = request.AclOperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclPermissionType))
            {
                query["AclPermissionType"] = request.AclPermissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceName))
            {
                query["AclResourceName"] = request.AclResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourcePatternType))
            {
                query["AclResourcePatternType"] = request.AclResourcePatternType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceType))
            {
                query["AclResourceType"] = request.AclResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAcls",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAclsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access control lists (ACLs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAclsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAclsResponse
        /// </returns>
        public async Task<DescribeAclsResponse> DescribeAclsWithOptionsAsync(DescribeAclsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationType))
            {
                query["AclOperationType"] = request.AclOperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclPermissionType))
            {
                query["AclPermissionType"] = request.AclPermissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceName))
            {
                query["AclResourceName"] = request.AclResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourcePatternType))
            {
                query["AclResourcePatternType"] = request.AclResourcePatternType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceType))
            {
                query["AclResourceType"] = request.AclResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAcls",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAclsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access control lists (ACLs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAclsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAclsResponse
        /// </returns>
        public DescribeAclsResponse DescribeAcls(DescribeAclsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAclsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access control lists (ACLs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAclsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAclsResponse
        /// </returns>
        public async Task<DescribeAclsResponse> DescribeAclsAsync(DescribeAclsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAclsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call DescribeSaslUsers to query SASL users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSaslUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSaslUsersResponse
        /// </returns>
        public DescribeSaslUsersResponse DescribeSaslUsersWithOptions(DescribeSaslUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DescribeSaslUsers",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSaslUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call DescribeSaslUsers to query SASL users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSaslUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSaslUsersResponse
        /// </returns>
        public async Task<DescribeSaslUsersResponse> DescribeSaslUsersWithOptionsAsync(DescribeSaslUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DescribeSaslUsers",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSaslUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call DescribeSaslUsers to query SASL users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSaslUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSaslUsersResponse
        /// </returns>
        public DescribeSaslUsersResponse DescribeSaslUsers(DescribeSaslUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSaslUsersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call DescribeSaslUsers to query SASL users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSaslUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSaslUsersResponse
        /// </returns>
        public async Task<DescribeSaslUsersResponse> DescribeSaslUsersAsync(DescribeSaslUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSaslUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>降配后付费实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DowngradePostPayOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DowngradePostPayOrderResponse
        /// </returns>
        public DowngradePostPayOrderResponse DowngradePostPayOrderWithOptions(DowngradePostPayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DowngradePostPayOrderShrinkRequest request = new DowngradePostPayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ServerlessConfig))
            {
                request.ServerlessConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ServerlessConfig, "ServerlessConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipModel))
            {
                query["EipModel"] = request.EipModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessConfigShrink))
            {
                query["ServerlessConfig"] = request.ServerlessConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DowngradePostPayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DowngradePostPayOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>降配后付费实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DowngradePostPayOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DowngradePostPayOrderResponse
        /// </returns>
        public async Task<DowngradePostPayOrderResponse> DowngradePostPayOrderWithOptionsAsync(DowngradePostPayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DowngradePostPayOrderShrinkRequest request = new DowngradePostPayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ServerlessConfig))
            {
                request.ServerlessConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ServerlessConfig, "ServerlessConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipModel))
            {
                query["EipModel"] = request.EipModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessConfigShrink))
            {
                query["ServerlessConfig"] = request.ServerlessConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DowngradePostPayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DowngradePostPayOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>降配后付费实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DowngradePostPayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// DowngradePostPayOrderResponse
        /// </returns>
        public DowngradePostPayOrderResponse DowngradePostPayOrder(DowngradePostPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DowngradePostPayOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>降配后付费实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DowngradePostPayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// DowngradePostPayOrderResponse
        /// </returns>
        public async Task<DowngradePostPayOrderResponse> DowngradePostPayOrderAsync(DowngradePostPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DowngradePostPayOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>降配预付费实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DowngradePrePayOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DowngradePrePayOrderResponse
        /// </returns>
        public DowngradePrePayOrderResponse DowngradePrePayOrderWithOptions(DowngradePrePayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DowngradePrePayOrderShrinkRequest request = new DowngradePrePayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfluentConfig))
            {
                request.ConfluentConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfluentConfig, "ConfluentConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfluentConfigShrink))
            {
                query["ConfluentConfig"] = request.ConfluentConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipModel))
            {
                query["EipModel"] = request.EipModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DowngradePrePayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DowngradePrePayOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>降配预付费实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DowngradePrePayOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DowngradePrePayOrderResponse
        /// </returns>
        public async Task<DowngradePrePayOrderResponse> DowngradePrePayOrderWithOptionsAsync(DowngradePrePayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DowngradePrePayOrderShrinkRequest request = new DowngradePrePayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfluentConfig))
            {
                request.ConfluentConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfluentConfig, "ConfluentConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfluentConfigShrink))
            {
                query["ConfluentConfig"] = request.ConfluentConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipModel))
            {
                query["EipModel"] = request.EipModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DowngradePrePayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DowngradePrePayOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>降配预付费实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DowngradePrePayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// DowngradePrePayOrderResponse
        /// </returns>
        public DowngradePrePayOrderResponse DowngradePrePayOrder(DowngradePrePayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DowngradePrePayOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>降配预付费实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DowngradePrePayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// DowngradePrePayOrderResponse
        /// </returns>
        public async Task<DowngradePrePayOrderResponse> DowngradePrePayOrderAsync(DowngradePrePayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DowngradePrePayOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to call EnableAutoGroupCreation to enable or disable the free use of Groups.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, only reserved instances support this API.
        /// Serverless instances are not supported at this time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableAutoGroupCreationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableAutoGroupCreationResponse
        /// </returns>
        public EnableAutoGroupCreationResponse EnableAutoGroupCreationWithOptions(EnableAutoGroupCreationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "EnableAutoGroupCreation",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAutoGroupCreationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to call EnableAutoGroupCreation to enable or disable the free use of Groups.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, only reserved instances support this API.
        /// Serverless instances are not supported at this time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableAutoGroupCreationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableAutoGroupCreationResponse
        /// </returns>
        public async Task<EnableAutoGroupCreationResponse> EnableAutoGroupCreationWithOptionsAsync(EnableAutoGroupCreationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "EnableAutoGroupCreation",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAutoGroupCreationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to call EnableAutoGroupCreation to enable or disable the free use of Groups.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, only reserved instances support this API.
        /// Serverless instances are not supported at this time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableAutoGroupCreationRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableAutoGroupCreationResponse
        /// </returns>
        public EnableAutoGroupCreationResponse EnableAutoGroupCreation(EnableAutoGroupCreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableAutoGroupCreationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to call EnableAutoGroupCreation to enable or disable the free use of Groups.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, only reserved instances support this API.
        /// Serverless instances are not supported at this time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableAutoGroupCreationRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableAutoGroupCreationResponse
        /// </returns>
        public async Task<EnableAutoGroupCreationResponse> EnableAutoGroupCreationAsync(EnableAutoGroupCreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableAutoGroupCreationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to call the EnableAutoTopicCreation operation to enable or disable automatic topic creation and modify the default number of partitions for automatically created topics.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableAutoTopicCreationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableAutoTopicCreationResponse
        /// </returns>
        public EnableAutoTopicCreationResponse EnableAutoTopicCreationWithOptions(EnableAutoTopicCreationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operate))
            {
                query["Operate"] = request.Operate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdatePartition))
            {
                query["UpdatePartition"] = request.UpdatePartition;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableAutoTopicCreation",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAutoTopicCreationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to call the EnableAutoTopicCreation operation to enable or disable automatic topic creation and modify the default number of partitions for automatically created topics.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableAutoTopicCreationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableAutoTopicCreationResponse
        /// </returns>
        public async Task<EnableAutoTopicCreationResponse> EnableAutoTopicCreationWithOptionsAsync(EnableAutoTopicCreationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operate))
            {
                query["Operate"] = request.Operate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdatePartition))
            {
                query["UpdatePartition"] = request.UpdatePartition;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableAutoTopicCreation",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAutoTopicCreationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to call the EnableAutoTopicCreation operation to enable or disable automatic topic creation and modify the default number of partitions for automatically created topics.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableAutoTopicCreationRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableAutoTopicCreationResponse
        /// </returns>
        public EnableAutoTopicCreationResponse EnableAutoTopicCreation(EnableAutoTopicCreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableAutoTopicCreationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to call the EnableAutoTopicCreation operation to enable or disable automatic topic creation and modify the default number of partitions for automatically created topics.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableAutoTopicCreationRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableAutoTopicCreationResponse
        /// </returns>
        public async Task<EnableAutoTopicCreationResponse> EnableAutoTopicCreationAsync(EnableAutoTopicCreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableAutoTopicCreationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>故障演练</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FailoverTestRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FailoverTestResponse
        /// </returns>
        public FailoverTestResponse FailoverTestWithOptions(FailoverTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configs))
            {
                query["Configs"] = request.Configs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteTime))
            {
                query["ExecuteTime"] = request.ExecuteTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "FailoverTest",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FailoverTestResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>故障演练</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FailoverTestRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FailoverTestResponse
        /// </returns>
        public async Task<FailoverTestResponse> FailoverTestWithOptionsAsync(FailoverTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configs))
            {
                query["Configs"] = request.Configs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteTime))
            {
                query["ExecuteTime"] = request.ExecuteTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "FailoverTest",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FailoverTestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>故障演练</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FailoverTestRequest
        /// </param>
        /// 
        /// <returns>
        /// FailoverTestResponse
        /// </returns>
        public FailoverTestResponse FailoverTest(FailoverTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FailoverTestWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>故障演练</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FailoverTestRequest
        /// </param>
        /// 
        /// <returns>
        /// FailoverTestResponse
        /// </returns>
        public async Task<FailoverTestResponse> FailoverTestAsync(FailoverTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FailoverTestWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IDs of all instances in the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllInstanceIdListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllInstanceIdListResponse
        /// </returns>
        public GetAllInstanceIdListResponse GetAllInstanceIdListWithOptions(GetAllInstanceIdListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAllInstanceIdList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllInstanceIdListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IDs of all instances in the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllInstanceIdListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllInstanceIdListResponse
        /// </returns>
        public async Task<GetAllInstanceIdListResponse> GetAllInstanceIdListWithOptionsAsync(GetAllInstanceIdListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAllInstanceIdList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllInstanceIdListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IDs of all instances in the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllInstanceIdListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAllInstanceIdListResponse
        /// </returns>
        public GetAllInstanceIdListResponse GetAllInstanceIdList(GetAllInstanceIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAllInstanceIdListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IDs of all instances in the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllInstanceIdListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAllInstanceIdListResponse
        /// </returns>
        public async Task<GetAllInstanceIdListResponse> GetAllInstanceIdListAsync(GetAllInstanceIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAllInstanceIdListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The GetAllowedIpList operation retrieves the IP address allowlist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllowedIpListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllowedIpListResponse
        /// </returns>
        public GetAllowedIpListResponse GetAllowedIpListWithOptions(GetAllowedIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetAllowedIpList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllowedIpListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The GetAllowedIpList operation retrieves the IP address allowlist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllowedIpListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllowedIpListResponse
        /// </returns>
        public async Task<GetAllowedIpListResponse> GetAllowedIpListWithOptionsAsync(GetAllowedIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetAllowedIpList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllowedIpListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The GetAllowedIpList operation retrieves the IP address allowlist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllowedIpListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAllowedIpListResponse
        /// </returns>
        public GetAllowedIpListResponse GetAllowedIpList(GetAllowedIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAllowedIpListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The GetAllowedIpList operation retrieves the IP address allowlist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllowedIpListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAllowedIpListResponse
        /// </returns>
        public async Task<GetAllowedIpListResponse> GetAllowedIpListAsync(GetAllowedIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAllowedIpListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After a Serverless instance is deployed, you can call this API operation to query the auto scaling configuration of the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h6><b>This operation applies only to Serverless instances.</b></h6>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutoScalingConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAutoScalingConfigurationResponse
        /// </returns>
        public GetAutoScalingConfigurationResponse GetAutoScalingConfigurationWithOptions(GetAutoScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetAutoScalingConfiguration",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoScalingConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After a Serverless instance is deployed, you can call this API operation to query the auto scaling configuration of the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h6><b>This operation applies only to Serverless instances.</b></h6>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutoScalingConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAutoScalingConfigurationResponse
        /// </returns>
        public async Task<GetAutoScalingConfigurationResponse> GetAutoScalingConfigurationWithOptionsAsync(GetAutoScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetAutoScalingConfiguration",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoScalingConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After a Serverless instance is deployed, you can call this API operation to query the auto scaling configuration of the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h6><b>This operation applies only to Serverless instances.</b></h6>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutoScalingConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAutoScalingConfigurationResponse
        /// </returns>
        public GetAutoScalingConfigurationResponse GetAutoScalingConfiguration(GetAutoScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAutoScalingConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After a Serverless instance is deployed, you can call this API operation to query the auto scaling configuration of the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h6><b>This operation applies only to Serverless instances.</b></h6>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutoScalingConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAutoScalingConfigurationResponse
        /// </returns>
        public async Task<GetAutoScalingConfigurationResponse> GetAutoScalingConfigurationAsync(GetAutoScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAutoScalingConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of consumer groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConsumerListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConsumerListResponse
        /// </returns>
        public GetConsumerListResponse GetConsumerListWithOptions(GetConsumerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetConsumerList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of consumer groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConsumerListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConsumerListResponse
        /// </returns>
        public async Task<GetConsumerListResponse> GetConsumerListWithOptionsAsync(GetConsumerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetConsumerList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of consumer groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConsumerListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConsumerListResponse
        /// </returns>
        public GetConsumerListResponse GetConsumerList(GetConsumerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConsumerListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of consumer groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConsumerListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConsumerListResponse
        /// </returns>
        public async Task<GetConsumerListResponse> GetConsumerListAsync(GetConsumerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConsumerListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the consumption status of a consumer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConsumerProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConsumerProgressResponse
        /// </returns>
        public GetConsumerProgressResponse GetConsumerProgressWithOptions(GetConsumerProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideLastTimestamp))
            {
                query["HideLastTimestamp"] = request.HideLastTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetConsumerProgress",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerProgressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the consumption status of a consumer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConsumerProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConsumerProgressResponse
        /// </returns>
        public async Task<GetConsumerProgressResponse> GetConsumerProgressWithOptionsAsync(GetConsumerProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideLastTimestamp))
            {
                query["HideLastTimestamp"] = request.HideLastTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetConsumerProgress",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerProgressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the consumption status of a consumer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConsumerProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConsumerProgressResponse
        /// </returns>
        public GetConsumerProgressResponse GetConsumerProgress(GetConsumerProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConsumerProgressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the consumption status of a consumer group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConsumerProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConsumerProgressResponse
        /// </returns>
        public async Task<GetConsumerProgressResponse> GetConsumerProgressAsync(GetConsumerProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConsumerProgressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about instances in a specified region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceListResponse
        /// </returns>
        public GetInstanceListResponse GetInstanceListWithOptions(GetInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Series))
            {
                query["Series"] = request.Series;
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
                Action = "GetInstanceList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about instances in a specified region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceListResponse
        /// </returns>
        public async Task<GetInstanceListResponse> GetInstanceListWithOptionsAsync(GetInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Series))
            {
                query["Series"] = request.Series;
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
                Action = "GetInstanceList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about instances in a specified region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceListResponse
        /// </returns>
        public GetInstanceListResponse GetInstanceList(GetInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about instances in a specified region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceListResponse
        /// </returns>
        public async Task<GetInstanceListResponse> GetInstanceListAsync(GetInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the IP addresses of Kafka clients.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The IP information is retrieved from the sampling logs of client requests to the server through the Kafka API.</description></item>
        /// <item><description>The count indicates the number of connections from a single IP address using different ports that the server detected within the specified time range.</description></item>
        /// <item><description>If your server is not running the latest minor version, the sampling logs may be inaccurate and provide less precise IP information. We recommend that you upgrade the server to the latest minor version.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetKafkaClientIpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKafkaClientIpResponse
        /// </returns>
        public GetKafkaClientIpResponse GetKafkaClientIpWithOptions(GetKafkaClientIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
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
                Action = "GetKafkaClientIp",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKafkaClientIpResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the IP addresses of Kafka clients.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The IP information is retrieved from the sampling logs of client requests to the server through the Kafka API.</description></item>
        /// <item><description>The count indicates the number of connections from a single IP address using different ports that the server detected within the specified time range.</description></item>
        /// <item><description>If your server is not running the latest minor version, the sampling logs may be inaccurate and provide less precise IP information. We recommend that you upgrade the server to the latest minor version.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetKafkaClientIpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKafkaClientIpResponse
        /// </returns>
        public async Task<GetKafkaClientIpResponse> GetKafkaClientIpWithOptionsAsync(GetKafkaClientIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
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
                Action = "GetKafkaClientIp",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKafkaClientIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the IP addresses of Kafka clients.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The IP information is retrieved from the sampling logs of client requests to the server through the Kafka API.</description></item>
        /// <item><description>The count indicates the number of connections from a single IP address using different ports that the server detected within the specified time range.</description></item>
        /// <item><description>If your server is not running the latest minor version, the sampling logs may be inaccurate and provide less precise IP information. We recommend that you upgrade the server to the latest minor version.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetKafkaClientIpRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKafkaClientIpResponse
        /// </returns>
        public GetKafkaClientIpResponse GetKafkaClientIp(GetKafkaClientIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetKafkaClientIpWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the IP addresses of Kafka clients.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The IP information is retrieved from the sampling logs of client requests to the server through the Kafka API.</description></item>
        /// <item><description>The count indicates the number of connections from a single IP address using different ports that the server detected within the specified time range.</description></item>
        /// <item><description>If your server is not running the latest minor version, the sampling logs may be inaccurate and provide less precise IP information. We recommend that you upgrade the server to the latest minor version.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetKafkaClientIpRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKafkaClientIpResponse
        /// </returns>
        public async Task<GetKafkaClientIpResponse> GetKafkaClientIpAsync(GetKafkaClientIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetKafkaClientIpWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the usage quotas for topics and partitions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaTipRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaTipResponse
        /// </returns>
        public GetQuotaTipResponse GetQuotaTipWithOptions(GetQuotaTipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetQuotaTip",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaTipResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the usage quotas for topics and partitions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaTipRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaTipResponse
        /// </returns>
        public async Task<GetQuotaTipResponse> GetQuotaTipWithOptionsAsync(GetQuotaTipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetQuotaTip",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaTipResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the usage quotas for topics and partitions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaTipRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaTipResponse
        /// </returns>
        public GetQuotaTipResponse GetQuotaTip(GetQuotaTipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQuotaTipWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the usage quotas for topics and partitions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaTipRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaTipResponse
        /// </returns>
        public async Task<GetQuotaTipResponse> GetQuotaTipAsync(GetQuotaTipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQuotaTipWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of threats on an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRiskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRiskListResponse
        /// </returns>
        public GetRiskListResponse GetRiskListWithOptions(GetRiskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartIndex))
            {
                query["StartIndex"] = request.StartIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRiskList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRiskListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of threats on an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRiskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRiskListResponse
        /// </returns>
        public async Task<GetRiskListResponse> GetRiskListWithOptionsAsync(GetRiskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartIndex))
            {
                query["StartIndex"] = request.StartIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRiskList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRiskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of threats on an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRiskListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRiskListResponse
        /// </returns>
        public GetRiskListResponse GetRiskList(GetRiskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRiskListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of threats on an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRiskListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRiskListResponse
        /// </returns>
        public async Task<GetRiskListResponse> GetRiskListAsync(GetRiskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRiskListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about topics.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTopicListResponse
        /// </returns>
        public GetTopicListResponse GetTopicListWithOptions(GetTopicListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about topics.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTopicListResponse
        /// </returns>
        public async Task<GetTopicListResponse> GetTopicListWithOptionsAsync(GetTopicListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about topics.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTopicListResponse
        /// </returns>
        public GetTopicListResponse GetTopicList(GetTopicListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTopicListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about topics.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTopicListResponse
        /// </returns>
        public async Task<GetTopicListResponse> GetTopicListAsync(GetTopicListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTopicListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the message sending and receiving status of a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTopicStatusResponse
        /// </returns>
        public GetTopicStatusResponse GetTopicStatusWithOptions(GetTopicStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicStatus",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the message sending and receiving status of a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTopicStatusResponse
        /// </returns>
        public async Task<GetTopicStatusResponse> GetTopicStatusWithOptionsAsync(GetTopicStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicStatus",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the message sending and receiving status of a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTopicStatusResponse
        /// </returns>
        public GetTopicStatusResponse GetTopicStatus(GetTopicStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTopicStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the message sending and receiving status of a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTopicStatusResponse
        /// </returns>
        public async Task<GetTopicStatusResponse> GetTopicStatusAsync(GetTopicStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTopicStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the subscription status of Groups for a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicSubscribeStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTopicSubscribeStatusResponse
        /// </returns>
        public GetTopicSubscribeStatusResponse GetTopicSubscribeStatusWithOptions(GetTopicSubscribeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicSubscribeStatus",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicSubscribeStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the subscription status of Groups for a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicSubscribeStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTopicSubscribeStatusResponse
        /// </returns>
        public async Task<GetTopicSubscribeStatusResponse> GetTopicSubscribeStatusWithOptionsAsync(GetTopicSubscribeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicSubscribeStatus",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicSubscribeStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the subscription status of Groups for a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicSubscribeStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTopicSubscribeStatusResponse
        /// </returns>
        public GetTopicSubscribeStatusResponse GetTopicSubscribeStatus(GetTopicSubscribeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTopicSubscribeStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the subscription status of Groups for a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicSubscribeStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTopicSubscribeStatusResponse
        /// </returns>
        public async Task<GetTopicSubscribeStatusResponse> GetTopicSubscribeStatusAsync(GetTopicSubscribeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTopicSubscribeStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of rebalancing tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRebalanceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRebalanceInfoResponse
        /// </returns>
        public ListRebalanceInfoResponse ListRebalanceInfoWithOptions(ListRebalanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListRebalanceInfo",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRebalanceInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of rebalancing tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRebalanceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRebalanceInfoResponse
        /// </returns>
        public async Task<ListRebalanceInfoResponse> ListRebalanceInfoWithOptionsAsync(ListRebalanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListRebalanceInfo",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRebalanceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of rebalancing tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRebalanceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRebalanceInfoResponse
        /// </returns>
        public ListRebalanceInfoResponse ListRebalanceInfo(ListRebalanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRebalanceInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of rebalancing tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRebalanceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRebalanceInfoResponse
        /// </returns>
        public async Task<ListRebalanceInfoResponse> ListRebalanceInfoAsync(ListRebalanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRebalanceInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of tags that are attached to resources.</para>
        /// </summary>
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
                Version = "2019-09-16",
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
        /// <para>Queries the list of tags that are attached to resources.</para>
        /// </summary>
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
                Version = "2019-09-16",
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
        /// <para>Queries the list of tags that are attached to resources.</para>
        /// </summary>
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
        /// <para>Queries the list of tags that are attached to resources.</para>
        /// </summary>
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
        /// <para>You can modify the name of an ApsaraMQ for Kafka instance after it is deployed. This topic describes how to call the ModifyInstanceName operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceNameResponse
        /// </returns>
        public ModifyInstanceNameResponse ModifyInstanceNameWithOptions(ModifyInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
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
                Action = "ModifyInstanceName",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can modify the name of an ApsaraMQ for Kafka instance after it is deployed. This topic describes how to call the ModifyInstanceName operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceNameResponse
        /// </returns>
        public async Task<ModifyInstanceNameResponse> ModifyInstanceNameWithOptionsAsync(ModifyInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
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
                Action = "ModifyInstanceName",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can modify the name of an ApsaraMQ for Kafka instance after it is deployed. This topic describes how to call the ModifyInstanceName operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceNameResponse
        /// </returns>
        public ModifyInstanceNameResponse ModifyInstanceName(ModifyInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can modify the name of an ApsaraMQ for Kafka instance after it is deployed. This topic describes how to call the ModifyInstanceName operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceNameResponse
        /// </returns>
        public async Task<ModifyInstanceNameResponse> ModifyInstanceNameAsync(ModifyInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation modifies the number of partitions in a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPartitionNumRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPartitionNumResponse
        /// </returns>
        public ModifyPartitionNumResponse ModifyPartitionNumWithOptions(ModifyPartitionNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddPartitionNum))
            {
                query["AddPartitionNum"] = request.AddPartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPartitionNum",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPartitionNumResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation modifies the number of partitions in a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPartitionNumRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPartitionNumResponse
        /// </returns>
        public async Task<ModifyPartitionNumResponse> ModifyPartitionNumWithOptionsAsync(ModifyPartitionNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddPartitionNum))
            {
                query["AddPartitionNum"] = request.AddPartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPartitionNum",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPartitionNumResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation modifies the number of partitions in a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPartitionNumRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPartitionNumResponse
        /// </returns>
        public ModifyPartitionNumResponse ModifyPartitionNum(ModifyPartitionNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPartitionNumWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation modifies the number of partitions in a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPartitionNumRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPartitionNumResponse
        /// </returns>
        public async Task<ModifyPartitionNumResponse> ModifyPartitionNumAsync(ModifyPartitionNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPartitionNumWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you deploy Serverless instances, you can call this API operation to modify their scheduled scaling policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h6>This operation applies only to Serverless instances.</h6>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyScheduledScalingRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyScheduledScalingRuleResponse
        /// </returns>
        public ModifyScheduledScalingRuleResponse ModifyScheduledScalingRuleWithOptions(ModifyScheduledScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScheduledScalingRule",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScheduledScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you deploy Serverless instances, you can call this API operation to modify their scheduled scaling policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h6>This operation applies only to Serverless instances.</h6>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyScheduledScalingRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyScheduledScalingRuleResponse
        /// </returns>
        public async Task<ModifyScheduledScalingRuleResponse> ModifyScheduledScalingRuleWithOptionsAsync(ModifyScheduledScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScheduledScalingRule",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScheduledScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you deploy Serverless instances, you can call this API operation to modify their scheduled scaling policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h6>This operation applies only to Serverless instances.</h6>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyScheduledScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyScheduledScalingRuleResponse
        /// </returns>
        public ModifyScheduledScalingRuleResponse ModifyScheduledScalingRule(ModifyScheduledScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScheduledScalingRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you deploy Serverless instances, you can call this API operation to modify their scheduled scaling policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h6>This operation applies only to Serverless instances.</h6>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyScheduledScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyScheduledScalingRuleResponse
        /// </returns>
        public async Task<ModifyScheduledScalingRuleResponse> ModifyScheduledScalingRuleAsync(ModifyScheduledScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScheduledScalingRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the remark of a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTopicRemarkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTopicRemarkResponse
        /// </returns>
        public ModifyTopicRemarkResponse ModifyTopicRemarkWithOptions(ModifyTopicRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTopicRemark",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTopicRemarkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the remark of a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTopicRemarkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTopicRemarkResponse
        /// </returns>
        public async Task<ModifyTopicRemarkResponse> ModifyTopicRemarkWithOptionsAsync(ModifyTopicRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTopicRemark",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTopicRemarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the remark of a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTopicRemarkRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTopicRemarkResponse
        /// </returns>
        public ModifyTopicRemarkResponse ModifyTopicRemark(ModifyTopicRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTopicRemarkWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the remark of a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTopicRemarkRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTopicRemarkResponse
        /// </returns>
        public async Task<ModifyTopicRemarkResponse> ModifyTopicRemarkAsync(ModifyTopicRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTopicRemarkWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyUserDefinedSg</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyUserDefinedSgRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyUserDefinedSgResponse
        /// </returns>
        public ModifyUserDefinedSgResponse ModifyUserDefinedSgWithOptions(ModifyUserDefinedSgRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyUserDefinedSgShrinkRequest request = new ModifyUserDefinedSgShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SgIdList))
            {
                request.SgIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SgIdList, "SgIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SgIdListShrink))
            {
                query["SgIdList"] = request.SgIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyUserDefinedSg",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyUserDefinedSgResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyUserDefinedSg</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyUserDefinedSgRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyUserDefinedSgResponse
        /// </returns>
        public async Task<ModifyUserDefinedSgResponse> ModifyUserDefinedSgWithOptionsAsync(ModifyUserDefinedSgRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyUserDefinedSgShrinkRequest request = new ModifyUserDefinedSgShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SgIdList))
            {
                request.SgIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SgIdList, "SgIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SgIdListShrink))
            {
                query["SgIdList"] = request.SgIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyUserDefinedSg",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyUserDefinedSgResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyUserDefinedSg</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyUserDefinedSgRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyUserDefinedSgResponse
        /// </returns>
        public ModifyUserDefinedSgResponse ModifyUserDefinedSg(ModifyUserDefinedSgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUserDefinedSgWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyUserDefinedSg</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyUserDefinedSgRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyUserDefinedSgResponse
        /// </returns>
        public async Task<ModifyUserDefinedSgResponse> ModifyUserDefinedSgAsync(ModifyUserDefinedSgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUserDefinedSgWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation queries messages stored in a topic by message creation time or offset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMessageResponse
        /// </returns>
        public QueryMessageResponse QueryMessageWithOptions(QueryMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMessage",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation queries messages stored in a topic by message creation time or offset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMessageResponse
        /// </returns>
        public async Task<QueryMessageResponse> QueryMessageWithOptionsAsync(QueryMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMessage",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation queries messages stored in a topic by message creation time or offset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMessageResponse
        /// </returns>
        public QueryMessageResponse QueryMessage(QueryMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMessageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation queries messages stored in a topic by message creation time or offset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMessageResponse
        /// </returns>
        public async Task<QueryMessageResponse> QueryMessageAsync(QueryMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMessageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a pay-as-you-go instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot use this operation to release subscription instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public ReleaseInstanceResponse ReleaseInstanceWithOptions(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDeleteInstance))
            {
                query["ForceDeleteInstance"] = request.ForceDeleteInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ReleaseInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a pay-as-you-go instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot use this operation to release subscription instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public async Task<ReleaseInstanceResponse> ReleaseInstanceWithOptionsAsync(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDeleteInstance))
            {
                query["ForceDeleteInstance"] = request.ForceDeleteInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ReleaseInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a pay-as-you-go instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot use this operation to release subscription instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public ReleaseInstanceResponse ReleaseInstance(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a pay-as-you-go instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot use this operation to release subscription instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public async Task<ReleaseInstanceResponse> ReleaseInstanceAsync(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation only when the instance is in the Stopped state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReopenInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReopenInstanceResponse
        /// </returns>
        public ReopenInstanceResponse ReopenInstanceWithOptions(ReopenInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ReopenInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReopenInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation only when the instance is in the Stopped state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReopenInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReopenInstanceResponse
        /// </returns>
        public async Task<ReopenInstanceResponse> ReopenInstanceWithOptionsAsync(ReopenInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ReopenInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReopenInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation only when the instance is in the Stopped state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReopenInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReopenInstanceResponse
        /// </returns>
        public ReopenInstanceResponse ReopenInstance(ReopenInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReopenInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation only when the instance is in the Stopped state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReopenInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReopenInstanceResponse
        /// </returns>
        public async Task<ReopenInstanceResponse> ReopenInstanceAsync(ReopenInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReopenInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You must purchase and deploy an ApsaraMQ for Kafka instance before you can send and receive messages. This topic describes how to deploy an instance by calling the StartInstance operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>The request frequency is limited to 2 queries per second (QPS) for each user.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// StartInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartInstanceResponse
        /// </returns>
        public StartInstanceResponse StartInstanceWithOptions(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossZone))
            {
                query["CrossZone"] = request.CrossZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployModule))
            {
                query["DeployModule"] = request.DeployModule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEipInner))
            {
                query["IsEipInner"] = request.IsEipInner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsForceSelectedZones))
            {
                query["IsForceSelectedZones"] = request.IsForceSelectedZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSetUserAndPassword))
            {
                query["IsSetUserAndPassword"] = request.IsSetUserAndPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KMSKeyId))
            {
                query["KMSKeyId"] = request.KMSKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notifier))
            {
                query["Notifier"] = request.Notifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroup))
            {
                query["SecurityGroup"] = request.SecurityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectedZones))
            {
                query["SelectedZones"] = request.SelectedZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPhoneNum))
            {
                query["UserPhoneNum"] = request.UserPhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
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
                Action = "StartInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You must purchase and deploy an ApsaraMQ for Kafka instance before you can send and receive messages. This topic describes how to deploy an instance by calling the StartInstance operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>The request frequency is limited to 2 queries per second (QPS) for each user.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// StartInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartInstanceResponse
        /// </returns>
        public async Task<StartInstanceResponse> StartInstanceWithOptionsAsync(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossZone))
            {
                query["CrossZone"] = request.CrossZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployModule))
            {
                query["DeployModule"] = request.DeployModule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEipInner))
            {
                query["IsEipInner"] = request.IsEipInner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsForceSelectedZones))
            {
                query["IsForceSelectedZones"] = request.IsForceSelectedZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSetUserAndPassword))
            {
                query["IsSetUserAndPassword"] = request.IsSetUserAndPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KMSKeyId))
            {
                query["KMSKeyId"] = request.KMSKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notifier))
            {
                query["Notifier"] = request.Notifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroup))
            {
                query["SecurityGroup"] = request.SecurityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectedZones))
            {
                query["SelectedZones"] = request.SelectedZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPhoneNum))
            {
                query["UserPhoneNum"] = request.UserPhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
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
                Action = "StartInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You must purchase and deploy an ApsaraMQ for Kafka instance before you can send and receive messages. This topic describes how to deploy an instance by calling the StartInstance operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>The request frequency is limited to 2 queries per second (QPS) for each user.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// StartInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartInstanceResponse
        /// </returns>
        public StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You must purchase and deploy an ApsaraMQ for Kafka instance before you can send and receive messages. This topic describes how to deploy an instance by calling the StartInstance operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>The request frequency is limited to 2 queries per second (QPS) for each user.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// StartInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartInstanceResponse
        /// </returns>
        public async Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stopping subscription instances is not currently supported. To stop a subscription instance, submit a ticket.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopInstanceResponse
        /// </returns>
        public StopInstanceResponse StopInstanceWithOptions(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "StopInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stopping subscription instances is not currently supported. To stop a subscription instance, submit a ticket.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopInstanceResponse
        /// </returns>
        public async Task<StopInstanceResponse> StopInstanceWithOptionsAsync(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "StopInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stopping subscription instances is not currently supported. To stop a subscription instance, submit a ticket.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StopInstanceResponse
        /// </returns>
        public StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stopping subscription instances is not currently supported. To stop a subscription instance, submit a ticket.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StopInstanceResponse
        /// </returns>
        public async Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the TagResources operation to attach tags to resources.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Version = "2019-09-16",
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
        /// <para>You can call the TagResources operation to attach tags to resources.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Version = "2019-09-16",
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
        /// <para>You can call the TagResources operation to attach tags to resources.</para>
        /// </summary>
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
        /// <para>You can call the TagResources operation to attach tags to resources.</para>
        /// </summary>
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
        /// <para>You can call UntagResources to detach tags from resources.</para>
        /// </summary>
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
                Version = "2019-09-16",
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
        /// <para>You can call UntagResources to detach tags from resources.</para>
        /// </summary>
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
                Version = "2019-09-16",
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
        /// <para>You can call UntagResources to detach tags from resources.</para>
        /// </summary>
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
        /// <para>You can call UntagResources to detach tags from resources.</para>
        /// </summary>
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
        /// <para>You can call the UpdateAllowedIp operation to edit the IP whitelist for an ApsaraMQ for Kafka instance. The whitelist specifies the IP addresses and ports that are allowed to access the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAllowedIpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAllowedIpResponse
        /// </returns>
        public UpdateAllowedIpResponse UpdateAllowedIpWithOptions(UpdateAllowedIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedListIp))
            {
                query["AllowedListIp"] = request.AllowedListIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedListType))
            {
                query["AllowedListType"] = request.AllowedListType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortRange))
            {
                query["PortRange"] = request.PortRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateType))
            {
                query["UpdateType"] = request.UpdateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAllowedIp",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAllowedIpResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the UpdateAllowedIp operation to edit the IP whitelist for an ApsaraMQ for Kafka instance. The whitelist specifies the IP addresses and ports that are allowed to access the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAllowedIpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAllowedIpResponse
        /// </returns>
        public async Task<UpdateAllowedIpResponse> UpdateAllowedIpWithOptionsAsync(UpdateAllowedIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedListIp))
            {
                query["AllowedListIp"] = request.AllowedListIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedListType))
            {
                query["AllowedListType"] = request.AllowedListType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortRange))
            {
                query["PortRange"] = request.PortRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateType))
            {
                query["UpdateType"] = request.UpdateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAllowedIp",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAllowedIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the UpdateAllowedIp operation to edit the IP whitelist for an ApsaraMQ for Kafka instance. The whitelist specifies the IP addresses and ports that are allowed to access the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAllowedIpRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAllowedIpResponse
        /// </returns>
        public UpdateAllowedIpResponse UpdateAllowedIp(UpdateAllowedIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAllowedIpWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the UpdateAllowedIp operation to edit the IP whitelist for an ApsaraMQ for Kafka instance. The whitelist specifies the IP addresses and ports that are allowed to access the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAllowedIpRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAllowedIpResponse
        /// </returns>
        public async Task<UpdateAllowedIpResponse> UpdateAllowedIpAsync(UpdateAllowedIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAllowedIpWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The UpdateConsumerOffset operation resets the consumer offset of a consumer group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation resets the consumer offset of a specified consumer group. You can reset the consumer offset by timestamp or by a specific offset value. Using different parameter combinations, you can perform the following tasks:</para>
        /// <list type="bullet">
        /// <item><description>Consume messages from the latest offset by setting the consumer offset to the latest position. This is supported for a single topic or all topics.</description></item>
        /// <item><description>Consume messages from the offset of a specified time point by providing a timestamp. This is supported for a single topic or all topics.</description></item>
        /// <item><description>Reset the consumer offset for a specific partition by providing the target partition ID and consumer offset. This is supported only for a single topic.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateConsumerOffsetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConsumerOffsetResponse
        /// </returns>
        public UpdateConsumerOffsetResponse UpdateConsumerOffsetWithOptions(UpdateConsumerOffsetRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateConsumerOffsetShrinkRequest request = new UpdateConsumerOffsetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Offsets))
            {
                request.OffsetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Offsets, "Offsets", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OffsetsShrink))
            {
                query["Offsets"] = request.OffsetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetType))
            {
                query["ResetType"] = request.ResetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConsumerOffset",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConsumerOffsetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The UpdateConsumerOffset operation resets the consumer offset of a consumer group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation resets the consumer offset of a specified consumer group. You can reset the consumer offset by timestamp or by a specific offset value. Using different parameter combinations, you can perform the following tasks:</para>
        /// <list type="bullet">
        /// <item><description>Consume messages from the latest offset by setting the consumer offset to the latest position. This is supported for a single topic or all topics.</description></item>
        /// <item><description>Consume messages from the offset of a specified time point by providing a timestamp. This is supported for a single topic or all topics.</description></item>
        /// <item><description>Reset the consumer offset for a specific partition by providing the target partition ID and consumer offset. This is supported only for a single topic.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateConsumerOffsetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConsumerOffsetResponse
        /// </returns>
        public async Task<UpdateConsumerOffsetResponse> UpdateConsumerOffsetWithOptionsAsync(UpdateConsumerOffsetRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateConsumerOffsetShrinkRequest request = new UpdateConsumerOffsetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Offsets))
            {
                request.OffsetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Offsets, "Offsets", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OffsetsShrink))
            {
                query["Offsets"] = request.OffsetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetType))
            {
                query["ResetType"] = request.ResetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConsumerOffset",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConsumerOffsetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The UpdateConsumerOffset operation resets the consumer offset of a consumer group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation resets the consumer offset of a specified consumer group. You can reset the consumer offset by timestamp or by a specific offset value. Using different parameter combinations, you can perform the following tasks:</para>
        /// <list type="bullet">
        /// <item><description>Consume messages from the latest offset by setting the consumer offset to the latest position. This is supported for a single topic or all topics.</description></item>
        /// <item><description>Consume messages from the offset of a specified time point by providing a timestamp. This is supported for a single topic or all topics.</description></item>
        /// <item><description>Reset the consumer offset for a specific partition by providing the target partition ID and consumer offset. This is supported only for a single topic.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateConsumerOffsetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConsumerOffsetResponse
        /// </returns>
        public UpdateConsumerOffsetResponse UpdateConsumerOffset(UpdateConsumerOffsetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConsumerOffsetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The UpdateConsumerOffset operation resets the consumer offset of a consumer group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation resets the consumer offset of a specified consumer group. You can reset the consumer offset by timestamp or by a specific offset value. Using different parameter combinations, you can perform the following tasks:</para>
        /// <list type="bullet">
        /// <item><description>Consume messages from the latest offset by setting the consumer offset to the latest position. This is supported for a single topic or all topics.</description></item>
        /// <item><description>Consume messages from the offset of a specified time point by providing a timestamp. This is supported for a single topic or all topics.</description></item>
        /// <item><description>Reset the consumer offset for a specific partition by providing the target partition ID and consumer offset. This is supported only for a single topic.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateConsumerOffsetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConsumerOffsetResponse
        /// </returns>
        public async Task<UpdateConsumerOffsetResponse> UpdateConsumerOffsetAsync(UpdateConsumerOffsetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConsumerOffsetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After an instance is deployed, you can modify configurations such as enabling Access Control List (ACL) and SSL, the message retention period, and the maximum message size. This topic describes how to call the UpdateInstanceConfig operation to modify the configuration of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Permission information</b></h2>
        /// <para>RAM users must obtain authorization before they can call the <b>UpdateInstanceConfig</b> operation. For more information, see <a href="https://help.aliyun.com/document_detail/185815.html">RAM access policies</a>.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>API</th>
        /// <th>Action</th>
        /// <th>Resource</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>UpdateInstanceConfig</td>
        /// <td>alikafka: UpdateInstance</td>
        /// <td>acs:alikafka:<em>:</em>:{instanceId}</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceConfigResponse
        /// </returns>
        public UpdateInstanceConfigResponse UpdateInstanceConfigWithOptions(UpdateInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "UpdateInstanceConfig",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After an instance is deployed, you can modify configurations such as enabling Access Control List (ACL) and SSL, the message retention period, and the maximum message size. This topic describes how to call the UpdateInstanceConfig operation to modify the configuration of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Permission information</b></h2>
        /// <para>RAM users must obtain authorization before they can call the <b>UpdateInstanceConfig</b> operation. For more information, see <a href="https://help.aliyun.com/document_detail/185815.html">RAM access policies</a>.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>API</th>
        /// <th>Action</th>
        /// <th>Resource</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>UpdateInstanceConfig</td>
        /// <td>alikafka: UpdateInstance</td>
        /// <td>acs:alikafka:<em>:</em>:{instanceId}</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceConfigResponse
        /// </returns>
        public async Task<UpdateInstanceConfigResponse> UpdateInstanceConfigWithOptionsAsync(UpdateInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "UpdateInstanceConfig",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After an instance is deployed, you can modify configurations such as enabling Access Control List (ACL) and SSL, the message retention period, and the maximum message size. This topic describes how to call the UpdateInstanceConfig operation to modify the configuration of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Permission information</b></h2>
        /// <para>RAM users must obtain authorization before they can call the <b>UpdateInstanceConfig</b> operation. For more information, see <a href="https://help.aliyun.com/document_detail/185815.html">RAM access policies</a>.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>API</th>
        /// <th>Action</th>
        /// <th>Resource</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>UpdateInstanceConfig</td>
        /// <td>alikafka: UpdateInstance</td>
        /// <td>acs:alikafka:<em>:</em>:{instanceId}</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceConfigResponse
        /// </returns>
        public UpdateInstanceConfigResponse UpdateInstanceConfig(UpdateInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After an instance is deployed, you can modify configurations such as enabling Access Control List (ACL) and SSL, the message retention period, and the maximum message size. This topic describes how to call the UpdateInstanceConfig operation to modify the configuration of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Permission information</b></h2>
        /// <para>RAM users must obtain authorization before they can call the <b>UpdateInstanceConfig</b> operation. For more information, see <a href="https://help.aliyun.com/document_detail/185815.html">RAM access policies</a>.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>API</th>
        /// <th>Action</th>
        /// <th>Resource</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>UpdateInstanceConfig</td>
        /// <td>alikafka: UpdateInstance</td>
        /// <td>acs:alikafka:<em>:</em>:{instanceId}</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceConfigResponse
        /// </returns>
        public async Task<UpdateInstanceConfigResponse> UpdateInstanceConfigAsync(UpdateInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After a topic is created, you can modify its configurations, such as the message retention period and maximum message size. This topic describes how to call this API operation to modify topic configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTopicConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTopicConfigResponse
        /// </returns>
        public UpdateTopicConfigResponse UpdateTopicConfigWithOptions(UpdateTopicConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTopicConfig",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTopicConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After a topic is created, you can modify its configurations, such as the message retention period and maximum message size. This topic describes how to call this API operation to modify topic configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTopicConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTopicConfigResponse
        /// </returns>
        public async Task<UpdateTopicConfigResponse> UpdateTopicConfigWithOptionsAsync(UpdateTopicConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTopicConfig",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTopicConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After a topic is created, you can modify its configurations, such as the message retention period and maximum message size. This topic describes how to call this API operation to modify topic configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTopicConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTopicConfigResponse
        /// </returns>
        public UpdateTopicConfigResponse UpdateTopicConfig(UpdateTopicConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTopicConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After a topic is created, you can modify its configurations, such as the message retention period and maximum message size. This topic describes how to call this API operation to modify topic configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTopicConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTopicConfigResponse
        /// </returns>
        public async Task<UpdateTopicConfigResponse> UpdateTopicConfigAsync(UpdateTopicConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTopicConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the version of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Permission description</b></h2>
        /// <para>RAM users must be authorized before they can call the <b>UpgradeInstanceVersion</b> API. For more information about authorization, see <a href="https://help.aliyun.com/document_detail/185815.html">RAM access policy</a>.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>API</th>
        /// <th>Action</th>
        /// <th>Resource</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>UpgradeInstanceVersion</td>
        /// <td>UpdateInstance</td>
        /// <td>acs:alikafka:<em>:</em>:{instanceId}</td>
        /// </tr>
        /// </tbody></table>
        /// <h2><b>QPS limits</b></h2>
        /// <para>The request frequency is limited to 2 queries per second (QPS) for a single user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeInstanceVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeInstanceVersionResponse
        /// </returns>
        public UpgradeInstanceVersionResponse UpgradeInstanceVersionWithOptions(UpgradeInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersion))
            {
                query["TargetVersion"] = request.TargetVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeInstanceVersion",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeInstanceVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the version of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Permission description</b></h2>
        /// <para>RAM users must be authorized before they can call the <b>UpgradeInstanceVersion</b> API. For more information about authorization, see <a href="https://help.aliyun.com/document_detail/185815.html">RAM access policy</a>.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>API</th>
        /// <th>Action</th>
        /// <th>Resource</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>UpgradeInstanceVersion</td>
        /// <td>UpdateInstance</td>
        /// <td>acs:alikafka:<em>:</em>:{instanceId}</td>
        /// </tr>
        /// </tbody></table>
        /// <h2><b>QPS limits</b></h2>
        /// <para>The request frequency is limited to 2 queries per second (QPS) for a single user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeInstanceVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeInstanceVersionResponse
        /// </returns>
        public async Task<UpgradeInstanceVersionResponse> UpgradeInstanceVersionWithOptionsAsync(UpgradeInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersion))
            {
                query["TargetVersion"] = request.TargetVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeInstanceVersion",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeInstanceVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the version of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Permission description</b></h2>
        /// <para>RAM users must be authorized before they can call the <b>UpgradeInstanceVersion</b> API. For more information about authorization, see <a href="https://help.aliyun.com/document_detail/185815.html">RAM access policy</a>.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>API</th>
        /// <th>Action</th>
        /// <th>Resource</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>UpgradeInstanceVersion</td>
        /// <td>UpdateInstance</td>
        /// <td>acs:alikafka:<em>:</em>:{instanceId}</td>
        /// </tr>
        /// </tbody></table>
        /// <h2><b>QPS limits</b></h2>
        /// <para>The request frequency is limited to 2 queries per second (QPS) for a single user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeInstanceVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeInstanceVersionResponse
        /// </returns>
        public UpgradeInstanceVersionResponse UpgradeInstanceVersion(UpgradeInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeInstanceVersionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the version of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Permission description</b></h2>
        /// <para>RAM users must be authorized before they can call the <b>UpgradeInstanceVersion</b> API. For more information about authorization, see <a href="https://help.aliyun.com/document_detail/185815.html">RAM access policy</a>.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>API</th>
        /// <th>Action</th>
        /// <th>Resource</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>UpgradeInstanceVersion</td>
        /// <td>UpdateInstance</td>
        /// <td>acs:alikafka:<em>:</em>:{instanceId}</td>
        /// </tr>
        /// </tbody></table>
        /// <h2><b>QPS limits</b></h2>
        /// <para>The request frequency is limited to 2 queries per second (QPS) for a single user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeInstanceVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeInstanceVersionResponse
        /// </returns>
        public async Task<UpgradeInstanceVersionResponse> UpgradeInstanceVersionAsync(UpgradeInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeInstanceVersionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades a pay-as-you-go instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the billing method and pricing of pay-as-you-go instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpgradePostPayOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradePostPayOrderResponse
        /// </returns>
        public UpgradePostPayOrderResponse UpgradePostPayOrderWithOptions(UpgradePostPayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpgradePostPayOrderShrinkRequest request = new UpgradePostPayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ServerlessConfig))
            {
                request.ServerlessConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ServerlessConfig, "ServerlessConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipModel))
            {
                query["EipModel"] = request.EipModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessConfigShrink))
            {
                query["ServerlessConfig"] = request.ServerlessConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradePostPayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradePostPayOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades a pay-as-you-go instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the billing method and pricing of pay-as-you-go instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpgradePostPayOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradePostPayOrderResponse
        /// </returns>
        public async Task<UpgradePostPayOrderResponse> UpgradePostPayOrderWithOptionsAsync(UpgradePostPayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpgradePostPayOrderShrinkRequest request = new UpgradePostPayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ServerlessConfig))
            {
                request.ServerlessConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ServerlessConfig, "ServerlessConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipModel))
            {
                query["EipModel"] = request.EipModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessConfigShrink))
            {
                query["ServerlessConfig"] = request.ServerlessConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradePostPayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradePostPayOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades a pay-as-you-go instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the billing method and pricing of pay-as-you-go instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradePostPayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradePostPayOrderResponse
        /// </returns>
        public UpgradePostPayOrderResponse UpgradePostPayOrder(UpgradePostPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradePostPayOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades a pay-as-you-go instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the billing method and pricing of pay-as-you-go instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradePostPayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradePostPayOrderResponse
        /// </returns>
        public async Task<UpgradePostPayOrderResponse> UpgradePostPayOrderAsync(UpgradePostPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradePostPayOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades a subscription instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before calling this operation, ensure you understand the billing method and pricing of subscription instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpgradePrePayOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradePrePayOrderResponse
        /// </returns>
        public UpgradePrePayOrderResponse UpgradePrePayOrderWithOptions(UpgradePrePayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpgradePrePayOrderShrinkRequest request = new UpgradePrePayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfluentConfig))
            {
                request.ConfluentConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfluentConfig, "ConfluentConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfluentConfigShrink))
            {
                query["ConfluentConfig"] = request.ConfluentConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipModel))
            {
                query["EipModel"] = request.EipModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradePrePayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradePrePayOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades a subscription instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before calling this operation, ensure you understand the billing method and pricing of subscription instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpgradePrePayOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradePrePayOrderResponse
        /// </returns>
        public async Task<UpgradePrePayOrderResponse> UpgradePrePayOrderWithOptionsAsync(UpgradePrePayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpgradePrePayOrderShrinkRequest request = new UpgradePrePayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfluentConfig))
            {
                request.ConfluentConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfluentConfig, "ConfluentConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfluentConfigShrink))
            {
                query["ConfluentConfig"] = request.ConfluentConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipModel))
            {
                query["EipModel"] = request.EipModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradePrePayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradePrePayOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades a subscription instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before calling this operation, ensure you understand the billing method and pricing of subscription instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradePrePayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradePrePayOrderResponse
        /// </returns>
        public UpgradePrePayOrderResponse UpgradePrePayOrder(UpgradePrePayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradePrePayOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades a subscription instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before calling this operation, ensure you understand the billing method and pricing of subscription instances. For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradePrePayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradePrePayOrderResponse
        /// </returns>
        public async Task<UpgradePrePayOrderResponse> UpgradePrePayOrderAsync(UpgradePrePayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradePrePayOrderWithOptionsAsync(request, runtime);
        }

    }
}
