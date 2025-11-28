// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Lto20210707.Models;

namespace AlibabaCloud.SDK.Lto20210707
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("lto", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// AddBaaSAntChainBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddBaaSAntChainBizChainResponse
        /// </returns>
        public AddBaaSAntChainBizChainResponse AddBaaSAntChainBizChainWithOptions(AddBaaSAntChainBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSAntChainChainId))
            {
                query["BaaSAntChainChainId"] = request.BaaSAntChainChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSAntChainConsortiumId))
            {
                query["BaaSAntChainConsortiumId"] = request.BaaSAntChainConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaCert))
            {
                query["CaCert"] = request.CaCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaCertPassword))
            {
                query["CaCertPassword"] = request.CaCertPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientCert))
            {
                query["ClientCert"] = request.ClientCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKey))
            {
                query["ClientKey"] = request.ClientKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKeyPassword))
            {
                query["ClientKeyPassword"] = request.ClientKeyPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractTemplateIdList))
            {
                query["ContractTemplateIdList"] = request.ContractTemplateIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNameList))
            {
                query["NodeNameList"] = request.NodeNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKey))
            {
                query["UserKey"] = request.UserKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKeyPassword))
            {
                query["UserKeyPassword"] = request.UserKeyPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBaaSAntChainBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBaaSAntChainBizChainResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AddBaaSAntChainBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddBaaSAntChainBizChainResponse
        /// </returns>
        public async Task<AddBaaSAntChainBizChainResponse> AddBaaSAntChainBizChainWithOptionsAsync(AddBaaSAntChainBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSAntChainChainId))
            {
                query["BaaSAntChainChainId"] = request.BaaSAntChainChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSAntChainConsortiumId))
            {
                query["BaaSAntChainConsortiumId"] = request.BaaSAntChainConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaCert))
            {
                query["CaCert"] = request.CaCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaCertPassword))
            {
                query["CaCertPassword"] = request.CaCertPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientCert))
            {
                query["ClientCert"] = request.ClientCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKey))
            {
                query["ClientKey"] = request.ClientKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKeyPassword))
            {
                query["ClientKeyPassword"] = request.ClientKeyPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractTemplateIdList))
            {
                query["ContractTemplateIdList"] = request.ContractTemplateIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNameList))
            {
                query["NodeNameList"] = request.NodeNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKey))
            {
                query["UserKey"] = request.UserKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKeyPassword))
            {
                query["UserKeyPassword"] = request.UserKeyPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBaaSAntChainBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBaaSAntChainBizChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AddBaaSAntChainBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// AddBaaSAntChainBizChainResponse
        /// </returns>
        public AddBaaSAntChainBizChainResponse AddBaaSAntChainBizChain(AddBaaSAntChainBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddBaaSAntChainBizChainWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AddBaaSAntChainBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// AddBaaSAntChainBizChainResponse
        /// </returns>
        public async Task<AddBaaSAntChainBizChainResponse> AddBaaSAntChainBizChainAsync(AddBaaSAntChainBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddBaaSAntChainBizChainWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AddBaaSFabricBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddBaaSFabricBizChainResponse
        /// </returns>
        public AddBaaSFabricBizChainResponse AddBaaSFabricBizChainWithOptions(AddBaaSFabricBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSFabricChannelId))
            {
                query["BaaSFabricChannelId"] = request.BaaSFabricChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSFabricConsortiumId))
            {
                query["BaaSFabricConsortiumId"] = request.BaaSFabricConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSFabricOrganizationId))
            {
                query["BaaSFabricOrganizationId"] = request.BaaSFabricOrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractTemplateIdList))
            {
                query["ContractTemplateIdList"] = request.ContractTemplateIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBaaSFabricBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBaaSFabricBizChainResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AddBaaSFabricBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddBaaSFabricBizChainResponse
        /// </returns>
        public async Task<AddBaaSFabricBizChainResponse> AddBaaSFabricBizChainWithOptionsAsync(AddBaaSFabricBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSFabricChannelId))
            {
                query["BaaSFabricChannelId"] = request.BaaSFabricChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSFabricConsortiumId))
            {
                query["BaaSFabricConsortiumId"] = request.BaaSFabricConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSFabricOrganizationId))
            {
                query["BaaSFabricOrganizationId"] = request.BaaSFabricOrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractTemplateIdList))
            {
                query["ContractTemplateIdList"] = request.ContractTemplateIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBaaSFabricBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBaaSFabricBizChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AddBaaSFabricBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// AddBaaSFabricBizChainResponse
        /// </returns>
        public AddBaaSFabricBizChainResponse AddBaaSFabricBizChain(AddBaaSFabricBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddBaaSFabricBizChainWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AddBaaSFabricBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// AddBaaSFabricBizChainResponse
        /// </returns>
        public async Task<AddBaaSFabricBizChainResponse> AddBaaSFabricBizChainAsync(AddBaaSFabricBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddBaaSFabricBizChainWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AddBsnFabricBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddBsnFabricBizChainResponse
        /// </returns>
        public AddBsnFabricBizChainResponse AddBsnFabricBizChainWithOptions(AddBsnFabricBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeList))
            {
                query["NodeList"] = request.NodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCode))
            {
                query["UserCode"] = request.UserCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBsnFabricBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBsnFabricBizChainResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AddBsnFabricBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddBsnFabricBizChainResponse
        /// </returns>
        public async Task<AddBsnFabricBizChainResponse> AddBsnFabricBizChainWithOptionsAsync(AddBsnFabricBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeList))
            {
                query["NodeList"] = request.NodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCode))
            {
                query["UserCode"] = request.UserCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBsnFabricBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBsnFabricBizChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AddBsnFabricBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// AddBsnFabricBizChainResponse
        /// </returns>
        public AddBsnFabricBizChainResponse AddBsnFabricBizChain(AddBsnFabricBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddBsnFabricBizChainWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AddBsnFabricBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// AddBsnFabricBizChainResponse
        /// </returns>
        public async Task<AddBsnFabricBizChainResponse> AddBsnFabricBizChainAsync(AddBsnFabricBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddBsnFabricBizChainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加设备组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDeviceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDeviceGroupResponse
        /// </returns>
        public AddDeviceGroupResponse AddDeviceGroupWithOptions(AddDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedCount))
            {
                query["AuthorizedCount"] = request.AuthorizedCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDeviceGroup",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDeviceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加设备组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDeviceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDeviceGroupResponse
        /// </returns>
        public async Task<AddDeviceGroupResponse> AddDeviceGroupWithOptionsAsync(AddDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedCount))
            {
                query["AuthorizedCount"] = request.AuthorizedCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDeviceGroup",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDeviceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加设备组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDeviceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDeviceGroupResponse
        /// </returns>
        public AddDeviceGroupResponse AddDeviceGroup(AddDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDeviceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加设备组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDeviceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDeviceGroupResponse
        /// </returns>
        public async Task<AddDeviceGroupResponse> AddDeviceGroupAsync(AddDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDeviceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMemberResponse
        /// </returns>
        public AddMemberResponse AddMemberWithOptions(AddMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedCount))
            {
                query["AuthorizedCount"] = request.AuthorizedCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedDeviceCount))
            {
                query["AuthorizedDeviceCount"] = request.AuthorizedDeviceCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contactor))
            {
                query["Contactor"] = request.Contactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephony))
            {
                query["Telephony"] = request.Telephony;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMember",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMemberResponse
        /// </returns>
        public async Task<AddMemberResponse> AddMemberWithOptionsAsync(AddMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedCount))
            {
                query["AuthorizedCount"] = request.AuthorizedCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedDeviceCount))
            {
                query["AuthorizedDeviceCount"] = request.AuthorizedDeviceCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contactor))
            {
                query["Contactor"] = request.Contactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephony))
            {
                query["Telephony"] = request.Telephony;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMember",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMemberResponse
        /// </returns>
        public AddMemberResponse AddMember(AddMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMemberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMemberResponse
        /// </returns>
        public async Task<AddMemberResponse> AddMemberAsync(AddMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMemberWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AddPrivacyRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddPrivacyRuleResponse
        /// </returns>
        public AddPrivacyRuleResponse AddPrivacyRuleWithOptions(AddPrivacyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgImpl))
            {
                query["AlgImpl"] = request.AlgImpl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgType))
            {
                query["AlgType"] = request.AlgType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddPrivacyRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPrivacyRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AddPrivacyRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddPrivacyRuleResponse
        /// </returns>
        public async Task<AddPrivacyRuleResponse> AddPrivacyRuleWithOptionsAsync(AddPrivacyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgImpl))
            {
                query["AlgImpl"] = request.AlgImpl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgType))
            {
                query["AlgType"] = request.AlgType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddPrivacyRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPrivacyRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AddPrivacyRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// AddPrivacyRuleResponse
        /// </returns>
        public AddPrivacyRuleResponse AddPrivacyRule(AddPrivacyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddPrivacyRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AddPrivacyRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// AddPrivacyRuleResponse
        /// </returns>
        public async Task<AddPrivacyRuleResponse> AddPrivacyRuleAsync(AddPrivacyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddPrivacyRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AddRouteRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRouteRuleResponse
        /// </returns>
        public AddRouteRuleResponse AddRouteRuleWithOptions(AddRouteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainUpMode))
            {
                query["ChainUpMode"] = request.ChainUpMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractName))
            {
                query["ContractName"] = request.ContractName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractTemplateId))
            {
                query["ContractTemplateId"] = request.ContractTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                query["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivacyRuleId))
            {
                query["PrivacyRuleId"] = request.PrivacyRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRouteRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRouteRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AddRouteRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRouteRuleResponse
        /// </returns>
        public async Task<AddRouteRuleResponse> AddRouteRuleWithOptionsAsync(AddRouteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainUpMode))
            {
                query["ChainUpMode"] = request.ChainUpMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractName))
            {
                query["ContractName"] = request.ContractName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractTemplateId))
            {
                query["ContractTemplateId"] = request.ContractTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                query["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivacyRuleId))
            {
                query["PrivacyRuleId"] = request.PrivacyRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRouteRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRouteRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AddRouteRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRouteRuleResponse
        /// </returns>
        public AddRouteRuleResponse AddRouteRule(AddRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddRouteRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AddRouteRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRouteRuleResponse
        /// </returns>
        public async Task<AddRouteRuleResponse> AddRouteRuleAsync(AddRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddRouteRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成员同意接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgreeMemberAccessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgreeMemberAccessResponse
        /// </returns>
        public AgreeMemberAccessResponse AgreeMemberAccessWithOptions(AgreeMemberAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberAccountId))
            {
                query["MemberAccountId"] = request.MemberAccountId;
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
                Action = "AgreeMemberAccess",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgreeMemberAccessResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成员同意接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgreeMemberAccessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgreeMemberAccessResponse
        /// </returns>
        public async Task<AgreeMemberAccessResponse> AgreeMemberAccessWithOptionsAsync(AgreeMemberAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberAccountId))
            {
                query["MemberAccountId"] = request.MemberAccountId;
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
                Action = "AgreeMemberAccess",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgreeMemberAccessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成员同意接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgreeMemberAccessRequest
        /// </param>
        /// 
        /// <returns>
        /// AgreeMemberAccessResponse
        /// </returns>
        public AgreeMemberAccessResponse AgreeMemberAccess(AgreeMemberAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AgreeMemberAccessWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成员同意接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgreeMemberAccessRequest
        /// </param>
        /// 
        /// <returns>
        /// AgreeMemberAccessResponse
        /// </returns>
        public async Task<AgreeMemberAccessResponse> AgreeMemberAccessAsync(AgreeMemberAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AgreeMemberAccessWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AuthorizeBaaSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeBaaSResponse
        /// </returns>
        public AuthorizeBaaSResponse AuthorizeBaaSWithOptions(AuthorizeBaaSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AuthorizeBaaS",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeBaaSResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AuthorizeBaaSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeBaaSResponse
        /// </returns>
        public async Task<AuthorizeBaaSResponse> AuthorizeBaaSWithOptionsAsync(AuthorizeBaaSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AuthorizeBaaS",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeBaaSResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AuthorizeBaaSRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeBaaSResponse
        /// </returns>
        public AuthorizeBaaSResponse AuthorizeBaaS(AuthorizeBaaSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeBaaSWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AuthorizeBaaSRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeBaaSResponse
        /// </returns>
        public async Task<AuthorizeBaaSResponse> AuthorizeBaaSAsync(AuthorizeBaaSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeBaaSWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AuthorizeDeviceGroupBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeDeviceGroupBizChainResponse
        /// </returns>
        public AuthorizeDeviceGroupBizChainResponse AuthorizeDeviceGroupBizChainWithOptions(AuthorizeDeviceGroupBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainIdList))
            {
                query["BizChainIdList"] = request.BizChainIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
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
                Action = "AuthorizeDeviceGroupBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeDeviceGroupBizChainResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AuthorizeDeviceGroupBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeDeviceGroupBizChainResponse
        /// </returns>
        public async Task<AuthorizeDeviceGroupBizChainResponse> AuthorizeDeviceGroupBizChainWithOptionsAsync(AuthorizeDeviceGroupBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainIdList))
            {
                query["BizChainIdList"] = request.BizChainIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
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
                Action = "AuthorizeDeviceGroupBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeDeviceGroupBizChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AuthorizeDeviceGroupBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeDeviceGroupBizChainResponse
        /// </returns>
        public AuthorizeDeviceGroupBizChainResponse AuthorizeDeviceGroupBizChain(AuthorizeDeviceGroupBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeDeviceGroupBizChainWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AuthorizeDeviceGroupBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeDeviceGroupBizChainResponse
        /// </returns>
        public async Task<AuthorizeDeviceGroupBizChainResponse> AuthorizeDeviceGroupBizChainAsync(AuthorizeDeviceGroupBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeDeviceGroupBizChainWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AuthorizeMemberBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeMemberBizChainResponse
        /// </returns>
        public AuthorizeMemberBizChainResponse AuthorizeMemberBizChainWithOptions(AuthorizeMemberBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainInfo))
            {
                query["BizChainInfo"] = request.BizChainInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
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
                Action = "AuthorizeMemberBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeMemberBizChainResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AuthorizeMemberBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeMemberBizChainResponse
        /// </returns>
        public async Task<AuthorizeMemberBizChainResponse> AuthorizeMemberBizChainWithOptionsAsync(AuthorizeMemberBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainInfo))
            {
                query["BizChainInfo"] = request.BizChainInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
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
                Action = "AuthorizeMemberBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeMemberBizChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AuthorizeMemberBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeMemberBizChainResponse
        /// </returns>
        public AuthorizeMemberBizChainResponse AuthorizeMemberBizChain(AuthorizeMemberBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeMemberBizChainWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AuthorizeMemberBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeMemberBizChainResponse
        /// </returns>
        public async Task<AuthorizeMemberBizChainResponse> AuthorizeMemberBizChainAsync(AuthorizeMemberBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeMemberBizChainWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeletePrivacyRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePrivacyRuleResponse
        /// </returns>
        public DeletePrivacyRuleResponse DeletePrivacyRuleWithOptions(DeletePrivacyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivacyRuleId))
            {
                query["PrivacyRuleId"] = request.PrivacyRuleId;
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
                Action = "DeletePrivacyRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePrivacyRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeletePrivacyRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePrivacyRuleResponse
        /// </returns>
        public async Task<DeletePrivacyRuleResponse> DeletePrivacyRuleWithOptionsAsync(DeletePrivacyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivacyRuleId))
            {
                query["PrivacyRuleId"] = request.PrivacyRuleId;
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
                Action = "DeletePrivacyRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePrivacyRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeletePrivacyRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePrivacyRuleResponse
        /// </returns>
        public DeletePrivacyRuleResponse DeletePrivacyRule(DeletePrivacyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePrivacyRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeletePrivacyRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePrivacyRuleResponse
        /// </returns>
        public async Task<DeletePrivacyRuleResponse> DeletePrivacyRuleAsync(DeletePrivacyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePrivacyRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteRouteRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRouteRuleResponse
        /// </returns>
        public DeleteRouteRuleResponse DeleteRouteRuleWithOptions(DeleteRouteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                query["RouteRuleId"] = request.RouteRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRouteRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRouteRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteRouteRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRouteRuleResponse
        /// </returns>
        public async Task<DeleteRouteRuleResponse> DeleteRouteRuleWithOptionsAsync(DeleteRouteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                query["RouteRuleId"] = request.RouteRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRouteRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRouteRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteRouteRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRouteRuleResponse
        /// </returns>
        public DeleteRouteRuleResponse DeleteRouteRule(DeleteRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRouteRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteRouteRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRouteRuleResponse
        /// </returns>
        public async Task<DeleteRouteRuleResponse> DeleteRouteRuleAsync(DeleteRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRouteRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成员拒绝接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeniedMemberAccessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeniedMemberAccessResponse
        /// </returns>
        public DeniedMemberAccessResponse DeniedMemberAccessWithOptions(DeniedMemberAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberAccountId))
            {
                query["MemberAccountId"] = request.MemberAccountId;
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
                Action = "DeniedMemberAccess",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeniedMemberAccessResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成员拒绝接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeniedMemberAccessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeniedMemberAccessResponse
        /// </returns>
        public async Task<DeniedMemberAccessResponse> DeniedMemberAccessWithOptionsAsync(DeniedMemberAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberAccountId))
            {
                query["MemberAccountId"] = request.MemberAccountId;
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
                Action = "DeniedMemberAccess",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeniedMemberAccessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成员拒绝接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeniedMemberAccessRequest
        /// </param>
        /// 
        /// <returns>
        /// DeniedMemberAccessResponse
        /// </returns>
        public DeniedMemberAccessResponse DeniedMemberAccess(DeniedMemberAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeniedMemberAccessWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成员拒绝接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeniedMemberAccessRequest
        /// </param>
        /// 
        /// <returns>
        /// DeniedMemberAccessResponse
        /// </returns>
        public async Task<DeniedMemberAccessResponse> DeniedMemberAccessAsync(DeniedMemberAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeniedMemberAccessWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeAccountRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccountRoleResponse
        /// </returns>
        public DescribeAccountRoleResponse DescribeAccountRoleWithOptions(DescribeAccountRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeAccountRole",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeAccountRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccountRoleResponse
        /// </returns>
        public async Task<DescribeAccountRoleResponse> DescribeAccountRoleWithOptionsAsync(DescribeAccountRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeAccountRole",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeAccountRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccountRoleResponse
        /// </returns>
        public DescribeAccountRoleResponse DescribeAccountRole(DescribeAccountRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountRoleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeAccountRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccountRoleResponse
        /// </returns>
        public async Task<DescribeAccountRoleResponse> DescribeAccountRoleAsync(DescribeAccountRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountRoleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询管理方信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdminInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdminInfoResponse
        /// </returns>
        public DescribeAdminInfoResponse DescribeAdminInfoWithOptions(DescribeAdminInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeAdminInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAdminInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询管理方信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdminInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdminInfoResponse
        /// </returns>
        public async Task<DescribeAdminInfoResponse> DescribeAdminInfoWithOptionsAsync(DescribeAdminInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeAdminInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAdminInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询管理方信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdminInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdminInfoResponse
        /// </returns>
        public DescribeAdminInfoResponse DescribeAdminInfo(DescribeAdminInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAdminInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询管理方信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdminInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdminInfoResponse
        /// </returns>
        public async Task<DescribeAdminInfoResponse> DescribeAdminInfoAsync(DescribeAdminInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAdminInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeBizChainStatInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBizChainStatInfoResponse
        /// </returns>
        public DescribeBizChainStatInfoResponse DescribeBizChainStatInfoWithOptions(DescribeBizChainStatInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeBizChainStatInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBizChainStatInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeBizChainStatInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBizChainStatInfoResponse
        /// </returns>
        public async Task<DescribeBizChainStatInfoResponse> DescribeBizChainStatInfoWithOptionsAsync(DescribeBizChainStatInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeBizChainStatInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBizChainStatInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeBizChainStatInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBizChainStatInfoResponse
        /// </returns>
        public DescribeBizChainStatInfoResponse DescribeBizChainStatInfo(DescribeBizChainStatInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBizChainStatInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeBizChainStatInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBizChainStatInfoResponse
        /// </returns>
        public async Task<DescribeBizChainStatInfoResponse> DescribeBizChainStatInfoAsync(DescribeBizChainStatInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBizChainStatInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览API信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardApiInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardApiInfoResponse
        /// </returns>
        public DescribeDashboardApiInfoResponse DescribeDashboardApiInfoWithOptions(DescribeDashboardApiInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDashboardApiInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDashboardApiInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览API信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardApiInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardApiInfoResponse
        /// </returns>
        public async Task<DescribeDashboardApiInfoResponse> DescribeDashboardApiInfoWithOptionsAsync(DescribeDashboardApiInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDashboardApiInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDashboardApiInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览API信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardApiInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardApiInfoResponse
        /// </returns>
        public DescribeDashboardApiInfoResponse DescribeDashboardApiInfo(DescribeDashboardApiInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDashboardApiInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览API信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardApiInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardApiInfoResponse
        /// </returns>
        public async Task<DescribeDashboardApiInfoResponse> DescribeDashboardApiInfoAsync(DescribeDashboardApiInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDashboardApiInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardBaseInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardBaseInfoResponse
        /// </returns>
        public DescribeDashboardBaseInfoResponse DescribeDashboardBaseInfoWithOptions(DescribeDashboardBaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDashboardBaseInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDashboardBaseInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardBaseInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardBaseInfoResponse
        /// </returns>
        public async Task<DescribeDashboardBaseInfoResponse> DescribeDashboardBaseInfoWithOptionsAsync(DescribeDashboardBaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDashboardBaseInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDashboardBaseInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardBaseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardBaseInfoResponse
        /// </returns>
        public DescribeDashboardBaseInfoResponse DescribeDashboardBaseInfo(DescribeDashboardBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDashboardBaseInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardBaseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardBaseInfoResponse
        /// </returns>
        public async Task<DescribeDashboardBaseInfoResponse> DescribeDashboardBaseInfoAsync(DescribeDashboardBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDashboardBaseInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardDeviceInfoResponse
        /// </returns>
        public DescribeDashboardDeviceInfoResponse DescribeDashboardDeviceInfoWithOptions(DescribeDashboardDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDashboardDeviceInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDashboardDeviceInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardDeviceInfoResponse
        /// </returns>
        public async Task<DescribeDashboardDeviceInfoResponse> DescribeDashboardDeviceInfoWithOptionsAsync(DescribeDashboardDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDashboardDeviceInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDashboardDeviceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardDeviceInfoResponse
        /// </returns>
        public DescribeDashboardDeviceInfoResponse DescribeDashboardDeviceInfo(DescribeDashboardDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDashboardDeviceInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardDeviceInfoResponse
        /// </returns>
        public async Task<DescribeDashboardDeviceInfoResponse> DescribeDashboardDeviceInfoAsync(DescribeDashboardDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDashboardDeviceInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览成员API信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardMemberApiInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardMemberApiInfoResponse
        /// </returns>
        public DescribeDashboardMemberApiInfoResponse DescribeDashboardMemberApiInfoWithOptions(DescribeDashboardMemberApiInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeDashboardMemberApiInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDashboardMemberApiInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览成员API信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardMemberApiInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardMemberApiInfoResponse
        /// </returns>
        public async Task<DescribeDashboardMemberApiInfoResponse> DescribeDashboardMemberApiInfoWithOptionsAsync(DescribeDashboardMemberApiInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeDashboardMemberApiInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDashboardMemberApiInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览成员API信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardMemberApiInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardMemberApiInfoResponse
        /// </returns>
        public DescribeDashboardMemberApiInfoResponse DescribeDashboardMemberApiInfo(DescribeDashboardMemberApiInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDashboardMemberApiInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览成员API信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardMemberApiInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardMemberApiInfoResponse
        /// </returns>
        public async Task<DescribeDashboardMemberApiInfoResponse> DescribeDashboardMemberApiInfoAsync(DescribeDashboardMemberApiInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDashboardMemberApiInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览成员设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardMemberDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardMemberDeviceInfoResponse
        /// </returns>
        public DescribeDashboardMemberDeviceInfoResponse DescribeDashboardMemberDeviceInfoWithOptions(DescribeDashboardMemberDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeDashboardMemberDeviceInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDashboardMemberDeviceInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览成员设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardMemberDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardMemberDeviceInfoResponse
        /// </returns>
        public async Task<DescribeDashboardMemberDeviceInfoResponse> DescribeDashboardMemberDeviceInfoWithOptionsAsync(DescribeDashboardMemberDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeDashboardMemberDeviceInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDashboardMemberDeviceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览成员设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardMemberDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardMemberDeviceInfoResponse
        /// </returns>
        public DescribeDashboardMemberDeviceInfoResponse DescribeDashboardMemberDeviceInfo(DescribeDashboardMemberDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDashboardMemberDeviceInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询概览成员设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDashboardMemberDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDashboardMemberDeviceInfoResponse
        /// </returns>
        public async Task<DescribeDashboardMemberDeviceInfoResponse> DescribeDashboardMemberDeviceInfoAsync(DescribeDashboardMemberDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDashboardMemberDeviceInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeviceInfoResponse
        /// </returns>
        public DescribeDeviceInfoResponse DescribeDeviceInfoWithOptions(DescribeDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDeviceInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeviceInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeviceInfoResponse
        /// </returns>
        public async Task<DescribeDeviceInfoResponse> DescribeDeviceInfoWithOptionsAsync(DescribeDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDeviceInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeviceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeviceInfoResponse
        /// </returns>
        public DescribeDeviceInfoResponse DescribeDeviceInfo(DescribeDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeviceInfoResponse
        /// </returns>
        public async Task<DescribeDeviceInfoResponse> DescribeDeviceInfoAsync(DescribeDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询边缘一体机统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEdgeStatInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEdgeStatInfoResponse
        /// </returns>
        public DescribeEdgeStatInfoResponse DescribeEdgeStatInfoWithOptions(DescribeEdgeStatInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdgeDn))
            {
                query["EdgeDn"] = request.EdgeDn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdgePk))
            {
                query["EdgePk"] = request.EdgePk;
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
                Action = "DescribeEdgeStatInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdgeStatInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询边缘一体机统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEdgeStatInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEdgeStatInfoResponse
        /// </returns>
        public async Task<DescribeEdgeStatInfoResponse> DescribeEdgeStatInfoWithOptionsAsync(DescribeEdgeStatInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdgeDn))
            {
                query["EdgeDn"] = request.EdgeDn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdgePk))
            {
                query["EdgePk"] = request.EdgePk;
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
                Action = "DescribeEdgeStatInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdgeStatInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询边缘一体机统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEdgeStatInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEdgeStatInfoResponse
        /// </returns>
        public DescribeEdgeStatInfoResponse DescribeEdgeStatInfo(DescribeEdgeStatInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEdgeStatInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询边缘一体机统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEdgeStatInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEdgeStatInfoResponse
        /// </returns>
        public async Task<DescribeEdgeStatInfoResponse> DescribeEdgeStatInfoAsync(DescribeEdgeStatInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEdgeStatInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeMemberBizChainStatInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMemberBizChainStatInfoResponse
        /// </returns>
        public DescribeMemberBizChainStatInfoResponse DescribeMemberBizChainStatInfoWithOptions(DescribeMemberBizChainStatInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
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
                Action = "DescribeMemberBizChainStatInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMemberBizChainStatInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeMemberBizChainStatInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMemberBizChainStatInfoResponse
        /// </returns>
        public async Task<DescribeMemberBizChainStatInfoResponse> DescribeMemberBizChainStatInfoWithOptionsAsync(DescribeMemberBizChainStatInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
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
                Action = "DescribeMemberBizChainStatInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMemberBizChainStatInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeMemberBizChainStatInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMemberBizChainStatInfoResponse
        /// </returns>
        public DescribeMemberBizChainStatInfoResponse DescribeMemberBizChainStatInfo(DescribeMemberBizChainStatInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMemberBizChainStatInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeMemberBizChainStatInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMemberBizChainStatInfoResponse
        /// </returns>
        public async Task<DescribeMemberBizChainStatInfoResponse> DescribeMemberBizChainStatInfoAsync(DescribeMemberBizChainStatInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMemberBizChainStatInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询统计成员API信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMemberStatInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMemberStatInfoResponse
        /// </returns>
        public DescribeMemberStatInfoResponse DescribeMemberStatInfoWithOptions(DescribeMemberStatInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
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
                Action = "DescribeMemberStatInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMemberStatInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询统计成员API信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMemberStatInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMemberStatInfoResponse
        /// </returns>
        public async Task<DescribeMemberStatInfoResponse> DescribeMemberStatInfoWithOptionsAsync(DescribeMemberStatInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
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
                Action = "DescribeMemberStatInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMemberStatInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询统计成员API信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMemberStatInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMemberStatInfoResponse
        /// </returns>
        public DescribeMemberStatInfoResponse DescribeMemberStatInfo(DescribeMemberStatInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMemberStatInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询统计成员API信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMemberStatInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMemberStatInfoResponse
        /// </returns>
        public async Task<DescribeMemberStatInfoResponse> DescribeMemberStatInfoAsync(DescribeMemberStatInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMemberStatInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeMemberTotalStatInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMemberTotalStatInfoResponse
        /// </returns>
        public DescribeMemberTotalStatInfoResponse DescribeMemberTotalStatInfoWithOptions(DescribeMemberTotalStatInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
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
                Action = "DescribeMemberTotalStatInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMemberTotalStatInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeMemberTotalStatInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMemberTotalStatInfoResponse
        /// </returns>
        public async Task<DescribeMemberTotalStatInfoResponse> DescribeMemberTotalStatInfoWithOptionsAsync(DescribeMemberTotalStatInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
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
                Action = "DescribeMemberTotalStatInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMemberTotalStatInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeMemberTotalStatInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMemberTotalStatInfoResponse
        /// </returns>
        public DescribeMemberTotalStatInfoResponse DescribeMemberTotalStatInfo(DescribeMemberTotalStatInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMemberTotalStatInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeMemberTotalStatInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMemberTotalStatInfoResponse
        /// </returns>
        public async Task<DescribeMemberTotalStatInfoResponse> DescribeMemberTotalStatInfoAsync(DescribeMemberTotalStatInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMemberTotalStatInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribePackgeInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePackgeInfoResponse
        /// </returns>
        public DescribePackgeInfoResponse DescribePackgeInfoWithOptions(DescribePackgeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
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
                Action = "DescribePackgeInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePackgeInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribePackgeInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePackgeInfoResponse
        /// </returns>
        public async Task<DescribePackgeInfoResponse> DescribePackgeInfoWithOptionsAsync(DescribePackgeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
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
                Action = "DescribePackgeInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePackgeInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribePackgeInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePackgeInfoResponse
        /// </returns>
        public DescribePackgeInfoResponse DescribePackgeInfo(DescribePackgeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePackgeInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribePackgeInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePackgeInfoResponse
        /// </returns>
        public async Task<DescribePackgeInfoResponse> DescribePackgeInfoAsync(DescribePackgeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePackgeInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询统计设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStatDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeStatDeviceInfoResponse
        /// </returns>
        public DescribeStatDeviceInfoResponse DescribeStatDeviceInfoWithOptions(DescribeStatDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeStatDeviceInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStatDeviceInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询统计设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStatDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeStatDeviceInfoResponse
        /// </returns>
        public async Task<DescribeStatDeviceInfoResponse> DescribeStatDeviceInfoWithOptionsAsync(DescribeStatDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeStatDeviceInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStatDeviceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询统计设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStatDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeStatDeviceInfoResponse
        /// </returns>
        public DescribeStatDeviceInfoResponse DescribeStatDeviceInfo(DescribeStatDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStatDeviceInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询统计设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStatDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeStatDeviceInfoResponse
        /// </returns>
        public async Task<DescribeStatDeviceInfoResponse> DescribeStatDeviceInfoAsync(DescribeStatDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStatDeviceInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询统计成员设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStatMemberDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeStatMemberDeviceInfoResponse
        /// </returns>
        public DescribeStatMemberDeviceInfoResponse DescribeStatMemberDeviceInfoWithOptions(DescribeStatMemberDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeStatMemberDeviceInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStatMemberDeviceInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询统计成员设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStatMemberDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeStatMemberDeviceInfoResponse
        /// </returns>
        public async Task<DescribeStatMemberDeviceInfoResponse> DescribeStatMemberDeviceInfoWithOptionsAsync(DescribeStatMemberDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeStatMemberDeviceInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStatMemberDeviceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询统计成员设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStatMemberDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeStatMemberDeviceInfoResponse
        /// </returns>
        public DescribeStatMemberDeviceInfoResponse DescribeStatMemberDeviceInfo(DescribeStatMemberDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStatMemberDeviceInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询统计成员设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStatMemberDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeStatMemberDeviceInfoResponse
        /// </returns>
        public async Task<DescribeStatMemberDeviceInfoResponse> DescribeStatMemberDeviceInfoAsync(DescribeStatMemberDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStatMemberDeviceInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeTotalStatInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTotalStatInfoResponse
        /// </returns>
        public DescribeTotalStatInfoResponse DescribeTotalStatInfoWithOptions(DescribeTotalStatInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeTotalStatInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTotalStatInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeTotalStatInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTotalStatInfoResponse
        /// </returns>
        public async Task<DescribeTotalStatInfoResponse> DescribeTotalStatInfoWithOptionsAsync(DescribeTotalStatInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeTotalStatInfo",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTotalStatInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeTotalStatInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTotalStatInfoResponse
        /// </returns>
        public DescribeTotalStatInfoResponse DescribeTotalStatInfo(DescribeTotalStatInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTotalStatInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeTotalStatInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTotalStatInfoResponse
        /// </returns>
        public async Task<DescribeTotalStatInfoResponse> DescribeTotalStatInfoAsync(DescribeTotalStatInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTotalStatInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DisableDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableDeviceResponse
        /// </returns>
        public DisableDeviceResponse DisableDeviceWithOptions(DisableDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
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
                Action = "DisableDevice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableDeviceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DisableDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableDeviceResponse
        /// </returns>
        public async Task<DisableDeviceResponse> DisableDeviceWithOptionsAsync(DisableDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
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
                Action = "DisableDevice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DisableDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableDeviceResponse
        /// </returns>
        public DisableDeviceResponse DisableDevice(DisableDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableDeviceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DisableDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableDeviceResponse
        /// </returns>
        public async Task<DisableDeviceResponse> DisableDeviceAsync(DisableDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableDeviceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DisableDeviceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableDeviceGroupResponse
        /// </returns>
        public DisableDeviceGroupResponse DisableDeviceGroupWithOptions(DisableDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
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
                Action = "DisableDeviceGroup",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableDeviceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DisableDeviceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableDeviceGroupResponse
        /// </returns>
        public async Task<DisableDeviceGroupResponse> DisableDeviceGroupWithOptionsAsync(DisableDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
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
                Action = "DisableDeviceGroup",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableDeviceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DisableDeviceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableDeviceGroupResponse
        /// </returns>
        public DisableDeviceGroupResponse DisableDeviceGroup(DisableDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableDeviceGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DisableDeviceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableDeviceGroupResponse
        /// </returns>
        public async Task<DisableDeviceGroupResponse> DisableDeviceGroupAsync(DisableDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableDeviceGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DownloadPrivacyKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DownloadPrivacyKeyResponse
        /// </returns>
        public DownloadPrivacyKeyResponse DownloadPrivacyKeyWithOptions(DownloadPrivacyKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DownloadPrivacyKey",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadPrivacyKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DownloadPrivacyKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DownloadPrivacyKeyResponse
        /// </returns>
        public async Task<DownloadPrivacyKeyResponse> DownloadPrivacyKeyWithOptionsAsync(DownloadPrivacyKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DownloadPrivacyKey",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadPrivacyKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DownloadPrivacyKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DownloadPrivacyKeyResponse
        /// </returns>
        public DownloadPrivacyKeyResponse DownloadPrivacyKey(DownloadPrivacyKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadPrivacyKeyWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DownloadPrivacyKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DownloadPrivacyKeyResponse
        /// </returns>
        public async Task<DownloadPrivacyKeyResponse> DownloadPrivacyKeyAsync(DownloadPrivacyKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadPrivacyKeyWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// EnableDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableDeviceResponse
        /// </returns>
        public EnableDeviceResponse EnableDeviceWithOptions(EnableDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
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
                Action = "EnableDevice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableDeviceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// EnableDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableDeviceResponse
        /// </returns>
        public async Task<EnableDeviceResponse> EnableDeviceWithOptionsAsync(EnableDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
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
                Action = "EnableDevice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// EnableDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableDeviceResponse
        /// </returns>
        public EnableDeviceResponse EnableDevice(EnableDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableDeviceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// EnableDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableDeviceResponse
        /// </returns>
        public async Task<EnableDeviceResponse> EnableDeviceAsync(EnableDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableDeviceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// EnableDeviceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableDeviceGroupResponse
        /// </returns>
        public EnableDeviceGroupResponse EnableDeviceGroupWithOptions(EnableDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
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
                Action = "EnableDeviceGroup",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableDeviceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// EnableDeviceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableDeviceGroupResponse
        /// </returns>
        public async Task<EnableDeviceGroupResponse> EnableDeviceGroupWithOptionsAsync(EnableDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
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
                Action = "EnableDeviceGroup",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableDeviceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// EnableDeviceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableDeviceGroupResponse
        /// </returns>
        public EnableDeviceGroupResponse EnableDeviceGroup(EnableDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableDeviceGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// EnableDeviceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableDeviceGroupResponse
        /// </returns>
        public async Task<EnableDeviceGroupResponse> EnableDeviceGroupAsync(EnableDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableDeviceGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// FreezeMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FreezeMemberResponse
        /// </returns>
        public FreezeMemberResponse FreezeMemberWithOptions(FreezeMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
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
                Action = "FreezeMember",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FreezeMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// FreezeMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FreezeMemberResponse
        /// </returns>
        public async Task<FreezeMemberResponse> FreezeMemberWithOptionsAsync(FreezeMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
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
                Action = "FreezeMember",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FreezeMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// FreezeMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// FreezeMemberResponse
        /// </returns>
        public FreezeMemberResponse FreezeMember(FreezeMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FreezeMemberWithOptions(request, runtime);
        }

        /// <param name="request">
        /// FreezeMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// FreezeMemberResponse
        /// </returns>
        public async Task<FreezeMemberResponse> FreezeMemberAsync(FreezeMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FreezeMemberWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetEdgeTotalDeviceCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEdgeTotalDeviceCountResponse
        /// </returns>
        public GetEdgeTotalDeviceCountResponse GetEdgeTotalDeviceCountWithOptions(GetEdgeTotalDeviceCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetEdgeTotalDeviceCount",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEdgeTotalDeviceCountResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetEdgeTotalDeviceCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEdgeTotalDeviceCountResponse
        /// </returns>
        public async Task<GetEdgeTotalDeviceCountResponse> GetEdgeTotalDeviceCountWithOptionsAsync(GetEdgeTotalDeviceCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetEdgeTotalDeviceCount",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEdgeTotalDeviceCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetEdgeTotalDeviceCountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEdgeTotalDeviceCountResponse
        /// </returns>
        public GetEdgeTotalDeviceCountResponse GetEdgeTotalDeviceCount(GetEdgeTotalDeviceCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEdgeTotalDeviceCountWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetEdgeTotalDeviceCountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEdgeTotalDeviceCountResponse
        /// </returns>
        public async Task<GetEdgeTotalDeviceCountResponse> GetEdgeTotalDeviceCountAsync(GetEdgeTotalDeviceCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEdgeTotalDeviceCountWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListAllAdminRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllAdminResponse
        /// </returns>
        public ListAllAdminResponse ListAllAdminWithOptions(ListAllAdminRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllAdmin",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllAdminResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllAdminRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllAdminResponse
        /// </returns>
        public async Task<ListAllAdminResponse> ListAllAdminWithOptionsAsync(ListAllAdminRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllAdmin",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllAdminResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllAdminRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllAdminResponse
        /// </returns>
        public ListAllAdminResponse ListAllAdmin(ListAllAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllAdminWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListAllAdminRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllAdminResponse
        /// </returns>
        public async Task<ListAllAdminResponse> ListAllAdminAsync(ListAllAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllAdminWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListAllBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllBizChainResponse
        /// </returns>
        public ListAllBizChainResponse ListAllBizChainWithOptions(ListAllBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllBizChainResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllBizChainResponse
        /// </returns>
        public async Task<ListAllBizChainResponse> ListAllBizChainWithOptionsAsync(ListAllBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllBizChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllBizChainResponse
        /// </returns>
        public ListAllBizChainResponse ListAllBizChain(ListAllBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllBizChainWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListAllBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllBizChainResponse
        /// </returns>
        public async Task<ListAllBizChainResponse> ListAllBizChainAsync(ListAllBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllBizChainWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListAllBizChainContractRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllBizChainContractResponse
        /// </returns>
        public ListAllBizChainContractResponse ListAllBizChainContractWithOptions(ListAllBizChainContractRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
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
                Action = "ListAllBizChainContract",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllBizChainContractResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllBizChainContractRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllBizChainContractResponse
        /// </returns>
        public async Task<ListAllBizChainContractResponse> ListAllBizChainContractWithOptionsAsync(ListAllBizChainContractRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
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
                Action = "ListAllBizChainContract",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllBizChainContractResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllBizChainContractRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllBizChainContractResponse
        /// </returns>
        public ListAllBizChainContractResponse ListAllBizChainContract(ListAllBizChainContractRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllBizChainContractWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListAllBizChainContractRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllBizChainContractResponse
        /// </returns>
        public async Task<ListAllBizChainContractResponse> ListAllBizChainContractAsync(ListAllBizChainContractRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllBizChainContractWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListAllDeviceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllDeviceGroupResponse
        /// </returns>
        public ListAllDeviceGroupResponse ListAllDeviceGroupWithOptions(ListAllDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllDeviceGroup",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllDeviceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllDeviceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllDeviceGroupResponse
        /// </returns>
        public async Task<ListAllDeviceGroupResponse> ListAllDeviceGroupWithOptionsAsync(ListAllDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllDeviceGroup",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllDeviceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllDeviceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllDeviceGroupResponse
        /// </returns>
        public ListAllDeviceGroupResponse ListAllDeviceGroup(ListAllDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllDeviceGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListAllDeviceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllDeviceGroupResponse
        /// </returns>
        public async Task<ListAllDeviceGroupResponse> ListAllDeviceGroupAsync(ListAllDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllDeviceGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListAllMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllMemberResponse
        /// </returns>
        public ListAllMemberResponse ListAllMemberWithOptions(ListAllMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllMember",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllMemberResponse
        /// </returns>
        public async Task<ListAllMemberResponse> ListAllMemberWithOptionsAsync(ListAllMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllMember",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllMemberResponse
        /// </returns>
        public ListAllMemberResponse ListAllMember(ListAllMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllMemberWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListAllMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllMemberResponse
        /// </returns>
        public async Task<ListAllMemberResponse> ListAllMemberAsync(ListAllMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllMemberWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListAllPrivacyAlgorithmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllPrivacyAlgorithmResponse
        /// </returns>
        public ListAllPrivacyAlgorithmResponse ListAllPrivacyAlgorithmWithOptions(ListAllPrivacyAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllPrivacyAlgorithm",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllPrivacyAlgorithmResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllPrivacyAlgorithmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllPrivacyAlgorithmResponse
        /// </returns>
        public async Task<ListAllPrivacyAlgorithmResponse> ListAllPrivacyAlgorithmWithOptionsAsync(ListAllPrivacyAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllPrivacyAlgorithm",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllPrivacyAlgorithmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllPrivacyAlgorithmRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllPrivacyAlgorithmResponse
        /// </returns>
        public ListAllPrivacyAlgorithmResponse ListAllPrivacyAlgorithm(ListAllPrivacyAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllPrivacyAlgorithmWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListAllPrivacyAlgorithmRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllPrivacyAlgorithmResponse
        /// </returns>
        public async Task<ListAllPrivacyAlgorithmResponse> ListAllPrivacyAlgorithmAsync(ListAllPrivacyAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllPrivacyAlgorithmWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListAllPrivacyRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllPrivacyRuleResponse
        /// </returns>
        public ListAllPrivacyRuleResponse ListAllPrivacyRuleWithOptions(ListAllPrivacyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllPrivacyRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllPrivacyRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllPrivacyRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllPrivacyRuleResponse
        /// </returns>
        public async Task<ListAllPrivacyRuleResponse> ListAllPrivacyRuleWithOptionsAsync(ListAllPrivacyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllPrivacyRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllPrivacyRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllPrivacyRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllPrivacyRuleResponse
        /// </returns>
        public ListAllPrivacyRuleResponse ListAllPrivacyRule(ListAllPrivacyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllPrivacyRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListAllPrivacyRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllPrivacyRuleResponse
        /// </returns>
        public async Task<ListAllPrivacyRuleResponse> ListAllPrivacyRuleAsync(ListAllPrivacyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllPrivacyRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListAllProductKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllProductKeyResponse
        /// </returns>
        public ListAllProductKeyResponse ListAllProductKeyWithOptions(ListAllProductKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllProductKey",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllProductKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllProductKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllProductKeyResponse
        /// </returns>
        public async Task<ListAllProductKeyResponse> ListAllProductKeyWithOptionsAsync(ListAllProductKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllProductKey",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllProductKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllProductKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllProductKeyResponse
        /// </returns>
        public ListAllProductKeyResponse ListAllProductKey(ListAllProductKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllProductKeyWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListAllProductKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllProductKeyResponse
        /// </returns>
        public async Task<ListAllProductKeyResponse> ListAllProductKeyAsync(ListAllProductKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllProductKeyWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListAllSystemContractRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllSystemContractResponse
        /// </returns>
        public ListAllSystemContractResponse ListAllSystemContractWithOptions(ListAllSystemContractRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockChainType))
            {
                query["BlockChainType"] = request.BlockChainType;
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
                Action = "ListAllSystemContract",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllSystemContractResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllSystemContractRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllSystemContractResponse
        /// </returns>
        public async Task<ListAllSystemContractResponse> ListAllSystemContractWithOptionsAsync(ListAllSystemContractRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockChainType))
            {
                query["BlockChainType"] = request.BlockChainType;
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
                Action = "ListAllSystemContract",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllSystemContractResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAllSystemContractRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllSystemContractResponse
        /// </returns>
        public ListAllSystemContractResponse ListAllSystemContract(ListAllSystemContractRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllSystemContractWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListAllSystemContractRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllSystemContractResponse
        /// </returns>
        public async Task<ListAllSystemContractResponse> ListAllSystemContractAsync(ListAllSystemContractRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllSystemContractWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListBaaSAntChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSAntChainResponse
        /// </returns>
        public ListBaaSAntChainResponse ListBaaSAntChainWithOptions(ListBaaSAntChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSAntChainConsortiumId))
            {
                query["BaaSAntChainConsortiumId"] = request.BaaSAntChainConsortiumId;
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
                Action = "ListBaaSAntChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBaaSAntChainResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListBaaSAntChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSAntChainResponse
        /// </returns>
        public async Task<ListBaaSAntChainResponse> ListBaaSAntChainWithOptionsAsync(ListBaaSAntChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSAntChainConsortiumId))
            {
                query["BaaSAntChainConsortiumId"] = request.BaaSAntChainConsortiumId;
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
                Action = "ListBaaSAntChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBaaSAntChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListBaaSAntChainRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSAntChainResponse
        /// </returns>
        public ListBaaSAntChainResponse ListBaaSAntChain(ListBaaSAntChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBaaSAntChainWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListBaaSAntChainRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSAntChainResponse
        /// </returns>
        public async Task<ListBaaSAntChainResponse> ListBaaSAntChainAsync(ListBaaSAntChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBaaSAntChainWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListBaaSAntChainConsortiumRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSAntChainConsortiumResponse
        /// </returns>
        public ListBaaSAntChainConsortiumResponse ListBaaSAntChainConsortiumWithOptions(ListBaaSAntChainConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListBaaSAntChainConsortium",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBaaSAntChainConsortiumResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListBaaSAntChainConsortiumRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSAntChainConsortiumResponse
        /// </returns>
        public async Task<ListBaaSAntChainConsortiumResponse> ListBaaSAntChainConsortiumWithOptionsAsync(ListBaaSAntChainConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListBaaSAntChainConsortium",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBaaSAntChainConsortiumResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListBaaSAntChainConsortiumRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSAntChainConsortiumResponse
        /// </returns>
        public ListBaaSAntChainConsortiumResponse ListBaaSAntChainConsortium(ListBaaSAntChainConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBaaSAntChainConsortiumWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListBaaSAntChainConsortiumRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSAntChainConsortiumResponse
        /// </returns>
        public async Task<ListBaaSAntChainConsortiumResponse> ListBaaSAntChainConsortiumAsync(ListBaaSAntChainConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBaaSAntChainConsortiumWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListBaaSAntChainPeerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSAntChainPeerResponse
        /// </returns>
        public ListBaaSAntChainPeerResponse ListBaaSAntChainPeerWithOptions(ListBaaSAntChainPeerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSAntChainChainId))
            {
                query["BaaSAntChainChainId"] = request.BaaSAntChainChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSAntChainConsortiumId))
            {
                query["BaaSAntChainConsortiumId"] = request.BaaSAntChainConsortiumId;
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
                Action = "ListBaaSAntChainPeer",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBaaSAntChainPeerResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListBaaSAntChainPeerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSAntChainPeerResponse
        /// </returns>
        public async Task<ListBaaSAntChainPeerResponse> ListBaaSAntChainPeerWithOptionsAsync(ListBaaSAntChainPeerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSAntChainChainId))
            {
                query["BaaSAntChainChainId"] = request.BaaSAntChainChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSAntChainConsortiumId))
            {
                query["BaaSAntChainConsortiumId"] = request.BaaSAntChainConsortiumId;
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
                Action = "ListBaaSAntChainPeer",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBaaSAntChainPeerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListBaaSAntChainPeerRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSAntChainPeerResponse
        /// </returns>
        public ListBaaSAntChainPeerResponse ListBaaSAntChainPeer(ListBaaSAntChainPeerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBaaSAntChainPeerWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListBaaSAntChainPeerRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSAntChainPeerResponse
        /// </returns>
        public async Task<ListBaaSAntChainPeerResponse> ListBaaSAntChainPeerAsync(ListBaaSAntChainPeerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBaaSAntChainPeerWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListBaaSFabricChannelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSFabricChannelResponse
        /// </returns>
        public ListBaaSFabricChannelResponse ListBaaSFabricChannelWithOptions(ListBaaSFabricChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSFabricConsortiumId))
            {
                query["BaaSFabricConsortiumId"] = request.BaaSFabricConsortiumId;
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
                Action = "ListBaaSFabricChannel",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBaaSFabricChannelResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListBaaSFabricChannelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSFabricChannelResponse
        /// </returns>
        public async Task<ListBaaSFabricChannelResponse> ListBaaSFabricChannelWithOptionsAsync(ListBaaSFabricChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSFabricConsortiumId))
            {
                query["BaaSFabricConsortiumId"] = request.BaaSFabricConsortiumId;
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
                Action = "ListBaaSFabricChannel",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBaaSFabricChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListBaaSFabricChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSFabricChannelResponse
        /// </returns>
        public ListBaaSFabricChannelResponse ListBaaSFabricChannel(ListBaaSFabricChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBaaSFabricChannelWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListBaaSFabricChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSFabricChannelResponse
        /// </returns>
        public async Task<ListBaaSFabricChannelResponse> ListBaaSFabricChannelAsync(ListBaaSFabricChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBaaSFabricChannelWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListBaaSFabricConsortiumRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSFabricConsortiumResponse
        /// </returns>
        public ListBaaSFabricConsortiumResponse ListBaaSFabricConsortiumWithOptions(ListBaaSFabricConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListBaaSFabricConsortium",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBaaSFabricConsortiumResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListBaaSFabricConsortiumRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSFabricConsortiumResponse
        /// </returns>
        public async Task<ListBaaSFabricConsortiumResponse> ListBaaSFabricConsortiumWithOptionsAsync(ListBaaSFabricConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListBaaSFabricConsortium",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBaaSFabricConsortiumResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListBaaSFabricConsortiumRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSFabricConsortiumResponse
        /// </returns>
        public ListBaaSFabricConsortiumResponse ListBaaSFabricConsortium(ListBaaSFabricConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBaaSFabricConsortiumWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListBaaSFabricConsortiumRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSFabricConsortiumResponse
        /// </returns>
        public async Task<ListBaaSFabricConsortiumResponse> ListBaaSFabricConsortiumAsync(ListBaaSFabricConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBaaSFabricConsortiumWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListBaaSFabricOrganizationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSFabricOrganizationResponse
        /// </returns>
        public ListBaaSFabricOrganizationResponse ListBaaSFabricOrganizationWithOptions(ListBaaSFabricOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSFabricChannelId))
            {
                query["BaaSFabricChannelId"] = request.BaaSFabricChannelId;
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
                Action = "ListBaaSFabricOrganization",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBaaSFabricOrganizationResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListBaaSFabricOrganizationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSFabricOrganizationResponse
        /// </returns>
        public async Task<ListBaaSFabricOrganizationResponse> ListBaaSFabricOrganizationWithOptionsAsync(ListBaaSFabricOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaaSFabricChannelId))
            {
                query["BaaSFabricChannelId"] = request.BaaSFabricChannelId;
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
                Action = "ListBaaSFabricOrganization",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBaaSFabricOrganizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListBaaSFabricOrganizationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSFabricOrganizationResponse
        /// </returns>
        public ListBaaSFabricOrganizationResponse ListBaaSFabricOrganization(ListBaaSFabricOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBaaSFabricOrganizationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListBaaSFabricOrganizationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBaaSFabricOrganizationResponse
        /// </returns>
        public async Task<ListBaaSFabricOrganizationResponse> ListBaaSFabricOrganizationAsync(ListBaaSFabricOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBaaSFabricOrganizationWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBizChainResponse
        /// </returns>
        public ListBizChainResponse ListBizChainWithOptions(ListBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBizChainResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBizChainResponse
        /// </returns>
        public async Task<ListBizChainResponse> ListBizChainWithOptionsAsync(ListBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBizChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBizChainResponse
        /// </returns>
        public ListBizChainResponse ListBizChain(ListBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBizChainWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBizChainResponse
        /// </returns>
        public async Task<ListBizChainResponse> ListBizChainAsync(ListBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBizChainWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListBizChainDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBizChainDataResponse
        /// </returns>
        public ListBizChainDataResponse ListBizChainDataWithOptions(ListBizChainDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTDataDID))
            {
                query["IoTDataDID"] = request.IoTDataDID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
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
                Action = "ListBizChainData",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBizChainDataResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListBizChainDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBizChainDataResponse
        /// </returns>
        public async Task<ListBizChainDataResponse> ListBizChainDataWithOptionsAsync(ListBizChainDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTDataDID))
            {
                query["IoTDataDID"] = request.IoTDataDID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
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
                Action = "ListBizChainData",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBizChainDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListBizChainDataRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBizChainDataResponse
        /// </returns>
        public ListBizChainDataResponse ListBizChainData(ListBizChainDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBizChainDataWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListBizChainDataRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBizChainDataResponse
        /// </returns>
        public async Task<ListBizChainDataResponse> ListBizChainDataAsync(ListBizChainDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBizChainDataWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceResponse
        /// </returns>
        public ListDeviceResponse ListDeviceWithOptions(ListDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDevice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceResponse
        /// </returns>
        public async Task<ListDeviceResponse> ListDeviceWithOptionsAsync(ListDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDevice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceResponse
        /// </returns>
        public ListDeviceResponse ListDevice(ListDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceResponse
        /// </returns>
        public async Task<ListDeviceResponse> ListDeviceAsync(ListDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeviceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceGroupResponse
        /// </returns>
        public ListDeviceGroupResponse ListDeviceGroupWithOptions(ListDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                query["MemberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
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
                Action = "ListDeviceGroup",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeviceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceGroupResponse
        /// </returns>
        public async Task<ListDeviceGroupResponse> ListDeviceGroupWithOptionsAsync(ListDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                query["MemberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
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
                Action = "ListDeviceGroup",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeviceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceGroupResponse
        /// </returns>
        public ListDeviceGroupResponse ListDeviceGroup(ListDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeviceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceGroupResponse
        /// </returns>
        public async Task<ListDeviceGroupResponse> ListDeviceGroupAsync(ListDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListDeviceGroupAuthorizedBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceGroupAuthorizedBizChainResponse
        /// </returns>
        public ListDeviceGroupAuthorizedBizChainResponse ListDeviceGroupAuthorizedBizChainWithOptions(ListDeviceGroupAuthorizedBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
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
                Action = "ListDeviceGroupAuthorizedBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceGroupAuthorizedBizChainResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListDeviceGroupAuthorizedBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceGroupAuthorizedBizChainResponse
        /// </returns>
        public async Task<ListDeviceGroupAuthorizedBizChainResponse> ListDeviceGroupAuthorizedBizChainWithOptionsAsync(ListDeviceGroupAuthorizedBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
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
                Action = "ListDeviceGroupAuthorizedBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceGroupAuthorizedBizChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListDeviceGroupAuthorizedBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceGroupAuthorizedBizChainResponse
        /// </returns>
        public ListDeviceGroupAuthorizedBizChainResponse ListDeviceGroupAuthorizedBizChain(ListDeviceGroupAuthorizedBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceGroupAuthorizedBizChainWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListDeviceGroupAuthorizedBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceGroupAuthorizedBizChainResponse
        /// </returns>
        public async Task<ListDeviceGroupAuthorizedBizChainResponse> ListDeviceGroupAuthorizedBizChainAsync(ListDeviceGroupAuthorizedBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceGroupAuthorizedBizChainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询边缘设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeDeviceResponse
        /// </returns>
        public ListEdgeDeviceResponse ListEdgeDeviceWithOptions(ListEdgeDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEdgeDevice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEdgeDeviceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询边缘设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeDeviceResponse
        /// </returns>
        public async Task<ListEdgeDeviceResponse> ListEdgeDeviceWithOptionsAsync(ListEdgeDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEdgeDevice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEdgeDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询边缘设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeDeviceResponse
        /// </returns>
        public ListEdgeDeviceResponse ListEdgeDevice(ListEdgeDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEdgeDeviceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询边缘设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeDeviceResponse
        /// </returns>
        public async Task<ListEdgeDeviceResponse> ListEdgeDeviceAsync(ListEdgeDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEdgeDeviceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询边缘设备组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeDeviceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeDeviceGroupResponse
        /// </returns>
        public ListEdgeDeviceGroupResponse ListEdgeDeviceGroupWithOptions(ListEdgeDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
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
                Action = "ListEdgeDeviceGroup",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEdgeDeviceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询边缘设备组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeDeviceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeDeviceGroupResponse
        /// </returns>
        public async Task<ListEdgeDeviceGroupResponse> ListEdgeDeviceGroupWithOptionsAsync(ListEdgeDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
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
                Action = "ListEdgeDeviceGroup",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEdgeDeviceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询边缘设备组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeDeviceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeDeviceGroupResponse
        /// </returns>
        public ListEdgeDeviceGroupResponse ListEdgeDeviceGroup(ListEdgeDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEdgeDeviceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询边缘设备组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEdgeDeviceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEdgeDeviceGroupResponse
        /// </returns>
        public async Task<ListEdgeDeviceGroupResponse> ListEdgeDeviceGroupAsync(ListEdgeDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEdgeDeviceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMemberResponse
        /// </returns>
        public ListMemberResponse ListMemberWithOptions(ListMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contactor))
            {
                query["Contactor"] = request.Contactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMember",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMemberResponse
        /// </returns>
        public async Task<ListMemberResponse> ListMemberWithOptionsAsync(ListMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contactor))
            {
                query["Contactor"] = request.Contactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMember",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMemberResponse
        /// </returns>
        public ListMemberResponse ListMember(ListMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMemberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMemberResponse
        /// </returns>
        public async Task<ListMemberResponse> ListMemberAsync(ListMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMemberWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询成员接入记录分页列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemberAccessRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMemberAccessRecordResponse
        /// </returns>
        public ListMemberAccessRecordResponse ListMemberAccessRecordWithOptions(ListMemberAccessRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessStatus))
            {
                query["AccessStatus"] = request.AccessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contactor))
            {
                query["Contactor"] = request.Contactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMemberAccessRecord",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemberAccessRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询成员接入记录分页列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemberAccessRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMemberAccessRecordResponse
        /// </returns>
        public async Task<ListMemberAccessRecordResponse> ListMemberAccessRecordWithOptionsAsync(ListMemberAccessRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessStatus))
            {
                query["AccessStatus"] = request.AccessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contactor))
            {
                query["Contactor"] = request.Contactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMemberAccessRecord",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemberAccessRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询成员接入记录分页列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemberAccessRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMemberAccessRecordResponse
        /// </returns>
        public ListMemberAccessRecordResponse ListMemberAccessRecord(ListMemberAccessRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMemberAccessRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询成员接入记录分页列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemberAccessRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMemberAccessRecordResponse
        /// </returns>
        public async Task<ListMemberAccessRecordResponse> ListMemberAccessRecordAsync(ListMemberAccessRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMemberAccessRecordWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListMemberAuthorizedBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMemberAuthorizedBizChainResponse
        /// </returns>
        public ListMemberAuthorizedBizChainResponse ListMemberAuthorizedBizChainWithOptions(ListMemberAuthorizedBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
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
                Action = "ListMemberAuthorizedBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemberAuthorizedBizChainResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMemberAuthorizedBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMemberAuthorizedBizChainResponse
        /// </returns>
        public async Task<ListMemberAuthorizedBizChainResponse> ListMemberAuthorizedBizChainWithOptionsAsync(ListMemberAuthorizedBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
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
                Action = "ListMemberAuthorizedBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemberAuthorizedBizChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMemberAuthorizedBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMemberAuthorizedBizChainResponse
        /// </returns>
        public ListMemberAuthorizedBizChainResponse ListMemberAuthorizedBizChain(ListMemberAuthorizedBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMemberAuthorizedBizChainWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListMemberAuthorizedBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMemberAuthorizedBizChainResponse
        /// </returns>
        public async Task<ListMemberAuthorizedBizChainResponse> ListMemberAuthorizedBizChainAsync(ListMemberAuthorizedBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMemberAuthorizedBizChainWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListPrivacyRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrivacyRuleResponse
        /// </returns>
        public ListPrivacyRuleResponse ListPrivacyRuleWithOptions(ListPrivacyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrivacyRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivacyRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListPrivacyRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrivacyRuleResponse
        /// </returns>
        public async Task<ListPrivacyRuleResponse> ListPrivacyRuleWithOptionsAsync(ListPrivacyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrivacyRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivacyRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListPrivacyRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrivacyRuleResponse
        /// </returns>
        public ListPrivacyRuleResponse ListPrivacyRule(ListPrivacyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPrivacyRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListPrivacyRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrivacyRuleResponse
        /// </returns>
        public async Task<ListPrivacyRuleResponse> ListPrivacyRuleAsync(ListPrivacyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPrivacyRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListPrivacyRuleSharedMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrivacyRuleSharedMemberResponse
        /// </returns>
        public ListPrivacyRuleSharedMemberResponse ListPrivacyRuleSharedMemberWithOptions(ListPrivacyRuleSharedMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivacyRuleId))
            {
                query["PrivacyRuleId"] = request.PrivacyRuleId;
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
                Action = "ListPrivacyRuleSharedMember",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivacyRuleSharedMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListPrivacyRuleSharedMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrivacyRuleSharedMemberResponse
        /// </returns>
        public async Task<ListPrivacyRuleSharedMemberResponse> ListPrivacyRuleSharedMemberWithOptionsAsync(ListPrivacyRuleSharedMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivacyRuleId))
            {
                query["PrivacyRuleId"] = request.PrivacyRuleId;
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
                Action = "ListPrivacyRuleSharedMember",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivacyRuleSharedMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListPrivacyRuleSharedMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrivacyRuleSharedMemberResponse
        /// </returns>
        public ListPrivacyRuleSharedMemberResponse ListPrivacyRuleSharedMember(ListPrivacyRuleSharedMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPrivacyRuleSharedMemberWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListPrivacyRuleSharedMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrivacyRuleSharedMemberResponse
        /// </returns>
        public async Task<ListPrivacyRuleSharedMemberResponse> ListPrivacyRuleSharedMemberAsync(ListPrivacyRuleSharedMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPrivacyRuleSharedMemberWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListRouteRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRouteRuleResponse
        /// </returns>
        public ListRouteRuleResponse ListRouteRuleWithOptions(ListRouteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainName))
            {
                query["BizChainName"] = request.BizChainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainUpMode))
            {
                query["ChainUpMode"] = request.ChainUpMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupName))
            {
                query["DeviceGroupName"] = request.DeviceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRouteRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRouteRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListRouteRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRouteRuleResponse
        /// </returns>
        public async Task<ListRouteRuleResponse> ListRouteRuleWithOptionsAsync(ListRouteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainName))
            {
                query["BizChainName"] = request.BizChainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainUpMode))
            {
                query["ChainUpMode"] = request.ChainUpMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupName))
            {
                query["DeviceGroupName"] = request.DeviceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRouteRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRouteRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListRouteRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRouteRuleResponse
        /// </returns>
        public ListRouteRuleResponse ListRouteRule(ListRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRouteRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListRouteRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRouteRuleResponse
        /// </returns>
        public async Task<ListRouteRuleResponse> ListRouteRuleAsync(ListRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRouteRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryBlockchainDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBlockchainDataResponse
        /// </returns>
        public QueryBlockchainDataResponse QueryBlockchainDataWithOptions(QueryBlockchainDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractName))
            {
                query["ContractName"] = request.ContractName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                query["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDID))
            {
                query["IotDataDID"] = request.IotDataDID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                query["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBlockchainData",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBlockchainDataResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryBlockchainDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBlockchainDataResponse
        /// </returns>
        public async Task<QueryBlockchainDataResponse> QueryBlockchainDataWithOptionsAsync(QueryBlockchainDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractName))
            {
                query["ContractName"] = request.ContractName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                query["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDID))
            {
                query["IotDataDID"] = request.IotDataDID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                query["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBlockchainData",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBlockchainDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryBlockchainDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBlockchainDataResponse
        /// </returns>
        public QueryBlockchainDataResponse QueryBlockchainData(QueryBlockchainDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBlockchainDataWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryBlockchainDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBlockchainDataResponse
        /// </returns>
        public async Task<QueryBlockchainDataResponse> QueryBlockchainDataAsync(QueryBlockchainDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBlockchainDataWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryBlockchainMetadataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBlockchainMetadataResponse
        /// </returns>
        public QueryBlockchainMetadataResponse QueryBlockchainMetadataWithOptions(QueryBlockchainMetadataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractName))
            {
                query["ContractName"] = request.ContractName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                query["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDID))
            {
                query["IotDataDID"] = request.IotDataDID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                query["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBlockchainMetadata",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBlockchainMetadataResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryBlockchainMetadataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBlockchainMetadataResponse
        /// </returns>
        public async Task<QueryBlockchainMetadataResponse> QueryBlockchainMetadataWithOptionsAsync(QueryBlockchainMetadataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractName))
            {
                query["ContractName"] = request.ContractName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                query["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDID))
            {
                query["IotDataDID"] = request.IotDataDID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                query["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBlockchainMetadata",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBlockchainMetadataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryBlockchainMetadataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBlockchainMetadataResponse
        /// </returns>
        public QueryBlockchainMetadataResponse QueryBlockchainMetadata(QueryBlockchainMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBlockchainMetadataWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryBlockchainMetadataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBlockchainMetadataResponse
        /// </returns>
        public async Task<QueryBlockchainMetadataResponse> QueryBlockchainMetadataAsync(QueryBlockchainMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBlockchainMetadataWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SharePrivacyRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SharePrivacyRuleResponse
        /// </returns>
        public SharePrivacyRuleResponse SharePrivacyRuleWithOptions(SharePrivacyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberIdList))
            {
                query["MemberIdList"] = request.MemberIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivacyRuleId))
            {
                query["PrivacyRuleId"] = request.PrivacyRuleId;
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
                Action = "SharePrivacyRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SharePrivacyRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SharePrivacyRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SharePrivacyRuleResponse
        /// </returns>
        public async Task<SharePrivacyRuleResponse> SharePrivacyRuleWithOptionsAsync(SharePrivacyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberIdList))
            {
                query["MemberIdList"] = request.MemberIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivacyRuleId))
            {
                query["PrivacyRuleId"] = request.PrivacyRuleId;
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
                Action = "SharePrivacyRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SharePrivacyRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SharePrivacyRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// SharePrivacyRuleResponse
        /// </returns>
        public SharePrivacyRuleResponse SharePrivacyRule(SharePrivacyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SharePrivacyRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SharePrivacyRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// SharePrivacyRuleResponse
        /// </returns>
        public async Task<SharePrivacyRuleResponse> SharePrivacyRuleAsync(SharePrivacyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SharePrivacyRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UnFreezeMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnFreezeMemberResponse
        /// </returns>
        public UnFreezeMemberResponse UnFreezeMemberWithOptions(UnFreezeMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
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
                Action = "UnFreezeMember",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnFreezeMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UnFreezeMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnFreezeMemberResponse
        /// </returns>
        public async Task<UnFreezeMemberResponse> UnFreezeMemberWithOptionsAsync(UnFreezeMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
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
                Action = "UnFreezeMember",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnFreezeMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UnFreezeMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// UnFreezeMemberResponse
        /// </returns>
        public UnFreezeMemberResponse UnFreezeMember(UnFreezeMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnFreezeMemberWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UnFreezeMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// UnFreezeMemberResponse
        /// </returns>
        public async Task<UnFreezeMemberResponse> UnFreezeMemberAsync(UnFreezeMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnFreezeMemberWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizChainResponse
        /// </returns>
        public UpdateBizChainResponse UpdateBizChainWithOptions(UpdateBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBizChainResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateBizChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizChainResponse
        /// </returns>
        public async Task<UpdateBizChainResponse> UpdateBizChainWithOptionsAsync(UpdateBizChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBizChain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBizChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizChainResponse
        /// </returns>
        public UpdateBizChainResponse UpdateBizChain(UpdateBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBizChainWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateBizChainRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizChainResponse
        /// </returns>
        public async Task<UpdateBizChainResponse> UpdateBizChainAsync(UpdateBizChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBizChainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改成员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemberResponse
        /// </returns>
        public UpdateMemberResponse UpdateMemberWithOptions(UpdateMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedCount))
            {
                query["AuthorizedCount"] = request.AuthorizedCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedDeviceCount))
            {
                query["AuthorizedDeviceCount"] = request.AuthorizedDeviceCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contactor))
            {
                query["Contactor"] = request.Contactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephony))
            {
                query["Telephony"] = request.Telephony;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMember",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改成员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemberResponse
        /// </returns>
        public async Task<UpdateMemberResponse> UpdateMemberWithOptionsAsync(UpdateMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedCount))
            {
                query["AuthorizedCount"] = request.AuthorizedCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedDeviceCount))
            {
                query["AuthorizedDeviceCount"] = request.AuthorizedDeviceCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contactor))
            {
                query["Contactor"] = request.Contactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephony))
            {
                query["Telephony"] = request.Telephony;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMember",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改成员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemberResponse
        /// </returns>
        public UpdateMemberResponse UpdateMember(UpdateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMemberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改成员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemberResponse
        /// </returns>
        public async Task<UpdateMemberResponse> UpdateMemberAsync(UpdateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMemberWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdatePrivacyRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrivacyRuleResponse
        /// </returns>
        public UpdatePrivacyRuleResponse UpdatePrivacyRuleWithOptions(UpdatePrivacyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgImpl))
            {
                query["AlgImpl"] = request.AlgImpl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgType))
            {
                query["AlgType"] = request.AlgType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivacyRuleId))
            {
                query["PrivacyRuleId"] = request.PrivacyRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePrivacyRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePrivacyRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdatePrivacyRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrivacyRuleResponse
        /// </returns>
        public async Task<UpdatePrivacyRuleResponse> UpdatePrivacyRuleWithOptionsAsync(UpdatePrivacyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgImpl))
            {
                query["AlgImpl"] = request.AlgImpl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgType))
            {
                query["AlgType"] = request.AlgType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivacyRuleId))
            {
                query["PrivacyRuleId"] = request.PrivacyRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePrivacyRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePrivacyRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdatePrivacyRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrivacyRuleResponse
        /// </returns>
        public UpdatePrivacyRuleResponse UpdatePrivacyRule(UpdatePrivacyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePrivacyRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdatePrivacyRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrivacyRuleResponse
        /// </returns>
        public async Task<UpdatePrivacyRuleResponse> UpdatePrivacyRuleAsync(UpdatePrivacyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePrivacyRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateRouteRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRouteRuleResponse
        /// </returns>
        public UpdateRouteRuleResponse UpdateRouteRuleWithOptions(UpdateRouteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractName))
            {
                query["ContractName"] = request.ContractName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractTemplateId))
            {
                query["ContractTemplateId"] = request.ContractTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                query["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivacyRuleId))
            {
                query["PrivacyRuleId"] = request.PrivacyRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                query["RouteRuleId"] = request.RouteRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRouteRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRouteRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateRouteRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRouteRuleResponse
        /// </returns>
        public async Task<UpdateRouteRuleResponse> UpdateRouteRuleWithOptionsAsync(UpdateRouteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizChainId))
            {
                query["BizChainId"] = request.BizChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractName))
            {
                query["ContractName"] = request.ContractName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractTemplateId))
            {
                query["ContractTemplateId"] = request.ContractTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                query["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivacyRuleId))
            {
                query["PrivacyRuleId"] = request.PrivacyRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteRuleId))
            {
                query["RouteRuleId"] = request.RouteRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRouteRule",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRouteRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateRouteRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRouteRuleResponse
        /// </returns>
        public UpdateRouteRuleResponse UpdateRouteRule(UpdateRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRouteRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateRouteRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRouteRuleResponse
        /// </returns>
        public async Task<UpdateRouteRuleResponse> UpdateRouteRuleAsync(UpdateRouteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRouteRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UploadIoTDataToBlockchainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadIoTDataToBlockchainResponse
        /// </returns>
        public UploadIoTDataToBlockchainResponse UploadIoTDataToBlockchainWithOptions(UploadIoTDataToBlockchainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotAuthType))
            {
                query["IotAuthType"] = request.IotAuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDID))
            {
                query["IotDataDID"] = request.IotDataDID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDigest))
            {
                query["IotDataDigest"] = request.IotDataDigest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataToken))
            {
                query["IotDataToken"] = request.IotDataToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdServiceProvider))
            {
                query["IotIdServiceProvider"] = request.IotIdServiceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdSource))
            {
                query["IotIdSource"] = request.IotIdSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlainData))
            {
                query["PlainData"] = request.PlainData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivacyData))
            {
                query["PrivacyData"] = request.PrivacyData;
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
                Action = "UploadIoTDataToBlockchain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadIoTDataToBlockchainResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UploadIoTDataToBlockchainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadIoTDataToBlockchainResponse
        /// </returns>
        public async Task<UploadIoTDataToBlockchainResponse> UploadIoTDataToBlockchainWithOptionsAsync(UploadIoTDataToBlockchainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotAuthType))
            {
                query["IotAuthType"] = request.IotAuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDID))
            {
                query["IotDataDID"] = request.IotDataDID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataDigest))
            {
                query["IotDataDigest"] = request.IotDataDigest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotDataToken))
            {
                query["IotDataToken"] = request.IotDataToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdServiceProvider))
            {
                query["IotIdServiceProvider"] = request.IotIdServiceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdSource))
            {
                query["IotIdSource"] = request.IotIdSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlainData))
            {
                query["PlainData"] = request.PlainData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivacyData))
            {
                query["PrivacyData"] = request.PrivacyData;
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
                Action = "UploadIoTDataToBlockchain",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadIoTDataToBlockchainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UploadIoTDataToBlockchainRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadIoTDataToBlockchainResponse
        /// </returns>
        public UploadIoTDataToBlockchainResponse UploadIoTDataToBlockchain(UploadIoTDataToBlockchainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadIoTDataToBlockchainWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UploadIoTDataToBlockchainRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadIoTDataToBlockchainResponse
        /// </returns>
        public async Task<UploadIoTDataToBlockchainResponse> UploadIoTDataToBlockchainAsync(UploadIoTDataToBlockchainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadIoTDataToBlockchainWithOptionsAsync(request, runtime);
        }

    }
}
