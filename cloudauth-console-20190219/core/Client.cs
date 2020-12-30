// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloudauth_console20190219.Models;

namespace AlibabaCloud.SDK.Cloudauth_console20190219
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudauth-console", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectResponse>(DoRPCRequest("CreateProject", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectResponse>(await DoRPCRequestAsync("CreateProject", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProjectWithOptions(request, runtime);
        }

        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProjectWithOptionsAsync(request, runtime);
        }

        public CreateSlrRoleResponse CreateSlrRoleWithOptions(CreateSlrRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSlrRoleResponse>(DoRPCRequest("CreateSlrRole", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSlrRoleResponse> CreateSlrRoleWithOptionsAsync(CreateSlrRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSlrRoleResponse>(await DoRPCRequestAsync("CreateSlrRole", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSlrRoleResponse CreateSlrRole(CreateSlrRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSlrRoleWithOptions(request, runtime);
        }

        public async Task<CreateSlrRoleResponse> CreateSlrRoleAsync(CreateSlrRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSlrRoleWithOptionsAsync(request, runtime);
        }

        public DeleteMnsServeResponse DeleteMnsServeWithOptions(DeleteMnsServeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMnsServeResponse>(DoRPCRequest("DeleteMnsServe", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMnsServeResponse> DeleteMnsServeWithOptionsAsync(DeleteMnsServeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMnsServeResponse>(await DoRPCRequestAsync("DeleteMnsServe", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMnsServeResponse DeleteMnsServe(DeleteMnsServeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMnsServeWithOptions(request, runtime);
        }

        public async Task<DeleteMnsServeResponse> DeleteMnsServeAsync(DeleteMnsServeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMnsServeWithOptionsAsync(request, runtime);
        }

        public DeleteUserGroupResponse DeleteUserGroupWithOptions(DeleteUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserGroupResponse>(DoRPCRequest("DeleteUserGroup", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUserGroupResponse> DeleteUserGroupWithOptionsAsync(DeleteUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserGroupResponse>(await DoRPCRequestAsync("DeleteUserGroup", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUserGroupResponse DeleteUserGroup(DeleteUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserGroupWithOptions(request, runtime);
        }

        public async Task<DeleteUserGroupResponse> DeleteUserGroupAsync(DeleteUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserGroupWithOptionsAsync(request, runtime);
        }

        public DeleteUserInfoResponse DeleteUserInfoWithOptions(DeleteUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserInfoResponse>(DoRPCRequest("DeleteUserInfo", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUserInfoResponse> DeleteUserInfoWithOptionsAsync(DeleteUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserInfoResponse>(await DoRPCRequestAsync("DeleteUserInfo", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUserInfoResponse DeleteUserInfo(DeleteUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserInfoWithOptions(request, runtime);
        }

        public async Task<DeleteUserInfoResponse> DeleteUserInfoAsync(DeleteUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserInfoWithOptionsAsync(request, runtime);
        }

        public DescribeAllEndPointResponse DescribeAllEndPointWithOptions(DescribeAllEndPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAllEndPointResponse>(DoRPCRequest("DescribeAllEndPoint", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAllEndPointResponse> DescribeAllEndPointWithOptionsAsync(DescribeAllEndPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAllEndPointResponse>(await DoRPCRequestAsync("DescribeAllEndPoint", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAllEndPointResponse DescribeAllEndPoint(DescribeAllEndPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAllEndPointWithOptions(request, runtime);
        }

        public async Task<DescribeAllEndPointResponse> DescribeAllEndPointAsync(DescribeAllEndPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAllEndPointWithOptionsAsync(request, runtime);
        }

        public DescribeBindUserIdListResponse DescribeBindUserIdListWithOptions(DescribeBindUserIdListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBindUserIdListResponse>(DoRPCRequest("DescribeBindUserIdList", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBindUserIdListResponse> DescribeBindUserIdListWithOptionsAsync(DescribeBindUserIdListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBindUserIdListResponse>(await DoRPCRequestAsync("DescribeBindUserIdList", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBindUserIdListResponse DescribeBindUserIdList(DescribeBindUserIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBindUserIdListWithOptions(request, runtime);
        }

        public async Task<DescribeBindUserIdListResponse> DescribeBindUserIdListAsync(DescribeBindUserIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBindUserIdListWithOptionsAsync(request, runtime);
        }

        public DescribeCertificateTypeListResponse DescribeCertificateTypeListWithOptions(DescribeCertificateTypeListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCertificateTypeListResponse>(DoRPCRequest("DescribeCertificateTypeList", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCertificateTypeListResponse> DescribeCertificateTypeListWithOptionsAsync(DescribeCertificateTypeListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCertificateTypeListResponse>(await DoRPCRequestAsync("DescribeCertificateTypeList", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCertificateTypeListResponse DescribeCertificateTypeList(DescribeCertificateTypeListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCertificateTypeListWithOptions(request, runtime);
        }

        public async Task<DescribeCertificateTypeListResponse> DescribeCertificateTypeListAsync(DescribeCertificateTypeListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCertificateTypeListWithOptionsAsync(request, runtime);
        }

        public DescribeDeviceListResponse DescribeDeviceListWithOptions(DescribeDeviceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceListResponse>(DoRPCRequest("DescribeDeviceList", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeviceListResponse> DescribeDeviceListWithOptionsAsync(DescribeDeviceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceListResponse>(await DoRPCRequestAsync("DescribeDeviceList", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeviceListResponse DescribeDeviceList(DescribeDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceListWithOptions(request, runtime);
        }

        public async Task<DescribeDeviceListResponse> DescribeDeviceListAsync(DescribeDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceListWithOptionsAsync(request, runtime);
        }

        public DescribeExcelAnalysisResultResponse DescribeExcelAnalysisResultWithOptions(DescribeExcelAnalysisResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExcelAnalysisResultResponse>(DoRPCRequest("DescribeExcelAnalysisResult", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeExcelAnalysisResultResponse> DescribeExcelAnalysisResultWithOptionsAsync(DescribeExcelAnalysisResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExcelAnalysisResultResponse>(await DoRPCRequestAsync("DescribeExcelAnalysisResult", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeExcelAnalysisResultResponse DescribeExcelAnalysisResult(DescribeExcelAnalysisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExcelAnalysisResultWithOptions(request, runtime);
        }

        public async Task<DescribeExcelAnalysisResultResponse> DescribeExcelAnalysisResultAsync(DescribeExcelAnalysisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExcelAnalysisResultWithOptionsAsync(request, runtime);
        }

        public DescribeIdentifyRecordListResponse DescribeIdentifyRecordListWithOptions(DescribeIdentifyRecordListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIdentifyRecordListResponse>(DoRPCRequest("DescribeIdentifyRecordList", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIdentifyRecordListResponse> DescribeIdentifyRecordListWithOptionsAsync(DescribeIdentifyRecordListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIdentifyRecordListResponse>(await DoRPCRequestAsync("DescribeIdentifyRecordList", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIdentifyRecordListResponse DescribeIdentifyRecordList(DescribeIdentifyRecordListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIdentifyRecordListWithOptions(request, runtime);
        }

        public async Task<DescribeIdentifyRecordListResponse> DescribeIdentifyRecordListAsync(DescribeIdentifyRecordListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIdentifyRecordListWithOptionsAsync(request, runtime);
        }

        public DescribeMnsOauthResponse DescribeMnsOauthWithOptions(DescribeMnsOauthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMnsOauthResponse>(DoRPCRequest("DescribeMnsOauth", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMnsOauthResponse> DescribeMnsOauthWithOptionsAsync(DescribeMnsOauthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMnsOauthResponse>(await DoRPCRequestAsync("DescribeMnsOauth", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMnsOauthResponse DescribeMnsOauth(DescribeMnsOauthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMnsOauthWithOptions(request, runtime);
        }

        public async Task<DescribeMnsOauthResponse> DescribeMnsOauthAsync(DescribeMnsOauthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMnsOauthWithOptionsAsync(request, runtime);
        }

        public DescribeOssOauthResponse DescribeOssOauthWithOptions(DescribeOssOauthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOssOauthResponse>(DoRPCRequest("DescribeOssOauth", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeOssOauthResponse> DescribeOssOauthWithOptionsAsync(DescribeOssOauthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOssOauthResponse>(await DoRPCRequestAsync("DescribeOssOauth", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeOssOauthResponse DescribeOssOauth(DescribeOssOauthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOssOauthWithOptions(request, runtime);
        }

        public async Task<DescribeOssOauthResponse> DescribeOssOauthAsync(DescribeOssOauthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOssOauthWithOptionsAsync(request, runtime);
        }

        public DescribeSignedUrlResponse DescribeSignedUrlWithOptions(DescribeSignedUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSignedUrlResponse>(DoRPCRequest("DescribeSignedUrl", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSignedUrlResponse> DescribeSignedUrlWithOptionsAsync(DescribeSignedUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSignedUrlResponse>(await DoRPCRequestAsync("DescribeSignedUrl", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSignedUrlResponse DescribeSignedUrl(DescribeSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSignedUrlWithOptions(request, runtime);
        }

        public async Task<DescribeSignedUrlResponse> DescribeSignedUrlAsync(DescribeSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSignedUrlWithOptionsAsync(request, runtime);
        }

        public DescribeTopicResponse DescribeTopicWithOptions(DescribeTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTopicResponse>(DoRPCRequest("DescribeTopic", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTopicResponse> DescribeTopicWithOptionsAsync(DescribeTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTopicResponse>(await DoRPCRequestAsync("DescribeTopic", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTopicResponse DescribeTopic(DescribeTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTopicWithOptions(request, runtime);
        }

        public async Task<DescribeTopicResponse> DescribeTopicAsync(DescribeTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTopicWithOptionsAsync(request, runtime);
        }

        public DescribeUploadPreSignResponse DescribeUploadPreSignWithOptions(DescribeUploadPreSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUploadPreSignResponse>(DoRPCRequest("DescribeUploadPreSign", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUploadPreSignResponse> DescribeUploadPreSignWithOptionsAsync(DescribeUploadPreSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUploadPreSignResponse>(await DoRPCRequestAsync("DescribeUploadPreSign", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUploadPreSignResponse DescribeUploadPreSign(DescribeUploadPreSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUploadPreSignWithOptions(request, runtime);
        }

        public async Task<DescribeUploadPreSignResponse> DescribeUploadPreSignAsync(DescribeUploadPreSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUploadPreSignWithOptionsAsync(request, runtime);
        }

        public DescribeUserGroupListResponse DescribeUserGroupListWithOptions(DescribeUserGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserGroupListResponse>(DoRPCRequest("DescribeUserGroupList", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserGroupListResponse> DescribeUserGroupListWithOptionsAsync(DescribeUserGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserGroupListResponse>(await DoRPCRequestAsync("DescribeUserGroupList", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserGroupListResponse DescribeUserGroupList(DescribeUserGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserGroupListWithOptions(request, runtime);
        }

        public async Task<DescribeUserGroupListResponse> DescribeUserGroupListAsync(DescribeUserGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserGroupListWithOptionsAsync(request, runtime);
        }

        public DescribeUserInfoListResponse DescribeUserInfoListWithOptions(DescribeUserInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserInfoListResponse>(DoRPCRequest("DescribeUserInfoList", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserInfoListResponse> DescribeUserInfoListWithOptionsAsync(DescribeUserInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserInfoListResponse>(await DoRPCRequestAsync("DescribeUserInfoList", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserInfoListResponse DescribeUserInfoList(DescribeUserInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserInfoListWithOptions(request, runtime);
        }

        public async Task<DescribeUserInfoListResponse> DescribeUserInfoListAsync(DescribeUserInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserInfoListWithOptionsAsync(request, runtime);
        }

        public GetAccountProjectResponse GetAccountProjectWithOptions(GetAccountProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAccountProjectResponse>(DoRPCRequest("GetAccountProject", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAccountProjectResponse> GetAccountProjectWithOptionsAsync(GetAccountProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAccountProjectResponse>(await DoRPCRequestAsync("GetAccountProject", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAccountProjectResponse GetAccountProject(GetAccountProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountProjectWithOptions(request, runtime);
        }

        public async Task<GetAccountProjectResponse> GetAccountProjectAsync(GetAccountProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountProjectWithOptionsAsync(request, runtime);
        }

        public SaveMnsServeResponse SaveMnsServeWithOptions(SaveMnsServeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveMnsServeResponse>(DoRPCRequest("SaveMnsServe", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveMnsServeResponse> SaveMnsServeWithOptionsAsync(SaveMnsServeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveMnsServeResponse>(await DoRPCRequestAsync("SaveMnsServe", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveMnsServeResponse SaveMnsServe(SaveMnsServeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveMnsServeWithOptions(request, runtime);
        }

        public async Task<SaveMnsServeResponse> SaveMnsServeAsync(SaveMnsServeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveMnsServeWithOptionsAsync(request, runtime);
        }

        public SaveOssServeResponse SaveOssServeWithOptions(SaveOssServeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveOssServeResponse>(DoRPCRequest("SaveOssServe", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveOssServeResponse> SaveOssServeWithOptionsAsync(SaveOssServeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveOssServeResponse>(await DoRPCRequestAsync("SaveOssServe", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveOssServeResponse SaveOssServe(SaveOssServeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveOssServeWithOptions(request, runtime);
        }

        public async Task<SaveOssServeResponse> SaveOssServeAsync(SaveOssServeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveOssServeWithOptionsAsync(request, runtime);
        }

        public SaveUserGroupResponse SaveUserGroupWithOptions(SaveUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveUserGroupResponse>(DoRPCRequest("SaveUserGroup", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveUserGroupResponse> SaveUserGroupWithOptionsAsync(SaveUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveUserGroupResponse>(await DoRPCRequestAsync("SaveUserGroup", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveUserGroupResponse SaveUserGroup(SaveUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveUserGroupWithOptions(request, runtime);
        }

        public async Task<SaveUserGroupResponse> SaveUserGroupAsync(SaveUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveUserGroupWithOptionsAsync(request, runtime);
        }

        public SaveUserInfoResponse SaveUserInfoWithOptions(SaveUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveUserInfoResponse>(DoRPCRequest("SaveUserInfo", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveUserInfoResponse> SaveUserInfoWithOptionsAsync(SaveUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveUserInfoResponse>(await DoRPCRequestAsync("SaveUserInfo", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveUserInfoResponse SaveUserInfo(SaveUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveUserInfoWithOptions(request, runtime);
        }

        public async Task<SaveUserInfoResponse> SaveUserInfoAsync(SaveUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveUserInfoWithOptionsAsync(request, runtime);
        }

        public UnbindDeviceResponse UnbindDeviceWithOptions(UnbindDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindDeviceResponse>(DoRPCRequest("UnbindDevice", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindDeviceResponse> UnbindDeviceWithOptionsAsync(UnbindDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindDeviceResponse>(await DoRPCRequestAsync("UnbindDevice", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindDeviceResponse UnbindDevice(UnbindDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindDeviceWithOptions(request, runtime);
        }

        public async Task<UnbindDeviceResponse> UnbindDeviceAsync(UnbindDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindDeviceWithOptionsAsync(request, runtime);
        }

        public UpdateDeviceControlInfoResponse UpdateDeviceControlInfoWithOptions(UpdateDeviceControlInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDeviceControlInfoResponse>(DoRPCRequest("UpdateDeviceControlInfo", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDeviceControlInfoResponse> UpdateDeviceControlInfoWithOptionsAsync(UpdateDeviceControlInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDeviceControlInfoResponse>(await DoRPCRequestAsync("UpdateDeviceControlInfo", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDeviceControlInfoResponse UpdateDeviceControlInfo(UpdateDeviceControlInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDeviceControlInfoWithOptions(request, runtime);
        }

        public async Task<UpdateDeviceControlInfoResponse> UpdateDeviceControlInfoAsync(UpdateDeviceControlInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDeviceControlInfoWithOptionsAsync(request, runtime);
        }

        public UpdateDeviceNameResponse UpdateDeviceNameWithOptions(UpdateDeviceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDeviceNameResponse>(DoRPCRequest("UpdateDeviceName", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDeviceNameResponse> UpdateDeviceNameWithOptionsAsync(UpdateDeviceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDeviceNameResponse>(await DoRPCRequestAsync("UpdateDeviceName", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDeviceNameResponse UpdateDeviceName(UpdateDeviceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDeviceNameWithOptions(request, runtime);
        }

        public async Task<UpdateDeviceNameResponse> UpdateDeviceNameAsync(UpdateDeviceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDeviceNameWithOptionsAsync(request, runtime);
        }

        public UpdateProjectNameResponse UpdateProjectNameWithOptions(UpdateProjectNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectNameResponse>(DoRPCRequest("UpdateProjectName", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateProjectNameResponse> UpdateProjectNameWithOptionsAsync(UpdateProjectNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectNameResponse>(await DoRPCRequestAsync("UpdateProjectName", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateProjectNameResponse UpdateProjectName(UpdateProjectNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProjectNameWithOptions(request, runtime);
        }

        public async Task<UpdateProjectNameResponse> UpdateProjectNameAsync(UpdateProjectNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProjectNameWithOptionsAsync(request, runtime);
        }

        public UpdateUserGroupResponse UpdateUserGroupWithOptions(UpdateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUserGroupResponse>(DoRPCRequest("UpdateUserGroup", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateUserGroupResponse> UpdateUserGroupWithOptionsAsync(UpdateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUserGroupResponse>(await DoRPCRequestAsync("UpdateUserGroup", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateUserGroupResponse UpdateUserGroup(UpdateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserGroupWithOptions(request, runtime);
        }

        public async Task<UpdateUserGroupResponse> UpdateUserGroupAsync(UpdateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserGroupWithOptionsAsync(request, runtime);
        }

        public UpdateUserInfoResponse UpdateUserInfoWithOptions(UpdateUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUserInfoResponse>(DoRPCRequest("UpdateUserInfo", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateUserInfoResponse> UpdateUserInfoWithOptionsAsync(UpdateUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUserInfoResponse>(await DoRPCRequestAsync("UpdateUserInfo", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateUserInfoResponse UpdateUserInfo(UpdateUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserInfoWithOptions(request, runtime);
        }

        public async Task<UpdateUserInfoResponse> UpdateUserInfoAsync(UpdateUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserInfoWithOptionsAsync(request, runtime);
        }

        public UploadIdentifyRecordResponse UploadIdentifyRecordWithOptions(UploadIdentifyRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadIdentifyRecordResponse>(DoRPCRequest("UploadIdentifyRecord", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UploadIdentifyRecordResponse> UploadIdentifyRecordWithOptionsAsync(UploadIdentifyRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadIdentifyRecordResponse>(await DoRPCRequestAsync("UploadIdentifyRecord", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UploadIdentifyRecordResponse UploadIdentifyRecord(UploadIdentifyRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadIdentifyRecordWithOptions(request, runtime);
        }

        public async Task<UploadIdentifyRecordResponse> UploadIdentifyRecordAsync(UploadIdentifyRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadIdentifyRecordWithOptionsAsync(request, runtime);
        }

        public VerifyAccountProjectResponse VerifyAccountProjectWithOptions(VerifyAccountProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyAccountProjectResponse>(DoRPCRequest("VerifyAccountProject", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VerifyAccountProjectResponse> VerifyAccountProjectWithOptionsAsync(VerifyAccountProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyAccountProjectResponse>(await DoRPCRequestAsync("VerifyAccountProject", "2019-02-19", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public VerifyAccountProjectResponse VerifyAccountProject(VerifyAccountProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyAccountProjectWithOptions(request, runtime);
        }

        public async Task<VerifyAccountProjectResponse> VerifyAccountProjectAsync(VerifyAccountProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyAccountProjectWithOptionsAsync(request, runtime);
        }

    }
}
