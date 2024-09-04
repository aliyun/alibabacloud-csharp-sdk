// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Green20180509.Models;

namespace AlibabaCloud.SDK.Green20180509
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "green.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "green.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "green.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "green.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "green.ap-southeast-1.aliyuncs.com"},
                {"cn-chengdu", "green.aliyuncs.com"},
                {"cn-hongkong", "green.aliyuncs.com"},
                {"cn-huhehaote", "green.aliyuncs.com"},
                {"cn-qingdao", "green.aliyuncs.com"},
                {"cn-zhangjiakou", "green.aliyuncs.com"},
                {"eu-central-1", "green.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "green.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "green.ap-southeast-1.aliyuncs.com"},
                {"us-east-1", "green.ap-southeast-1.aliyuncs.com"},
                {"cn-hangzhou-finance", "green.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "green.aliyuncs.com"},
                {"cn-shanghai-finance-1", "green.aliyuncs.com"},
                {"cn-north-2-gov-1", "green.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("green", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /**
         * @summary 添加人脸
         *
         * @param request AddFacesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddFacesResponse
         */
        public AddFacesResponse AddFacesWithOptions(AddFacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFaces",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/face/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFacesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加人脸
         *
         * @param request AddFacesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddFacesResponse
         */
        public async Task<AddFacesResponse> AddFacesWithOptionsAsync(AddFacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFaces",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/face/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加人脸
         *
         * @param request AddFacesRequest
         * @return AddFacesResponse
         */
        public AddFacesResponse AddFaces(AddFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddFacesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加人脸
         *
         * @param request AddFacesRequest
         * @return AddFacesResponse
         */
        public async Task<AddFacesResponse> AddFacesAsync(AddFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddFacesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 添加分组
         *
         * @param request AddGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGroupsResponse
         */
        public AddGroupsResponse AddGroupsWithOptions(AddGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGroups",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/person/groups/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加分组
         *
         * @param request AddGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGroupsResponse
         */
        public async Task<AddGroupsResponse> AddGroupsWithOptionsAsync(AddGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGroups",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/person/groups/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加分组
         *
         * @param request AddGroupsRequest
         * @return AddGroupsResponse
         */
        public AddGroupsResponse AddGroups(AddGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加分组
         *
         * @param request AddGroupsRequest
         * @return AddGroupsResponse
         */
        public async Task<AddGroupsResponse> AddGroupsAsync(AddGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 添加个体
         *
         * @param request AddPersonRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddPersonResponse
         */
        public AddPersonResponse AddPersonWithOptions(AddPersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddPerson",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/person/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPersonResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加个体
         *
         * @param request AddPersonRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddPersonResponse
         */
        public async Task<AddPersonResponse> AddPersonWithOptionsAsync(AddPersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddPerson",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/person/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPersonResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加个体
         *
         * @param request AddPersonRequest
         * @return AddPersonResponse
         */
        public AddPersonResponse AddPerson(AddPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddPersonWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加个体
         *
         * @param request AddPersonRequest
         * @return AddPersonResponse
         */
        public async Task<AddPersonResponse> AddPersonAsync(AddPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddPersonWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 添加相似图
         *
         * @param request AddSimilarityImageRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddSimilarityImageResponse
         */
        public AddSimilarityImageResponse AddSimilarityImageWithOptions(AddSimilarityImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSimilarityImage",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/similarity/image/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSimilarityImageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加相似图
         *
         * @param request AddSimilarityImageRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddSimilarityImageResponse
         */
        public async Task<AddSimilarityImageResponse> AddSimilarityImageWithOptionsAsync(AddSimilarityImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSimilarityImage",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/similarity/image/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSimilarityImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加相似图
         *
         * @param request AddSimilarityImageRequest
         * @return AddSimilarityImageResponse
         */
        public AddSimilarityImageResponse AddSimilarityImage(AddSimilarityImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddSimilarityImageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加相似图
         *
         * @param request AddSimilarityImageRequest
         * @return AddSimilarityImageResponse
         */
        public async Task<AddSimilarityImageResponse> AddSimilarityImageAsync(AddSimilarityImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddSimilarityImageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 添加相似图库
         *
         * @param request AddSimilarityLibraryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddSimilarityLibraryResponse
         */
        public AddSimilarityLibraryResponse AddSimilarityLibraryWithOptions(AddSimilarityLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSimilarityLibrary",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/similarity/library/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSimilarityLibraryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加相似图库
         *
         * @param request AddSimilarityLibraryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddSimilarityLibraryResponse
         */
        public async Task<AddSimilarityLibraryResponse> AddSimilarityLibraryWithOptionsAsync(AddSimilarityLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSimilarityLibrary",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/similarity/library/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSimilarityLibraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加相似图库
         *
         * @param request AddSimilarityLibraryRequest
         * @return AddSimilarityLibraryResponse
         */
        public AddSimilarityLibraryResponse AddSimilarityLibrary(AddSimilarityLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddSimilarityLibraryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加相似图库
         *
         * @param request AddSimilarityLibraryRequest
         * @return AddSimilarityLibraryResponse
         */
        public async Task<AddSimilarityLibraryResponse> AddSimilarityLibraryAsync(AddSimilarityLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddSimilarityLibraryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 添加视频Dna
         *
         * @param request AddVideoDnaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddVideoDnaResponse
         */
        public AddVideoDnaResponse AddVideoDnaWithOptions(AddVideoDnaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddVideoDna",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/dna/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddVideoDnaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加视频Dna
         *
         * @param request AddVideoDnaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddVideoDnaResponse
         */
        public async Task<AddVideoDnaResponse> AddVideoDnaWithOptionsAsync(AddVideoDnaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddVideoDna",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/dna/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddVideoDnaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加视频Dna
         *
         * @param request AddVideoDnaRequest
         * @return AddVideoDnaResponse
         */
        public AddVideoDnaResponse AddVideoDna(AddVideoDnaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddVideoDnaWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加视频Dna
         *
         * @param request AddVideoDnaRequest
         * @return AddVideoDnaResponse
         */
        public async Task<AddVideoDnaResponse> AddVideoDnaAsync(AddVideoDnaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddVideoDnaWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 添加视频Dna分组
         *
         * @param request AddVideoDnaGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddVideoDnaGroupResponse
         */
        public AddVideoDnaGroupResponse AddVideoDnaGroupWithOptions(AddVideoDnaGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddVideoDnaGroup",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/dna/group/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddVideoDnaGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加视频Dna分组
         *
         * @param request AddVideoDnaGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddVideoDnaGroupResponse
         */
        public async Task<AddVideoDnaGroupResponse> AddVideoDnaGroupWithOptionsAsync(AddVideoDnaGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddVideoDnaGroup",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/dna/group/add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddVideoDnaGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加视频Dna分组
         *
         * @param request AddVideoDnaGroupRequest
         * @return AddVideoDnaGroupResponse
         */
        public AddVideoDnaGroupResponse AddVideoDnaGroup(AddVideoDnaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddVideoDnaGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加视频Dna分组
         *
         * @param request AddVideoDnaGroupRequest
         * @return AddVideoDnaGroupResponse
         */
        public async Task<AddVideoDnaGroupResponse> AddVideoDnaGroupAsync(AddVideoDnaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddVideoDnaGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除人脸
         *
         * @param request DeleteFacesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFacesResponse
         */
        public DeleteFacesResponse DeleteFacesWithOptions(DeleteFacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFaces",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/face/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFacesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除人脸
         *
         * @param request DeleteFacesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFacesResponse
         */
        public async Task<DeleteFacesResponse> DeleteFacesWithOptionsAsync(DeleteFacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFaces",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/face/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除人脸
         *
         * @param request DeleteFacesRequest
         * @return DeleteFacesResponse
         */
        public DeleteFacesResponse DeleteFaces(DeleteFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFacesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除人脸
         *
         * @param request DeleteFacesRequest
         * @return DeleteFacesResponse
         */
        public async Task<DeleteFacesResponse> DeleteFacesAsync(DeleteFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFacesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除分组
         *
         * @param request DeleteGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGroupsResponse
         */
        public DeleteGroupsResponse DeleteGroupsWithOptions(DeleteGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroups",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/person/groups/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除分组
         *
         * @param request DeleteGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGroupsResponse
         */
        public async Task<DeleteGroupsResponse> DeleteGroupsWithOptionsAsync(DeleteGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroups",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/person/groups/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除分组
         *
         * @param request DeleteGroupsRequest
         * @return DeleteGroupsResponse
         */
        public DeleteGroupsResponse DeleteGroups(DeleteGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除分组
         *
         * @param request DeleteGroupsRequest
         * @return DeleteGroupsResponse
         */
        public async Task<DeleteGroupsResponse> DeleteGroupsAsync(DeleteGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除个体
         *
         * @param request DeletePersonRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePersonResponse
         */
        public DeletePersonResponse DeletePersonWithOptions(DeletePersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePerson",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/person/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePersonResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除个体
         *
         * @param request DeletePersonRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePersonResponse
         */
        public async Task<DeletePersonResponse> DeletePersonWithOptionsAsync(DeletePersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePerson",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/person/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePersonResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除个体
         *
         * @param request DeletePersonRequest
         * @return DeletePersonResponse
         */
        public DeletePersonResponse DeletePerson(DeletePersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePersonWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除个体
         *
         * @param request DeletePersonRequest
         * @return DeletePersonResponse
         */
        public async Task<DeletePersonResponse> DeletePersonAsync(DeletePersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePersonWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除相似图
         *
         * @param request DeleteSimilarityImageRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSimilarityImageResponse
         */
        public DeleteSimilarityImageResponse DeleteSimilarityImageWithOptions(DeleteSimilarityImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSimilarityImage",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/similarity/image/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSimilarityImageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除相似图
         *
         * @param request DeleteSimilarityImageRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSimilarityImageResponse
         */
        public async Task<DeleteSimilarityImageResponse> DeleteSimilarityImageWithOptionsAsync(DeleteSimilarityImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSimilarityImage",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/similarity/image/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSimilarityImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除相似图
         *
         * @param request DeleteSimilarityImageRequest
         * @return DeleteSimilarityImageResponse
         */
        public DeleteSimilarityImageResponse DeleteSimilarityImage(DeleteSimilarityImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSimilarityImageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除相似图
         *
         * @param request DeleteSimilarityImageRequest
         * @return DeleteSimilarityImageResponse
         */
        public async Task<DeleteSimilarityImageResponse> DeleteSimilarityImageAsync(DeleteSimilarityImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSimilarityImageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除相似图库
         *
         * @param request DeleteSimilarityLibraryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSimilarityLibraryResponse
         */
        public DeleteSimilarityLibraryResponse DeleteSimilarityLibraryWithOptions(DeleteSimilarityLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSimilarityLibrary",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/similarity/library/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSimilarityLibraryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除相似图库
         *
         * @param request DeleteSimilarityLibraryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSimilarityLibraryResponse
         */
        public async Task<DeleteSimilarityLibraryResponse> DeleteSimilarityLibraryWithOptionsAsync(DeleteSimilarityLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSimilarityLibrary",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/similarity/library/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSimilarityLibraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除相似图库
         *
         * @param request DeleteSimilarityLibraryRequest
         * @return DeleteSimilarityLibraryResponse
         */
        public DeleteSimilarityLibraryResponse DeleteSimilarityLibrary(DeleteSimilarityLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSimilarityLibraryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除相似图库
         *
         * @param request DeleteSimilarityLibraryRequest
         * @return DeleteSimilarityLibraryResponse
         */
        public async Task<DeleteSimilarityLibraryResponse> DeleteSimilarityLibraryAsync(DeleteSimilarityLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSimilarityLibraryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除视频Dna
         *
         * @param request DeleteVideoDnaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVideoDnaResponse
         */
        public DeleteVideoDnaResponse DeleteVideoDnaWithOptions(DeleteVideoDnaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVideoDna",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/dna/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVideoDnaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除视频Dna
         *
         * @param request DeleteVideoDnaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVideoDnaResponse
         */
        public async Task<DeleteVideoDnaResponse> DeleteVideoDnaWithOptionsAsync(DeleteVideoDnaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVideoDna",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/dna/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVideoDnaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除视频Dna
         *
         * @param request DeleteVideoDnaRequest
         * @return DeleteVideoDnaResponse
         */
        public DeleteVideoDnaResponse DeleteVideoDna(DeleteVideoDnaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteVideoDnaWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除视频Dna
         *
         * @param request DeleteVideoDnaRequest
         * @return DeleteVideoDnaResponse
         */
        public async Task<DeleteVideoDnaResponse> DeleteVideoDnaAsync(DeleteVideoDnaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteVideoDnaWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除视频Dna分组
         *
         * @param request DeleteVideoDnaGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVideoDnaGroupResponse
         */
        public DeleteVideoDnaGroupResponse DeleteVideoDnaGroupWithOptions(DeleteVideoDnaGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVideoDnaGroup",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/dna/group/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVideoDnaGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除视频Dna分组
         *
         * @param request DeleteVideoDnaGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVideoDnaGroupResponse
         */
        public async Task<DeleteVideoDnaGroupResponse> DeleteVideoDnaGroupWithOptionsAsync(DeleteVideoDnaGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVideoDnaGroup",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/dna/group/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVideoDnaGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除视频Dna分组
         *
         * @param request DeleteVideoDnaGroupRequest
         * @return DeleteVideoDnaGroupResponse
         */
        public DeleteVideoDnaGroupResponse DeleteVideoDnaGroup(DeleteVideoDnaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteVideoDnaGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除视频Dna分组
         *
         * @param request DeleteVideoDnaGroupRequest
         * @return DeleteVideoDnaGroupResponse
         */
        public async Task<DeleteVideoDnaGroupResponse> DeleteVideoDnaGroupAsync(DeleteVideoDnaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteVideoDnaGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 人脸属性检测
         *
         * @param request DetectFaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectFaceResponse
         */
        public DetectFaceResponse DetectFaceWithOptions(DetectFaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectFace",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/face/detect",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectFaceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 人脸属性检测
         *
         * @param request DetectFaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectFaceResponse
         */
        public async Task<DetectFaceResponse> DetectFaceWithOptionsAsync(DetectFaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectFace",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/face/detect",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectFaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 人脸属性检测
         *
         * @param request DetectFaceRequest
         * @return DetectFaceResponse
         */
        public DetectFaceResponse DetectFace(DetectFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DetectFaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 人脸属性检测
         *
         * @param request DetectFaceRequest
         * @return DetectFaceResponse
         */
        public async Task<DetectFaceResponse> DetectFaceAsync(DetectFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DetectFaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 文件异步检测
         *
         * @param request FileAsyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileAsyncScanResponse
         */
        public FileAsyncScanResponse FileAsyncScanWithOptions(FileAsyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileAsyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/file/asyncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileAsyncScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 文件异步检测
         *
         * @param request FileAsyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileAsyncScanResponse
         */
        public async Task<FileAsyncScanResponse> FileAsyncScanWithOptionsAsync(FileAsyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileAsyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/file/asyncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileAsyncScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 文件异步检测
         *
         * @param request FileAsyncScanRequest
         * @return FileAsyncScanResponse
         */
        public FileAsyncScanResponse FileAsyncScan(FileAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FileAsyncScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 文件异步检测
         *
         * @param request FileAsyncScanRequest
         * @return FileAsyncScanResponse
         */
        public async Task<FileAsyncScanResponse> FileAsyncScanAsync(FileAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FileAsyncScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 文件异步检测结果
         *
         * @param request FileAsyncScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileAsyncScanResultsResponse
         */
        public FileAsyncScanResultsResponse FileAsyncScanResultsWithOptions(FileAsyncScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileAsyncScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/file/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileAsyncScanResultsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 文件异步检测结果
         *
         * @param request FileAsyncScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileAsyncScanResultsResponse
         */
        public async Task<FileAsyncScanResultsResponse> FileAsyncScanResultsWithOptionsAsync(FileAsyncScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileAsyncScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/file/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileAsyncScanResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 文件异步检测结果
         *
         * @param request FileAsyncScanResultsRequest
         * @return FileAsyncScanResultsResponse
         */
        public FileAsyncScanResultsResponse FileAsyncScanResults(FileAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FileAsyncScanResultsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 文件异步检测结果
         *
         * @param request FileAsyncScanResultsRequest
         * @return FileAsyncScanResultsResponse
         */
        public async Task<FileAsyncScanResultsResponse> FileAsyncScanResultsAsync(FileAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FileAsyncScanResultsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 文件检测新版本
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileAsyncScanV2Response
         */
        public FileAsyncScanV2Response FileAsyncScanV2WithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileAsyncScanV2",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/file/asyncscanv2",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileAsyncScanV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 文件检测新版本
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileAsyncScanV2Response
         */
        public async Task<FileAsyncScanV2Response> FileAsyncScanV2WithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileAsyncScanV2",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/file/asyncscanv2",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileAsyncScanV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 文件检测新版本
         *
         * @return FileAsyncScanV2Response
         */
        public FileAsyncScanV2Response FileAsyncScanV2()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FileAsyncScanV2WithOptions(headers, runtime);
        }

        /**
         * @summary 文件检测新版本
         *
         * @return FileAsyncScanV2Response
         */
        public async Task<FileAsyncScanV2Response> FileAsyncScanV2Async()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FileAsyncScanV2WithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取人脸列表
         *
         * @param request GetFacesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFacesResponse
         */
        public GetFacesResponse GetFacesWithOptions(GetFacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFaces",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/faces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFacesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取人脸列表
         *
         * @param request GetFacesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFacesResponse
         */
        public async Task<GetFacesResponse> GetFacesWithOptionsAsync(GetFacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFaces",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/faces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取人脸列表
         *
         * @param request GetFacesRequest
         * @return GetFacesResponse
         */
        public GetFacesResponse GetFaces(GetFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFacesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取人脸列表
         *
         * @param request GetFacesRequest
         * @return GetFacesResponse
         */
        public async Task<GetFacesResponse> GetFacesAsync(GetFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFacesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取组列表
         *
         * @param request GetGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGroupsResponse
         */
        public GetGroupsResponse GetGroupsWithOptions(GetGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroups",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取组列表
         *
         * @param request GetGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGroupsResponse
         */
        public async Task<GetGroupsResponse> GetGroupsWithOptionsAsync(GetGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroups",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取组列表
         *
         * @param request GetGroupsRequest
         * @return GetGroupsResponse
         */
        public GetGroupsResponse GetGroups(GetGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取组列表
         *
         * @param request GetGroupsRequest
         * @return GetGroupsResponse
         */
        public async Task<GetGroupsResponse> GetGroupsAsync(GetGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取单个个体
         *
         * @param request GetPersonRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPersonResponse
         */
        public GetPersonResponse GetPersonWithOptions(GetPersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPerson",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/person",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPersonResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取单个个体
         *
         * @param request GetPersonRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPersonResponse
         */
        public async Task<GetPersonResponse> GetPersonWithOptionsAsync(GetPersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPerson",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/person",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPersonResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取单个个体
         *
         * @param request GetPersonRequest
         * @return GetPersonResponse
         */
        public GetPersonResponse GetPerson(GetPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPersonWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取单个个体
         *
         * @param request GetPersonRequest
         * @return GetPersonResponse
         */
        public async Task<GetPersonResponse> GetPersonAsync(GetPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPersonWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取个体列表
         *
         * @param request GetPersonsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPersonsResponse
         */
        public GetPersonsResponse GetPersonsWithOptions(GetPersonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPersons",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/group/persons",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPersonsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取个体列表
         *
         * @param request GetPersonsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPersonsResponse
         */
        public async Task<GetPersonsResponse> GetPersonsWithOptionsAsync(GetPersonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPersons",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/group/persons",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPersonsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取个体列表
         *
         * @param request GetPersonsRequest
         * @return GetPersonsResponse
         */
        public GetPersonsResponse GetPersons(GetPersonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPersonsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取个体列表
         *
         * @param request GetPersonsRequest
         * @return GetPersonsResponse
         */
        public async Task<GetPersonsResponse> GetPersonsAsync(GetPersonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPersonsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取相似图
         *
         * @param request GetSimilarityImageRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSimilarityImageResponse
         */
        public GetSimilarityImageResponse GetSimilarityImageWithOptions(GetSimilarityImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSimilarityImage",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/similarity/image/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSimilarityImageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取相似图
         *
         * @param request GetSimilarityImageRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSimilarityImageResponse
         */
        public async Task<GetSimilarityImageResponse> GetSimilarityImageWithOptionsAsync(GetSimilarityImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSimilarityImage",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/similarity/image/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSimilarityImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取相似图
         *
         * @param request GetSimilarityImageRequest
         * @return GetSimilarityImageResponse
         */
        public GetSimilarityImageResponse GetSimilarityImage(GetSimilarityImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSimilarityImageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取相似图
         *
         * @param request GetSimilarityImageRequest
         * @return GetSimilarityImageResponse
         */
        public async Task<GetSimilarityImageResponse> GetSimilarityImageAsync(GetSimilarityImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSimilarityImageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取相似图库
         *
         * @param request GetSimilarityLibraryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSimilarityLibraryResponse
         */
        public GetSimilarityLibraryResponse GetSimilarityLibraryWithOptions(GetSimilarityLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSimilarityLibrary",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/similarity/library/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSimilarityLibraryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取相似图库
         *
         * @param request GetSimilarityLibraryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSimilarityLibraryResponse
         */
        public async Task<GetSimilarityLibraryResponse> GetSimilarityLibraryWithOptionsAsync(GetSimilarityLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSimilarityLibrary",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/similarity/library/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSimilarityLibraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取相似图库
         *
         * @param request GetSimilarityLibraryRequest
         * @return GetSimilarityLibraryResponse
         */
        public GetSimilarityLibraryResponse GetSimilarityLibrary(GetSimilarityLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSimilarityLibraryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取相似图库
         *
         * @param request GetSimilarityLibraryRequest
         * @return GetSimilarityLibraryResponse
         */
        public async Task<GetSimilarityLibraryResponse> GetSimilarityLibraryAsync(GetSimilarityLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSimilarityLibraryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 图片人工异步审核
         *
         * @param request ImageAsyncManualScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImageAsyncManualScanResponse
         */
        public ImageAsyncManualScanResponse ImageAsyncManualScanWithOptions(ImageAsyncManualScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageAsyncManualScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/image/manual/asyncScan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageAsyncManualScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 图片人工异步审核
         *
         * @param request ImageAsyncManualScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImageAsyncManualScanResponse
         */
        public async Task<ImageAsyncManualScanResponse> ImageAsyncManualScanWithOptionsAsync(ImageAsyncManualScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageAsyncManualScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/image/manual/asyncScan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageAsyncManualScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 图片人工异步审核
         *
         * @param request ImageAsyncManualScanRequest
         * @return ImageAsyncManualScanResponse
         */
        public ImageAsyncManualScanResponse ImageAsyncManualScan(ImageAsyncManualScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ImageAsyncManualScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 图片人工异步审核
         *
         * @param request ImageAsyncManualScanRequest
         * @return ImageAsyncManualScanResponse
         */
        public async Task<ImageAsyncManualScanResponse> ImageAsyncManualScanAsync(ImageAsyncManualScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ImageAsyncManualScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 图片人工异步审核结果
         *
         * @param request ImageAsyncManualScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImageAsyncManualScanResultsResponse
         */
        public ImageAsyncManualScanResultsResponse ImageAsyncManualScanResultsWithOptions(ImageAsyncManualScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageAsyncManualScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/image/manual/scan/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageAsyncManualScanResultsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 图片人工异步审核结果
         *
         * @param request ImageAsyncManualScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImageAsyncManualScanResultsResponse
         */
        public async Task<ImageAsyncManualScanResultsResponse> ImageAsyncManualScanResultsWithOptionsAsync(ImageAsyncManualScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageAsyncManualScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/image/manual/scan/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageAsyncManualScanResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 图片人工异步审核结果
         *
         * @param request ImageAsyncManualScanResultsRequest
         * @return ImageAsyncManualScanResultsResponse
         */
        public ImageAsyncManualScanResultsResponse ImageAsyncManualScanResults(ImageAsyncManualScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ImageAsyncManualScanResultsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 图片人工异步审核结果
         *
         * @param request ImageAsyncManualScanResultsRequest
         * @return ImageAsyncManualScanResultsResponse
         */
        public async Task<ImageAsyncManualScanResultsResponse> ImageAsyncManualScanResultsAsync(ImageAsyncManualScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ImageAsyncManualScanResultsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 图片异步检测
         *
         * @param request ImageAsyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImageAsyncScanResponse
         */
        public ImageAsyncScanResponse ImageAsyncScanWithOptions(ImageAsyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageAsyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/image/asyncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageAsyncScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 图片异步检测
         *
         * @param request ImageAsyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImageAsyncScanResponse
         */
        public async Task<ImageAsyncScanResponse> ImageAsyncScanWithOptionsAsync(ImageAsyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageAsyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/image/asyncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageAsyncScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 图片异步检测
         *
         * @param request ImageAsyncScanRequest
         * @return ImageAsyncScanResponse
         */
        public ImageAsyncScanResponse ImageAsyncScan(ImageAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ImageAsyncScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 图片异步检测
         *
         * @param request ImageAsyncScanRequest
         * @return ImageAsyncScanResponse
         */
        public async Task<ImageAsyncScanResponse> ImageAsyncScanAsync(ImageAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ImageAsyncScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 图片异步检测结果
         *
         * @param request ImageAsyncScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImageAsyncScanResultsResponse
         */
        public ImageAsyncScanResultsResponse ImageAsyncScanResultsWithOptions(ImageAsyncScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageAsyncScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/image/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageAsyncScanResultsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 图片异步检测结果
         *
         * @param request ImageAsyncScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImageAsyncScanResultsResponse
         */
        public async Task<ImageAsyncScanResultsResponse> ImageAsyncScanResultsWithOptionsAsync(ImageAsyncScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageAsyncScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/image/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageAsyncScanResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 图片异步检测结果
         *
         * @param request ImageAsyncScanResultsRequest
         * @return ImageAsyncScanResultsResponse
         */
        public ImageAsyncScanResultsResponse ImageAsyncScanResults(ImageAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ImageAsyncScanResultsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 图片异步检测结果
         *
         * @param request ImageAsyncScanResultsRequest
         * @return ImageAsyncScanResultsResponse
         */
        public async Task<ImageAsyncScanResultsResponse> ImageAsyncScanResultsAsync(ImageAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ImageAsyncScanResultsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 图片检测反馈
         *
         * @param request ImageScanFeedbackRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImageScanFeedbackResponse
         */
        public ImageScanFeedbackResponse ImageScanFeedbackWithOptions(ImageScanFeedbackRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageScanFeedback",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/image/feedback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageScanFeedbackResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 图片检测反馈
         *
         * @param request ImageScanFeedbackRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImageScanFeedbackResponse
         */
        public async Task<ImageScanFeedbackResponse> ImageScanFeedbackWithOptionsAsync(ImageScanFeedbackRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageScanFeedback",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/image/feedback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageScanFeedbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 图片检测反馈
         *
         * @param request ImageScanFeedbackRequest
         * @return ImageScanFeedbackResponse
         */
        public ImageScanFeedbackResponse ImageScanFeedback(ImageScanFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ImageScanFeedbackWithOptions(request, headers, runtime);
        }

        /**
         * @summary 图片检测反馈
         *
         * @param request ImageScanFeedbackRequest
         * @return ImageScanFeedbackResponse
         */
        public async Task<ImageScanFeedbackResponse> ImageScanFeedbackAsync(ImageScanFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ImageScanFeedbackWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 图片同步检测
         *
         * @param request ImageSyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImageSyncScanResponse
         */
        public ImageSyncScanResponse ImageSyncScanWithOptions(ImageSyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageSyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/image/scan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageSyncScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 图片同步检测
         *
         * @param request ImageSyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImageSyncScanResponse
         */
        public async Task<ImageSyncScanResponse> ImageSyncScanWithOptionsAsync(ImageSyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageSyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/image/scan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageSyncScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 图片同步检测
         *
         * @param request ImageSyncScanRequest
         * @return ImageSyncScanResponse
         */
        public ImageSyncScanResponse ImageSyncScan(ImageSyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ImageSyncScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 图片同步检测
         *
         * @param request ImageSyncScanRequest
         * @return ImageSyncScanResponse
         */
        public async Task<ImageSyncScanResponse> ImageSyncScanAsync(ImageSyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ImageSyncScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取相似图
         *
         * @param request ListSimilarityImagesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSimilarityImagesResponse
         */
        public ListSimilarityImagesResponse ListSimilarityImagesWithOptions(ListSimilarityImagesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSimilarityImages",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/similarity/image/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSimilarityImagesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取相似图
         *
         * @param request ListSimilarityImagesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSimilarityImagesResponse
         */
        public async Task<ListSimilarityImagesResponse> ListSimilarityImagesWithOptionsAsync(ListSimilarityImagesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSimilarityImages",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/similarity/image/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSimilarityImagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取相似图
         *
         * @param request ListSimilarityImagesRequest
         * @return ListSimilarityImagesResponse
         */
        public ListSimilarityImagesResponse ListSimilarityImages(ListSimilarityImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSimilarityImagesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取相似图
         *
         * @param request ListSimilarityImagesRequest
         * @return ListSimilarityImagesResponse
         */
        public async Task<ListSimilarityImagesResponse> ListSimilarityImagesAsync(ListSimilarityImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSimilarityImagesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取相似图库
         *
         * @param request ListSimilarityLibrariesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSimilarityLibrariesResponse
         */
        public ListSimilarityLibrariesResponse ListSimilarityLibrariesWithOptions(ListSimilarityLibrariesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSimilarityLibraries",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/similarity/library/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSimilarityLibrariesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取相似图库
         *
         * @param request ListSimilarityLibrariesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSimilarityLibrariesResponse
         */
        public async Task<ListSimilarityLibrariesResponse> ListSimilarityLibrariesWithOptionsAsync(ListSimilarityLibrariesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSimilarityLibraries",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/similarity/library/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSimilarityLibrariesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取相似图库
         *
         * @param request ListSimilarityLibrariesRequest
         * @return ListSimilarityLibrariesResponse
         */
        public ListSimilarityLibrariesResponse ListSimilarityLibraries(ListSimilarityLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSimilarityLibrariesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取相似图库
         *
         * @param request ListSimilarityLibrariesRequest
         * @return ListSimilarityLibrariesResponse
         */
        public async Task<ListSimilarityLibrariesResponse> ListSimilarityLibrariesAsync(ListSimilarityLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSimilarityLibrariesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 直播流异步检测
         *
         * @param request LiveStreamAsyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return LiveStreamAsyncScanResponse
         */
        public LiveStreamAsyncScanResponse LiveStreamAsyncScanWithOptions(LiveStreamAsyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LiveStreamAsyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/livestream/asyncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LiveStreamAsyncScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 直播流异步检测
         *
         * @param request LiveStreamAsyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return LiveStreamAsyncScanResponse
         */
        public async Task<LiveStreamAsyncScanResponse> LiveStreamAsyncScanWithOptionsAsync(LiveStreamAsyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LiveStreamAsyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/livestream/asyncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LiveStreamAsyncScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 直播流异步检测
         *
         * @param request LiveStreamAsyncScanRequest
         * @return LiveStreamAsyncScanResponse
         */
        public LiveStreamAsyncScanResponse LiveStreamAsyncScan(LiveStreamAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return LiveStreamAsyncScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 直播流异步检测
         *
         * @param request LiveStreamAsyncScanRequest
         * @return LiveStreamAsyncScanResponse
         */
        public async Task<LiveStreamAsyncScanResponse> LiveStreamAsyncScanAsync(LiveStreamAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await LiveStreamAsyncScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 直播流异步检测结果
         *
         * @param request LiveStreamAsyncScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return LiveStreamAsyncScanResultsResponse
         */
        public LiveStreamAsyncScanResultsResponse LiveStreamAsyncScanResultsWithOptions(LiveStreamAsyncScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LiveStreamAsyncScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/livestream/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LiveStreamAsyncScanResultsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 直播流异步检测结果
         *
         * @param request LiveStreamAsyncScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return LiveStreamAsyncScanResultsResponse
         */
        public async Task<LiveStreamAsyncScanResultsResponse> LiveStreamAsyncScanResultsWithOptionsAsync(LiveStreamAsyncScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LiveStreamAsyncScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/livestream/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LiveStreamAsyncScanResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 直播流异步检测结果
         *
         * @param request LiveStreamAsyncScanResultsRequest
         * @return LiveStreamAsyncScanResultsResponse
         */
        public LiveStreamAsyncScanResultsResponse LiveStreamAsyncScanResults(LiveStreamAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return LiveStreamAsyncScanResultsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 直播流异步检测结果
         *
         * @param request LiveStreamAsyncScanResultsRequest
         * @return LiveStreamAsyncScanResultsResponse
         */
        public async Task<LiveStreamAsyncScanResultsResponse> LiveStreamAsyncScanResultsAsync(LiveStreamAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await LiveStreamAsyncScanResultsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 直播流取消检测
         *
         * @param request LiveStreamCancelScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return LiveStreamCancelScanResponse
         */
        public LiveStreamCancelScanResponse LiveStreamCancelScanWithOptions(LiveStreamCancelScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LiveStreamCancelScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/livestream/cancelscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LiveStreamCancelScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 直播流取消检测
         *
         * @param request LiveStreamCancelScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return LiveStreamCancelScanResponse
         */
        public async Task<LiveStreamCancelScanResponse> LiveStreamCancelScanWithOptionsAsync(LiveStreamCancelScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LiveStreamCancelScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/livestream/cancelscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LiveStreamCancelScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 直播流取消检测
         *
         * @param request LiveStreamCancelScanRequest
         * @return LiveStreamCancelScanResponse
         */
        public LiveStreamCancelScanResponse LiveStreamCancelScan(LiveStreamCancelScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return LiveStreamCancelScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 直播流取消检测
         *
         * @param request LiveStreamCancelScanRequest
         * @return LiveStreamCancelScanResponse
         */
        public async Task<LiveStreamCancelScanResponse> LiveStreamCancelScanAsync(LiveStreamCancelScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await LiveStreamCancelScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 设置个体
         *
         * @param request SetPersonRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetPersonResponse
         */
        public SetPersonResponse SetPersonWithOptions(SetPersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPerson",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/person/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPersonResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 设置个体
         *
         * @param request SetPersonRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetPersonResponse
         */
        public async Task<SetPersonResponse> SetPersonWithOptionsAsync(SetPersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPerson",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/sface/person/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPersonResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 设置个体
         *
         * @param request SetPersonRequest
         * @return SetPersonResponse
         */
        public SetPersonResponse SetPerson(SetPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SetPersonWithOptions(request, headers, runtime);
        }

        /**
         * @summary 设置个体
         *
         * @param request SetPersonRequest
         * @return SetPersonResponse
         */
        public async Task<SetPersonResponse> SetPersonAsync(SetPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SetPersonWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 文本异步人工审核
         *
         * @param request TextAsyncManualScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TextAsyncManualScanResponse
         */
        public TextAsyncManualScanResponse TextAsyncManualScanWithOptions(TextAsyncManualScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TextAsyncManualScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/text/manual/asyncScan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextAsyncManualScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 文本异步人工审核
         *
         * @param request TextAsyncManualScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TextAsyncManualScanResponse
         */
        public async Task<TextAsyncManualScanResponse> TextAsyncManualScanWithOptionsAsync(TextAsyncManualScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TextAsyncManualScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/text/manual/asyncScan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextAsyncManualScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 文本异步人工审核
         *
         * @param request TextAsyncManualScanRequest
         * @return TextAsyncManualScanResponse
         */
        public TextAsyncManualScanResponse TextAsyncManualScan(TextAsyncManualScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TextAsyncManualScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 文本异步人工审核
         *
         * @param request TextAsyncManualScanRequest
         * @return TextAsyncManualScanResponse
         */
        public async Task<TextAsyncManualScanResponse> TextAsyncManualScanAsync(TextAsyncManualScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TextAsyncManualScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 文本异步人工审核结果
         *
         * @param request TextAsyncManualScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TextAsyncManualScanResultsResponse
         */
        public TextAsyncManualScanResultsResponse TextAsyncManualScanResultsWithOptions(TextAsyncManualScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TextAsyncManualScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/text/manual/scan/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextAsyncManualScanResultsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 文本异步人工审核结果
         *
         * @param request TextAsyncManualScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TextAsyncManualScanResultsResponse
         */
        public async Task<TextAsyncManualScanResultsResponse> TextAsyncManualScanResultsWithOptionsAsync(TextAsyncManualScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TextAsyncManualScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/text/manual/scan/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextAsyncManualScanResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 文本异步人工审核结果
         *
         * @param request TextAsyncManualScanResultsRequest
         * @return TextAsyncManualScanResultsResponse
         */
        public TextAsyncManualScanResultsResponse TextAsyncManualScanResults(TextAsyncManualScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TextAsyncManualScanResultsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 文本异步人工审核结果
         *
         * @param request TextAsyncManualScanResultsRequest
         * @return TextAsyncManualScanResultsResponse
         */
        public async Task<TextAsyncManualScanResultsResponse> TextAsyncManualScanResultsAsync(TextAsyncManualScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TextAsyncManualScanResultsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 文本结果反馈
         *
         * @param request TextFeedbackRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TextFeedbackResponse
         */
        public TextFeedbackResponse TextFeedbackWithOptions(TextFeedbackRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TextFeedback",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/text/feedback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextFeedbackResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 文本结果反馈
         *
         * @param request TextFeedbackRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TextFeedbackResponse
         */
        public async Task<TextFeedbackResponse> TextFeedbackWithOptionsAsync(TextFeedbackRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TextFeedback",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/text/feedback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextFeedbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 文本结果反馈
         *
         * @param request TextFeedbackRequest
         * @return TextFeedbackResponse
         */
        public TextFeedbackResponse TextFeedback(TextFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TextFeedbackWithOptions(request, headers, runtime);
        }

        /**
         * @summary 文本结果反馈
         *
         * @param request TextFeedbackRequest
         * @return TextFeedbackResponse
         */
        public async Task<TextFeedbackResponse> TextFeedbackAsync(TextFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TextFeedbackWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request TextScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TextScanResponse
         */
        public TextScanResponse TextScanWithOptions(TextScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TextScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/text/scan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request TextScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TextScanResponse
         */
        public async Task<TextScanResponse> TextScanWithOptionsAsync(TextScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TextScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/text/scan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request TextScanRequest
         * @return TextScanResponse
         */
        public TextScanResponse TextScan(TextScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TextScanWithOptions(request, headers, runtime);
        }

        /**
         * @param request TextScanRequest
         * @return TextScanResponse
         */
        public async Task<TextScanResponse> TextScanAsync(TextScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TextScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取上传证书
         *
         * @param request UploadCredentialsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadCredentialsResponse
         */
        public UploadCredentialsResponse UploadCredentialsWithOptions(UploadCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadCredentials",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/credentials/uploadcredentials",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadCredentialsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取上传证书
         *
         * @param request UploadCredentialsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadCredentialsResponse
         */
        public async Task<UploadCredentialsResponse> UploadCredentialsWithOptionsAsync(UploadCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadCredentials",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/credentials/uploadcredentials",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadCredentialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取上传证书
         *
         * @param request UploadCredentialsRequest
         * @return UploadCredentialsResponse
         */
        public UploadCredentialsResponse UploadCredentials(UploadCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UploadCredentialsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取上传证书
         *
         * @param request UploadCredentialsRequest
         * @return UploadCredentialsResponse
         */
        public async Task<UploadCredentialsResponse> UploadCredentialsAsync(UploadCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UploadCredentialsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 视频异步人工审核
         *
         * @param request VideoAsyncManualScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoAsyncManualScanResponse
         */
        public VideoAsyncManualScanResponse VideoAsyncManualScanWithOptions(VideoAsyncManualScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoAsyncManualScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/manual/asyncScan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoAsyncManualScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 视频异步人工审核
         *
         * @param request VideoAsyncManualScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoAsyncManualScanResponse
         */
        public async Task<VideoAsyncManualScanResponse> VideoAsyncManualScanWithOptionsAsync(VideoAsyncManualScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoAsyncManualScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/manual/asyncScan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoAsyncManualScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 视频异步人工审核
         *
         * @param request VideoAsyncManualScanRequest
         * @return VideoAsyncManualScanResponse
         */
        public VideoAsyncManualScanResponse VideoAsyncManualScan(VideoAsyncManualScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VideoAsyncManualScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 视频异步人工审核
         *
         * @param request VideoAsyncManualScanRequest
         * @return VideoAsyncManualScanResponse
         */
        public async Task<VideoAsyncManualScanResponse> VideoAsyncManualScanAsync(VideoAsyncManualScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VideoAsyncManualScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 视频异步人工审核结果
         *
         * @param request VideoAsyncManualScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoAsyncManualScanResultsResponse
         */
        public VideoAsyncManualScanResultsResponse VideoAsyncManualScanResultsWithOptions(VideoAsyncManualScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoAsyncManualScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/manual/scan/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoAsyncManualScanResultsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 视频异步人工审核结果
         *
         * @param request VideoAsyncManualScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoAsyncManualScanResultsResponse
         */
        public async Task<VideoAsyncManualScanResultsResponse> VideoAsyncManualScanResultsWithOptionsAsync(VideoAsyncManualScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoAsyncManualScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/manual/scan/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoAsyncManualScanResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 视频异步人工审核结果
         *
         * @param request VideoAsyncManualScanResultsRequest
         * @return VideoAsyncManualScanResultsResponse
         */
        public VideoAsyncManualScanResultsResponse VideoAsyncManualScanResults(VideoAsyncManualScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VideoAsyncManualScanResultsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 视频异步人工审核结果
         *
         * @param request VideoAsyncManualScanResultsRequest
         * @return VideoAsyncManualScanResultsResponse
         */
        public async Task<VideoAsyncManualScanResultsResponse> VideoAsyncManualScanResultsAsync(VideoAsyncManualScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VideoAsyncManualScanResultsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 视频异步检测
         *
         * @param request VideoAsyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoAsyncScanResponse
         */
        public VideoAsyncScanResponse VideoAsyncScanWithOptions(VideoAsyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoAsyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/asyncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoAsyncScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 视频异步检测
         *
         * @param request VideoAsyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoAsyncScanResponse
         */
        public async Task<VideoAsyncScanResponse> VideoAsyncScanWithOptionsAsync(VideoAsyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoAsyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/asyncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoAsyncScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 视频异步检测
         *
         * @param request VideoAsyncScanRequest
         * @return VideoAsyncScanResponse
         */
        public VideoAsyncScanResponse VideoAsyncScan(VideoAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VideoAsyncScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 视频异步检测
         *
         * @param request VideoAsyncScanRequest
         * @return VideoAsyncScanResponse
         */
        public async Task<VideoAsyncScanResponse> VideoAsyncScanAsync(VideoAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VideoAsyncScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 视频异步检测结果
         *
         * @param request VideoAsyncScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoAsyncScanResultsResponse
         */
        public VideoAsyncScanResultsResponse VideoAsyncScanResultsWithOptions(VideoAsyncScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoAsyncScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoAsyncScanResultsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 视频异步检测结果
         *
         * @param request VideoAsyncScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoAsyncScanResultsResponse
         */
        public async Task<VideoAsyncScanResultsResponse> VideoAsyncScanResultsWithOptionsAsync(VideoAsyncScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoAsyncScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoAsyncScanResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 视频异步检测结果
         *
         * @param request VideoAsyncScanResultsRequest
         * @return VideoAsyncScanResultsResponse
         */
        public VideoAsyncScanResultsResponse VideoAsyncScanResults(VideoAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VideoAsyncScanResultsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 视频异步检测结果
         *
         * @param request VideoAsyncScanResultsRequest
         * @return VideoAsyncScanResultsResponse
         */
        public async Task<VideoAsyncScanResultsResponse> VideoAsyncScanResultsAsync(VideoAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VideoAsyncScanResultsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 视频取消检测
         *
         * @param request VideoCancelScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoCancelScanResponse
         */
        public VideoCancelScanResponse VideoCancelScanWithOptions(VideoCancelScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoCancelScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/cancelscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoCancelScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 视频取消检测
         *
         * @param request VideoCancelScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoCancelScanResponse
         */
        public async Task<VideoCancelScanResponse> VideoCancelScanWithOptionsAsync(VideoCancelScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoCancelScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/cancelscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoCancelScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 视频取消检测
         *
         * @param request VideoCancelScanRequest
         * @return VideoCancelScanResponse
         */
        public VideoCancelScanResponse VideoCancelScan(VideoCancelScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VideoCancelScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 视频取消检测
         *
         * @param request VideoCancelScanRequest
         * @return VideoCancelScanResponse
         */
        public async Task<VideoCancelScanResponse> VideoCancelScanAsync(VideoCancelScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VideoCancelScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 视频结果反馈
         *
         * @param request VideoFeedbackRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoFeedbackResponse
         */
        public VideoFeedbackResponse VideoFeedbackWithOptions(VideoFeedbackRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoFeedback",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/feedback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoFeedbackResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 视频结果反馈
         *
         * @param request VideoFeedbackRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoFeedbackResponse
         */
        public async Task<VideoFeedbackResponse> VideoFeedbackWithOptionsAsync(VideoFeedbackRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoFeedback",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/feedback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoFeedbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 视频结果反馈
         *
         * @param request VideoFeedbackRequest
         * @return VideoFeedbackResponse
         */
        public VideoFeedbackResponse VideoFeedback(VideoFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VideoFeedbackWithOptions(request, headers, runtime);
        }

        /**
         * @summary 视频结果反馈
         *
         * @param request VideoFeedbackRequest
         * @return VideoFeedbackResponse
         */
        public async Task<VideoFeedbackResponse> VideoFeedbackAsync(VideoFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VideoFeedbackWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 视频同步检测
         *
         * @param request VideoSyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoSyncScanResponse
         */
        public VideoSyncScanResponse VideoSyncScanWithOptions(VideoSyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoSyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/syncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoSyncScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 视频同步检测
         *
         * @param request VideoSyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoSyncScanResponse
         */
        public async Task<VideoSyncScanResponse> VideoSyncScanWithOptionsAsync(VideoSyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoSyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/video/syncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoSyncScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 视频同步检测
         *
         * @param request VideoSyncScanRequest
         * @return VideoSyncScanResponse
         */
        public VideoSyncScanResponse VideoSyncScan(VideoSyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VideoSyncScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 视频同步检测
         *
         * @param request VideoSyncScanRequest
         * @return VideoSyncScanResponse
         */
        public async Task<VideoSyncScanResponse> VideoSyncScanAsync(VideoSyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VideoSyncScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 视频点播异步检测
         *
         * @param request VodAsyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VodAsyncScanResponse
         */
        public VodAsyncScanResponse VodAsyncScanWithOptions(VodAsyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VodAsyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/vod/asyncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VodAsyncScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 视频点播异步检测
         *
         * @param request VodAsyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VodAsyncScanResponse
         */
        public async Task<VodAsyncScanResponse> VodAsyncScanWithOptionsAsync(VodAsyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VodAsyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/vod/asyncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VodAsyncScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 视频点播异步检测
         *
         * @param request VodAsyncScanRequest
         * @return VodAsyncScanResponse
         */
        public VodAsyncScanResponse VodAsyncScan(VodAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VodAsyncScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 视频点播异步检测
         *
         * @param request VodAsyncScanRequest
         * @return VodAsyncScanResponse
         */
        public async Task<VodAsyncScanResponse> VodAsyncScanAsync(VodAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VodAsyncScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 视频点播异步检测结果
         *
         * @param request VodAsyncScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VodAsyncScanResultsResponse
         */
        public VodAsyncScanResultsResponse VodAsyncScanResultsWithOptions(VodAsyncScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VodAsyncScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/vod/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VodAsyncScanResultsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 视频点播异步检测结果
         *
         * @param request VodAsyncScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VodAsyncScanResultsResponse
         */
        public async Task<VodAsyncScanResultsResponse> VodAsyncScanResultsWithOptionsAsync(VodAsyncScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VodAsyncScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/vod/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VodAsyncScanResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 视频点播异步检测结果
         *
         * @param request VodAsyncScanResultsRequest
         * @return VodAsyncScanResultsResponse
         */
        public VodAsyncScanResultsResponse VodAsyncScanResults(VodAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VodAsyncScanResultsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 视频点播异步检测结果
         *
         * @param request VodAsyncScanResultsRequest
         * @return VodAsyncScanResultsResponse
         */
        public async Task<VodAsyncScanResultsResponse> VodAsyncScanResultsAsync(VodAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VodAsyncScanResultsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 语音异步人工审核
         *
         * @param request VoiceAsyncManualScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceAsyncManualScanResponse
         */
        public VoiceAsyncManualScanResponse VoiceAsyncManualScanWithOptions(VoiceAsyncManualScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceAsyncManualScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/manual/asyncScan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceAsyncManualScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 语音异步人工审核
         *
         * @param request VoiceAsyncManualScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceAsyncManualScanResponse
         */
        public async Task<VoiceAsyncManualScanResponse> VoiceAsyncManualScanWithOptionsAsync(VoiceAsyncManualScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceAsyncManualScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/manual/asyncScan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceAsyncManualScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 语音异步人工审核
         *
         * @param request VoiceAsyncManualScanRequest
         * @return VoiceAsyncManualScanResponse
         */
        public VoiceAsyncManualScanResponse VoiceAsyncManualScan(VoiceAsyncManualScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceAsyncManualScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 语音异步人工审核
         *
         * @param request VoiceAsyncManualScanRequest
         * @return VoiceAsyncManualScanResponse
         */
        public async Task<VoiceAsyncManualScanResponse> VoiceAsyncManualScanAsync(VoiceAsyncManualScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceAsyncManualScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 语音异步人工审核结果
         *
         * @param request VoiceAsyncManualScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceAsyncManualScanResultsResponse
         */
        public VoiceAsyncManualScanResultsResponse VoiceAsyncManualScanResultsWithOptions(VoiceAsyncManualScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceAsyncManualScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/manual/scan/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceAsyncManualScanResultsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 语音异步人工审核结果
         *
         * @param request VoiceAsyncManualScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceAsyncManualScanResultsResponse
         */
        public async Task<VoiceAsyncManualScanResultsResponse> VoiceAsyncManualScanResultsWithOptionsAsync(VoiceAsyncManualScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceAsyncManualScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/manual/scan/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceAsyncManualScanResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 语音异步人工审核结果
         *
         * @param request VoiceAsyncManualScanResultsRequest
         * @return VoiceAsyncManualScanResultsResponse
         */
        public VoiceAsyncManualScanResultsResponse VoiceAsyncManualScanResults(VoiceAsyncManualScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceAsyncManualScanResultsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 语音异步人工审核结果
         *
         * @param request VoiceAsyncManualScanResultsRequest
         * @return VoiceAsyncManualScanResultsResponse
         */
        public async Task<VoiceAsyncManualScanResultsResponse> VoiceAsyncManualScanResultsAsync(VoiceAsyncManualScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceAsyncManualScanResultsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 语音异步检测
         *
         * @param request VoiceAsyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceAsyncScanResponse
         */
        public VoiceAsyncScanResponse VoiceAsyncScanWithOptions(VoiceAsyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceAsyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/asyncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceAsyncScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 语音异步检测
         *
         * @param request VoiceAsyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceAsyncScanResponse
         */
        public async Task<VoiceAsyncScanResponse> VoiceAsyncScanWithOptionsAsync(VoiceAsyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceAsyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/asyncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceAsyncScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 语音异步检测
         *
         * @param request VoiceAsyncScanRequest
         * @return VoiceAsyncScanResponse
         */
        public VoiceAsyncScanResponse VoiceAsyncScan(VoiceAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceAsyncScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 语音异步检测
         *
         * @param request VoiceAsyncScanRequest
         * @return VoiceAsyncScanResponse
         */
        public async Task<VoiceAsyncScanResponse> VoiceAsyncScanAsync(VoiceAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceAsyncScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 语音异步检测结果
         *
         * @param request VoiceAsyncScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceAsyncScanResultsResponse
         */
        public VoiceAsyncScanResultsResponse VoiceAsyncScanResultsWithOptions(VoiceAsyncScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceAsyncScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceAsyncScanResultsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 语音异步检测结果
         *
         * @param request VoiceAsyncScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceAsyncScanResultsResponse
         */
        public async Task<VoiceAsyncScanResultsResponse> VoiceAsyncScanResultsWithOptionsAsync(VoiceAsyncScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceAsyncScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceAsyncScanResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 语音异步检测结果
         *
         * @param request VoiceAsyncScanResultsRequest
         * @return VoiceAsyncScanResultsResponse
         */
        public VoiceAsyncScanResultsResponse VoiceAsyncScanResults(VoiceAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceAsyncScanResultsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 语音异步检测结果
         *
         * @param request VoiceAsyncScanResultsRequest
         * @return VoiceAsyncScanResultsResponse
         */
        public async Task<VoiceAsyncScanResultsResponse> VoiceAsyncScanResultsAsync(VoiceAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceAsyncScanResultsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 语音取消检测
         *
         * @param request VoiceCancelScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceCancelScanResponse
         */
        public VoiceCancelScanResponse VoiceCancelScanWithOptions(VoiceCancelScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceCancelScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/cancelscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceCancelScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 语音取消检测
         *
         * @param request VoiceCancelScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceCancelScanResponse
         */
        public async Task<VoiceCancelScanResponse> VoiceCancelScanWithOptionsAsync(VoiceCancelScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceCancelScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/cancelscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceCancelScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 语音取消检测
         *
         * @param request VoiceCancelScanRequest
         * @return VoiceCancelScanResponse
         */
        public VoiceCancelScanResponse VoiceCancelScan(VoiceCancelScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceCancelScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 语音取消检测
         *
         * @param request VoiceCancelScanRequest
         * @return VoiceCancelScanResponse
         */
        public async Task<VoiceCancelScanResponse> VoiceCancelScanAsync(VoiceCancelScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceCancelScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 声纹比对
         *
         * @param request VoiceIdentityCheckRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceIdentityCheckResponse
         */
        public VoiceIdentityCheckResponse VoiceIdentityCheckWithOptions(VoiceIdentityCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceIdentityCheck",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/auth/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceIdentityCheckResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 声纹比对
         *
         * @param request VoiceIdentityCheckRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceIdentityCheckResponse
         */
        public async Task<VoiceIdentityCheckResponse> VoiceIdentityCheckWithOptionsAsync(VoiceIdentityCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceIdentityCheck",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/auth/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceIdentityCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 声纹比对
         *
         * @param request VoiceIdentityCheckRequest
         * @return VoiceIdentityCheckResponse
         */
        public VoiceIdentityCheckResponse VoiceIdentityCheck(VoiceIdentityCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceIdentityCheckWithOptions(request, headers, runtime);
        }

        /**
         * @summary 声纹比对
         *
         * @param request VoiceIdentityCheckRequest
         * @return VoiceIdentityCheckResponse
         */
        public async Task<VoiceIdentityCheckResponse> VoiceIdentityCheckAsync(VoiceIdentityCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceIdentityCheckWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 声纹注册
         *
         * @param request VoiceIdentityRegisterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceIdentityRegisterResponse
         */
        public VoiceIdentityRegisterResponse VoiceIdentityRegisterWithOptions(VoiceIdentityRegisterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceIdentityRegister",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/auth/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceIdentityRegisterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 声纹注册
         *
         * @param request VoiceIdentityRegisterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceIdentityRegisterResponse
         */
        public async Task<VoiceIdentityRegisterResponse> VoiceIdentityRegisterWithOptionsAsync(VoiceIdentityRegisterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceIdentityRegister",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/auth/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceIdentityRegisterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 声纹注册
         *
         * @param request VoiceIdentityRegisterRequest
         * @return VoiceIdentityRegisterResponse
         */
        public VoiceIdentityRegisterResponse VoiceIdentityRegister(VoiceIdentityRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceIdentityRegisterWithOptions(request, headers, runtime);
        }

        /**
         * @summary 声纹注册
         *
         * @param request VoiceIdentityRegisterRequest
         * @return VoiceIdentityRegisterResponse
         */
        public async Task<VoiceIdentityRegisterResponse> VoiceIdentityRegisterAsync(VoiceIdentityRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceIdentityRegisterWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 声纹开始比对
         *
         * @param request VoiceIdentityStartCheckRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceIdentityStartCheckResponse
         */
        public VoiceIdentityStartCheckResponse VoiceIdentityStartCheckWithOptions(VoiceIdentityStartCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceIdentityStartCheck",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/auth/start/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceIdentityStartCheckResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 声纹开始比对
         *
         * @param request VoiceIdentityStartCheckRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceIdentityStartCheckResponse
         */
        public async Task<VoiceIdentityStartCheckResponse> VoiceIdentityStartCheckWithOptionsAsync(VoiceIdentityStartCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceIdentityStartCheck",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/auth/start/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceIdentityStartCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 声纹开始比对
         *
         * @param request VoiceIdentityStartCheckRequest
         * @return VoiceIdentityStartCheckResponse
         */
        public VoiceIdentityStartCheckResponse VoiceIdentityStartCheck(VoiceIdentityStartCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceIdentityStartCheckWithOptions(request, headers, runtime);
        }

        /**
         * @summary 声纹开始比对
         *
         * @param request VoiceIdentityStartCheckRequest
         * @return VoiceIdentityStartCheckResponse
         */
        public async Task<VoiceIdentityStartCheckResponse> VoiceIdentityStartCheckAsync(VoiceIdentityStartCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceIdentityStartCheckWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 声纹开始注册
         *
         * @param request VoiceIdentityStartRegisterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceIdentityStartRegisterResponse
         */
        public VoiceIdentityStartRegisterResponse VoiceIdentityStartRegisterWithOptions(VoiceIdentityStartRegisterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceIdentityStartRegister",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/auth/start/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceIdentityStartRegisterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 声纹开始注册
         *
         * @param request VoiceIdentityStartRegisterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceIdentityStartRegisterResponse
         */
        public async Task<VoiceIdentityStartRegisterResponse> VoiceIdentityStartRegisterWithOptionsAsync(VoiceIdentityStartRegisterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceIdentityStartRegister",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/auth/start/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceIdentityStartRegisterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 声纹开始注册
         *
         * @param request VoiceIdentityStartRegisterRequest
         * @return VoiceIdentityStartRegisterResponse
         */
        public VoiceIdentityStartRegisterResponse VoiceIdentityStartRegister(VoiceIdentityStartRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceIdentityStartRegisterWithOptions(request, headers, runtime);
        }

        /**
         * @summary 声纹开始注册
         *
         * @param request VoiceIdentityStartRegisterRequest
         * @return VoiceIdentityStartRegisterResponse
         */
        public async Task<VoiceIdentityStartRegisterResponse> VoiceIdentityStartRegisterAsync(VoiceIdentityStartRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceIdentityStartRegisterWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 声纹注销
         *
         * @param request VoiceIdentityUnregisterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceIdentityUnregisterResponse
         */
        public VoiceIdentityUnregisterResponse VoiceIdentityUnregisterWithOptions(VoiceIdentityUnregisterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceIdentityUnregister",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/auth/unregister",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceIdentityUnregisterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 声纹注销
         *
         * @param request VoiceIdentityUnregisterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceIdentityUnregisterResponse
         */
        public async Task<VoiceIdentityUnregisterResponse> VoiceIdentityUnregisterWithOptionsAsync(VoiceIdentityUnregisterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceIdentityUnregister",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/auth/unregister",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceIdentityUnregisterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 声纹注销
         *
         * @param request VoiceIdentityUnregisterRequest
         * @return VoiceIdentityUnregisterResponse
         */
        public VoiceIdentityUnregisterResponse VoiceIdentityUnregister(VoiceIdentityUnregisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceIdentityUnregisterWithOptions(request, headers, runtime);
        }

        /**
         * @summary 声纹注销
         *
         * @param request VoiceIdentityUnregisterRequest
         * @return VoiceIdentityUnregisterResponse
         */
        public async Task<VoiceIdentityUnregisterResponse> VoiceIdentityUnregisterAsync(VoiceIdentityUnregisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceIdentityUnregisterWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 语音同步检测
         *
         * @param request VoiceSyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceSyncScanResponse
         */
        public VoiceSyncScanResponse VoiceSyncScanWithOptions(VoiceSyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceSyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/syncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceSyncScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 语音同步检测
         *
         * @param request VoiceSyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceSyncScanResponse
         */
        public async Task<VoiceSyncScanResponse> VoiceSyncScanWithOptionsAsync(VoiceSyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceSyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/voice/syncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceSyncScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 语音同步检测
         *
         * @param request VoiceSyncScanRequest
         * @return VoiceSyncScanResponse
         */
        public VoiceSyncScanResponse VoiceSyncScan(VoiceSyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceSyncScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 语音同步检测
         *
         * @param request VoiceSyncScanRequest
         * @return VoiceSyncScanResponse
         */
        public async Task<VoiceSyncScanResponse> VoiceSyncScanAsync(VoiceSyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceSyncScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 站点异步检测
         *
         * @param request WebpageAsyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return WebpageAsyncScanResponse
         */
        public WebpageAsyncScanResponse WebpageAsyncScanWithOptions(WebpageAsyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WebpageAsyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/webpage/asyncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WebpageAsyncScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 站点异步检测
         *
         * @param request WebpageAsyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return WebpageAsyncScanResponse
         */
        public async Task<WebpageAsyncScanResponse> WebpageAsyncScanWithOptionsAsync(WebpageAsyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WebpageAsyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/webpage/asyncscan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WebpageAsyncScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 站点异步检测
         *
         * @param request WebpageAsyncScanRequest
         * @return WebpageAsyncScanResponse
         */
        public WebpageAsyncScanResponse WebpageAsyncScan(WebpageAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return WebpageAsyncScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 站点异步检测
         *
         * @param request WebpageAsyncScanRequest
         * @return WebpageAsyncScanResponse
         */
        public async Task<WebpageAsyncScanResponse> WebpageAsyncScanAsync(WebpageAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await WebpageAsyncScanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 站点异步检测结果
         *
         * @param request WebpageAsyncScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return WebpageAsyncScanResultsResponse
         */
        public WebpageAsyncScanResultsResponse WebpageAsyncScanResultsWithOptions(WebpageAsyncScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WebpageAsyncScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/webpage/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WebpageAsyncScanResultsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 站点异步检测结果
         *
         * @param request WebpageAsyncScanResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return WebpageAsyncScanResultsResponse
         */
        public async Task<WebpageAsyncScanResultsResponse> WebpageAsyncScanResultsWithOptionsAsync(WebpageAsyncScanResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WebpageAsyncScanResults",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/webpage/results",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WebpageAsyncScanResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 站点异步检测结果
         *
         * @param request WebpageAsyncScanResultsRequest
         * @return WebpageAsyncScanResultsResponse
         */
        public WebpageAsyncScanResultsResponse WebpageAsyncScanResults(WebpageAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return WebpageAsyncScanResultsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 站点异步检测结果
         *
         * @param request WebpageAsyncScanResultsRequest
         * @return WebpageAsyncScanResultsResponse
         */
        public async Task<WebpageAsyncScanResultsResponse> WebpageAsyncScanResultsAsync(WebpageAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await WebpageAsyncScanResultsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 站点同步检测
         *
         * @param request WebpageSyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return WebpageSyncScanResponse
         */
        public WebpageSyncScanResponse WebpageSyncScanWithOptions(WebpageSyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WebpageSyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/webpage/scan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WebpageSyncScanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 站点同步检测
         *
         * @param request WebpageSyncScanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return WebpageSyncScanResponse
         */
        public async Task<WebpageSyncScanResponse> WebpageSyncScanWithOptionsAsync(WebpageSyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WebpageSyncScan",
                Version = "2018-05-09",
                Protocol = "HTTPS",
                Pathname = "/green/webpage/scan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WebpageSyncScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 站点同步检测
         *
         * @param request WebpageSyncScanRequest
         * @return WebpageSyncScanResponse
         */
        public WebpageSyncScanResponse WebpageSyncScan(WebpageSyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return WebpageSyncScanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 站点同步检测
         *
         * @param request WebpageSyncScanRequest
         * @return WebpageSyncScanResponse
         */
        public async Task<WebpageSyncScanResponse> WebpageSyncScanAsync(WebpageSyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await WebpageSyncScanWithOptionsAsync(request, headers, runtime);
        }

    }
}
