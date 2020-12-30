// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CloudPhoto20170711.Models;

namespace AlibabaCloud.SDK.CloudPhoto20170711
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudphoto", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ActivatePhotosResponse ActivatePhotosWithOptions(ActivatePhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActivatePhotosResponse>(DoRPCRequest("ActivatePhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ActivatePhotosResponse> ActivatePhotosWithOptionsAsync(ActivatePhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActivatePhotosResponse>(await DoRPCRequestAsync("ActivatePhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ActivatePhotosResponse ActivatePhotos(ActivatePhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActivatePhotosWithOptions(request, runtime);
        }

        public async Task<ActivatePhotosResponse> ActivatePhotosAsync(ActivatePhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActivatePhotosWithOptionsAsync(request, runtime);
        }

        public AddAlbumPhotosResponse AddAlbumPhotosWithOptions(AddAlbumPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAlbumPhotosResponse>(DoRPCRequest("AddAlbumPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddAlbumPhotosResponse> AddAlbumPhotosWithOptionsAsync(AddAlbumPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAlbumPhotosResponse>(await DoRPCRequestAsync("AddAlbumPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddAlbumPhotosResponse AddAlbumPhotos(AddAlbumPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAlbumPhotosWithOptions(request, runtime);
        }

        public async Task<AddAlbumPhotosResponse> AddAlbumPhotosAsync(AddAlbumPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAlbumPhotosWithOptionsAsync(request, runtime);
        }

        public CreateAlbumResponse CreateAlbumWithOptions(CreateAlbumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAlbumResponse>(DoRPCRequest("CreateAlbum", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAlbumResponse> CreateAlbumWithOptionsAsync(CreateAlbumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAlbumResponse>(await DoRPCRequestAsync("CreateAlbum", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAlbumResponse CreateAlbum(CreateAlbumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAlbumWithOptions(request, runtime);
        }

        public async Task<CreateAlbumResponse> CreateAlbumAsync(CreateAlbumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAlbumWithOptionsAsync(request, runtime);
        }

        public CreatePhotoResponse CreatePhotoWithOptions(CreatePhotoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePhotoResponse>(DoRPCRequest("CreatePhoto", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePhotoResponse> CreatePhotoWithOptionsAsync(CreatePhotoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePhotoResponse>(await DoRPCRequestAsync("CreatePhoto", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePhotoResponse CreatePhoto(CreatePhotoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePhotoWithOptions(request, runtime);
        }

        public async Task<CreatePhotoResponse> CreatePhotoAsync(CreatePhotoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePhotoWithOptionsAsync(request, runtime);
        }

        public CreatePhotoStoreResponse CreatePhotoStoreWithOptions(CreatePhotoStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePhotoStoreResponse>(DoRPCRequest("CreatePhotoStore", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePhotoStoreResponse> CreatePhotoStoreWithOptionsAsync(CreatePhotoStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePhotoStoreResponse>(await DoRPCRequestAsync("CreatePhotoStore", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePhotoStoreResponse CreatePhotoStore(CreatePhotoStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePhotoStoreWithOptions(request, runtime);
        }

        public async Task<CreatePhotoStoreResponse> CreatePhotoStoreAsync(CreatePhotoStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePhotoStoreWithOptionsAsync(request, runtime);
        }

        public CreateTransactionResponse CreateTransactionWithOptions(CreateTransactionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTransactionResponse>(DoRPCRequest("CreateTransaction", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTransactionResponse> CreateTransactionWithOptionsAsync(CreateTransactionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTransactionResponse>(await DoRPCRequestAsync("CreateTransaction", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTransactionResponse CreateTransaction(CreateTransactionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTransactionWithOptions(request, runtime);
        }

        public async Task<CreateTransactionResponse> CreateTransactionAsync(CreateTransactionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTransactionWithOptionsAsync(request, runtime);
        }

        public DeleteAlbumsResponse DeleteAlbumsWithOptions(DeleteAlbumsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlbumsResponse>(DoRPCRequest("DeleteAlbums", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAlbumsResponse> DeleteAlbumsWithOptionsAsync(DeleteAlbumsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlbumsResponse>(await DoRPCRequestAsync("DeleteAlbums", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAlbumsResponse DeleteAlbums(DeleteAlbumsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAlbumsWithOptions(request, runtime);
        }

        public async Task<DeleteAlbumsResponse> DeleteAlbumsAsync(DeleteAlbumsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAlbumsWithOptionsAsync(request, runtime);
        }

        public DeleteEventResponse DeleteEventWithOptions(DeleteEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEventResponse>(DoRPCRequest("DeleteEvent", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteEventResponse> DeleteEventWithOptionsAsync(DeleteEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEventResponse>(await DoRPCRequestAsync("DeleteEvent", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteEventResponse DeleteEvent(DeleteEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventWithOptions(request, runtime);
        }

        public async Task<DeleteEventResponse> DeleteEventAsync(DeleteEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventWithOptionsAsync(request, runtime);
        }

        public DeleteFacesResponse DeleteFacesWithOptions(DeleteFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFacesResponse>(DoRPCRequest("DeleteFaces", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFacesResponse> DeleteFacesWithOptionsAsync(DeleteFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFacesResponse>(await DoRPCRequestAsync("DeleteFaces", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFacesResponse DeleteFaces(DeleteFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFacesWithOptions(request, runtime);
        }

        public async Task<DeleteFacesResponse> DeleteFacesAsync(DeleteFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFacesWithOptionsAsync(request, runtime);
        }

        public DeletePhotosResponse DeletePhotosWithOptions(DeletePhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePhotosResponse>(DoRPCRequest("DeletePhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeletePhotosResponse> DeletePhotosWithOptionsAsync(DeletePhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePhotosResponse>(await DoRPCRequestAsync("DeletePhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeletePhotosResponse DeletePhotos(DeletePhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePhotosWithOptions(request, runtime);
        }

        public async Task<DeletePhotosResponse> DeletePhotosAsync(DeletePhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePhotosWithOptionsAsync(request, runtime);
        }

        public DeletePhotoStoreResponse DeletePhotoStoreWithOptions(DeletePhotoStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePhotoStoreResponse>(DoRPCRequest("DeletePhotoStore", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeletePhotoStoreResponse> DeletePhotoStoreWithOptionsAsync(DeletePhotoStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePhotoStoreResponse>(await DoRPCRequestAsync("DeletePhotoStore", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeletePhotoStoreResponse DeletePhotoStore(DeletePhotoStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePhotoStoreWithOptions(request, runtime);
        }

        public async Task<DeletePhotoStoreResponse> DeletePhotoStoreAsync(DeletePhotoStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePhotoStoreWithOptionsAsync(request, runtime);
        }

        public EditPhotosResponse EditPhotosWithOptions(EditPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditPhotosResponse>(DoRPCRequest("EditPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EditPhotosResponse> EditPhotosWithOptionsAsync(EditPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditPhotosResponse>(await DoRPCRequestAsync("EditPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EditPhotosResponse EditPhotos(EditPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditPhotosWithOptions(request, runtime);
        }

        public async Task<EditPhotosResponse> EditPhotosAsync(EditPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditPhotosWithOptionsAsync(request, runtime);
        }

        public EditPhotoStoreResponse EditPhotoStoreWithOptions(EditPhotoStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditPhotoStoreResponse>(DoRPCRequest("EditPhotoStore", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EditPhotoStoreResponse> EditPhotoStoreWithOptionsAsync(EditPhotoStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditPhotoStoreResponse>(await DoRPCRequestAsync("EditPhotoStore", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EditPhotoStoreResponse EditPhotoStore(EditPhotoStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditPhotoStoreWithOptions(request, runtime);
        }

        public async Task<EditPhotoStoreResponse> EditPhotoStoreAsync(EditPhotoStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditPhotoStoreWithOptionsAsync(request, runtime);
        }

        public FetchAlbumTagPhotosResponse FetchAlbumTagPhotosWithOptions(FetchAlbumTagPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FetchAlbumTagPhotosResponse>(DoRPCRequest("FetchAlbumTagPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FetchAlbumTagPhotosResponse> FetchAlbumTagPhotosWithOptionsAsync(FetchAlbumTagPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FetchAlbumTagPhotosResponse>(await DoRPCRequestAsync("FetchAlbumTagPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FetchAlbumTagPhotosResponse FetchAlbumTagPhotos(FetchAlbumTagPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FetchAlbumTagPhotosWithOptions(request, runtime);
        }

        public async Task<FetchAlbumTagPhotosResponse> FetchAlbumTagPhotosAsync(FetchAlbumTagPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FetchAlbumTagPhotosWithOptionsAsync(request, runtime);
        }

        public FetchLibrariesResponse FetchLibrariesWithOptions(FetchLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FetchLibrariesResponse>(DoRPCRequest("FetchLibraries", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FetchLibrariesResponse> FetchLibrariesWithOptionsAsync(FetchLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FetchLibrariesResponse>(await DoRPCRequestAsync("FetchLibraries", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FetchLibrariesResponse FetchLibraries(FetchLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FetchLibrariesWithOptions(request, runtime);
        }

        public async Task<FetchLibrariesResponse> FetchLibrariesAsync(FetchLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FetchLibrariesWithOptionsAsync(request, runtime);
        }

        public FetchMomentPhotosResponse FetchMomentPhotosWithOptions(FetchMomentPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FetchMomentPhotosResponse>(DoRPCRequest("FetchMomentPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FetchMomentPhotosResponse> FetchMomentPhotosWithOptionsAsync(FetchMomentPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FetchMomentPhotosResponse>(await DoRPCRequestAsync("FetchMomentPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FetchMomentPhotosResponse FetchMomentPhotos(FetchMomentPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FetchMomentPhotosWithOptions(request, runtime);
        }

        public async Task<FetchMomentPhotosResponse> FetchMomentPhotosAsync(FetchMomentPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FetchMomentPhotosWithOptionsAsync(request, runtime);
        }

        public FetchPhotosResponse FetchPhotosWithOptions(FetchPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FetchPhotosResponse>(DoRPCRequest("FetchPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FetchPhotosResponse> FetchPhotosWithOptionsAsync(FetchPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FetchPhotosResponse>(await DoRPCRequestAsync("FetchPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FetchPhotosResponse FetchPhotos(FetchPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FetchPhotosWithOptions(request, runtime);
        }

        public async Task<FetchPhotosResponse> FetchPhotosAsync(FetchPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FetchPhotosWithOptionsAsync(request, runtime);
        }

        public GetAlbumsByNamesResponse GetAlbumsByNamesWithOptions(GetAlbumsByNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAlbumsByNamesResponse>(DoRPCRequest("GetAlbumsByNames", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAlbumsByNamesResponse> GetAlbumsByNamesWithOptionsAsync(GetAlbumsByNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAlbumsByNamesResponse>(await DoRPCRequestAsync("GetAlbumsByNames", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAlbumsByNamesResponse GetAlbumsByNames(GetAlbumsByNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAlbumsByNamesWithOptions(request, runtime);
        }

        public async Task<GetAlbumsByNamesResponse> GetAlbumsByNamesAsync(GetAlbumsByNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAlbumsByNamesWithOptionsAsync(request, runtime);
        }

        public GetDownloadUrlResponse GetDownloadUrlWithOptions(GetDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDownloadUrlResponse>(DoRPCRequest("GetDownloadUrl", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDownloadUrlResponse> GetDownloadUrlWithOptionsAsync(GetDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDownloadUrlResponse>(await DoRPCRequestAsync("GetDownloadUrl", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDownloadUrlResponse GetDownloadUrl(GetDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDownloadUrlWithOptions(request, runtime);
        }

        public async Task<GetDownloadUrlResponse> GetDownloadUrlAsync(GetDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDownloadUrlWithOptionsAsync(request, runtime);
        }

        public GetDownloadUrlsResponse GetDownloadUrlsWithOptions(GetDownloadUrlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDownloadUrlsResponse>(DoRPCRequest("GetDownloadUrls", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDownloadUrlsResponse> GetDownloadUrlsWithOptionsAsync(GetDownloadUrlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDownloadUrlsResponse>(await DoRPCRequestAsync("GetDownloadUrls", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDownloadUrlsResponse GetDownloadUrls(GetDownloadUrlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDownloadUrlsWithOptions(request, runtime);
        }

        public async Task<GetDownloadUrlsResponse> GetDownloadUrlsAsync(GetDownloadUrlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDownloadUrlsWithOptionsAsync(request, runtime);
        }

        public GetFramedPhotoUrlsResponse GetFramedPhotoUrlsWithOptions(GetFramedPhotoUrlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFramedPhotoUrlsResponse>(DoRPCRequest("GetFramedPhotoUrls", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetFramedPhotoUrlsResponse> GetFramedPhotoUrlsWithOptionsAsync(GetFramedPhotoUrlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFramedPhotoUrlsResponse>(await DoRPCRequestAsync("GetFramedPhotoUrls", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetFramedPhotoUrlsResponse GetFramedPhotoUrls(GetFramedPhotoUrlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFramedPhotoUrlsWithOptions(request, runtime);
        }

        public async Task<GetFramedPhotoUrlsResponse> GetFramedPhotoUrlsAsync(GetFramedPhotoUrlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFramedPhotoUrlsWithOptionsAsync(request, runtime);
        }

        public GetLibraryResponse GetLibraryWithOptions(GetLibraryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLibraryResponse>(DoRPCRequest("GetLibrary", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLibraryResponse> GetLibraryWithOptionsAsync(GetLibraryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLibraryResponse>(await DoRPCRequestAsync("GetLibrary", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLibraryResponse GetLibrary(GetLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLibraryWithOptions(request, runtime);
        }

        public async Task<GetLibraryResponse> GetLibraryAsync(GetLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLibraryWithOptionsAsync(request, runtime);
        }

        public GetPhotosResponse GetPhotosWithOptions(GetPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPhotosResponse>(DoRPCRequest("GetPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPhotosResponse> GetPhotosWithOptionsAsync(GetPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPhotosResponse>(await DoRPCRequestAsync("GetPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPhotosResponse GetPhotos(GetPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPhotosWithOptions(request, runtime);
        }

        public async Task<GetPhotosResponse> GetPhotosAsync(GetPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPhotosWithOptionsAsync(request, runtime);
        }

        public GetPhotosByMd5sResponse GetPhotosByMd5sWithOptions(GetPhotosByMd5sRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPhotosByMd5sResponse>(DoRPCRequest("GetPhotosByMd5s", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPhotosByMd5sResponse> GetPhotosByMd5sWithOptionsAsync(GetPhotosByMd5sRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPhotosByMd5sResponse>(await DoRPCRequestAsync("GetPhotosByMd5s", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPhotosByMd5sResponse GetPhotosByMd5s(GetPhotosByMd5sRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPhotosByMd5sWithOptions(request, runtime);
        }

        public async Task<GetPhotosByMd5sResponse> GetPhotosByMd5sAsync(GetPhotosByMd5sRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPhotosByMd5sWithOptionsAsync(request, runtime);
        }

        public GetPhotoStoreResponse GetPhotoStoreWithOptions(GetPhotoStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPhotoStoreResponse>(DoRPCRequest("GetPhotoStore", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPhotoStoreResponse> GetPhotoStoreWithOptionsAsync(GetPhotoStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPhotoStoreResponse>(await DoRPCRequestAsync("GetPhotoStore", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPhotoStoreResponse GetPhotoStore(GetPhotoStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPhotoStoreWithOptions(request, runtime);
        }

        public async Task<GetPhotoStoreResponse> GetPhotoStoreAsync(GetPhotoStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPhotoStoreWithOptionsAsync(request, runtime);
        }

        public GetPrivateAccessUrlsResponse GetPrivateAccessUrlsWithOptions(GetPrivateAccessUrlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPrivateAccessUrlsResponse>(DoRPCRequest("GetPrivateAccessUrls", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPrivateAccessUrlsResponse> GetPrivateAccessUrlsWithOptionsAsync(GetPrivateAccessUrlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPrivateAccessUrlsResponse>(await DoRPCRequestAsync("GetPrivateAccessUrls", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPrivateAccessUrlsResponse GetPrivateAccessUrls(GetPrivateAccessUrlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPrivateAccessUrlsWithOptions(request, runtime);
        }

        public async Task<GetPrivateAccessUrlsResponse> GetPrivateAccessUrlsAsync(GetPrivateAccessUrlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPrivateAccessUrlsWithOptionsAsync(request, runtime);
        }

        public GetPublicAccessUrlsResponse GetPublicAccessUrlsWithOptions(GetPublicAccessUrlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPublicAccessUrlsResponse>(DoRPCRequest("GetPublicAccessUrls", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPublicAccessUrlsResponse> GetPublicAccessUrlsWithOptionsAsync(GetPublicAccessUrlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPublicAccessUrlsResponse>(await DoRPCRequestAsync("GetPublicAccessUrls", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPublicAccessUrlsResponse GetPublicAccessUrls(GetPublicAccessUrlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPublicAccessUrlsWithOptions(request, runtime);
        }

        public async Task<GetPublicAccessUrlsResponse> GetPublicAccessUrlsAsync(GetPublicAccessUrlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPublicAccessUrlsWithOptionsAsync(request, runtime);
        }

        public GetQuotaResponse GetQuotaWithOptions(GetQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQuotaResponse>(DoRPCRequest("GetQuota", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQuotaResponse> GetQuotaWithOptionsAsync(GetQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQuotaResponse>(await DoRPCRequestAsync("GetQuota", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQuotaResponse GetQuota(GetQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQuotaWithOptions(request, runtime);
        }

        public async Task<GetQuotaResponse> GetQuotaAsync(GetQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQuotaWithOptionsAsync(request, runtime);
        }

        public GetSimilarPhotosResponse GetSimilarPhotosWithOptions(GetSimilarPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSimilarPhotosResponse>(DoRPCRequest("GetSimilarPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSimilarPhotosResponse> GetSimilarPhotosWithOptionsAsync(GetSimilarPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSimilarPhotosResponse>(await DoRPCRequestAsync("GetSimilarPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSimilarPhotosResponse GetSimilarPhotos(GetSimilarPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSimilarPhotosWithOptions(request, runtime);
        }

        public async Task<GetSimilarPhotosResponse> GetSimilarPhotosAsync(GetSimilarPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSimilarPhotosWithOptionsAsync(request, runtime);
        }

        public GetThumbnailResponse GetThumbnailWithOptions(GetThumbnailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetThumbnailResponse>(DoRPCRequest("GetThumbnail", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetThumbnailResponse> GetThumbnailWithOptionsAsync(GetThumbnailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetThumbnailResponse>(await DoRPCRequestAsync("GetThumbnail", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetThumbnailResponse GetThumbnail(GetThumbnailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetThumbnailWithOptions(request, runtime);
        }

        public async Task<GetThumbnailResponse> GetThumbnailAsync(GetThumbnailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetThumbnailWithOptionsAsync(request, runtime);
        }

        public GetThumbnailsResponse GetThumbnailsWithOptions(GetThumbnailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetThumbnailsResponse>(DoRPCRequest("GetThumbnails", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetThumbnailsResponse> GetThumbnailsWithOptionsAsync(GetThumbnailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetThumbnailsResponse>(await DoRPCRequestAsync("GetThumbnails", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetThumbnailsResponse GetThumbnails(GetThumbnailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetThumbnailsWithOptions(request, runtime);
        }

        public async Task<GetThumbnailsResponse> GetThumbnailsAsync(GetThumbnailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetThumbnailsWithOptionsAsync(request, runtime);
        }

        public GetVideoCoverResponse GetVideoCoverWithOptions(GetVideoCoverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetVideoCoverResponse>(DoRPCRequest("GetVideoCover", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetVideoCoverResponse> GetVideoCoverWithOptionsAsync(GetVideoCoverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetVideoCoverResponse>(await DoRPCRequestAsync("GetVideoCover", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetVideoCoverResponse GetVideoCover(GetVideoCoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoCoverWithOptions(request, runtime);
        }

        public async Task<GetVideoCoverResponse> GetVideoCoverAsync(GetVideoCoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoCoverWithOptionsAsync(request, runtime);
        }

        public InactivatePhotosResponse InactivatePhotosWithOptions(InactivatePhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InactivatePhotosResponse>(DoRPCRequest("InactivatePhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InactivatePhotosResponse> InactivatePhotosWithOptionsAsync(InactivatePhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InactivatePhotosResponse>(await DoRPCRequestAsync("InactivatePhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InactivatePhotosResponse InactivatePhotos(InactivatePhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InactivatePhotosWithOptions(request, runtime);
        }

        public async Task<InactivatePhotosResponse> InactivatePhotosAsync(InactivatePhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InactivatePhotosWithOptionsAsync(request, runtime);
        }

        public LikePhotoResponse LikePhotoWithOptions(LikePhotoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LikePhotoResponse>(DoRPCRequest("LikePhoto", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LikePhotoResponse> LikePhotoWithOptionsAsync(LikePhotoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LikePhotoResponse>(await DoRPCRequestAsync("LikePhoto", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public LikePhotoResponse LikePhoto(LikePhotoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LikePhotoWithOptions(request, runtime);
        }

        public async Task<LikePhotoResponse> LikePhotoAsync(LikePhotoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LikePhotoWithOptionsAsync(request, runtime);
        }

        public ListAlbumPhotosResponse ListAlbumPhotosWithOptions(ListAlbumPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAlbumPhotosResponse>(DoRPCRequest("ListAlbumPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAlbumPhotosResponse> ListAlbumPhotosWithOptionsAsync(ListAlbumPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAlbumPhotosResponse>(await DoRPCRequestAsync("ListAlbumPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAlbumPhotosResponse ListAlbumPhotos(ListAlbumPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAlbumPhotosWithOptions(request, runtime);
        }

        public async Task<ListAlbumPhotosResponse> ListAlbumPhotosAsync(ListAlbumPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAlbumPhotosWithOptionsAsync(request, runtime);
        }

        public ListAlbumsResponse ListAlbumsWithOptions(ListAlbumsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAlbumsResponse>(DoRPCRequest("ListAlbums", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAlbumsResponse> ListAlbumsWithOptionsAsync(ListAlbumsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAlbumsResponse>(await DoRPCRequestAsync("ListAlbums", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAlbumsResponse ListAlbums(ListAlbumsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAlbumsWithOptions(request, runtime);
        }

        public async Task<ListAlbumsResponse> ListAlbumsAsync(ListAlbumsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAlbumsWithOptionsAsync(request, runtime);
        }

        public ListFacePhotosResponse ListFacePhotosWithOptions(ListFacePhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFacePhotosResponse>(DoRPCRequest("ListFacePhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFacePhotosResponse> ListFacePhotosWithOptionsAsync(ListFacePhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFacePhotosResponse>(await DoRPCRequestAsync("ListFacePhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFacePhotosResponse ListFacePhotos(ListFacePhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFacePhotosWithOptions(request, runtime);
        }

        public async Task<ListFacePhotosResponse> ListFacePhotosAsync(ListFacePhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFacePhotosWithOptionsAsync(request, runtime);
        }

        public ListFacesResponse ListFacesWithOptions(ListFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFacesResponse>(DoRPCRequest("ListFaces", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFacesResponse> ListFacesWithOptionsAsync(ListFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFacesResponse>(await DoRPCRequestAsync("ListFaces", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFacesResponse ListFaces(ListFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFacesWithOptions(request, runtime);
        }

        public async Task<ListFacesResponse> ListFacesAsync(ListFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFacesWithOptionsAsync(request, runtime);
        }

        public ListMomentPhotosResponse ListMomentPhotosWithOptions(ListMomentPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMomentPhotosResponse>(DoRPCRequest("ListMomentPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMomentPhotosResponse> ListMomentPhotosWithOptionsAsync(ListMomentPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMomentPhotosResponse>(await DoRPCRequestAsync("ListMomentPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListMomentPhotosResponse ListMomentPhotos(ListMomentPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMomentPhotosWithOptions(request, runtime);
        }

        public async Task<ListMomentPhotosResponse> ListMomentPhotosAsync(ListMomentPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMomentPhotosWithOptionsAsync(request, runtime);
        }

        public ListMomentsResponse ListMomentsWithOptions(ListMomentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMomentsResponse>(DoRPCRequest("ListMoments", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMomentsResponse> ListMomentsWithOptionsAsync(ListMomentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMomentsResponse>(await DoRPCRequestAsync("ListMoments", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListMomentsResponse ListMoments(ListMomentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMomentsWithOptions(request, runtime);
        }

        public async Task<ListMomentsResponse> ListMomentsAsync(ListMomentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMomentsWithOptionsAsync(request, runtime);
        }

        public ListPhotoFacesResponse ListPhotoFacesWithOptions(ListPhotoFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPhotoFacesResponse>(DoRPCRequest("ListPhotoFaces", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPhotoFacesResponse> ListPhotoFacesWithOptionsAsync(ListPhotoFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPhotoFacesResponse>(await DoRPCRequestAsync("ListPhotoFaces", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPhotoFacesResponse ListPhotoFaces(ListPhotoFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPhotoFacesWithOptions(request, runtime);
        }

        public async Task<ListPhotoFacesResponse> ListPhotoFacesAsync(ListPhotoFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPhotoFacesWithOptionsAsync(request, runtime);
        }

        public ListPhotosResponse ListPhotosWithOptions(ListPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPhotosResponse>(DoRPCRequest("ListPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPhotosResponse> ListPhotosWithOptionsAsync(ListPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPhotosResponse>(await DoRPCRequestAsync("ListPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPhotosResponse ListPhotos(ListPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPhotosWithOptions(request, runtime);
        }

        public async Task<ListPhotosResponse> ListPhotosAsync(ListPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPhotosWithOptionsAsync(request, runtime);
        }

        public ListPhotoStoresResponse ListPhotoStoresWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListPhotoStoresResponse>(DoRPCRequest("ListPhotoStores", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPhotoStoresResponse> ListPhotoStoresWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListPhotoStoresResponse>(await DoRPCRequestAsync("ListPhotoStores", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPhotoStoresResponse ListPhotoStores()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPhotoStoresWithOptions(runtime);
        }

        public async Task<ListPhotoStoresResponse> ListPhotoStoresAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPhotoStoresWithOptionsAsync(runtime);
        }

        public ListPhotoTagsResponse ListPhotoTagsWithOptions(ListPhotoTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPhotoTagsResponse>(DoRPCRequest("ListPhotoTags", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPhotoTagsResponse> ListPhotoTagsWithOptionsAsync(ListPhotoTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPhotoTagsResponse>(await DoRPCRequestAsync("ListPhotoTags", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPhotoTagsResponse ListPhotoTags(ListPhotoTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPhotoTagsWithOptions(request, runtime);
        }

        public async Task<ListPhotoTagsResponse> ListPhotoTagsAsync(ListPhotoTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPhotoTagsWithOptionsAsync(request, runtime);
        }

        public ListRegisteredTagsResponse ListRegisteredTagsWithOptions(ListRegisteredTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRegisteredTagsResponse>(DoRPCRequest("ListRegisteredTags", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRegisteredTagsResponse> ListRegisteredTagsWithOptionsAsync(ListRegisteredTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRegisteredTagsResponse>(await DoRPCRequestAsync("ListRegisteredTags", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRegisteredTagsResponse ListRegisteredTags(ListRegisteredTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegisteredTagsWithOptions(request, runtime);
        }

        public async Task<ListRegisteredTagsResponse> ListRegisteredTagsAsync(ListRegisteredTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegisteredTagsWithOptionsAsync(request, runtime);
        }

        public ListTagPhotosResponse ListTagPhotosWithOptions(ListTagPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagPhotosResponse>(DoRPCRequest("ListTagPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagPhotosResponse> ListTagPhotosWithOptionsAsync(ListTagPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagPhotosResponse>(await DoRPCRequestAsync("ListTagPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagPhotosResponse ListTagPhotos(ListTagPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagPhotosWithOptions(request, runtime);
        }

        public async Task<ListTagPhotosResponse> ListTagPhotosAsync(ListTagPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagPhotosWithOptionsAsync(request, runtime);
        }

        public ListTagsResponse ListTagsWithOptions(ListTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagsResponse>(DoRPCRequest("ListTags", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagsResponse> ListTagsWithOptionsAsync(ListTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagsResponse>(await DoRPCRequestAsync("ListTags", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagsResponse ListTags(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagsWithOptions(request, runtime);
        }

        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagsWithOptionsAsync(request, runtime);
        }

        public ListTimeLinePhotosResponse ListTimeLinePhotosWithOptions(ListTimeLinePhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTimeLinePhotosResponse>(DoRPCRequest("ListTimeLinePhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTimeLinePhotosResponse> ListTimeLinePhotosWithOptionsAsync(ListTimeLinePhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTimeLinePhotosResponse>(await DoRPCRequestAsync("ListTimeLinePhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTimeLinePhotosResponse ListTimeLinePhotos(ListTimeLinePhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTimeLinePhotosWithOptions(request, runtime);
        }

        public async Task<ListTimeLinePhotosResponse> ListTimeLinePhotosAsync(ListTimeLinePhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTimeLinePhotosWithOptionsAsync(request, runtime);
        }

        public ListTimeLinesResponse ListTimeLinesWithOptions(ListTimeLinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTimeLinesResponse>(DoRPCRequest("ListTimeLines", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTimeLinesResponse> ListTimeLinesWithOptionsAsync(ListTimeLinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTimeLinesResponse>(await DoRPCRequestAsync("ListTimeLines", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTimeLinesResponse ListTimeLines(ListTimeLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTimeLinesWithOptions(request, runtime);
        }

        public async Task<ListTimeLinesResponse> ListTimeLinesAsync(ListTimeLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTimeLinesWithOptionsAsync(request, runtime);
        }

        public MergeFacesResponse MergeFacesWithOptions(MergeFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MergeFacesResponse>(DoRPCRequest("MergeFaces", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MergeFacesResponse> MergeFacesWithOptionsAsync(MergeFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MergeFacesResponse>(await DoRPCRequestAsync("MergeFaces", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MergeFacesResponse MergeFaces(MergeFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MergeFacesWithOptions(request, runtime);
        }

        public async Task<MergeFacesResponse> MergeFacesAsync(MergeFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MergeFacesWithOptionsAsync(request, runtime);
        }

        public MoveAlbumPhotosResponse MoveAlbumPhotosWithOptions(MoveAlbumPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveAlbumPhotosResponse>(DoRPCRequest("MoveAlbumPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MoveAlbumPhotosResponse> MoveAlbumPhotosWithOptionsAsync(MoveAlbumPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveAlbumPhotosResponse>(await DoRPCRequestAsync("MoveAlbumPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MoveAlbumPhotosResponse MoveAlbumPhotos(MoveAlbumPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveAlbumPhotosWithOptions(request, runtime);
        }

        public async Task<MoveAlbumPhotosResponse> MoveAlbumPhotosAsync(MoveAlbumPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveAlbumPhotosWithOptionsAsync(request, runtime);
        }

        public MoveFacePhotosResponse MoveFacePhotosWithOptions(MoveFacePhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveFacePhotosResponse>(DoRPCRequest("MoveFacePhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MoveFacePhotosResponse> MoveFacePhotosWithOptionsAsync(MoveFacePhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveFacePhotosResponse>(await DoRPCRequestAsync("MoveFacePhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MoveFacePhotosResponse MoveFacePhotos(MoveFacePhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveFacePhotosWithOptions(request, runtime);
        }

        public async Task<MoveFacePhotosResponse> MoveFacePhotosAsync(MoveFacePhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveFacePhotosWithOptionsAsync(request, runtime);
        }

        public ReactivatePhotosResponse ReactivatePhotosWithOptions(ReactivatePhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReactivatePhotosResponse>(DoRPCRequest("ReactivatePhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReactivatePhotosResponse> ReactivatePhotosWithOptionsAsync(ReactivatePhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReactivatePhotosResponse>(await DoRPCRequestAsync("ReactivatePhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReactivatePhotosResponse ReactivatePhotos(ReactivatePhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReactivatePhotosWithOptions(request, runtime);
        }

        public async Task<ReactivatePhotosResponse> ReactivatePhotosAsync(ReactivatePhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReactivatePhotosWithOptionsAsync(request, runtime);
        }

        public RegisterPhotoResponse RegisterPhotoWithOptions(RegisterPhotoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterPhotoResponse>(DoRPCRequest("RegisterPhoto", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegisterPhotoResponse> RegisterPhotoWithOptionsAsync(RegisterPhotoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterPhotoResponse>(await DoRPCRequestAsync("RegisterPhoto", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RegisterPhotoResponse RegisterPhoto(RegisterPhotoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterPhotoWithOptions(request, runtime);
        }

        public async Task<RegisterPhotoResponse> RegisterPhotoAsync(RegisterPhotoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterPhotoWithOptionsAsync(request, runtime);
        }

        public RegisterTagResponse RegisterTagWithOptions(RegisterTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterTagResponse>(DoRPCRequest("RegisterTag", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegisterTagResponse> RegisterTagWithOptionsAsync(RegisterTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterTagResponse>(await DoRPCRequestAsync("RegisterTag", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RegisterTagResponse RegisterTag(RegisterTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterTagWithOptions(request, runtime);
        }

        public async Task<RegisterTagResponse> RegisterTagAsync(RegisterTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterTagWithOptionsAsync(request, runtime);
        }

        public RemoveAlbumPhotosResponse RemoveAlbumPhotosWithOptions(RemoveAlbumPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveAlbumPhotosResponse>(DoRPCRequest("RemoveAlbumPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveAlbumPhotosResponse> RemoveAlbumPhotosWithOptionsAsync(RemoveAlbumPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveAlbumPhotosResponse>(await DoRPCRequestAsync("RemoveAlbumPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveAlbumPhotosResponse RemoveAlbumPhotos(RemoveAlbumPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveAlbumPhotosWithOptions(request, runtime);
        }

        public async Task<RemoveAlbumPhotosResponse> RemoveAlbumPhotosAsync(RemoveAlbumPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveAlbumPhotosWithOptionsAsync(request, runtime);
        }

        public RemoveFacePhotosResponse RemoveFacePhotosWithOptions(RemoveFacePhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveFacePhotosResponse>(DoRPCRequest("RemoveFacePhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveFacePhotosResponse> RemoveFacePhotosWithOptionsAsync(RemoveFacePhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveFacePhotosResponse>(await DoRPCRequestAsync("RemoveFacePhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveFacePhotosResponse RemoveFacePhotos(RemoveFacePhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveFacePhotosWithOptions(request, runtime);
        }

        public async Task<RemoveFacePhotosResponse> RemoveFacePhotosAsync(RemoveFacePhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveFacePhotosWithOptionsAsync(request, runtime);
        }

        public RenameAlbumResponse RenameAlbumWithOptions(RenameAlbumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenameAlbumResponse>(DoRPCRequest("RenameAlbum", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenameAlbumResponse> RenameAlbumWithOptionsAsync(RenameAlbumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenameAlbumResponse>(await DoRPCRequestAsync("RenameAlbum", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RenameAlbumResponse RenameAlbum(RenameAlbumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenameAlbumWithOptions(request, runtime);
        }

        public async Task<RenameAlbumResponse> RenameAlbumAsync(RenameAlbumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenameAlbumWithOptionsAsync(request, runtime);
        }

        public RenameFaceResponse RenameFaceWithOptions(RenameFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenameFaceResponse>(DoRPCRequest("RenameFace", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenameFaceResponse> RenameFaceWithOptionsAsync(RenameFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenameFaceResponse>(await DoRPCRequestAsync("RenameFace", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RenameFaceResponse RenameFace(RenameFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenameFaceWithOptions(request, runtime);
        }

        public async Task<RenameFaceResponse> RenameFaceAsync(RenameFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenameFaceWithOptionsAsync(request, runtime);
        }

        public SearchPhotosResponse SearchPhotosWithOptions(SearchPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchPhotosResponse>(DoRPCRequest("SearchPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchPhotosResponse> SearchPhotosWithOptionsAsync(SearchPhotosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchPhotosResponse>(await DoRPCRequestAsync("SearchPhotos", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchPhotosResponse SearchPhotos(SearchPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchPhotosWithOptions(request, runtime);
        }

        public async Task<SearchPhotosResponse> SearchPhotosAsync(SearchPhotosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchPhotosWithOptionsAsync(request, runtime);
        }

        public SetAlbumCoverResponse SetAlbumCoverWithOptions(SetAlbumCoverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetAlbumCoverResponse>(DoRPCRequest("SetAlbumCover", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetAlbumCoverResponse> SetAlbumCoverWithOptionsAsync(SetAlbumCoverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetAlbumCoverResponse>(await DoRPCRequestAsync("SetAlbumCover", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetAlbumCoverResponse SetAlbumCover(SetAlbumCoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAlbumCoverWithOptions(request, runtime);
        }

        public async Task<SetAlbumCoverResponse> SetAlbumCoverAsync(SetAlbumCoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAlbumCoverWithOptionsAsync(request, runtime);
        }

        public SetFaceCoverResponse SetFaceCoverWithOptions(SetFaceCoverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetFaceCoverResponse>(DoRPCRequest("SetFaceCover", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetFaceCoverResponse> SetFaceCoverWithOptionsAsync(SetFaceCoverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetFaceCoverResponse>(await DoRPCRequestAsync("SetFaceCover", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetFaceCoverResponse SetFaceCover(SetFaceCoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetFaceCoverWithOptions(request, runtime);
        }

        public async Task<SetFaceCoverResponse> SetFaceCoverAsync(SetFaceCoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetFaceCoverWithOptionsAsync(request, runtime);
        }

        public SetMeResponse SetMeWithOptions(SetMeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetMeResponse>(DoRPCRequest("SetMe", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetMeResponse> SetMeWithOptionsAsync(SetMeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetMeResponse>(await DoRPCRequestAsync("SetMe", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetMeResponse SetMe(SetMeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetMeWithOptions(request, runtime);
        }

        public async Task<SetMeResponse> SetMeAsync(SetMeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetMeWithOptionsAsync(request, runtime);
        }

        public SetQuotaResponse SetQuotaWithOptions(SetQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetQuotaResponse>(DoRPCRequest("SetQuota", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetQuotaResponse> SetQuotaWithOptionsAsync(SetQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetQuotaResponse>(await DoRPCRequestAsync("SetQuota", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetQuotaResponse SetQuota(SetQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetQuotaWithOptions(request, runtime);
        }

        public async Task<SetQuotaResponse> SetQuotaAsync(SetQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetQuotaWithOptionsAsync(request, runtime);
        }

        public TagPhotoResponse TagPhotoWithOptions(TagPhotoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagPhotoResponse>(DoRPCRequest("TagPhoto", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagPhotoResponse> TagPhotoWithOptionsAsync(TagPhotoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagPhotoResponse>(await DoRPCRequestAsync("TagPhoto", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TagPhotoResponse TagPhoto(TagPhotoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagPhotoWithOptions(request, runtime);
        }

        public async Task<TagPhotoResponse> TagPhotoAsync(TagPhotoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagPhotoWithOptionsAsync(request, runtime);
        }

        public ToggleFeaturesResponse ToggleFeaturesWithOptions(ToggleFeaturesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ToggleFeaturesResponse>(DoRPCRequest("ToggleFeatures", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ToggleFeaturesResponse> ToggleFeaturesWithOptionsAsync(ToggleFeaturesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ToggleFeaturesResponse>(await DoRPCRequestAsync("ToggleFeatures", "2017-07-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ToggleFeaturesResponse ToggleFeatures(ToggleFeaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ToggleFeaturesWithOptions(request, runtime);
        }

        public async Task<ToggleFeaturesResponse> ToggleFeaturesAsync(ToggleFeaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ToggleFeaturesWithOptionsAsync(request, runtime);
        }

    }
}
