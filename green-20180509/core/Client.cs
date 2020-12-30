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

        public AddFacesResponse AddFaces(AddFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddFacesWithOptions(request, headers, runtime);
        }

        public async Task<AddFacesResponse> AddFacesAsync(AddFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddFacesWithOptionsAsync(request, headers, runtime);
        }

        public AddFacesResponse AddFacesWithOptions(AddFacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AddFacesResponse>(DoROARequest("AddFaces", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/face/add", "none", req, runtime));
        }

        public async Task<AddFacesResponse> AddFacesWithOptionsAsync(AddFacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AddFacesResponse>(await DoROARequestAsync("AddFaces", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/face/add", "none", req, runtime));
        }

        public AddGroupsResponse AddGroups(AddGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddGroupsWithOptions(request, headers, runtime);
        }

        public async Task<AddGroupsResponse> AddGroupsAsync(AddGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddGroupsWithOptionsAsync(request, headers, runtime);
        }

        public AddGroupsResponse AddGroupsWithOptions(AddGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AddGroupsResponse>(DoROARequest("AddGroups", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/person/groups/add", "none", req, runtime));
        }

        public async Task<AddGroupsResponse> AddGroupsWithOptionsAsync(AddGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AddGroupsResponse>(await DoROARequestAsync("AddGroups", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/person/groups/add", "none", req, runtime));
        }

        public AddPersonResponse AddPerson(AddPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddPersonWithOptions(request, headers, runtime);
        }

        public async Task<AddPersonResponse> AddPersonAsync(AddPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddPersonWithOptionsAsync(request, headers, runtime);
        }

        public AddPersonResponse AddPersonWithOptions(AddPersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AddPersonResponse>(DoROARequest("AddPerson", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/person/add", "none", req, runtime));
        }

        public async Task<AddPersonResponse> AddPersonWithOptionsAsync(AddPersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AddPersonResponse>(await DoROARequestAsync("AddPerson", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/person/add", "none", req, runtime));
        }

        public AddSimilarityImageResponse AddSimilarityImage(AddSimilarityImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddSimilarityImageWithOptions(request, headers, runtime);
        }

        public async Task<AddSimilarityImageResponse> AddSimilarityImageAsync(AddSimilarityImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddSimilarityImageWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<AddSimilarityImageResponse>(DoROARequest("AddSimilarityImage", "2018-05-09", "HTTPS", "POST", "AK", "/green/similarity/image/add", "none", req, runtime));
        }

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
            return TeaModel.ToObject<AddSimilarityImageResponse>(await DoROARequestAsync("AddSimilarityImage", "2018-05-09", "HTTPS", "POST", "AK", "/green/similarity/image/add", "none", req, runtime));
        }

        public AddSimilarityLibraryResponse AddSimilarityLibrary(AddSimilarityLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddSimilarityLibraryWithOptions(request, headers, runtime);
        }

        public async Task<AddSimilarityLibraryResponse> AddSimilarityLibraryAsync(AddSimilarityLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddSimilarityLibraryWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<AddSimilarityLibraryResponse>(DoROARequest("AddSimilarityLibrary", "2018-05-09", "HTTPS", "POST", "AK", "/green/similarity/library/add", "none", req, runtime));
        }

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
            return TeaModel.ToObject<AddSimilarityLibraryResponse>(await DoROARequestAsync("AddSimilarityLibrary", "2018-05-09", "HTTPS", "POST", "AK", "/green/similarity/library/add", "none", req, runtime));
        }

        public AddVideoDnaResponse AddVideoDna(AddVideoDnaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddVideoDnaWithOptions(request, headers, runtime);
        }

        public async Task<AddVideoDnaResponse> AddVideoDnaAsync(AddVideoDnaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddVideoDnaWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<AddVideoDnaResponse>(DoROARequest("AddVideoDna", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/dna/add", "none", req, runtime));
        }

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
            return TeaModel.ToObject<AddVideoDnaResponse>(await DoROARequestAsync("AddVideoDna", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/dna/add", "none", req, runtime));
        }

        public AddVideoDnaGroupResponse AddVideoDnaGroup(AddVideoDnaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddVideoDnaGroupWithOptions(request, headers, runtime);
        }

        public async Task<AddVideoDnaGroupResponse> AddVideoDnaGroupAsync(AddVideoDnaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddVideoDnaGroupWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<AddVideoDnaGroupResponse>(DoROARequest("AddVideoDnaGroup", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/dna/group/add", "none", req, runtime));
        }

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
            return TeaModel.ToObject<AddVideoDnaGroupResponse>(await DoROARequestAsync("AddVideoDnaGroup", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/dna/group/add", "none", req, runtime));
        }

        public DeleteFacesResponse DeleteFaces(DeleteFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFacesWithOptions(request, headers, runtime);
        }

        public async Task<DeleteFacesResponse> DeleteFacesAsync(DeleteFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFacesWithOptionsAsync(request, headers, runtime);
        }

        public DeleteFacesResponse DeleteFacesWithOptions(DeleteFacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteFacesResponse>(DoROARequest("DeleteFaces", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/face/delete", "none", req, runtime));
        }

        public async Task<DeleteFacesResponse> DeleteFacesWithOptionsAsync(DeleteFacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteFacesResponse>(await DoROARequestAsync("DeleteFaces", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/face/delete", "none", req, runtime));
        }

        public DeleteGroupsResponse DeleteGroups(DeleteGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGroupsWithOptions(request, headers, runtime);
        }

        public async Task<DeleteGroupsResponse> DeleteGroupsAsync(DeleteGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGroupsWithOptionsAsync(request, headers, runtime);
        }

        public DeleteGroupsResponse DeleteGroupsWithOptions(DeleteGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteGroupsResponse>(DoROARequest("DeleteGroups", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/person/groups/delete", "none", req, runtime));
        }

        public async Task<DeleteGroupsResponse> DeleteGroupsWithOptionsAsync(DeleteGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteGroupsResponse>(await DoROARequestAsync("DeleteGroups", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/person/groups/delete", "none", req, runtime));
        }

        public DeletePersonResponse DeletePerson(DeletePersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePersonWithOptions(request, headers, runtime);
        }

        public async Task<DeletePersonResponse> DeletePersonAsync(DeletePersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePersonWithOptionsAsync(request, headers, runtime);
        }

        public DeletePersonResponse DeletePersonWithOptions(DeletePersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeletePersonResponse>(DoROARequest("DeletePerson", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/person/delete", "none", req, runtime));
        }

        public async Task<DeletePersonResponse> DeletePersonWithOptionsAsync(DeletePersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeletePersonResponse>(await DoROARequestAsync("DeletePerson", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/person/delete", "none", req, runtime));
        }

        public DeleteSimilarityImageResponse DeleteSimilarityImage(DeleteSimilarityImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSimilarityImageWithOptions(request, headers, runtime);
        }

        public async Task<DeleteSimilarityImageResponse> DeleteSimilarityImageAsync(DeleteSimilarityImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSimilarityImageWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<DeleteSimilarityImageResponse>(DoROARequest("DeleteSimilarityImage", "2018-05-09", "HTTPS", "POST", "AK", "/green/similarity/image/delete", "none", req, runtime));
        }

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
            return TeaModel.ToObject<DeleteSimilarityImageResponse>(await DoROARequestAsync("DeleteSimilarityImage", "2018-05-09", "HTTPS", "POST", "AK", "/green/similarity/image/delete", "none", req, runtime));
        }

        public DeleteSimilarityLibraryResponse DeleteSimilarityLibrary(DeleteSimilarityLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSimilarityLibraryWithOptions(request, headers, runtime);
        }

        public async Task<DeleteSimilarityLibraryResponse> DeleteSimilarityLibraryAsync(DeleteSimilarityLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSimilarityLibraryWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<DeleteSimilarityLibraryResponse>(DoROARequest("DeleteSimilarityLibrary", "2018-05-09", "HTTPS", "POST", "AK", "/green/similarity/library/delete", "none", req, runtime));
        }

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
            return TeaModel.ToObject<DeleteSimilarityLibraryResponse>(await DoROARequestAsync("DeleteSimilarityLibrary", "2018-05-09", "HTTPS", "POST", "AK", "/green/similarity/library/delete", "none", req, runtime));
        }

        public DeleteVideoDnaResponse DeleteVideoDna(DeleteVideoDnaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteVideoDnaWithOptions(request, headers, runtime);
        }

        public async Task<DeleteVideoDnaResponse> DeleteVideoDnaAsync(DeleteVideoDnaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteVideoDnaWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<DeleteVideoDnaResponse>(DoROARequest("DeleteVideoDna", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/dna/delete", "none", req, runtime));
        }

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
            return TeaModel.ToObject<DeleteVideoDnaResponse>(await DoROARequestAsync("DeleteVideoDna", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/dna/delete", "none", req, runtime));
        }

        public DeleteVideoDnaGroupResponse DeleteVideoDnaGroup(DeleteVideoDnaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteVideoDnaGroupWithOptions(request, headers, runtime);
        }

        public async Task<DeleteVideoDnaGroupResponse> DeleteVideoDnaGroupAsync(DeleteVideoDnaGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteVideoDnaGroupWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<DeleteVideoDnaGroupResponse>(DoROARequest("DeleteVideoDnaGroup", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/dna/group/delete", "none", req, runtime));
        }

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
            return TeaModel.ToObject<DeleteVideoDnaGroupResponse>(await DoROARequestAsync("DeleteVideoDnaGroup", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/dna/group/delete", "none", req, runtime));
        }

        public DetectFaceResponse DetectFace(DetectFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DetectFaceWithOptions(request, headers, runtime);
        }

        public async Task<DetectFaceResponse> DetectFaceAsync(DetectFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DetectFaceWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<DetectFaceResponse>(DoROARequest("DetectFace", "2018-05-09", "HTTPS", "POST", "AK", "/green/face/detect", "none", req, runtime));
        }

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
            return TeaModel.ToObject<DetectFaceResponse>(await DoROARequestAsync("DetectFace", "2018-05-09", "HTTPS", "POST", "AK", "/green/face/detect", "none", req, runtime));
        }

        public FileAsyncScanResponse FileAsyncScan(FileAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FileAsyncScanWithOptions(request, headers, runtime);
        }

        public async Task<FileAsyncScanResponse> FileAsyncScanAsync(FileAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FileAsyncScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<FileAsyncScanResponse>(DoROARequest("FileAsyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/file/asyncscan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<FileAsyncScanResponse>(await DoROARequestAsync("FileAsyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/file/asyncscan", "none", req, runtime));
        }

        public FileAsyncScanResultsResponse FileAsyncScanResults(FileAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FileAsyncScanResultsWithOptions(request, headers, runtime);
        }

        public async Task<FileAsyncScanResultsResponse> FileAsyncScanResultsAsync(FileAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FileAsyncScanResultsWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<FileAsyncScanResultsResponse>(DoROARequest("FileAsyncScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/file/results", "none", req, runtime));
        }

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
            return TeaModel.ToObject<FileAsyncScanResultsResponse>(await DoROARequestAsync("FileAsyncScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/file/results", "none", req, runtime));
        }

        public GetAddVideoDnaResultsResponse GetAddVideoDnaResults(GetAddVideoDnaResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAddVideoDnaResultsWithOptions(request, headers, runtime);
        }

        public async Task<GetAddVideoDnaResultsResponse> GetAddVideoDnaResultsAsync(GetAddVideoDnaResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAddVideoDnaResultsWithOptionsAsync(request, headers, runtime);
        }

        public GetAddVideoDnaResultsResponse GetAddVideoDnaResultsWithOptions(GetAddVideoDnaResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetAddVideoDnaResultsResponse>(DoROARequest("GetAddVideoDnaResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/dna/add/results", "none", req, runtime));
        }

        public async Task<GetAddVideoDnaResultsResponse> GetAddVideoDnaResultsWithOptionsAsync(GetAddVideoDnaResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetAddVideoDnaResultsResponse>(await DoROARequestAsync("GetAddVideoDnaResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/dna/add/results", "none", req, runtime));
        }

        public GetFacesResponse GetFaces(GetFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFacesWithOptions(request, headers, runtime);
        }

        public async Task<GetFacesResponse> GetFacesAsync(GetFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFacesWithOptionsAsync(request, headers, runtime);
        }

        public GetFacesResponse GetFacesWithOptions(GetFacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFacesResponse>(DoROARequest("GetFaces", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/faces", "json", req, runtime));
        }

        public async Task<GetFacesResponse> GetFacesWithOptionsAsync(GetFacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFacesResponse>(await DoROARequestAsync("GetFaces", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/faces", "json", req, runtime));
        }

        public GetGroupsResponse GetGroups(GetGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGroupsWithOptions(request, headers, runtime);
        }

        public async Task<GetGroupsResponse> GetGroupsAsync(GetGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGroupsWithOptionsAsync(request, headers, runtime);
        }

        public GetGroupsResponse GetGroupsWithOptions(GetGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetGroupsResponse>(DoROARequest("GetGroups", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/groups", "none", req, runtime));
        }

        public async Task<GetGroupsResponse> GetGroupsWithOptionsAsync(GetGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetGroupsResponse>(await DoROARequestAsync("GetGroups", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/groups", "none", req, runtime));
        }

        public GetPersonResponse GetPerson(GetPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPersonWithOptions(request, headers, runtime);
        }

        public async Task<GetPersonResponse> GetPersonAsync(GetPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPersonWithOptionsAsync(request, headers, runtime);
        }

        public GetPersonResponse GetPersonWithOptions(GetPersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetPersonResponse>(DoROARequest("GetPerson", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/person", "none", req, runtime));
        }

        public async Task<GetPersonResponse> GetPersonWithOptionsAsync(GetPersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetPersonResponse>(await DoROARequestAsync("GetPerson", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/person", "none", req, runtime));
        }

        public GetPersonsResponse GetPersons(GetPersonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPersonsWithOptions(request, headers, runtime);
        }

        public async Task<GetPersonsResponse> GetPersonsAsync(GetPersonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPersonsWithOptionsAsync(request, headers, runtime);
        }

        public GetPersonsResponse GetPersonsWithOptions(GetPersonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetPersonsResponse>(DoROARequest("GetPersons", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/group/persons", "none", req, runtime));
        }

        public async Task<GetPersonsResponse> GetPersonsWithOptionsAsync(GetPersonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetPersonsResponse>(await DoROARequestAsync("GetPersons", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/group/persons", "none", req, runtime));
        }

        public GetSimilarityImageResponse GetSimilarityImage(GetSimilarityImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSimilarityImageWithOptions(request, headers, runtime);
        }

        public async Task<GetSimilarityImageResponse> GetSimilarityImageAsync(GetSimilarityImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSimilarityImageWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetSimilarityImageResponse>(DoROARequest("GetSimilarityImage", "2018-05-09", "HTTPS", "POST", "AK", "/green/similarity/image/get", "none", req, runtime));
        }

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
            return TeaModel.ToObject<GetSimilarityImageResponse>(await DoROARequestAsync("GetSimilarityImage", "2018-05-09", "HTTPS", "POST", "AK", "/green/similarity/image/get", "none", req, runtime));
        }

        public GetSimilarityLibraryResponse GetSimilarityLibrary(GetSimilarityLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSimilarityLibraryWithOptions(request, headers, runtime);
        }

        public async Task<GetSimilarityLibraryResponse> GetSimilarityLibraryAsync(GetSimilarityLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSimilarityLibraryWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetSimilarityLibraryResponse>(DoROARequest("GetSimilarityLibrary", "2018-05-09", "HTTPS", "POST", "AK", "/green/similarity/library/get", "none", req, runtime));
        }

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
            return TeaModel.ToObject<GetSimilarityLibraryResponse>(await DoROARequestAsync("GetSimilarityLibrary", "2018-05-09", "HTTPS", "POST", "AK", "/green/similarity/library/get", "none", req, runtime));
        }

        public ImageAsyncManualScanResponse ImageAsyncManualScan(ImageAsyncManualScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ImageAsyncManualScanWithOptions(request, headers, runtime);
        }

        public async Task<ImageAsyncManualScanResponse> ImageAsyncManualScanAsync(ImageAsyncManualScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ImageAsyncManualScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<ImageAsyncManualScanResponse>(DoROARequest("ImageAsyncManualScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/image/manual/asyncScan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<ImageAsyncManualScanResponse>(await DoROARequestAsync("ImageAsyncManualScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/image/manual/asyncScan", "none", req, runtime));
        }

        public ImageAsyncManualScanResultsResponse ImageAsyncManualScanResults(ImageAsyncManualScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ImageAsyncManualScanResultsWithOptions(request, headers, runtime);
        }

        public async Task<ImageAsyncManualScanResultsResponse> ImageAsyncManualScanResultsAsync(ImageAsyncManualScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ImageAsyncManualScanResultsWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<ImageAsyncManualScanResultsResponse>(DoROARequest("ImageAsyncManualScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/image/manual/scan/results", "none", req, runtime));
        }

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
            return TeaModel.ToObject<ImageAsyncManualScanResultsResponse>(await DoROARequestAsync("ImageAsyncManualScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/image/manual/scan/results", "none", req, runtime));
        }

        public ImageAsyncScanResponse ImageAsyncScan(ImageAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ImageAsyncScanWithOptions(request, headers, runtime);
        }

        public async Task<ImageAsyncScanResponse> ImageAsyncScanAsync(ImageAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ImageAsyncScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<ImageAsyncScanResponse>(DoROARequest("ImageAsyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/image/asyncscan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<ImageAsyncScanResponse>(await DoROARequestAsync("ImageAsyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/image/asyncscan", "none", req, runtime));
        }

        public ImageAsyncScanResultsResponse ImageAsyncScanResults(ImageAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ImageAsyncScanResultsWithOptions(request, headers, runtime);
        }

        public async Task<ImageAsyncScanResultsResponse> ImageAsyncScanResultsAsync(ImageAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ImageAsyncScanResultsWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<ImageAsyncScanResultsResponse>(DoROARequest("ImageAsyncScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/image/results", "none", req, runtime));
        }

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
            return TeaModel.ToObject<ImageAsyncScanResultsResponse>(await DoROARequestAsync("ImageAsyncScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/image/results", "none", req, runtime));
        }

        public ImageScanFeedbackResponse ImageScanFeedback(ImageScanFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ImageScanFeedbackWithOptions(request, headers, runtime);
        }

        public async Task<ImageScanFeedbackResponse> ImageScanFeedbackAsync(ImageScanFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ImageScanFeedbackWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<ImageScanFeedbackResponse>(DoROARequest("ImageScanFeedback", "2018-05-09", "HTTPS", "POST", "AK", "/green/image/feedback", "none", req, runtime));
        }

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
            return TeaModel.ToObject<ImageScanFeedbackResponse>(await DoROARequestAsync("ImageScanFeedback", "2018-05-09", "HTTPS", "POST", "AK", "/green/image/feedback", "none", req, runtime));
        }

        public ImageSyncScanResponse ImageSyncScan(ImageSyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ImageSyncScanWithOptions(request, headers, runtime);
        }

        public async Task<ImageSyncScanResponse> ImageSyncScanAsync(ImageSyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ImageSyncScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<ImageSyncScanResponse>(DoROARequest("ImageSyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/image/scan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<ImageSyncScanResponse>(await DoROARequestAsync("ImageSyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/image/scan", "none", req, runtime));
        }

        public ListSimilarityImagesResponse ListSimilarityImages(ListSimilarityImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSimilarityImagesWithOptions(request, headers, runtime);
        }

        public async Task<ListSimilarityImagesResponse> ListSimilarityImagesAsync(ListSimilarityImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSimilarityImagesWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<ListSimilarityImagesResponse>(DoROARequest("ListSimilarityImages", "2018-05-09", "HTTPS", "POST", "AK", "/green/similarity/image/list", "none", req, runtime));
        }

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
            return TeaModel.ToObject<ListSimilarityImagesResponse>(await DoROARequestAsync("ListSimilarityImages", "2018-05-09", "HTTPS", "POST", "AK", "/green/similarity/image/list", "none", req, runtime));
        }

        public ListSimilarityLibrariesResponse ListSimilarityLibraries(ListSimilarityLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSimilarityLibrariesWithOptions(request, headers, runtime);
        }

        public async Task<ListSimilarityLibrariesResponse> ListSimilarityLibrariesAsync(ListSimilarityLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSimilarityLibrariesWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<ListSimilarityLibrariesResponse>(DoROARequest("ListSimilarityLibraries", "2018-05-09", "HTTPS", "POST", "AK", "/green/similarity/library/list", "none", req, runtime));
        }

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
            return TeaModel.ToObject<ListSimilarityLibrariesResponse>(await DoROARequestAsync("ListSimilarityLibraries", "2018-05-09", "HTTPS", "POST", "AK", "/green/similarity/library/list", "none", req, runtime));
        }

        public LiveStreamAsyncScanResponse LiveStreamAsyncScan(LiveStreamAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return LiveStreamAsyncScanWithOptions(request, headers, runtime);
        }

        public async Task<LiveStreamAsyncScanResponse> LiveStreamAsyncScanAsync(LiveStreamAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await LiveStreamAsyncScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<LiveStreamAsyncScanResponse>(DoROARequest("LiveStreamAsyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/livestream/asyncscan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<LiveStreamAsyncScanResponse>(await DoROARequestAsync("LiveStreamAsyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/livestream/asyncscan", "none", req, runtime));
        }

        public LiveStreamAsyncScanResultsResponse LiveStreamAsyncScanResults(LiveStreamAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return LiveStreamAsyncScanResultsWithOptions(request, headers, runtime);
        }

        public async Task<LiveStreamAsyncScanResultsResponse> LiveStreamAsyncScanResultsAsync(LiveStreamAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await LiveStreamAsyncScanResultsWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<LiveStreamAsyncScanResultsResponse>(DoROARequest("LiveStreamAsyncScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/livestream/results", "none", req, runtime));
        }

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
            return TeaModel.ToObject<LiveStreamAsyncScanResultsResponse>(await DoROARequestAsync("LiveStreamAsyncScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/livestream/results", "none", req, runtime));
        }

        public LiveStreamCancelScanResponse LiveStreamCancelScan(LiveStreamCancelScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return LiveStreamCancelScanWithOptions(request, headers, runtime);
        }

        public async Task<LiveStreamCancelScanResponse> LiveStreamCancelScanAsync(LiveStreamCancelScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await LiveStreamCancelScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<LiveStreamCancelScanResponse>(DoROARequest("LiveStreamCancelScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/livestream/cancelscan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<LiveStreamCancelScanResponse>(await DoROARequestAsync("LiveStreamCancelScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/livestream/cancelscan", "none", req, runtime));
        }

        public SearchPersonResponse SearchPerson(SearchPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchPersonWithOptions(request, headers, runtime);
        }

        public async Task<SearchPersonResponse> SearchPersonAsync(SearchPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchPersonWithOptionsAsync(request, headers, runtime);
        }

        public SearchPersonResponse SearchPersonWithOptions(SearchPersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<SearchPersonResponse>(DoROARequest("SearchPerson", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/search", "none", req, runtime));
        }

        public async Task<SearchPersonResponse> SearchPersonWithOptionsAsync(SearchPersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<SearchPersonResponse>(await DoROARequestAsync("SearchPerson", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/search", "none", req, runtime));
        }

        public SetPersonResponse SetPerson(SetPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SetPersonWithOptions(request, headers, runtime);
        }

        public async Task<SetPersonResponse> SetPersonAsync(SetPersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SetPersonWithOptionsAsync(request, headers, runtime);
        }

        public SetPersonResponse SetPersonWithOptions(SetPersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<SetPersonResponse>(DoROARequest("SetPerson", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/person/update", "none", req, runtime));
        }

        public async Task<SetPersonResponse> SetPersonWithOptionsAsync(SetPersonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<SetPersonResponse>(await DoROARequestAsync("SetPerson", "2018-05-09", "HTTPS", "POST", "AK", "/green/sface/person/update", "none", req, runtime));
        }

        public TextAsyncManualScanResponse TextAsyncManualScan(TextAsyncManualScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TextAsyncManualScanWithOptions(request, headers, runtime);
        }

        public async Task<TextAsyncManualScanResponse> TextAsyncManualScanAsync(TextAsyncManualScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TextAsyncManualScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<TextAsyncManualScanResponse>(DoROARequest("TextAsyncManualScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/text/manual/asyncScan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<TextAsyncManualScanResponse>(await DoROARequestAsync("TextAsyncManualScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/text/manual/asyncScan", "none", req, runtime));
        }

        public TextAsyncManualScanResultsResponse TextAsyncManualScanResults(TextAsyncManualScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TextAsyncManualScanResultsWithOptions(request, headers, runtime);
        }

        public async Task<TextAsyncManualScanResultsResponse> TextAsyncManualScanResultsAsync(TextAsyncManualScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TextAsyncManualScanResultsWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<TextAsyncManualScanResultsResponse>(DoROARequest("TextAsyncManualScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/text/manual/scan/results", "none", req, runtime));
        }

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
            return TeaModel.ToObject<TextAsyncManualScanResultsResponse>(await DoROARequestAsync("TextAsyncManualScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/text/manual/scan/results", "none", req, runtime));
        }

        public TextFeedbackResponse TextFeedback(TextFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TextFeedbackWithOptions(request, headers, runtime);
        }

        public async Task<TextFeedbackResponse> TextFeedbackAsync(TextFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TextFeedbackWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<TextFeedbackResponse>(DoROARequest("TextFeedback", "2018-05-09", "HTTPS", "POST", "AK", "/green/text/feedback", "none", req, runtime));
        }

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
            return TeaModel.ToObject<TextFeedbackResponse>(await DoROARequestAsync("TextFeedback", "2018-05-09", "HTTPS", "POST", "AK", "/green/text/feedback", "none", req, runtime));
        }

        public TextScanResponse TextScan(TextScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TextScanWithOptions(request, headers, runtime);
        }

        public async Task<TextScanResponse> TextScanAsync(TextScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TextScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<TextScanResponse>(DoROARequest("TextScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/text/scan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<TextScanResponse>(await DoROARequestAsync("TextScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/text/scan", "none", req, runtime));
        }

        public UploadCredentialsResponse UploadCredentials(UploadCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UploadCredentialsWithOptions(request, headers, runtime);
        }

        public async Task<UploadCredentialsResponse> UploadCredentialsAsync(UploadCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UploadCredentialsWithOptionsAsync(request, headers, runtime);
        }

        public UploadCredentialsResponse UploadCredentialsWithOptions(UploadCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UploadCredentialsResponse>(DoROARequest("UploadCredentials", "2018-05-09", "HTTPS", "POST", "AK", "/green/credentials/uploadcredentials", "none", req, runtime));
        }

        public async Task<UploadCredentialsResponse> UploadCredentialsWithOptionsAsync(UploadCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UploadCredentialsResponse>(await DoROARequestAsync("UploadCredentials", "2018-05-09", "HTTPS", "POST", "AK", "/green/credentials/uploadcredentials", "none", req, runtime));
        }

        public VideoAsyncManualScanResponse VideoAsyncManualScan(VideoAsyncManualScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VideoAsyncManualScanWithOptions(request, headers, runtime);
        }

        public async Task<VideoAsyncManualScanResponse> VideoAsyncManualScanAsync(VideoAsyncManualScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VideoAsyncManualScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<VideoAsyncManualScanResponse>(DoROARequest("VideoAsyncManualScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/manual/asyncScan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<VideoAsyncManualScanResponse>(await DoROARequestAsync("VideoAsyncManualScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/manual/asyncScan", "none", req, runtime));
        }

        public VideoAsyncManualScanResultsResponse VideoAsyncManualScanResults(VideoAsyncManualScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VideoAsyncManualScanResultsWithOptions(request, headers, runtime);
        }

        public async Task<VideoAsyncManualScanResultsResponse> VideoAsyncManualScanResultsAsync(VideoAsyncManualScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VideoAsyncManualScanResultsWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<VideoAsyncManualScanResultsResponse>(DoROARequest("VideoAsyncManualScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/manual/scan/results", "none", req, runtime));
        }

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
            return TeaModel.ToObject<VideoAsyncManualScanResultsResponse>(await DoROARequestAsync("VideoAsyncManualScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/manual/scan/results", "none", req, runtime));
        }

        public VideoAsyncScanResponse VideoAsyncScan(VideoAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VideoAsyncScanWithOptions(request, headers, runtime);
        }

        public async Task<VideoAsyncScanResponse> VideoAsyncScanAsync(VideoAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VideoAsyncScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<VideoAsyncScanResponse>(DoROARequest("VideoAsyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/asyncscan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<VideoAsyncScanResponse>(await DoROARequestAsync("VideoAsyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/asyncscan", "none", req, runtime));
        }

        public VideoAsyncScanResultsResponse VideoAsyncScanResults(VideoAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VideoAsyncScanResultsWithOptions(request, headers, runtime);
        }

        public async Task<VideoAsyncScanResultsResponse> VideoAsyncScanResultsAsync(VideoAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VideoAsyncScanResultsWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<VideoAsyncScanResultsResponse>(DoROARequest("VideoAsyncScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/results", "none", req, runtime));
        }

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
            return TeaModel.ToObject<VideoAsyncScanResultsResponse>(await DoROARequestAsync("VideoAsyncScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/results", "none", req, runtime));
        }

        public VideoCancelScanResponse VideoCancelScan(VideoCancelScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VideoCancelScanWithOptions(request, headers, runtime);
        }

        public async Task<VideoCancelScanResponse> VideoCancelScanAsync(VideoCancelScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VideoCancelScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<VideoCancelScanResponse>(DoROARequest("VideoCancelScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/cancelscan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<VideoCancelScanResponse>(await DoROARequestAsync("VideoCancelScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/cancelscan", "none", req, runtime));
        }

        public VideoFeedbackResponse VideoFeedback(VideoFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VideoFeedbackWithOptions(request, headers, runtime);
        }

        public async Task<VideoFeedbackResponse> VideoFeedbackAsync(VideoFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VideoFeedbackWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<VideoFeedbackResponse>(DoROARequest("VideoFeedback", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/feedback", "none", req, runtime));
        }

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
            return TeaModel.ToObject<VideoFeedbackResponse>(await DoROARequestAsync("VideoFeedback", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/feedback", "none", req, runtime));
        }

        public VideoSyncScanResponse VideoSyncScan(VideoSyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VideoSyncScanWithOptions(request, headers, runtime);
        }

        public async Task<VideoSyncScanResponse> VideoSyncScanAsync(VideoSyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VideoSyncScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<VideoSyncScanResponse>(DoROARequest("VideoSyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/syncscan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<VideoSyncScanResponse>(await DoROARequestAsync("VideoSyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/video/syncscan", "none", req, runtime));
        }

        public VodAsyncScanResponse VodAsyncScan(VodAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VodAsyncScanWithOptions(request, headers, runtime);
        }

        public async Task<VodAsyncScanResponse> VodAsyncScanAsync(VodAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VodAsyncScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<VodAsyncScanResponse>(DoROARequest("VodAsyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/vod/asyncscan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<VodAsyncScanResponse>(await DoROARequestAsync("VodAsyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/vod/asyncscan", "none", req, runtime));
        }

        public VodAsyncScanResultsResponse VodAsyncScanResults(VodAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VodAsyncScanResultsWithOptions(request, headers, runtime);
        }

        public async Task<VodAsyncScanResultsResponse> VodAsyncScanResultsAsync(VodAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VodAsyncScanResultsWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<VodAsyncScanResultsResponse>(DoROARequest("VodAsyncScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/vod/results", "none", req, runtime));
        }

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
            return TeaModel.ToObject<VodAsyncScanResultsResponse>(await DoROARequestAsync("VodAsyncScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/vod/results", "none", req, runtime));
        }

        public VoiceAsyncManualScanResponse VoiceAsyncManualScan(VoiceAsyncManualScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceAsyncManualScanWithOptions(request, headers, runtime);
        }

        public async Task<VoiceAsyncManualScanResponse> VoiceAsyncManualScanAsync(VoiceAsyncManualScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceAsyncManualScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<VoiceAsyncManualScanResponse>(DoROARequest("VoiceAsyncManualScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/manual/asyncScan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<VoiceAsyncManualScanResponse>(await DoROARequestAsync("VoiceAsyncManualScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/manual/asyncScan", "none", req, runtime));
        }

        public VoiceAsyncManualScanResultsResponse VoiceAsyncManualScanResults(VoiceAsyncManualScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceAsyncManualScanResultsWithOptions(request, headers, runtime);
        }

        public async Task<VoiceAsyncManualScanResultsResponse> VoiceAsyncManualScanResultsAsync(VoiceAsyncManualScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceAsyncManualScanResultsWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<VoiceAsyncManualScanResultsResponse>(DoROARequest("VoiceAsyncManualScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/manual/scan/results", "none", req, runtime));
        }

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
            return TeaModel.ToObject<VoiceAsyncManualScanResultsResponse>(await DoROARequestAsync("VoiceAsyncManualScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/manual/scan/results", "none", req, runtime));
        }

        public VoiceAsyncScanResponse VoiceAsyncScan(VoiceAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceAsyncScanWithOptions(request, headers, runtime);
        }

        public async Task<VoiceAsyncScanResponse> VoiceAsyncScanAsync(VoiceAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceAsyncScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<VoiceAsyncScanResponse>(DoROARequest("VoiceAsyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/asyncscan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<VoiceAsyncScanResponse>(await DoROARequestAsync("VoiceAsyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/asyncscan", "none", req, runtime));
        }

        public VoiceAsyncScanResultsResponse VoiceAsyncScanResults(VoiceAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceAsyncScanResultsWithOptions(request, headers, runtime);
        }

        public async Task<VoiceAsyncScanResultsResponse> VoiceAsyncScanResultsAsync(VoiceAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceAsyncScanResultsWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<VoiceAsyncScanResultsResponse>(DoROARequest("VoiceAsyncScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/results", "none", req, runtime));
        }

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
            return TeaModel.ToObject<VoiceAsyncScanResultsResponse>(await DoROARequestAsync("VoiceAsyncScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/results", "none", req, runtime));
        }

        public VoiceCancelScanResponse VoiceCancelScan(VoiceCancelScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceCancelScanWithOptions(request, headers, runtime);
        }

        public async Task<VoiceCancelScanResponse> VoiceCancelScanAsync(VoiceCancelScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceCancelScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<VoiceCancelScanResponse>(DoROARequest("VoiceCancelScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/cancelscan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<VoiceCancelScanResponse>(await DoROARequestAsync("VoiceCancelScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/cancelscan", "none", req, runtime));
        }

        public VoiceIdentityCheckResponse VoiceIdentityCheck(VoiceIdentityCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceIdentityCheckWithOptions(request, headers, runtime);
        }

        public async Task<VoiceIdentityCheckResponse> VoiceIdentityCheckAsync(VoiceIdentityCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceIdentityCheckWithOptionsAsync(request, headers, runtime);
        }

        public VoiceIdentityCheckResponse VoiceIdentityCheckWithOptions(VoiceIdentityCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<VoiceIdentityCheckResponse>(DoROARequest("VoiceIdentityCheck", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/auth/check", "none", req, runtime));
        }

        public async Task<VoiceIdentityCheckResponse> VoiceIdentityCheckWithOptionsAsync(VoiceIdentityCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<VoiceIdentityCheckResponse>(await DoROARequestAsync("VoiceIdentityCheck", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/auth/check", "none", req, runtime));
        }

        public VoiceIdentityRegisterResponse VoiceIdentityRegister(VoiceIdentityRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceIdentityRegisterWithOptions(request, headers, runtime);
        }

        public async Task<VoiceIdentityRegisterResponse> VoiceIdentityRegisterAsync(VoiceIdentityRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceIdentityRegisterWithOptionsAsync(request, headers, runtime);
        }

        public VoiceIdentityRegisterResponse VoiceIdentityRegisterWithOptions(VoiceIdentityRegisterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<VoiceIdentityRegisterResponse>(DoROARequest("VoiceIdentityRegister", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/auth/register", "none", req, runtime));
        }

        public async Task<VoiceIdentityRegisterResponse> VoiceIdentityRegisterWithOptionsAsync(VoiceIdentityRegisterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<VoiceIdentityRegisterResponse>(await DoROARequestAsync("VoiceIdentityRegister", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/auth/register", "none", req, runtime));
        }

        public VoiceIdentityStartCheckResponse VoiceIdentityStartCheck(VoiceIdentityStartCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceIdentityStartCheckWithOptions(request, headers, runtime);
        }

        public async Task<VoiceIdentityStartCheckResponse> VoiceIdentityStartCheckAsync(VoiceIdentityStartCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceIdentityStartCheckWithOptionsAsync(request, headers, runtime);
        }

        public VoiceIdentityStartCheckResponse VoiceIdentityStartCheckWithOptions(VoiceIdentityStartCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<VoiceIdentityStartCheckResponse>(DoROARequest("VoiceIdentityStartCheck", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/auth/start/check", "none", req, runtime));
        }

        public async Task<VoiceIdentityStartCheckResponse> VoiceIdentityStartCheckWithOptionsAsync(VoiceIdentityStartCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<VoiceIdentityStartCheckResponse>(await DoROARequestAsync("VoiceIdentityStartCheck", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/auth/start/check", "none", req, runtime));
        }

        public VoiceIdentityStartRegisterResponse VoiceIdentityStartRegister(VoiceIdentityStartRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceIdentityStartRegisterWithOptions(request, headers, runtime);
        }

        public async Task<VoiceIdentityStartRegisterResponse> VoiceIdentityStartRegisterAsync(VoiceIdentityStartRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceIdentityStartRegisterWithOptionsAsync(request, headers, runtime);
        }

        public VoiceIdentityStartRegisterResponse VoiceIdentityStartRegisterWithOptions(VoiceIdentityStartRegisterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<VoiceIdentityStartRegisterResponse>(DoROARequest("VoiceIdentityStartRegister", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/auth/start/register", "none", req, runtime));
        }

        public async Task<VoiceIdentityStartRegisterResponse> VoiceIdentityStartRegisterWithOptionsAsync(VoiceIdentityStartRegisterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<VoiceIdentityStartRegisterResponse>(await DoROARequestAsync("VoiceIdentityStartRegister", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/auth/start/register", "none", req, runtime));
        }

        public VoiceIdentityUnregisterResponse VoiceIdentityUnregister(VoiceIdentityUnregisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceIdentityUnregisterWithOptions(request, headers, runtime);
        }

        public async Task<VoiceIdentityUnregisterResponse> VoiceIdentityUnregisterAsync(VoiceIdentityUnregisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceIdentityUnregisterWithOptionsAsync(request, headers, runtime);
        }

        public VoiceIdentityUnregisterResponse VoiceIdentityUnregisterWithOptions(VoiceIdentityUnregisterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<VoiceIdentityUnregisterResponse>(DoROARequest("VoiceIdentityUnregister", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/auth/unregister", "none", req, runtime));
        }

        public async Task<VoiceIdentityUnregisterResponse> VoiceIdentityUnregisterWithOptionsAsync(VoiceIdentityUnregisterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<VoiceIdentityUnregisterResponse>(await DoROARequestAsync("VoiceIdentityUnregister", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/auth/unregister", "none", req, runtime));
        }

        public VoiceSyncScanResponse VoiceSyncScan(VoiceSyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VoiceSyncScanWithOptions(request, headers, runtime);
        }

        public async Task<VoiceSyncScanResponse> VoiceSyncScanAsync(VoiceSyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VoiceSyncScanWithOptionsAsync(request, headers, runtime);
        }

        public VoiceSyncScanResponse VoiceSyncScanWithOptions(VoiceSyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<VoiceSyncScanResponse>(DoROARequest("VoiceSyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/syncscan", "none", req, runtime));
        }

        public async Task<VoiceSyncScanResponse> VoiceSyncScanWithOptionsAsync(VoiceSyncScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<VoiceSyncScanResponse>(await DoROARequestAsync("VoiceSyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/voice/syncscan", "none", req, runtime));
        }

        public WebpageAsyncScanResponse WebpageAsyncScan(WebpageAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return WebpageAsyncScanWithOptions(request, headers, runtime);
        }

        public async Task<WebpageAsyncScanResponse> WebpageAsyncScanAsync(WebpageAsyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await WebpageAsyncScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<WebpageAsyncScanResponse>(DoROARequest("WebpageAsyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/webpage/asyncscan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<WebpageAsyncScanResponse>(await DoROARequestAsync("WebpageAsyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/webpage/asyncscan", "none", req, runtime));
        }

        public WebpageAsyncScanResultsResponse WebpageAsyncScanResults(WebpageAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return WebpageAsyncScanResultsWithOptions(request, headers, runtime);
        }

        public async Task<WebpageAsyncScanResultsResponse> WebpageAsyncScanResultsAsync(WebpageAsyncScanResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await WebpageAsyncScanResultsWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<WebpageAsyncScanResultsResponse>(DoROARequest("WebpageAsyncScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/webpage/results", "none", req, runtime));
        }

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
            return TeaModel.ToObject<WebpageAsyncScanResultsResponse>(await DoROARequestAsync("WebpageAsyncScanResults", "2018-05-09", "HTTPS", "POST", "AK", "/green/webpage/results", "none", req, runtime));
        }

        public WebpageSyncScanResponse WebpageSyncScan(WebpageSyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return WebpageSyncScanWithOptions(request, headers, runtime);
        }

        public async Task<WebpageSyncScanResponse> WebpageSyncScanAsync(WebpageSyncScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await WebpageSyncScanWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<WebpageSyncScanResponse>(DoROARequest("WebpageSyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/webpage/scan", "none", req, runtime));
        }

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
            return TeaModel.ToObject<WebpageSyncScanResponse>(await DoROARequestAsync("WebpageSyncScan", "2018-05-09", "HTTPS", "POST", "AK", "/green/webpage/scan", "none", req, runtime));
        }

    }
}
