// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Tag20180828.Models;

namespace AlibabaCloud.SDK.Tag20180828
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"us-west-1", "tag.us-east-1.aliyuncs.com"},
                {"cn-hangzhou-finance", "tag.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai-finance-1", "tag.aliyuncs.com"},
                {"ap-northeast-2-pop", "tag.aliyuncs.com"},
                {"cn-beijing-finance-pop", "tag.aliyuncs.com"},
                {"cn-beijing-gov-1", "tag.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "tag.cn-hangzhou.aliyuncs.com"},
                {"cn-edge-1", "tag.aliyuncs.com"},
                {"cn-fujian", "tag.cn-hangzhou.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "tag.cn-north-2-gov-1.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "tag.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "tag.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "tag.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "tag.cn-hangzhou.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "tag.cn-hangzhou.aliyuncs.com"},
                {"cn-hangzhou-test-306", "tag.cn-hangzhou.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "tag.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "tag.cn-qingdao-nebula.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "tag.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "tag.aliyuncs.com"},
                {"cn-shanghai-inner", "tag.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "tag.aliyuncs.com"},
                {"cn-shenzhen-inner", "tag.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "tag.cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "tag.aliyuncs.com"},
                {"cn-wuhan", "tag.aliyuncs.com"},
                {"cn-yushanfang", "tag.aliyuncs.com"},
                {"cn-zhangbei", "tag.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "tag.cn-hangzhou.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "tag.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "tag.cn-qingdao-nebula.aliyuncs.com"},
                {"eu-west-1-oxs", "tag.cn-shenzhen-cloudstone.aliyuncs.com"},
                {"rus-west-1-pop", "tag.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("tag", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>绑定策略</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can call this API operation to attach a tag policy to the current logon account. If you use the Tag Policy feature in multi-account mode, you can call this API operation to attach a tag policy to the Root folder, a folder other than the Root folder, or a member in a resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to attach the tag policy with an ID of <c>p-de62a0bf400e4b69****</c> to the current logon account. In this example, the Tag Policy feature in single-account mode is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachPolicyResponse
        /// </returns>
        public AttachPolicyResponse AttachPolicyWithOptions(AttachPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
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
                Action = "AttachPolicy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定策略</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can call this API operation to attach a tag policy to the current logon account. If you use the Tag Policy feature in multi-account mode, you can call this API operation to attach a tag policy to the Root folder, a folder other than the Root folder, or a member in a resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to attach the tag policy with an ID of <c>p-de62a0bf400e4b69****</c> to the current logon account. In this example, the Tag Policy feature in single-account mode is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachPolicyResponse
        /// </returns>
        public async Task<AttachPolicyResponse> AttachPolicyWithOptionsAsync(AttachPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
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
                Action = "AttachPolicy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定策略</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can call this API operation to attach a tag policy to the current logon account. If you use the Tag Policy feature in multi-account mode, you can call this API operation to attach a tag policy to the Root folder, a folder other than the Root folder, or a member in a resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to attach the tag policy with an ID of <c>p-de62a0bf400e4b69****</c> to the current logon account. In this example, the Tag Policy feature in single-account mode is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachPolicyResponse
        /// </returns>
        public AttachPolicyResponse AttachPolicy(AttachPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定策略</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can call this API operation to attach a tag policy to the current logon account. If you use the Tag Policy feature in multi-account mode, you can call this API operation to attach a tag policy to the Root folder, a folder other than the Root folder, or a member in a resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to attach the tag policy with an ID of <c>p-de62a0bf400e4b69****</c> to the current logon account. In this example, the Tag Policy feature in single-account mode is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachPolicyResponse
        /// </returns>
        public async Task<AttachPolicyResponse> AttachPolicyAsync(AttachPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验CreatedBy开通状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckCreatedByEnabledRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckCreatedByEnabledResponse
        /// </returns>
        public CheckCreatedByEnabledResponse CheckCreatedByEnabledWithOptions(CheckCreatedByEnabledRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckCreatedByEnabled",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckCreatedByEnabledResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验CreatedBy开通状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckCreatedByEnabledRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckCreatedByEnabledResponse
        /// </returns>
        public async Task<CheckCreatedByEnabledResponse> CheckCreatedByEnabledWithOptionsAsync(CheckCreatedByEnabledRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckCreatedByEnabled",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckCreatedByEnabledResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验CreatedBy开通状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckCreatedByEnabledRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckCreatedByEnabledResponse
        /// </returns>
        public CheckCreatedByEnabledResponse CheckCreatedByEnabled(CheckCreatedByEnabledRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckCreatedByEnabledWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验CreatedBy开通状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckCreatedByEnabledRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckCreatedByEnabledResponse
        /// </returns>
        public async Task<CheckCreatedByEnabledResponse> CheckCreatedByEnabledAsync(CheckCreatedByEnabledRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckCreatedByEnabledWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭CreatedBy服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseCreatedByRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseCreatedByResponse
        /// </returns>
        public CloseCreatedByResponse CloseCreatedByWithOptions(CloseCreatedByRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseCreatedBy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseCreatedByResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭CreatedBy服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseCreatedByRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseCreatedByResponse
        /// </returns>
        public async Task<CloseCreatedByResponse> CloseCreatedByWithOptionsAsync(CloseCreatedByRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseCreatedBy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseCreatedByResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭CreatedBy服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseCreatedByRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseCreatedByResponse
        /// </returns>
        public CloseCreatedByResponse CloseCreatedBy(CloseCreatedByRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseCreatedByWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭CreatedBy服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseCreatedByRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseCreatedByResponse
        /// </returns>
        public async Task<CloseCreatedByResponse> CloseCreatedByAsync(CloseCreatedByRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseCreatedByWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates associated resource tagging rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAssociatedResourceRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAssociatedResourceRulesResponse
        /// </returns>
        public CreateAssociatedResourceRulesResponse CreateAssociatedResourceRulesWithOptions(CreateAssociatedResourceRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateRulesList))
            {
                query["CreateRulesList"] = request.CreateRulesList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAssociatedResourceRules",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssociatedResourceRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates associated resource tagging rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAssociatedResourceRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAssociatedResourceRulesResponse
        /// </returns>
        public async Task<CreateAssociatedResourceRulesResponse> CreateAssociatedResourceRulesWithOptionsAsync(CreateAssociatedResourceRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateRulesList))
            {
                query["CreateRulesList"] = request.CreateRulesList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAssociatedResourceRules",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssociatedResourceRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates associated resource tagging rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAssociatedResourceRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAssociatedResourceRulesResponse
        /// </returns>
        public CreateAssociatedResourceRulesResponse CreateAssociatedResourceRules(CreateAssociatedResourceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAssociatedResourceRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates associated resource tagging rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAssociatedResourceRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAssociatedResourceRulesResponse
        /// </returns>
        public async Task<CreateAssociatedResourceRulesResponse> CreateAssociatedResourceRulesAsync(CreateAssociatedResourceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAssociatedResourceRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tag policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to call the API operation to create a tag policy named <c>test</c>. In this example, the Tag Policy feature in multi-account mode is used. The tag policy defines that resources to which the <c>CostCenter:Beijing</c> or <c>CostCenter:Shanghai</c> tag is added are compliant and other resources are not compliant.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
        public CreatePolicyResponse CreatePolicyWithOptions(CreatePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyContent))
            {
                query["PolicyContent"] = request.PolicyContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDesc))
            {
                query["PolicyDesc"] = request.PolicyDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tag policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to call the API operation to create a tag policy named <c>test</c>. In this example, the Tag Policy feature in multi-account mode is used. The tag policy defines that resources to which the <c>CostCenter:Beijing</c> or <c>CostCenter:Shanghai</c> tag is added are compliant and other resources are not compliant.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
        public async Task<CreatePolicyResponse> CreatePolicyWithOptionsAsync(CreatePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyContent))
            {
                query["PolicyContent"] = request.PolicyContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDesc))
            {
                query["PolicyDesc"] = request.PolicyDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tag policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to call the API operation to create a tag policy named <c>test</c>. In this example, the Tag Policy feature in multi-account mode is used. The tag policy defines that resources to which the <c>CostCenter:Beijing</c> or <c>CostCenter:Shanghai</c> tag is added are compliant and other resources are not compliant.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
        public CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tag policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to call the API operation to create a tag policy named <c>test</c>. In this example, the Tag Policy feature in multi-account mode is used. The tag policy defines that resources to which the <c>CostCenter:Beijing</c> or <c>CostCenter:Shanghai</c> tag is added are compliant and other resources are not compliant.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
        public async Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates predefined tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>A preset tag is a tag that you create in advance and is available for the resources in all regions. You can create preset tags in the stage of tag planning and add them to specific resources in the stage of tag implementation. When you create a preset tag, you can specify only the tag key. You can specify a tag value in the future.
        /// This topic provides an example on how to call the API operation to create a preset tag whose tag key is <c>Environment</c> to indicate the business environment.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTagsResponse
        /// </returns>
        public CreateTagsResponse CreateTagsWithOptions(CreateTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyValueParamList))
            {
                query["TagKeyValueParamList"] = request.TagKeyValueParamList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTags",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTagsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates predefined tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>A preset tag is a tag that you create in advance and is available for the resources in all regions. You can create preset tags in the stage of tag planning and add them to specific resources in the stage of tag implementation. When you create a preset tag, you can specify only the tag key. You can specify a tag value in the future.
        /// This topic provides an example on how to call the API operation to create a preset tag whose tag key is <c>Environment</c> to indicate the business environment.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTagsResponse
        /// </returns>
        public async Task<CreateTagsResponse> CreateTagsWithOptionsAsync(CreateTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyValueParamList))
            {
                query["TagKeyValueParamList"] = request.TagKeyValueParamList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTags",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates predefined tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>A preset tag is a tag that you create in advance and is available for the resources in all regions. You can create preset tags in the stage of tag planning and add them to specific resources in the stage of tag implementation. When you create a preset tag, you can specify only the tag key. You can specify a tag value in the future.
        /// This topic provides an example on how to call the API operation to create a preset tag whose tag key is <c>Environment</c> to indicate the business environment.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTagsResponse
        /// </returns>
        public CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTagsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates predefined tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>A preset tag is a tag that you create in advance and is available for the resources in all regions. You can create preset tags in the stage of tag planning and add them to specific resources in the stage of tag implementation. When you create a preset tag, you can specify only the tag key. You can specify a tag value in the future.
        /// This topic provides an example on how to call the API operation to create a preset tag whose tag key is <c>Environment</c> to indicate the business environment.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTagsResponse
        /// </returns>
        public async Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTagsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an associated resource tagging rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAssociatedResourceRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAssociatedResourceRuleResponse
        /// </returns>
        public DeleteAssociatedResourceRuleResponse DeleteAssociatedResourceRuleWithOptions(DeleteAssociatedResourceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingName))
            {
                query["SettingName"] = request.SettingName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAssociatedResourceRule",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAssociatedResourceRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an associated resource tagging rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAssociatedResourceRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAssociatedResourceRuleResponse
        /// </returns>
        public async Task<DeleteAssociatedResourceRuleResponse> DeleteAssociatedResourceRuleWithOptionsAsync(DeleteAssociatedResourceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingName))
            {
                query["SettingName"] = request.SettingName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAssociatedResourceRule",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAssociatedResourceRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an associated resource tagging rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAssociatedResourceRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAssociatedResourceRuleResponse
        /// </returns>
        public DeleteAssociatedResourceRuleResponse DeleteAssociatedResourceRule(DeleteAssociatedResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAssociatedResourceRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an associated resource tagging rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAssociatedResourceRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAssociatedResourceRuleResponse
        /// </returns>
        public async Task<DeleteAssociatedResourceRuleResponse> DeleteAssociatedResourceRuleAsync(DeleteAssociatedResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAssociatedResourceRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a tag policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a tag policy, make sure that the tag policy is detached from all objects to which the tag policy is attached. For more information about how to detach a tag policy, see <a href="https://help.aliyun.com/document_detail/429724.html">DetachPolicy</a>.
        /// This topic provides an example on how to call the API operation to delete the tag policy with an ID of <c>p-557cb141331f41c7****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeletePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
        public DeletePolicyResponse DeletePolicyWithOptions(DeletePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a tag policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a tag policy, make sure that the tag policy is detached from all objects to which the tag policy is attached. For more information about how to detach a tag policy, see <a href="https://help.aliyun.com/document_detail/429724.html">DetachPolicy</a>.
        /// This topic provides an example on how to call the API operation to delete the tag policy with an ID of <c>p-557cb141331f41c7****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeletePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
        public async Task<DeletePolicyResponse> DeletePolicyWithOptionsAsync(DeletePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a tag policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a tag policy, make sure that the tag policy is detached from all objects to which the tag policy is attached. For more information about how to detach a tag policy, see <a href="https://help.aliyun.com/document_detail/429724.html">DetachPolicy</a>.
        /// This topic provides an example on how to call the API operation to delete the tag policy with an ID of <c>p-557cb141331f41c7****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeletePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
        public DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a tag policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a tag policy, make sure that the tag policy is detached from all objects to which the tag policy is attached. For more information about how to detach a tag policy, see <a href="https://help.aliyun.com/document_detail/429724.html">DetachPolicy</a>.
        /// This topic provides an example on how to call the API operation to delete the tag policy with an ID of <c>p-557cb141331f41c7****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeletePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
        public async Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a preset tag.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to delete the preset tag whose tag key is <c>Environment</c> and tag value is <c>test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTagResponse
        /// </returns>
        public DeleteTagResponse DeleteTagWithOptions(DeleteTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
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
                Action = "DeleteTag",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a preset tag.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to delete the preset tag whose tag key is <c>Environment</c> and tag value is <c>test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTagResponse
        /// </returns>
        public async Task<DeleteTagResponse> DeleteTagWithOptionsAsync(DeleteTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
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
                Action = "DeleteTag",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a preset tag.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to delete the preset tag whose tag key is <c>Environment</c> and tag value is <c>test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTagRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTagResponse
        /// </returns>
        public DeleteTagResponse DeleteTag(DeleteTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a preset tag.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to delete the preset tag whose tag key is <c>Environment</c> and tag value is <c>test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTagRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTagResponse
        /// </returns>
        public async Task<DeleteTagResponse> DeleteTagAsync(DeleteTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions where the Tag service is available.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2018-08-28",
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
        /// <para>Queries the regions where the Tag service is available.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2018-08-28",
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
        /// <para>Queries the regions where the Tag service is available.</para>
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
        /// <para>Queries the regions where the Tag service is available.</para>
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
        /// <para>Detaches a tag policy from an object.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>If you use the Tag Policy feature in single-account mode, you can call this API operation to detach a tag policy from the current logon account. If you use the Tag Policy feature in multi-account mode, you can call this API operation to detach a tag policy from the Root folder, a folder other than the Root folder, or a member in a resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to detach the tag policy with an ID of <c>p-a3381efe2fe34a75****</c> from the current logon account. In this example, the Tag Policy feature in single-account mode is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachPolicyResponse
        /// </returns>
        public DetachPolicyResponse DetachPolicyWithOptions(DetachPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
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
                Action = "DetachPolicy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detaches a tag policy from an object.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>If you use the Tag Policy feature in single-account mode, you can call this API operation to detach a tag policy from the current logon account. If you use the Tag Policy feature in multi-account mode, you can call this API operation to detach a tag policy from the Root folder, a folder other than the Root folder, or a member in a resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to detach the tag policy with an ID of <c>p-a3381efe2fe34a75****</c> from the current logon account. In this example, the Tag Policy feature in single-account mode is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachPolicyResponse
        /// </returns>
        public async Task<DetachPolicyResponse> DetachPolicyWithOptionsAsync(DetachPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
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
                Action = "DetachPolicy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detaches a tag policy from an object.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>If you use the Tag Policy feature in single-account mode, you can call this API operation to detach a tag policy from the current logon account. If you use the Tag Policy feature in multi-account mode, you can call this API operation to detach a tag policy from the Root folder, a folder other than the Root folder, or a member in a resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to detach the tag policy with an ID of <c>p-a3381efe2fe34a75****</c> from the current logon account. In this example, the Tag Policy feature in single-account mode is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachPolicyResponse
        /// </returns>
        public DetachPolicyResponse DetachPolicy(DetachPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detaches a tag policy from an object.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>If you use the Tag Policy feature in single-account mode, you can call this API operation to detach a tag policy from the current logon account. If you use the Tag Policy feature in multi-account mode, you can call this API operation to detach a tag policy from the Root folder, a folder other than the Root folder, or a member in a resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to detach the tag policy with an ID of <c>p-a3381efe2fe34a75****</c> from the current logon account. In this example, the Tag Policy feature in single-account mode is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachPolicyResponse
        /// </returns>
        public async Task<DetachPolicyResponse> DetachPolicyAsync(DetachPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisablePolicyTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisablePolicyTypeResponse
        /// </returns>
        public DisablePolicyTypeResponse DisablePolicyTypeWithOptions(DisablePolicyTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenType))
            {
                query["OpenType"] = request.OpenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisablePolicyType",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisablePolicyTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisablePolicyTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisablePolicyTypeResponse
        /// </returns>
        public async Task<DisablePolicyTypeResponse> DisablePolicyTypeWithOptionsAsync(DisablePolicyTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenType))
            {
                query["OpenType"] = request.OpenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisablePolicyType",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisablePolicyTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisablePolicyTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// DisablePolicyTypeResponse
        /// </returns>
        public DisablePolicyTypeResponse DisablePolicyType(DisablePolicyTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisablePolicyTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisablePolicyTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// DisablePolicyTypeResponse
        /// </returns>
        public async Task<DisablePolicyTypeResponse> DisablePolicyTypeAsync(DisablePolicyTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisablePolicyTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开通策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnablePolicyTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnablePolicyTypeResponse
        /// </returns>
        public EnablePolicyTypeResponse EnablePolicyTypeWithOptions(EnablePolicyTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenType))
            {
                query["OpenType"] = request.OpenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnablePolicyType",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnablePolicyTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开通策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnablePolicyTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnablePolicyTypeResponse
        /// </returns>
        public async Task<EnablePolicyTypeResponse> EnablePolicyTypeWithOptionsAsync(EnablePolicyTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenType))
            {
                query["OpenType"] = request.OpenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnablePolicyType",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnablePolicyTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开通策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnablePolicyTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// EnablePolicyTypeResponse
        /// </returns>
        public EnablePolicyTypeResponse EnablePolicyType(EnablePolicyTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnablePolicyTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开通策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnablePolicyTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// EnablePolicyTypeResponse
        /// </returns>
        public async Task<EnablePolicyTypeResponse> EnablePolicyTypeAsync(EnablePolicyTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnablePolicyTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成规则检测报告</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can call this API operation to generate a resource non-compliance report for the current logon account. If you use the Tag Policy feature in multi-account mode, you can call this API operation to generate a resource non-compliance report for the Root folder, a folder other than the Root folder, or a member in a resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call this API operation to generate a resource non-compliance report for the current logon account. In this example, the Tag Policy feature in single-account mode is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateConfigRuleReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateConfigRuleReportResponse
        /// </returns>
        public GenerateConfigRuleReportResponse GenerateConfigRuleReportWithOptions(GenerateConfigRuleReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateConfigRuleReport",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateConfigRuleReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成规则检测报告</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can call this API operation to generate a resource non-compliance report for the current logon account. If you use the Tag Policy feature in multi-account mode, you can call this API operation to generate a resource non-compliance report for the Root folder, a folder other than the Root folder, or a member in a resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call this API operation to generate a resource non-compliance report for the current logon account. In this example, the Tag Policy feature in single-account mode is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateConfigRuleReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateConfigRuleReportResponse
        /// </returns>
        public async Task<GenerateConfigRuleReportResponse> GenerateConfigRuleReportWithOptionsAsync(GenerateConfigRuleReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateConfigRuleReport",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateConfigRuleReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成规则检测报告</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can call this API operation to generate a resource non-compliance report for the current logon account. If you use the Tag Policy feature in multi-account mode, you can call this API operation to generate a resource non-compliance report for the Root folder, a folder other than the Root folder, or a member in a resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call this API operation to generate a resource non-compliance report for the current logon account. In this example, the Tag Policy feature in single-account mode is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateConfigRuleReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateConfigRuleReportResponse
        /// </returns>
        public GenerateConfigRuleReportResponse GenerateConfigRuleReport(GenerateConfigRuleReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateConfigRuleReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成规则检测报告</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can call this API operation to generate a resource non-compliance report for the current logon account. If you use the Tag Policy feature in multi-account mode, you can call this API operation to generate a resource non-compliance report for the Root folder, a folder other than the Root folder, or a member in a resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call this API operation to generate a resource non-compliance report for the current logon account. In this example, the Tag Policy feature in single-account mode is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateConfigRuleReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateConfigRuleReportResponse
        /// </returns>
        public async Task<GenerateConfigRuleReportResponse> GenerateConfigRuleReportAsync(GenerateConfigRuleReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateConfigRuleReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information of the resource non-compliance report that is last generated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the basic information of the resource non-compliance report that is last generated for the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the basic information of the resource non-compliance report that is last generated for an object in the resource directory. The object can be the Root folder, a folder other than the Root folder, or a member. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call this API operation to query the basic information of the resource non-compliance report that is last generated for the current logon account. In this example, the Tag Policy feature in single-account mode is used. The response shows that the ID of the report is <c>crp-ao0786618088006c****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConfigRuleReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConfigRuleReportResponse
        /// </returns>
        public GetConfigRuleReportResponse GetConfigRuleReportWithOptions(GetConfigRuleReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigRuleReport",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigRuleReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information of the resource non-compliance report that is last generated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the basic information of the resource non-compliance report that is last generated for the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the basic information of the resource non-compliance report that is last generated for an object in the resource directory. The object can be the Root folder, a folder other than the Root folder, or a member. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call this API operation to query the basic information of the resource non-compliance report that is last generated for the current logon account. In this example, the Tag Policy feature in single-account mode is used. The response shows that the ID of the report is <c>crp-ao0786618088006c****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConfigRuleReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConfigRuleReportResponse
        /// </returns>
        public async Task<GetConfigRuleReportResponse> GetConfigRuleReportWithOptionsAsync(GetConfigRuleReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigRuleReport",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigRuleReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information of the resource non-compliance report that is last generated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the basic information of the resource non-compliance report that is last generated for the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the basic information of the resource non-compliance report that is last generated for an object in the resource directory. The object can be the Root folder, a folder other than the Root folder, or a member. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call this API operation to query the basic information of the resource non-compliance report that is last generated for the current logon account. In this example, the Tag Policy feature in single-account mode is used. The response shows that the ID of the report is <c>crp-ao0786618088006c****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConfigRuleReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConfigRuleReportResponse
        /// </returns>
        public GetConfigRuleReportResponse GetConfigRuleReport(GetConfigRuleReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConfigRuleReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information of the resource non-compliance report that is last generated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the basic information of the resource non-compliance report that is last generated for the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the basic information of the resource non-compliance report that is last generated for an object in the resource directory. The object can be the Root folder, a folder other than the Root folder, or a member. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call this API operation to query the basic information of the resource non-compliance report that is last generated for the current logon account. In this example, the Tag Policy feature in single-account mode is used. The response shows that the ID of the report is <c>crp-ao0786618088006c****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConfigRuleReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConfigRuleReportResponse
        /// </returns>
        public async Task<GetConfigRuleReportResponse> GetConfigRuleReportAsync(GetConfigRuleReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConfigRuleReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the effective policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the effective tag policy for the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the effective tag policy for the Root folder, a folder other than the Root folder, or a member in the resource directory. You can also use a member of a resource directory to call this API operation to query the effective tag policy for the member. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// An effective tag policy is obtained based on tag policy inheritance. For more information, see <a href="https://help.aliyun.com/document_detail/417435.html">Inheritance of a tag policy and calculation of an effective tag policy</a>.
        /// This topic provides an example on how to call the API operation to query the effective tag policy for the current logon account. In this example, the Tag Policy feature in single-account mode is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEffectivePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEffectivePolicyResponse
        /// </returns>
        public GetEffectivePolicyResponse GetEffectivePolicyWithOptions(GetEffectivePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
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
                Action = "GetEffectivePolicy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEffectivePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the effective policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the effective tag policy for the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the effective tag policy for the Root folder, a folder other than the Root folder, or a member in the resource directory. You can also use a member of a resource directory to call this API operation to query the effective tag policy for the member. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// An effective tag policy is obtained based on tag policy inheritance. For more information, see <a href="https://help.aliyun.com/document_detail/417435.html">Inheritance of a tag policy and calculation of an effective tag policy</a>.
        /// This topic provides an example on how to call the API operation to query the effective tag policy for the current logon account. In this example, the Tag Policy feature in single-account mode is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEffectivePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEffectivePolicyResponse
        /// </returns>
        public async Task<GetEffectivePolicyResponse> GetEffectivePolicyWithOptionsAsync(GetEffectivePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
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
                Action = "GetEffectivePolicy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEffectivePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the effective policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the effective tag policy for the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the effective tag policy for the Root folder, a folder other than the Root folder, or a member in the resource directory. You can also use a member of a resource directory to call this API operation to query the effective tag policy for the member. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// An effective tag policy is obtained based on tag policy inheritance. For more information, see <a href="https://help.aliyun.com/document_detail/417435.html">Inheritance of a tag policy and calculation of an effective tag policy</a>.
        /// This topic provides an example on how to call the API operation to query the effective tag policy for the current logon account. In this example, the Tag Policy feature in single-account mode is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEffectivePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEffectivePolicyResponse
        /// </returns>
        public GetEffectivePolicyResponse GetEffectivePolicy(GetEffectivePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEffectivePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the effective policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the effective tag policy for the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the effective tag policy for the Root folder, a folder other than the Root folder, or a member in the resource directory. You can also use a member of a resource directory to call this API operation to query the effective tag policy for the member. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// An effective tag policy is obtained based on tag policy inheritance. For more information, see <a href="https://help.aliyun.com/document_detail/417435.html">Inheritance of a tag policy and calculation of an effective tag policy</a>.
        /// This topic provides an example on how to call the API operation to query the effective tag policy for the current logon account. In this example, the Tag Policy feature in single-account mode is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEffectivePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEffectivePolicyResponse
        /// </returns>
        public async Task<GetEffectivePolicyResponse> GetEffectivePolicyAsync(GetEffectivePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEffectivePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a tag policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the details of the tag policy with an ID of <c>p-557cb141331f41c7****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyResponse
        /// </returns>
        public GetPolicyResponse GetPolicyWithOptions(GetPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPolicy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a tag policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the details of the tag policy with an ID of <c>p-557cb141331f41c7****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyResponse
        /// </returns>
        public async Task<GetPolicyResponse> GetPolicyWithOptionsAsync(GetPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPolicy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a tag policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the details of the tag policy with an ID of <c>p-557cb141331f41c7****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyResponse
        /// </returns>
        public GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a tag policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the details of the tag policy with an ID of <c>p-557cb141331f41c7****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyResponse
        /// </returns>
        public async Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Tag Policy feature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the status of the Tag Policy feature for the current logon account. The response shows that the Tag Policy feature in multi-account mode is enabled for the current logon account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPolicyEnableStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyEnableStatusResponse
        /// </returns>
        public GetPolicyEnableStatusResponse GetPolicyEnableStatusWithOptions(GetPolicyEnableStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenType))
            {
                query["OpenType"] = request.OpenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPolicyEnableStatus",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyEnableStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Tag Policy feature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the status of the Tag Policy feature for the current logon account. The response shows that the Tag Policy feature in multi-account mode is enabled for the current logon account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPolicyEnableStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyEnableStatusResponse
        /// </returns>
        public async Task<GetPolicyEnableStatusResponse> GetPolicyEnableStatusWithOptionsAsync(GetPolicyEnableStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenType))
            {
                query["OpenType"] = request.OpenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPolicyEnableStatus",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyEnableStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Tag Policy feature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the status of the Tag Policy feature for the current logon account. The response shows that the Tag Policy feature in multi-account mode is enabled for the current logon account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPolicyEnableStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyEnableStatusResponse
        /// </returns>
        public GetPolicyEnableStatusResponse GetPolicyEnableStatus(GetPolicyEnableStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPolicyEnableStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Tag Policy feature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the status of the Tag Policy feature for the current logon account. The response shows that the Tag Policy feature in multi-account mode is enabled for the current logon account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPolicyEnableStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPolicyEnableStatusResponse
        /// </returns>
        public async Task<GetPolicyEnableStatusResponse> GetPolicyEnableStatusAsync(GetPolicyEnableStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPolicyEnableStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Search the rules for associated resources that the user has set up.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAssociatedResourceRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAssociatedResourceRulesResponse
        /// </returns>
        public ListAssociatedResourceRulesResponse ListAssociatedResourceRulesWithOptions(ListAssociatedResourceRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["MaxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingName))
            {
                query["SettingName"] = request.SettingName;
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
                Action = "ListAssociatedResourceRules",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAssociatedResourceRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Search the rules for associated resources that the user has set up.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAssociatedResourceRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAssociatedResourceRulesResponse
        /// </returns>
        public async Task<ListAssociatedResourceRulesResponse> ListAssociatedResourceRulesWithOptionsAsync(ListAssociatedResourceRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["MaxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingName))
            {
                query["SettingName"] = request.SettingName;
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
                Action = "ListAssociatedResourceRules",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAssociatedResourceRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Search the rules for associated resources that the user has set up.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAssociatedResourceRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAssociatedResourceRulesResponse
        /// </returns>
        public ListAssociatedResourceRulesResponse ListAssociatedResourceRules(ListAssociatedResourceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAssociatedResourceRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Search the rules for associated resources that the user has set up.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAssociatedResourceRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAssociatedResourceRulesResponse
        /// </returns>
        public async Task<ListAssociatedResourceRulesResponse> ListAssociatedResourceRulesAsync(ListAssociatedResourceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAssociatedResourceRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of tag detection tasks for an object.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the tag detection tasks for the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the tag detection tasks for the Root folder, a folder other than the Root folder, or a member in the resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to query the tag detection tasks for the current logon account. In this example, the Tag Policy feature in single-account mode is used. The response shows that only one tag detection task exists.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListConfigRulesForTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConfigRulesForTargetResponse
        /// </returns>
        public ListConfigRulesForTargetResponse ListConfigRulesForTargetWithOptions(ListConfigRulesForTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["MaxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigRulesForTarget",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigRulesForTargetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of tag detection tasks for an object.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the tag detection tasks for the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the tag detection tasks for the Root folder, a folder other than the Root folder, or a member in the resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to query the tag detection tasks for the current logon account. In this example, the Tag Policy feature in single-account mode is used. The response shows that only one tag detection task exists.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListConfigRulesForTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConfigRulesForTargetResponse
        /// </returns>
        public async Task<ListConfigRulesForTargetResponse> ListConfigRulesForTargetWithOptionsAsync(ListConfigRulesForTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["MaxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigRulesForTarget",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigRulesForTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of tag detection tasks for an object.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the tag detection tasks for the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the tag detection tasks for the Root folder, a folder other than the Root folder, or a member in the resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to query the tag detection tasks for the current logon account. In this example, the Tag Policy feature in single-account mode is used. The response shows that only one tag detection task exists.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListConfigRulesForTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConfigRulesForTargetResponse
        /// </returns>
        public ListConfigRulesForTargetResponse ListConfigRulesForTarget(ListConfigRulesForTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConfigRulesForTargetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of tag detection tasks for an object.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the tag detection tasks for the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the tag detection tasks for the Root folder, a folder other than the Root folder, or a member in the resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to query the tag detection tasks for the current logon account. In this example, the Tag Policy feature in single-account mode is used. The response shows that only one tag detection task exists.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListConfigRulesForTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConfigRulesForTargetResponse
        /// </returns>
        public async Task<ListConfigRulesForTargetResponse> ListConfigRulesForTargetAsync(ListConfigRulesForTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConfigRulesForTargetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query all tag policies that are created for the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query all tag policies that are created for the resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to query all tag policies that are created for the current logon account. In this example, the Tag Policy feature in single-account mode is used. The response shows that two tag policies are created.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesResponse
        /// </returns>
        public ListPoliciesResponse ListPoliciesWithOptions(ListPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["MaxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIds))
            {
                query["PolicyIds"] = request.PolicyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyNames))
            {
                query["PolicyNames"] = request.PolicyNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicies",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query all tag policies that are created for the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query all tag policies that are created for the resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to query all tag policies that are created for the current logon account. In this example, the Tag Policy feature in single-account mode is used. The response shows that two tag policies are created.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesResponse
        /// </returns>
        public async Task<ListPoliciesResponse> ListPoliciesWithOptionsAsync(ListPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["MaxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIds))
            {
                query["PolicyIds"] = request.PolicyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyNames))
            {
                query["PolicyNames"] = request.PolicyNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicies",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query all tag policies that are created for the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query all tag policies that are created for the resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to query all tag policies that are created for the current logon account. In this example, the Tag Policy feature in single-account mode is used. The response shows that two tag policies are created.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesResponse
        /// </returns>
        public ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPoliciesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query all tag policies that are created for the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query all tag policies that are created for the resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to query all tag policies that are created for the current logon account. In this example, the Tag Policy feature in single-account mode is used. The response shows that two tag policies are created.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesResponse
        /// </returns>
        public async Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPoliciesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag policies that are attached to an object.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the tag policies that are attached to the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the tag policies that are attached to the Root folder, a folder other than the Root folder, or a member in the resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to query the tag policies that are attached to the current logon account. In this example, the Tag Policy feature in single-account mode is used. The response shows that only one tag policy is attached to the current logon account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPoliciesForTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesForTargetResponse
        /// </returns>
        public ListPoliciesForTargetResponse ListPoliciesForTargetWithOptions(ListPoliciesForTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["MaxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
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
                Action = "ListPoliciesForTarget",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPoliciesForTargetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag policies that are attached to an object.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the tag policies that are attached to the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the tag policies that are attached to the Root folder, a folder other than the Root folder, or a member in the resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to query the tag policies that are attached to the current logon account. In this example, the Tag Policy feature in single-account mode is used. The response shows that only one tag policy is attached to the current logon account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPoliciesForTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesForTargetResponse
        /// </returns>
        public async Task<ListPoliciesForTargetResponse> ListPoliciesForTargetWithOptionsAsync(ListPoliciesForTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["MaxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
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
                Action = "ListPoliciesForTarget",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPoliciesForTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag policies that are attached to an object.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the tag policies that are attached to the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the tag policies that are attached to the Root folder, a folder other than the Root folder, or a member in the resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to query the tag policies that are attached to the current logon account. In this example, the Tag Policy feature in single-account mode is used. The response shows that only one tag policy is attached to the current logon account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPoliciesForTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesForTargetResponse
        /// </returns>
        public ListPoliciesForTargetResponse ListPoliciesForTarget(ListPoliciesForTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPoliciesForTargetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag policies that are attached to an object.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the tag policies that are attached to the account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the tag policies that are attached to the Root folder, a folder other than the Root folder, or a member in the resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to query the tag policies that are attached to the current logon account. In this example, the Tag Policy feature in single-account mode is used. The response shows that only one tag policy is attached to the current logon account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPoliciesForTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesForTargetResponse
        /// </returns>
        public async Task<ListPoliciesForTargetResponse> ListPoliciesForTargetAsync(ListPoliciesForTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPoliciesForTargetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resources to which a specified tag is added or resources to which a specified tag is not added.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation in the China (Shenzhen) region to query virtual private clouds (VPCs) to which the tag key <c>k1</c> is added. The response shows that the tag key is added to two VPCs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourcesByTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourcesByTagResponse
        /// </returns>
        public ListResourcesByTagResponse ListResourcesByTagWithOptions(ListResourcesByTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuzzyType))
            {
                query["FuzzyType"] = request.FuzzyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeAllTags))
            {
                query["IncludeAllTags"] = request.IncludeAllTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["MaxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagFilter))
            {
                query["TagFilter"] = request.TagFilter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourcesByTag",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcesByTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resources to which a specified tag is added or resources to which a specified tag is not added.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation in the China (Shenzhen) region to query virtual private clouds (VPCs) to which the tag key <c>k1</c> is added. The response shows that the tag key is added to two VPCs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourcesByTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourcesByTagResponse
        /// </returns>
        public async Task<ListResourcesByTagResponse> ListResourcesByTagWithOptionsAsync(ListResourcesByTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuzzyType))
            {
                query["FuzzyType"] = request.FuzzyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeAllTags))
            {
                query["IncludeAllTags"] = request.IncludeAllTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["MaxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagFilter))
            {
                query["TagFilter"] = request.TagFilter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourcesByTag",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcesByTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resources to which a specified tag is added or resources to which a specified tag is not added.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation in the China (Shenzhen) region to query virtual private clouds (VPCs) to which the tag key <c>k1</c> is added. The response shows that the tag key is added to two VPCs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourcesByTagRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourcesByTagResponse
        /// </returns>
        public ListResourcesByTagResponse ListResourcesByTag(ListResourcesByTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourcesByTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resources to which a specified tag is added or resources to which a specified tag is not added.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation in the China (Shenzhen) region to query virtual private clouds (VPCs) to which the tag key <c>k1</c> is added. The response shows that the tag key is added to two VPCs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourcesByTagRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourcesByTagResponse
        /// </returns>
        public async Task<ListResourcesByTagResponse> ListResourcesByTagAsync(ListResourcesByTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourcesByTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource types supported by tags and tag-related capability items.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Call example</h3>
        /// <list type="bullet">
        /// <item><description>Query a list of resource types supported by TagResources or UntagResources. For more information, see <a href="https://api.alibabacloud.com/api/Tag/2018-08-28/ListSupportResourceTypes?tab=DEBUG%5C&params=%7B%22RegionId%22:%22cn-hangzhou%22,%22SupportCode%22:%22TAG_CONSOLE_SUPPORT%22%7D">Example</a>.</description></item>
        /// <item><description>Query a list of resource types supported by ListTagResources or ListResourcesByTag. For more information, see <a href="https://api.alibabacloud.com/api/Tag/2018-08-28/ListSupportResourceTypes?tab=DEBUG%5C&params=%7B%22RegionId%22:%22cn-hangzhou%22%7D">Example</a>.</description></item>
        /// <item><description>Query a list of resource types that support createdby tags. For more information, see <a href="https://api.alibabacloud.com/api/Tag/2018-08-28/ListSupportResourceTypes?tab=DEBUG%5C&params=%7B%22RegionId%22:%22cn-hangzhou%22,%22SupportCode%22:%22CREATED_BY_TAG_CONSOLE_SUPPORT%22%7D">Example</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSupportResourceTypesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSupportResourceTypesResponse
        /// </returns>
        public ListSupportResourceTypesResponse ListSupportResourceTypesWithOptions(ListSupportResourceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["MaxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTye))
            {
                query["ResourceTye"] = request.ResourceTye;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowItems))
            {
                query["ShowItems"] = request.ShowItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportCode))
            {
                query["SupportCode"] = request.SupportCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSupportResourceTypes",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSupportResourceTypesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource types supported by tags and tag-related capability items.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Call example</h3>
        /// <list type="bullet">
        /// <item><description>Query a list of resource types supported by TagResources or UntagResources. For more information, see <a href="https://api.alibabacloud.com/api/Tag/2018-08-28/ListSupportResourceTypes?tab=DEBUG%5C&params=%7B%22RegionId%22:%22cn-hangzhou%22,%22SupportCode%22:%22TAG_CONSOLE_SUPPORT%22%7D">Example</a>.</description></item>
        /// <item><description>Query a list of resource types supported by ListTagResources or ListResourcesByTag. For more information, see <a href="https://api.alibabacloud.com/api/Tag/2018-08-28/ListSupportResourceTypes?tab=DEBUG%5C&params=%7B%22RegionId%22:%22cn-hangzhou%22%7D">Example</a>.</description></item>
        /// <item><description>Query a list of resource types that support createdby tags. For more information, see <a href="https://api.alibabacloud.com/api/Tag/2018-08-28/ListSupportResourceTypes?tab=DEBUG%5C&params=%7B%22RegionId%22:%22cn-hangzhou%22,%22SupportCode%22:%22CREATED_BY_TAG_CONSOLE_SUPPORT%22%7D">Example</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSupportResourceTypesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSupportResourceTypesResponse
        /// </returns>
        public async Task<ListSupportResourceTypesResponse> ListSupportResourceTypesWithOptionsAsync(ListSupportResourceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["MaxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTye))
            {
                query["ResourceTye"] = request.ResourceTye;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowItems))
            {
                query["ShowItems"] = request.ShowItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportCode))
            {
                query["SupportCode"] = request.SupportCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSupportResourceTypes",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSupportResourceTypesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource types supported by tags and tag-related capability items.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Call example</h3>
        /// <list type="bullet">
        /// <item><description>Query a list of resource types supported by TagResources or UntagResources. For more information, see <a href="https://api.alibabacloud.com/api/Tag/2018-08-28/ListSupportResourceTypes?tab=DEBUG%5C&params=%7B%22RegionId%22:%22cn-hangzhou%22,%22SupportCode%22:%22TAG_CONSOLE_SUPPORT%22%7D">Example</a>.</description></item>
        /// <item><description>Query a list of resource types supported by ListTagResources or ListResourcesByTag. For more information, see <a href="https://api.alibabacloud.com/api/Tag/2018-08-28/ListSupportResourceTypes?tab=DEBUG%5C&params=%7B%22RegionId%22:%22cn-hangzhou%22%7D">Example</a>.</description></item>
        /// <item><description>Query a list of resource types that support createdby tags. For more information, see <a href="https://api.alibabacloud.com/api/Tag/2018-08-28/ListSupportResourceTypes?tab=DEBUG%5C&params=%7B%22RegionId%22:%22cn-hangzhou%22,%22SupportCode%22:%22CREATED_BY_TAG_CONSOLE_SUPPORT%22%7D">Example</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSupportResourceTypesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSupportResourceTypesResponse
        /// </returns>
        public ListSupportResourceTypesResponse ListSupportResourceTypes(ListSupportResourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSupportResourceTypesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource types supported by tags and tag-related capability items.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Call example</h3>
        /// <list type="bullet">
        /// <item><description>Query a list of resource types supported by TagResources or UntagResources. For more information, see <a href="https://api.alibabacloud.com/api/Tag/2018-08-28/ListSupportResourceTypes?tab=DEBUG%5C&params=%7B%22RegionId%22:%22cn-hangzhou%22,%22SupportCode%22:%22TAG_CONSOLE_SUPPORT%22%7D">Example</a>.</description></item>
        /// <item><description>Query a list of resource types supported by ListTagResources or ListResourcesByTag. For more information, see <a href="https://api.alibabacloud.com/api/Tag/2018-08-28/ListSupportResourceTypes?tab=DEBUG%5C&params=%7B%22RegionId%22:%22cn-hangzhou%22%7D">Example</a>.</description></item>
        /// <item><description>Query a list of resource types that support createdby tags. For more information, see <a href="https://api.alibabacloud.com/api/Tag/2018-08-28/ListSupportResourceTypes?tab=DEBUG%5C&params=%7B%22RegionId%22:%22cn-hangzhou%22,%22SupportCode%22:%22CREATED_BY_TAG_CONSOLE_SUPPORT%22%7D">Example</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSupportResourceTypesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSupportResourceTypesResponse
        /// </returns>
        public async Task<ListSupportResourceTypesResponse> ListSupportResourceTypesAsync(ListSupportResourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSupportResourceTypesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag keys.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the tag keys in the <c>cn-hangzhou</c> region. The response shows that the following tag keys exist: <c>team</c>, <c>k1</c>, and <c>k2</c>.</para>
        /// </description>
        /// 
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuzzyType))
            {
                query["FuzzyType"] = request.FuzzyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagFilter))
            {
                query["TagFilter"] = request.TagFilter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagKeys",
                Version = "2018-08-28",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag keys.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the tag keys in the <c>cn-hangzhou</c> region. The response shows that the following tag keys exist: <c>team</c>, <c>k1</c>, and <c>k2</c>.</para>
        /// </description>
        /// 
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuzzyType))
            {
                query["FuzzyType"] = request.FuzzyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagFilter))
            {
                query["TagFilter"] = request.TagFilter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagKeys",
                Version = "2018-08-28",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag keys.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the tag keys in the <c>cn-hangzhou</c> region. The response shows that the following tag keys exist: <c>team</c>, <c>k1</c>, and <c>k2</c>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag keys.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the tag keys in the <c>cn-hangzhou</c> region. The response shows that the following tag keys exist: <c>team</c>, <c>k1</c>, and <c>k2</c>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to the resources of various Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the Alibaba Cloud services that support tags, see <a href="https://help.aliyun.com/document_detail/171455.html">Services that work with Tag</a>.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceARN))
            {
                query["ResourceARN"] = request.ResourceARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
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
                Action = "ListTagResources",
                Version = "2018-08-28",
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
        /// <para>Queries the tags that are added to the resources of various Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the Alibaba Cloud services that support tags, see <a href="https://help.aliyun.com/document_detail/171455.html">Services that work with Tag</a>.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceARN))
            {
                query["ResourceARN"] = request.ResourceARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
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
                Action = "ListTagResources",
                Version = "2018-08-28",
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
        /// <para>Queries the tags that are added to the resources of various Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the Alibaba Cloud services that support tags, see <a href="https://help.aliyun.com/document_detail/171455.html">Services that work with Tag</a>.</para>
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
        /// <para>Queries the tags that are added to the resources of various Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the Alibaba Cloud services that support tags, see <a href="https://help.aliyun.com/document_detail/171455.html">Services that work with Tag</a>.</para>
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
        /// <para>Queries the tag values of a tag key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the values of the tag key <c>k1</c> in the <c>cn-hangzhou</c> region. The response shows that the value of the tag key <c>k1</c> is <c>v1</c>.</para>
        /// </description>
        /// 
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuzzyType))
            {
                query["FuzzyType"] = request.FuzzyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagFilter))
            {
                query["TagFilter"] = request.TagFilter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagValues",
                Version = "2018-08-28",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag values of a tag key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the values of the tag key <c>k1</c> in the <c>cn-hangzhou</c> region. The response shows that the value of the tag key <c>k1</c> is <c>v1</c>.</para>
        /// </description>
        /// 
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuzzyType))
            {
                query["FuzzyType"] = request.FuzzyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagFilter))
            {
                query["TagFilter"] = request.TagFilter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagValues",
                Version = "2018-08-28",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag values of a tag key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the values of the tag key <c>k1</c> in the <c>cn-hangzhou</c> region. The response shows that the value of the tag key <c>k1</c> is <c>v1</c>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag values of a tag key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the values of the tag key <c>k1</c> in the <c>cn-hangzhou</c> region. The response shows that the value of the tag key <c>k1</c> is <c>v1</c>.</para>
        /// </description>
        /// 
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
        /// <para>Queries the objects to which a tag policy is attached.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the object to which a tag policy is attached. The object is the current logon account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the objects to which a tag policy is attached. The objects include the Root folder, folders other than the Root folder, and members in the resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to query the objects to which the tag policy with an ID of <c>p-de62a0bf400e4b69****</c> is attached. In this example, the Tag Policy feature in multi-account mode is used. The response shows that the tag policy is attached to two members in the related resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTargetsForPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTargetsForPolicyResponse
        /// </returns>
        public ListTargetsForPolicyResponse ListTargetsForPolicyWithOptions(ListTargetsForPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["MaxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTargetsForPolicy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTargetsForPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the objects to which a tag policy is attached.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the object to which a tag policy is attached. The object is the current logon account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the objects to which a tag policy is attached. The objects include the Root folder, folders other than the Root folder, and members in the resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to query the objects to which the tag policy with an ID of <c>p-de62a0bf400e4b69****</c> is attached. In this example, the Tag Policy feature in multi-account mode is used. The response shows that the tag policy is attached to two members in the related resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTargetsForPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTargetsForPolicyResponse
        /// </returns>
        public async Task<ListTargetsForPolicyResponse> ListTargetsForPolicyWithOptionsAsync(ListTargetsForPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["MaxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                query["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTargetsForPolicy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTargetsForPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the objects to which a tag policy is attached.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the object to which a tag policy is attached. The object is the current logon account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the objects to which a tag policy is attached. The objects include the Root folder, folders other than the Root folder, and members in the resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to query the objects to which the tag policy with an ID of <c>p-de62a0bf400e4b69****</c> is attached. In this example, the Tag Policy feature in multi-account mode is used. The response shows that the tag policy is attached to two members in the related resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTargetsForPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTargetsForPolicyResponse
        /// </returns>
        public ListTargetsForPolicyResponse ListTargetsForPolicy(ListTargetsForPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTargetsForPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the objects to which a tag policy is attached.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use the Tag Policy feature in single-account mode, you can use the current logon account to call this API operation to query the object to which a tag policy is attached. The object is the current logon account. If you use the Tag Policy feature in multi-account mode, you can use the management account of a resource directory to call this API operation to query the objects to which a tag policy is attached. The objects include the Root folder, folders other than the Root folder, and members in the resource directory. For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.
        /// This topic provides an example on how to call the API operation to query the objects to which the tag policy with an ID of <c>p-de62a0bf400e4b69****</c> is attached. In this example, the Tag Policy feature in multi-account mode is used. The response shows that the tag policy is attached to two members in the related resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTargetsForPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTargetsForPolicyResponse
        /// </returns>
        public async Task<ListTargetsForPolicyResponse> ListTargetsForPolicyAsync(ListTargetsForPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTargetsForPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a tag policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a></h3>
        /// <para>This topic provides an example on how to call the API operation to change the name of a tag policy to <c>test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPolicyResponse
        /// </returns>
        public ModifyPolicyResponse ModifyPolicyWithOptions(ModifyPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyContent))
            {
                query["PolicyContent"] = request.PolicyContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDesc))
            {
                query["PolicyDesc"] = request.PolicyDesc;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPolicy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a tag policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a></h3>
        /// <para>This topic provides an example on how to call the API operation to change the name of a tag policy to <c>test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPolicyResponse
        /// </returns>
        public async Task<ModifyPolicyResponse> ModifyPolicyWithOptionsAsync(ModifyPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyContent))
            {
                query["PolicyContent"] = request.PolicyContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDesc))
            {
                query["PolicyDesc"] = request.PolicyDesc;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPolicy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a tag policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a></h3>
        /// <para>This topic provides an example on how to call the API operation to change the name of a tag policy to <c>test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPolicyResponse
        /// </returns>
        public ModifyPolicyResponse ModifyPolicy(ModifyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a tag policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a></h3>
        /// <para>This topic provides an example on how to call the API operation to change the name of a tag policy to <c>test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPolicyResponse
        /// </returns>
        public async Task<ModifyPolicyResponse> ModifyPolicyAsync(ModifyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables createdby tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>createdby tags can help you analyze costs and bills and manage the costs of cloud resources in an efficient manner. You can identify the creators of resources based on the createdby tags added to the resources. createdby tags are system tags that are provided by Alibaba Cloud and automatically added to resources. The key of createdby tags is <c>acs:tag:createdby</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OpenCreatedByRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenCreatedByResponse
        /// </returns>
        public OpenCreatedByResponse OpenCreatedByWithOptions(OpenCreatedByRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenCreatedBy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenCreatedByResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables createdby tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>createdby tags can help you analyze costs and bills and manage the costs of cloud resources in an efficient manner. You can identify the creators of resources based on the createdby tags added to the resources. createdby tags are system tags that are provided by Alibaba Cloud and automatically added to resources. The key of createdby tags is <c>acs:tag:createdby</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OpenCreatedByRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenCreatedByResponse
        /// </returns>
        public async Task<OpenCreatedByResponse> OpenCreatedByWithOptionsAsync(OpenCreatedByRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenCreatedBy",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenCreatedByResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables createdby tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>createdby tags can help you analyze costs and bills and manage the costs of cloud resources in an efficient manner. You can identify the creators of resources based on the createdby tags added to the resources. createdby tags are system tags that are provided by Alibaba Cloud and automatically added to resources. The key of createdby tags is <c>acs:tag:createdby</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OpenCreatedByRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenCreatedByResponse
        /// </returns>
        public OpenCreatedByResponse OpenCreatedBy(OpenCreatedByRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenCreatedByWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables createdby tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>createdby tags can help you analyze costs and bills and manage the costs of cloud resources in an efficient manner. You can identify the creators of resources based on the createdby tags added to the resources. createdby tags are system tags that are provided by Alibaba Cloud and automatically added to resources. The key of createdby tags is <c>acs:tag:createdby</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OpenCreatedByRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenCreatedByResponse
        /// </returns>
        public async Task<OpenCreatedByResponse> OpenCreatedByAsync(OpenCreatedByRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenCreatedByWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to the resources of various Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tags are used to identify resources. Tags allow you to categorize, search for, and aggregate resources that have the same characteristics from different dimensions. This facilitates resource management. For more information, see <a href="https://help.aliyun.com/document_detail/156983.html">Tag overview</a>.
        /// For information about the Alibaba Cloud services that support tags, see <a href="https://help.aliyun.com/document_detail/171455.html">Services that work with Tag</a>.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceARN))
            {
                query["ResourceARN"] = request.ResourceARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
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
                Action = "TagResources",
                Version = "2018-08-28",
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
        /// <para>Adds tags to the resources of various Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tags are used to identify resources. Tags allow you to categorize, search for, and aggregate resources that have the same characteristics from different dimensions. This facilitates resource management. For more information, see <a href="https://help.aliyun.com/document_detail/156983.html">Tag overview</a>.
        /// For information about the Alibaba Cloud services that support tags, see <a href="https://help.aliyun.com/document_detail/171455.html">Services that work with Tag</a>.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceARN))
            {
                query["ResourceARN"] = request.ResourceARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
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
                Action = "TagResources",
                Version = "2018-08-28",
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
        /// <para>Adds tags to the resources of various Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tags are used to identify resources. Tags allow you to categorize, search for, and aggregate resources that have the same characteristics from different dimensions. This facilitates resource management. For more information, see <a href="https://help.aliyun.com/document_detail/156983.html">Tag overview</a>.
        /// For information about the Alibaba Cloud services that support tags, see <a href="https://help.aliyun.com/document_detail/171455.html">Services that work with Tag</a>.</para>
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
        /// <para>Adds tags to the resources of various Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tags are used to identify resources. Tags allow you to categorize, search for, and aggregate resources that have the same characteristics from different dimensions. This facilitates resource management. For more information, see <a href="https://help.aliyun.com/document_detail/156983.html">Tag overview</a>.
        /// For information about the Alibaba Cloud services that support tags, see <a href="https://help.aliyun.com/document_detail/171455.html">Services that work with Tag</a>.</para>
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
        /// <para>Removes tags from the resources of various Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you remove a tag, the tag is automatically deleted within 24 hours if it is not added to other resources.
        /// For information about the Alibaba Cloud services that support tags, see <a href="https://help.aliyun.com/document_detail/171455.html">Services that work with Tag</a>.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceARN))
            {
                query["ResourceARN"] = request.ResourceARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
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
                Version = "2018-08-28",
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
        /// <para>Removes tags from the resources of various Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you remove a tag, the tag is automatically deleted within 24 hours if it is not added to other resources.
        /// For information about the Alibaba Cloud services that support tags, see <a href="https://help.aliyun.com/document_detail/171455.html">Services that work with Tag</a>.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceARN))
            {
                query["ResourceARN"] = request.ResourceARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
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
                Version = "2018-08-28",
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
        /// <para>Removes tags from the resources of various Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you remove a tag, the tag is automatically deleted within 24 hours if it is not added to other resources.
        /// For information about the Alibaba Cloud services that support tags, see <a href="https://help.aliyun.com/document_detail/171455.html">Services that work with Tag</a>.</para>
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
        /// <para>Removes tags from the resources of various Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you remove a tag, the tag is automatically deleted within 24 hours if it is not added to other resources.
        /// For information about the Alibaba Cloud services that support tags, see <a href="https://help.aliyun.com/document_detail/171455.html">Services that work with Tag</a>.</para>
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
        /// <para>Update the rule for tagging associated resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAssociatedResourceRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAssociatedResourceRuleResponse
        /// </returns>
        public UpdateAssociatedResourceRuleResponse UpdateAssociatedResourceRuleWithOptions(UpdateAssociatedResourceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistingStatus))
            {
                query["ExistingStatus"] = request.ExistingStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingName))
            {
                query["SettingName"] = request.SettingName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAssociatedResourceRule",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAssociatedResourceRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the rule for tagging associated resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAssociatedResourceRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAssociatedResourceRuleResponse
        /// </returns>
        public async Task<UpdateAssociatedResourceRuleResponse> UpdateAssociatedResourceRuleWithOptionsAsync(UpdateAssociatedResourceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistingStatus))
            {
                query["ExistingStatus"] = request.ExistingStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingName))
            {
                query["SettingName"] = request.SettingName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAssociatedResourceRule",
                Version = "2018-08-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAssociatedResourceRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the rule for tagging associated resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAssociatedResourceRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAssociatedResourceRuleResponse
        /// </returns>
        public UpdateAssociatedResourceRuleResponse UpdateAssociatedResourceRule(UpdateAssociatedResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAssociatedResourceRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the rule for tagging associated resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAssociatedResourceRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAssociatedResourceRuleResponse
        /// </returns>
        public async Task<UpdateAssociatedResourceRuleResponse> UpdateAssociatedResourceRuleAsync(UpdateAssociatedResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAssociatedResourceRuleWithOptionsAsync(request, runtime);
        }

    }
}
