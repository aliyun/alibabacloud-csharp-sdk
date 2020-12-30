// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cityvisual20181030.Models;

namespace AlibabaCloud.SDK.Cityvisual20181030
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cityvisual", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AttachStreamResponse AttachStreamWithOptions(AttachStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachStreamResponse>(DoRPCRequest("AttachStream", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachStreamResponse> AttachStreamWithOptionsAsync(AttachStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachStreamResponse>(await DoRPCRequestAsync("AttachStream", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachStreamResponse AttachStream(AttachStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachStreamWithOptions(request, runtime);
        }

        public async Task<AttachStreamResponse> AttachStreamAsync(AttachStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachStreamWithOptionsAsync(request, runtime);
        }

        public BatchModifyCameraStatusResponse BatchModifyCameraStatusWithOptions(BatchModifyCameraStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchModifyCameraStatusResponse>(DoRPCRequest("BatchModifyCameraStatus", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchModifyCameraStatusResponse> BatchModifyCameraStatusWithOptionsAsync(BatchModifyCameraStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchModifyCameraStatusResponse>(await DoRPCRequestAsync("BatchModifyCameraStatus", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchModifyCameraStatusResponse BatchModifyCameraStatus(BatchModifyCameraStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchModifyCameraStatusWithOptions(request, runtime);
        }

        public async Task<BatchModifyCameraStatusResponse> BatchModifyCameraStatusAsync(BatchModifyCameraStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchModifyCameraStatusWithOptionsAsync(request, runtime);
        }

        public CreateAlgoLibResponse CreateAlgoLibWithOptions(CreateAlgoLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAlgoLibResponse>(DoRPCRequest("CreateAlgoLib", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAlgoLibResponse> CreateAlgoLibWithOptionsAsync(CreateAlgoLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAlgoLibResponse>(await DoRPCRequestAsync("CreateAlgoLib", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAlgoLibResponse CreateAlgoLib(CreateAlgoLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAlgoLibWithOptions(request, runtime);
        }

        public async Task<CreateAlgoLibResponse> CreateAlgoLibAsync(CreateAlgoLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAlgoLibWithOptionsAsync(request, runtime);
        }

        public CreateCameraResponse CreateCameraWithOptions(CreateCameraRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCameraResponse>(DoRPCRequest("CreateCamera", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCameraResponse> CreateCameraWithOptionsAsync(CreateCameraRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCameraResponse>(await DoRPCRequestAsync("CreateCamera", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCameraResponse CreateCamera(CreateCameraRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCameraWithOptions(request, runtime);
        }

        public async Task<CreateCameraResponse> CreateCameraAsync(CreateCameraRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCameraWithOptionsAsync(request, runtime);
        }

        public CreateCapabilityResponse CreateCapabilityWithOptions(CreateCapabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCapabilityResponse>(DoRPCRequest("CreateCapability", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCapabilityResponse> CreateCapabilityWithOptionsAsync(CreateCapabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCapabilityResponse>(await DoRPCRequestAsync("CreateCapability", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCapabilityResponse CreateCapability(CreateCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCapabilityWithOptions(request, runtime);
        }

        public async Task<CreateCapabilityResponse> CreateCapabilityAsync(CreateCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCapabilityWithOptionsAsync(request, runtime);
        }

        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(DoRPCRequest("CreateInstance", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await DoRPCRequestAsync("CreateInstance", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        public CreateJobGroupResponse CreateJobGroupWithOptions(CreateJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateJobGroupResponse>(DoRPCRequest("CreateJobGroup", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateJobGroupResponse> CreateJobGroupWithOptionsAsync(CreateJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateJobGroupResponse>(await DoRPCRequestAsync("CreateJobGroup", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateJobGroupResponse CreateJobGroup(CreateJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateJobGroupWithOptions(request, runtime);
        }

        public async Task<CreateJobGroupResponse> CreateJobGroupAsync(CreateJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateJobGroupWithOptionsAsync(request, runtime);
        }

        public CreateResourceProfileResponse CreateResourceProfileWithOptions(CreateResourceProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateResourceProfileResponse>(DoRPCRequest("CreateResourceProfile", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateResourceProfileResponse> CreateResourceProfileWithOptionsAsync(CreateResourceProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateResourceProfileResponse>(await DoRPCRequestAsync("CreateResourceProfile", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateResourceProfileResponse CreateResourceProfile(CreateResourceProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResourceProfileWithOptions(request, runtime);
        }

        public async Task<CreateResourceProfileResponse> CreateResourceProfileAsync(CreateResourceProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResourceProfileWithOptionsAsync(request, runtime);
        }

        public CreateWorkGroupResponse CreateWorkGroupWithOptions(CreateWorkGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWorkGroupResponse>(DoRPCRequest("CreateWorkGroup", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateWorkGroupResponse> CreateWorkGroupWithOptionsAsync(CreateWorkGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWorkGroupResponse>(await DoRPCRequestAsync("CreateWorkGroup", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateWorkGroupResponse CreateWorkGroup(CreateWorkGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWorkGroupWithOptions(request, runtime);
        }

        public async Task<CreateWorkGroupResponse> CreateWorkGroupAsync(CreateWorkGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWorkGroupWithOptionsAsync(request, runtime);
        }

        public DeleteAlgoLibResponse DeleteAlgoLibWithOptions(DeleteAlgoLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlgoLibResponse>(DoRPCRequest("DeleteAlgoLib", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAlgoLibResponse> DeleteAlgoLibWithOptionsAsync(DeleteAlgoLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlgoLibResponse>(await DoRPCRequestAsync("DeleteAlgoLib", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAlgoLibResponse DeleteAlgoLib(DeleteAlgoLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAlgoLibWithOptions(request, runtime);
        }

        public async Task<DeleteAlgoLibResponse> DeleteAlgoLibAsync(DeleteAlgoLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAlgoLibWithOptionsAsync(request, runtime);
        }

        public DeleteCameraResponse DeleteCameraWithOptions(DeleteCameraRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCameraResponse>(DoRPCRequest("DeleteCamera", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCameraResponse> DeleteCameraWithOptionsAsync(DeleteCameraRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCameraResponse>(await DoRPCRequestAsync("DeleteCamera", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCameraResponse DeleteCamera(DeleteCameraRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCameraWithOptions(request, runtime);
        }

        public async Task<DeleteCameraResponse> DeleteCameraAsync(DeleteCameraRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCameraWithOptionsAsync(request, runtime);
        }

        public DeleteCapabilityResponse DeleteCapabilityWithOptions(DeleteCapabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCapabilityResponse>(DoRPCRequest("DeleteCapability", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCapabilityResponse> DeleteCapabilityWithOptionsAsync(DeleteCapabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCapabilityResponse>(await DoRPCRequestAsync("DeleteCapability", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCapabilityResponse DeleteCapability(DeleteCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCapabilityWithOptions(request, runtime);
        }

        public async Task<DeleteCapabilityResponse> DeleteCapabilityAsync(DeleteCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCapabilityWithOptionsAsync(request, runtime);
        }

        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(DoRPCRequest("DeleteInstance", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await DoRPCRequestAsync("DeleteInstance", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        public DeleteJobGroupResponse DeleteJobGroupWithOptions(DeleteJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteJobGroupResponse>(DoRPCRequest("DeleteJobGroup", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteJobGroupResponse> DeleteJobGroupWithOptionsAsync(DeleteJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteJobGroupResponse>(await DoRPCRequestAsync("DeleteJobGroup", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteJobGroupResponse DeleteJobGroup(DeleteJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteJobGroupWithOptions(request, runtime);
        }

        public async Task<DeleteJobGroupResponse> DeleteJobGroupAsync(DeleteJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteJobGroupWithOptionsAsync(request, runtime);
        }

        public DeleteResourceProfileResponse DeleteResourceProfileWithOptions(DeleteResourceProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteResourceProfileResponse>(DoRPCRequest("DeleteResourceProfile", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteResourceProfileResponse> DeleteResourceProfileWithOptionsAsync(DeleteResourceProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteResourceProfileResponse>(await DoRPCRequestAsync("DeleteResourceProfile", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteResourceProfileResponse DeleteResourceProfile(DeleteResourceProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteResourceProfileWithOptions(request, runtime);
        }

        public async Task<DeleteResourceProfileResponse> DeleteResourceProfileAsync(DeleteResourceProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteResourceProfileWithOptionsAsync(request, runtime);
        }

        public DeleteWorkGroupResponse DeleteWorkGroupWithOptions(DeleteWorkGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWorkGroupResponse>(DoRPCRequest("DeleteWorkGroup", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteWorkGroupResponse> DeleteWorkGroupWithOptionsAsync(DeleteWorkGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWorkGroupResponse>(await DoRPCRequestAsync("DeleteWorkGroup", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteWorkGroupResponse DeleteWorkGroup(DeleteWorkGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWorkGroupWithOptions(request, runtime);
        }

        public async Task<DeleteWorkGroupResponse> DeleteWorkGroupAsync(DeleteWorkGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWorkGroupWithOptionsAsync(request, runtime);
        }

        public DescribeAlgoLibsResponse DescribeAlgoLibsWithOptions(DescribeAlgoLibsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlgoLibsResponse>(DoRPCRequest("DescribeAlgoLibs", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAlgoLibsResponse> DescribeAlgoLibsWithOptionsAsync(DescribeAlgoLibsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlgoLibsResponse>(await DoRPCRequestAsync("DescribeAlgoLibs", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAlgoLibsResponse DescribeAlgoLibs(DescribeAlgoLibsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlgoLibsWithOptions(request, runtime);
        }

        public async Task<DescribeAlgoLibsResponse> DescribeAlgoLibsAsync(DescribeAlgoLibsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlgoLibsWithOptionsAsync(request, runtime);
        }

        public DescribeCamerasResponse DescribeCamerasWithOptions(DescribeCamerasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCamerasResponse>(DoRPCRequest("DescribeCameras", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCamerasResponse> DescribeCamerasWithOptionsAsync(DescribeCamerasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCamerasResponse>(await DoRPCRequestAsync("DescribeCameras", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCamerasResponse DescribeCameras(DescribeCamerasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCamerasWithOptions(request, runtime);
        }

        public async Task<DescribeCamerasResponse> DescribeCamerasAsync(DescribeCamerasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCamerasWithOptionsAsync(request, runtime);
        }

        public DescribeCapabilitiesResponse DescribeCapabilitiesWithOptions(DescribeCapabilitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCapabilitiesResponse>(DoRPCRequest("DescribeCapabilities", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCapabilitiesResponse> DescribeCapabilitiesWithOptionsAsync(DescribeCapabilitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCapabilitiesResponse>(await DoRPCRequestAsync("DescribeCapabilities", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCapabilitiesResponse DescribeCapabilities(DescribeCapabilitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCapabilitiesWithOptions(request, runtime);
        }

        public async Task<DescribeCapabilitiesResponse> DescribeCapabilitiesAsync(DescribeCapabilitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCapabilitiesWithOptionsAsync(request, runtime);
        }

        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(DoRPCRequest("DescribeInstances", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(await DoRPCRequestAsync("DescribeInstances", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeJobGroupsResponse DescribeJobGroupsWithOptions(DescribeJobGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeJobGroupsResponse>(DoRPCRequest("DescribeJobGroups", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeJobGroupsResponse> DescribeJobGroupsWithOptionsAsync(DescribeJobGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeJobGroupsResponse>(await DoRPCRequestAsync("DescribeJobGroups", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeJobGroupsResponse DescribeJobGroups(DescribeJobGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJobGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeJobGroupsResponse> DescribeJobGroupsAsync(DescribeJobGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJobGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeProtocolsResponse DescribeProtocolsWithOptions(DescribeProtocolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProtocolsResponse>(DoRPCRequest("DescribeProtocols", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeProtocolsResponse> DescribeProtocolsWithOptionsAsync(DescribeProtocolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProtocolsResponse>(await DoRPCRequestAsync("DescribeProtocols", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeProtocolsResponse DescribeProtocols(DescribeProtocolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProtocolsWithOptions(request, runtime);
        }

        public async Task<DescribeProtocolsResponse> DescribeProtocolsAsync(DescribeProtocolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProtocolsWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        public DescribeResourceProfilesResponse DescribeResourceProfilesWithOptions(DescribeResourceProfilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeResourceProfilesResponse>(DoRPCRequest("DescribeResourceProfiles", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeResourceProfilesResponse> DescribeResourceProfilesWithOptionsAsync(DescribeResourceProfilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeResourceProfilesResponse>(await DoRPCRequestAsync("DescribeResourceProfiles", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeResourceProfilesResponse DescribeResourceProfiles(DescribeResourceProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceProfilesWithOptions(request, runtime);
        }

        public async Task<DescribeResourceProfilesResponse> DescribeResourceProfilesAsync(DescribeResourceProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceProfilesWithOptionsAsync(request, runtime);
        }

        public DescribeStreamsResponse DescribeStreamsWithOptions(DescribeStreamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStreamsResponse>(DoRPCRequest("DescribeStreams", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeStreamsResponse> DescribeStreamsWithOptionsAsync(DescribeStreamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStreamsResponse>(await DoRPCRequestAsync("DescribeStreams", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeStreamsResponse DescribeStreams(DescribeStreamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStreamsWithOptions(request, runtime);
        }

        public async Task<DescribeStreamsResponse> DescribeStreamsAsync(DescribeStreamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStreamsWithOptionsAsync(request, runtime);
        }

        public DescribeWorkGroupsResponse DescribeWorkGroupsWithOptions(DescribeWorkGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWorkGroupsResponse>(DoRPCRequest("DescribeWorkGroups", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWorkGroupsResponse> DescribeWorkGroupsWithOptionsAsync(DescribeWorkGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWorkGroupsResponse>(await DoRPCRequestAsync("DescribeWorkGroups", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWorkGroupsResponse DescribeWorkGroups(DescribeWorkGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWorkGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeWorkGroupsResponse> DescribeWorkGroupsAsync(DescribeWorkGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWorkGroupsWithOptionsAsync(request, runtime);
        }

        public DetachStreamResponse DetachStreamWithOptions(DetachStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachStreamResponse>(DoRPCRequest("DetachStream", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachStreamResponse> DetachStreamWithOptionsAsync(DetachStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachStreamResponse>(await DoRPCRequestAsync("DetachStream", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachStreamResponse DetachStream(DetachStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachStreamWithOptions(request, runtime);
        }

        public async Task<DetachStreamResponse> DetachStreamAsync(DetachStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachStreamWithOptionsAsync(request, runtime);
        }

        public GetCameraConfForCameraResponse GetCameraConfForCameraWithOptions(GetCameraConfForCameraRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCameraConfForCameraResponse>(DoRPCRequest("GetCameraConfForCamera", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCameraConfForCameraResponse> GetCameraConfForCameraWithOptionsAsync(GetCameraConfForCameraRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCameraConfForCameraResponse>(await DoRPCRequestAsync("GetCameraConfForCamera", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCameraConfForCameraResponse GetCameraConfForCamera(GetCameraConfForCameraRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCameraConfForCameraWithOptions(request, runtime);
        }

        public async Task<GetCameraConfForCameraResponse> GetCameraConfForCameraAsync(GetCameraConfForCameraRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCameraConfForCameraWithOptionsAsync(request, runtime);
        }

        public GetComputeJobLogResponse GetComputeJobLogWithOptions(GetComputeJobLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetComputeJobLogResponse>(DoRPCRequest("GetComputeJobLog", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetComputeJobLogResponse> GetComputeJobLogWithOptionsAsync(GetComputeJobLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetComputeJobLogResponse>(await DoRPCRequestAsync("GetComputeJobLog", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetComputeJobLogResponse GetComputeJobLog(GetComputeJobLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetComputeJobLogWithOptions(request, runtime);
        }

        public async Task<GetComputeJobLogResponse> GetComputeJobLogAsync(GetComputeJobLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetComputeJobLogWithOptionsAsync(request, runtime);
        }

        public GetPlayUrlForCameraResponse GetPlayUrlForCameraWithOptions(GetPlayUrlForCameraRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPlayUrlForCameraResponse>(DoRPCRequest("GetPlayUrlForCamera", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPlayUrlForCameraResponse> GetPlayUrlForCameraWithOptionsAsync(GetPlayUrlForCameraRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPlayUrlForCameraResponse>(await DoRPCRequestAsync("GetPlayUrlForCamera", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPlayUrlForCameraResponse GetPlayUrlForCamera(GetPlayUrlForCameraRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPlayUrlForCameraWithOptions(request, runtime);
        }

        public async Task<GetPlayUrlForCameraResponse> GetPlayUrlForCameraAsync(GetPlayUrlForCameraRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPlayUrlForCameraWithOptionsAsync(request, runtime);
        }

        public ListComputeJobLogsResponse ListComputeJobLogsWithOptions(ListComputeJobLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListComputeJobLogsResponse>(DoRPCRequest("ListComputeJobLogs", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListComputeJobLogsResponse> ListComputeJobLogsWithOptionsAsync(ListComputeJobLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListComputeJobLogsResponse>(await DoRPCRequestAsync("ListComputeJobLogs", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListComputeJobLogsResponse ListComputeJobLogs(ListComputeJobLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListComputeJobLogsWithOptions(request, runtime);
        }

        public async Task<ListComputeJobLogsResponse> ListComputeJobLogsAsync(ListComputeJobLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListComputeJobLogsWithOptionsAsync(request, runtime);
        }

        public ListParkingResultsResponse ListParkingResultsWithOptions(ListParkingResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListParkingResultsResponse>(DoRPCRequest("ListParkingResults", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListParkingResultsResponse> ListParkingResultsWithOptionsAsync(ListParkingResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListParkingResultsResponse>(await DoRPCRequestAsync("ListParkingResults", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListParkingResultsResponse ListParkingResults(ListParkingResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListParkingResultsWithOptions(request, runtime);
        }

        public async Task<ListParkingResultsResponse> ListParkingResultsAsync(ListParkingResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListParkingResultsWithOptionsAsync(request, runtime);
        }

        public ListSafetyHelmetResultsResponse ListSafetyHelmetResultsWithOptions(ListSafetyHelmetResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSafetyHelmetResultsResponse>(DoRPCRequest("ListSafetyHelmetResults", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSafetyHelmetResultsResponse> ListSafetyHelmetResultsWithOptionsAsync(ListSafetyHelmetResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSafetyHelmetResultsResponse>(await DoRPCRequestAsync("ListSafetyHelmetResults", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSafetyHelmetResultsResponse ListSafetyHelmetResults(ListSafetyHelmetResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSafetyHelmetResultsWithOptions(request, runtime);
        }

        public async Task<ListSafetyHelmetResultsResponse> ListSafetyHelmetResultsAsync(ListSafetyHelmetResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSafetyHelmetResultsWithOptionsAsync(request, runtime);
        }

        public ListStreamsForCamerasResponse ListStreamsForCamerasWithOptions(ListStreamsForCamerasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListStreamsForCamerasResponse>(DoRPCRequest("ListStreamsForCameras", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListStreamsForCamerasResponse> ListStreamsForCamerasWithOptionsAsync(ListStreamsForCamerasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListStreamsForCamerasResponse>(await DoRPCRequestAsync("ListStreamsForCameras", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListStreamsForCamerasResponse ListStreamsForCameras(ListStreamsForCamerasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStreamsForCamerasWithOptions(request, runtime);
        }

        public async Task<ListStreamsForCamerasResponse> ListStreamsForCamerasAsync(ListStreamsForCamerasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStreamsForCamerasWithOptionsAsync(request, runtime);
        }

        public ListVehicleEntryResultsResponse ListVehicleEntryResultsWithOptions(ListVehicleEntryResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVehicleEntryResultsResponse>(DoRPCRequest("ListVehicleEntryResults", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListVehicleEntryResultsResponse> ListVehicleEntryResultsWithOptionsAsync(ListVehicleEntryResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVehicleEntryResultsResponse>(await DoRPCRequestAsync("ListVehicleEntryResults", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListVehicleEntryResultsResponse ListVehicleEntryResults(ListVehicleEntryResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVehicleEntryResultsWithOptions(request, runtime);
        }

        public async Task<ListVehicleEntryResultsResponse> ListVehicleEntryResultsAsync(ListVehicleEntryResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVehicleEntryResultsWithOptionsAsync(request, runtime);
        }

        public ModifyAlgoLibResponse ModifyAlgoLibWithOptions(ModifyAlgoLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAlgoLibResponse>(DoRPCRequest("ModifyAlgoLib", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAlgoLibResponse> ModifyAlgoLibWithOptionsAsync(ModifyAlgoLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAlgoLibResponse>(await DoRPCRequestAsync("ModifyAlgoLib", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyAlgoLibResponse ModifyAlgoLib(ModifyAlgoLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAlgoLibWithOptions(request, runtime);
        }

        public async Task<ModifyAlgoLibResponse> ModifyAlgoLibAsync(ModifyAlgoLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAlgoLibWithOptionsAsync(request, runtime);
        }

        public ModifyCameraResponse ModifyCameraWithOptions(ModifyCameraRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCameraResponse>(DoRPCRequest("ModifyCamera", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCameraResponse> ModifyCameraWithOptionsAsync(ModifyCameraRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCameraResponse>(await DoRPCRequestAsync("ModifyCamera", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCameraResponse ModifyCamera(ModifyCameraRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCameraWithOptions(request, runtime);
        }

        public async Task<ModifyCameraResponse> ModifyCameraAsync(ModifyCameraRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCameraWithOptionsAsync(request, runtime);
        }

        public ModifyCapabilityResponse ModifyCapabilityWithOptions(ModifyCapabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCapabilityResponse>(DoRPCRequest("ModifyCapability", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCapabilityResponse> ModifyCapabilityWithOptionsAsync(ModifyCapabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCapabilityResponse>(await DoRPCRequestAsync("ModifyCapability", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCapabilityResponse ModifyCapability(ModifyCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCapabilityWithOptions(request, runtime);
        }

        public async Task<ModifyCapabilityResponse> ModifyCapabilityAsync(ModifyCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCapabilityWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceResponse ModifyInstanceWithOptions(ModifyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(DoRPCRequest("ModifyInstance", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceResponse> ModifyInstanceWithOptionsAsync(ModifyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(await DoRPCRequestAsync("ModifyInstance", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceResponse ModifyInstance(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceResponse> ModifyInstanceAsync(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceWithOptionsAsync(request, runtime);
        }

        public ModifyJobGroupResponse ModifyJobGroupWithOptions(ModifyJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyJobGroupResponse>(DoRPCRequest("ModifyJobGroup", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyJobGroupResponse> ModifyJobGroupWithOptionsAsync(ModifyJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyJobGroupResponse>(await DoRPCRequestAsync("ModifyJobGroup", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyJobGroupResponse ModifyJobGroup(ModifyJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyJobGroupWithOptions(request, runtime);
        }

        public async Task<ModifyJobGroupResponse> ModifyJobGroupAsync(ModifyJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyJobGroupWithOptionsAsync(request, runtime);
        }

        public ModifyResourceProfileResponse ModifyResourceProfileWithOptions(ModifyResourceProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyResourceProfileResponse>(DoRPCRequest("ModifyResourceProfile", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyResourceProfileResponse> ModifyResourceProfileWithOptionsAsync(ModifyResourceProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyResourceProfileResponse>(await DoRPCRequestAsync("ModifyResourceProfile", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyResourceProfileResponse ModifyResourceProfile(ModifyResourceProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyResourceProfileWithOptions(request, runtime);
        }

        public async Task<ModifyResourceProfileResponse> ModifyResourceProfileAsync(ModifyResourceProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyResourceProfileWithOptionsAsync(request, runtime);
        }

        public ModifyWorkGroupResponse ModifyWorkGroupWithOptions(ModifyWorkGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWorkGroupResponse>(DoRPCRequest("ModifyWorkGroup", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWorkGroupResponse> ModifyWorkGroupWithOptionsAsync(ModifyWorkGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWorkGroupResponse>(await DoRPCRequestAsync("ModifyWorkGroup", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWorkGroupResponse ModifyWorkGroup(ModifyWorkGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWorkGroupWithOptions(request, runtime);
        }

        public async Task<ModifyWorkGroupResponse> ModifyWorkGroupAsync(ModifyWorkGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWorkGroupWithOptionsAsync(request, runtime);
        }

        public PutCameraConfForCameraResponse PutCameraConfForCameraWithOptions(PutCameraConfForCameraRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutCameraConfForCameraResponse>(DoRPCRequest("PutCameraConfForCamera", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutCameraConfForCameraResponse> PutCameraConfForCameraWithOptionsAsync(PutCameraConfForCameraRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutCameraConfForCameraResponse>(await DoRPCRequestAsync("PutCameraConfForCamera", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutCameraConfForCameraResponse PutCameraConfForCamera(PutCameraConfForCameraRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutCameraConfForCameraWithOptions(request, runtime);
        }

        public async Task<PutCameraConfForCameraResponse> PutCameraConfForCameraAsync(PutCameraConfForCameraRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutCameraConfForCameraWithOptionsAsync(request, runtime);
        }

        public SearchImagesResponse SearchImagesWithOptions(SearchImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchImagesResponse>(DoRPCRequest("SearchImages", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchImagesResponse> SearchImagesWithOptionsAsync(SearchImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchImagesResponse>(await DoRPCRequestAsync("SearchImages", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchImagesResponse SearchImages(SearchImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchImagesWithOptions(request, runtime);
        }

        public async Task<SearchImagesResponse> SearchImagesAsync(SearchImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchImagesWithOptionsAsync(request, runtime);
        }

        public StartJobGroupResponse StartJobGroupWithOptions(StartJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartJobGroupResponse>(DoRPCRequest("StartJobGroup", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartJobGroupResponse> StartJobGroupWithOptionsAsync(StartJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartJobGroupResponse>(await DoRPCRequestAsync("StartJobGroup", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartJobGroupResponse StartJobGroup(StartJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartJobGroupWithOptions(request, runtime);
        }

        public async Task<StartJobGroupResponse> StartJobGroupAsync(StartJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartJobGroupWithOptionsAsync(request, runtime);
        }

        public StopJobGroupResponse StopJobGroupWithOptions(StopJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopJobGroupResponse>(DoRPCRequest("StopJobGroup", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopJobGroupResponse> StopJobGroupWithOptionsAsync(StopJobGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopJobGroupResponse>(await DoRPCRequestAsync("StopJobGroup", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopJobGroupResponse StopJobGroup(StopJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopJobGroupWithOptions(request, runtime);
        }

        public async Task<StopJobGroupResponse> StopJobGroupAsync(StopJobGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopJobGroupWithOptionsAsync(request, runtime);
        }

    }
}
