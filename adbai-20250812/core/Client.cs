// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ADBAI20250812.Models;

namespace AlibabaCloud.SDK.ADBAI20250812
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("adbai", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>创建具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateEmbodiedAIPlatformRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEmbodiedAIPlatformResponse
        /// </returns>
        public CreateEmbodiedAIPlatformResponse CreateEmbodiedAIPlatformWithOptions(CreateEmbodiedAIPlatformRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEmbodiedAIPlatformShrinkRequest request = new CreateEmbodiedAIPlatformShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RayConfig))
            {
                request.RayConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RayConfig, "RayConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformName))
            {
                query["PlatformName"] = request.PlatformName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RayConfigShrink))
            {
                query["RayConfig"] = request.RayConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebserverSpecName))
            {
                query["WebserverSpecName"] = request.WebserverSpecName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEmbodiedAIPlatform",
                Version = "2025-08-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEmbodiedAIPlatformResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateEmbodiedAIPlatformRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEmbodiedAIPlatformResponse
        /// </returns>
        public async Task<CreateEmbodiedAIPlatformResponse> CreateEmbodiedAIPlatformWithOptionsAsync(CreateEmbodiedAIPlatformRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEmbodiedAIPlatformShrinkRequest request = new CreateEmbodiedAIPlatformShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RayConfig))
            {
                request.RayConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RayConfig, "RayConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformName))
            {
                query["PlatformName"] = request.PlatformName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RayConfigShrink))
            {
                query["RayConfig"] = request.RayConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebserverSpecName))
            {
                query["WebserverSpecName"] = request.WebserverSpecName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEmbodiedAIPlatform",
                Version = "2025-08-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEmbodiedAIPlatformResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEmbodiedAIPlatformRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEmbodiedAIPlatformResponse
        /// </returns>
        public CreateEmbodiedAIPlatformResponse CreateEmbodiedAIPlatform(CreateEmbodiedAIPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEmbodiedAIPlatformWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEmbodiedAIPlatformRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEmbodiedAIPlatformResponse
        /// </returns>
        public async Task<CreateEmbodiedAIPlatformResponse> CreateEmbodiedAIPlatformAsync(CreateEmbodiedAIPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEmbodiedAIPlatformWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEmbodiedAIPlatformsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEmbodiedAIPlatformsResponse
        /// </returns>
        public DescribeEmbodiedAIPlatformsResponse DescribeEmbodiedAIPlatformsWithOptions(DescribeEmbodiedAIPlatformsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformName))
            {
                query["PlatformName"] = request.PlatformName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEmbodiedAIPlatforms",
                Version = "2025-08-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEmbodiedAIPlatformsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEmbodiedAIPlatformsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEmbodiedAIPlatformsResponse
        /// </returns>
        public async Task<DescribeEmbodiedAIPlatformsResponse> DescribeEmbodiedAIPlatformsWithOptionsAsync(DescribeEmbodiedAIPlatformsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformName))
            {
                query["PlatformName"] = request.PlatformName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEmbodiedAIPlatforms",
                Version = "2025-08-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEmbodiedAIPlatformsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEmbodiedAIPlatformsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEmbodiedAIPlatformsResponse
        /// </returns>
        public DescribeEmbodiedAIPlatformsResponse DescribeEmbodiedAIPlatforms(DescribeEmbodiedAIPlatformsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEmbodiedAIPlatformsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEmbodiedAIPlatformsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEmbodiedAIPlatformsResponse
        /// </returns>
        public async Task<DescribeEmbodiedAIPlatformsResponse> DescribeEmbodiedAIPlatformsAsync(DescribeEmbodiedAIPlatformsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEmbodiedAIPlatformsWithOptionsAsync(request, runtime);
        }

    }
}
