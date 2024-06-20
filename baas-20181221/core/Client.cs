// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Baas20181221.Models;

namespace AlibabaCloud.SDK.Baas20181221
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "baas.aliyuncs.com"},
                {"cn-beijing", "baas.aliyuncs.com"},
                {"cn-zhangjiakou", "baas.aliyuncs.com"},
                {"cn-huhehaote", "baas.aliyuncs.com"},
                {"cn-shanghai", "baas.aliyuncs.com"},
                {"cn-shenzhen", "baas.aliyuncs.com"},
                {"cn-hongkong", "baas.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "baas.ap-southeast-1.aliyuncs.com"},
                {"ap-northeast-1", "baas.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "baas.ap-southeast-1.aliyuncs.com"},
                {"us-west-1", "baas.ap-southeast-1.aliyuncs.com"},
                {"us-east-1", "baas.ap-southeast-1.aliyuncs.com"},
                {"eu-central-1", "baas.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "baas.ap-southeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("baas", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @param request AcceptFabricInvitationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AcceptFabricInvitationResponse
         */
        public AcceptFabricInvitationResponse AcceptFabricInvitationWithOptions(AcceptFabricInvitationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAccepted))
            {
                body["IsAccepted"] = request.IsAccepted;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptFabricInvitation",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptFabricInvitationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request AcceptFabricInvitationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AcceptFabricInvitationResponse
         */
        public async Task<AcceptFabricInvitationResponse> AcceptFabricInvitationWithOptionsAsync(AcceptFabricInvitationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAccepted))
            {
                body["IsAccepted"] = request.IsAccepted;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptFabricInvitation",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptFabricInvitationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request AcceptFabricInvitationRequest
         * @return AcceptFabricInvitationResponse
         */
        public AcceptFabricInvitationResponse AcceptFabricInvitation(AcceptFabricInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AcceptFabricInvitationWithOptions(request, runtime);
        }

        /**
         * @param request AcceptFabricInvitationRequest
         * @return AcceptFabricInvitationResponse
         */
        public async Task<AcceptFabricInvitationResponse> AcceptFabricInvitationAsync(AcceptFabricInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AcceptFabricInvitationWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ApplyAntChainCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyAntChainCertificateResponse
         */
        public ApplyAntChainCertificateResponse ApplyAntChainCertificateWithOptions(ApplyAntChainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadReq))
            {
                body["UploadReq"] = request.UploadReq;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyAntChainCertificate",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyAntChainCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ApplyAntChainCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyAntChainCertificateResponse
         */
        public async Task<ApplyAntChainCertificateResponse> ApplyAntChainCertificateWithOptionsAsync(ApplyAntChainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadReq))
            {
                body["UploadReq"] = request.UploadReq;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyAntChainCertificate",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyAntChainCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ApplyAntChainCertificateRequest
         * @return ApplyAntChainCertificateResponse
         */
        public ApplyAntChainCertificateResponse ApplyAntChainCertificate(ApplyAntChainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyAntChainCertificateWithOptions(request, runtime);
        }

        /**
         * @param request ApplyAntChainCertificateRequest
         * @return ApplyAntChainCertificateResponse
         */
        public async Task<ApplyAntChainCertificateResponse> ApplyAntChainCertificateAsync(ApplyAntChainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyAntChainCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ApplyAntChainCertificateWithKeyAutoCreationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyAntChainCertificateWithKeyAutoCreationResponse
         */
        public ApplyAntChainCertificateWithKeyAutoCreationResponse ApplyAntChainCertificateWithKeyAutoCreationWithOptions(ApplyAntChainCertificateWithKeyAutoCreationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonName))
            {
                body["CommonName"] = request.CommonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryName))
            {
                body["CountryName"] = request.CountryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalityName))
            {
                body["LocalityName"] = request.LocalityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationName))
            {
                body["OrganizationName"] = request.OrganizationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationUnitName))
            {
                body["OrganizationUnitName"] = request.OrganizationUnitName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateOrProvinceName))
            {
                body["StateOrProvinceName"] = request.StateOrProvinceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyAntChainCertificateWithKeyAutoCreation",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyAntChainCertificateWithKeyAutoCreationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ApplyAntChainCertificateWithKeyAutoCreationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyAntChainCertificateWithKeyAutoCreationResponse
         */
        public async Task<ApplyAntChainCertificateWithKeyAutoCreationResponse> ApplyAntChainCertificateWithKeyAutoCreationWithOptionsAsync(ApplyAntChainCertificateWithKeyAutoCreationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonName))
            {
                body["CommonName"] = request.CommonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryName))
            {
                body["CountryName"] = request.CountryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalityName))
            {
                body["LocalityName"] = request.LocalityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationName))
            {
                body["OrganizationName"] = request.OrganizationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationUnitName))
            {
                body["OrganizationUnitName"] = request.OrganizationUnitName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateOrProvinceName))
            {
                body["StateOrProvinceName"] = request.StateOrProvinceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyAntChainCertificateWithKeyAutoCreation",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyAntChainCertificateWithKeyAutoCreationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ApplyAntChainCertificateWithKeyAutoCreationRequest
         * @return ApplyAntChainCertificateWithKeyAutoCreationResponse
         */
        public ApplyAntChainCertificateWithKeyAutoCreationResponse ApplyAntChainCertificateWithKeyAutoCreation(ApplyAntChainCertificateWithKeyAutoCreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyAntChainCertificateWithKeyAutoCreationWithOptions(request, runtime);
        }

        /**
         * @param request ApplyAntChainCertificateWithKeyAutoCreationRequest
         * @return ApplyAntChainCertificateWithKeyAutoCreationResponse
         */
        public async Task<ApplyAntChainCertificateWithKeyAutoCreationResponse> ApplyAntChainCertificateWithKeyAutoCreationAsync(ApplyAntChainCertificateWithKeyAutoCreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyAntChainCertificateWithKeyAutoCreationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary ApproveFabricChaincodeDefinition
         *
         * @param request ApproveFabricChaincodeDefinitionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApproveFabricChaincodeDefinitionResponse
         */
        public ApproveFabricChaincodeDefinitionResponse ApproveFabricChaincodeDefinitionWithOptions(ApproveFabricChaincodeDefinitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeId))
            {
                body["ChaincodeId"] = request.ChaincodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodePackageId))
            {
                body["ChaincodePackageId"] = request.ChaincodePackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApproveFabricChaincodeDefinition",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApproveFabricChaincodeDefinitionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary ApproveFabricChaincodeDefinition
         *
         * @param request ApproveFabricChaincodeDefinitionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApproveFabricChaincodeDefinitionResponse
         */
        public async Task<ApproveFabricChaincodeDefinitionResponse> ApproveFabricChaincodeDefinitionWithOptionsAsync(ApproveFabricChaincodeDefinitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeId))
            {
                body["ChaincodeId"] = request.ChaincodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodePackageId))
            {
                body["ChaincodePackageId"] = request.ChaincodePackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApproveFabricChaincodeDefinition",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApproveFabricChaincodeDefinitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary ApproveFabricChaincodeDefinition
         *
         * @param request ApproveFabricChaincodeDefinitionRequest
         * @return ApproveFabricChaincodeDefinitionResponse
         */
        public ApproveFabricChaincodeDefinitionResponse ApproveFabricChaincodeDefinition(ApproveFabricChaincodeDefinitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApproveFabricChaincodeDefinitionWithOptions(request, runtime);
        }

        /**
         * @summary ApproveFabricChaincodeDefinition
         *
         * @param request ApproveFabricChaincodeDefinitionRequest
         * @return ApproveFabricChaincodeDefinitionResponse
         */
        public async Task<ApproveFabricChaincodeDefinitionResponse> ApproveFabricChaincodeDefinitionAsync(ApproveFabricChaincodeDefinitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApproveFabricChaincodeDefinitionWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq BatchAddAntChainMiniAppQRCodeAuthorizedUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchAddAntChainMiniAppQRCodeAuthorizedUsersResponse
         */
        public BatchAddAntChainMiniAppQRCodeAuthorizedUsersResponse BatchAddAntChainMiniAppQRCodeAuthorizedUsersWithOptions(BatchAddAntChainMiniAppQRCodeAuthorizedUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchAddAntChainMiniAppQRCodeAuthorizedUsersShrinkRequest request = new BatchAddAntChainMiniAppQRCodeAuthorizedUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PhoneList))
            {
                request.PhoneListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PhoneList, "PhoneList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneListShrink))
            {
                body["PhoneList"] = request.PhoneListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddAntChainMiniAppQRCodeAuthorizedUsers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddAntChainMiniAppQRCodeAuthorizedUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param tmpReq BatchAddAntChainMiniAppQRCodeAuthorizedUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchAddAntChainMiniAppQRCodeAuthorizedUsersResponse
         */
        public async Task<BatchAddAntChainMiniAppQRCodeAuthorizedUsersResponse> BatchAddAntChainMiniAppQRCodeAuthorizedUsersWithOptionsAsync(BatchAddAntChainMiniAppQRCodeAuthorizedUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchAddAntChainMiniAppQRCodeAuthorizedUsersShrinkRequest request = new BatchAddAntChainMiniAppQRCodeAuthorizedUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PhoneList))
            {
                request.PhoneListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PhoneList, "PhoneList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneListShrink))
            {
                body["PhoneList"] = request.PhoneListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddAntChainMiniAppQRCodeAuthorizedUsers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddAntChainMiniAppQRCodeAuthorizedUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request BatchAddAntChainMiniAppQRCodeAuthorizedUsersRequest
         * @return BatchAddAntChainMiniAppQRCodeAuthorizedUsersResponse
         */
        public BatchAddAntChainMiniAppQRCodeAuthorizedUsersResponse BatchAddAntChainMiniAppQRCodeAuthorizedUsers(BatchAddAntChainMiniAppQRCodeAuthorizedUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchAddAntChainMiniAppQRCodeAuthorizedUsersWithOptions(request, runtime);
        }

        /**
         * @param request BatchAddAntChainMiniAppQRCodeAuthorizedUsersRequest
         * @return BatchAddAntChainMiniAppQRCodeAuthorizedUsersResponse
         */
        public async Task<BatchAddAntChainMiniAppQRCodeAuthorizedUsersResponse> BatchAddAntChainMiniAppQRCodeAuthorizedUsersAsync(BatchAddAntChainMiniAppQRCodeAuthorizedUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchAddAntChainMiniAppQRCodeAuthorizedUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CheckFabricConsortiumDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckFabricConsortiumDomainResponse
         */
        public CheckFabricConsortiumDomainResponse CheckFabricConsortiumDomainWithOptions(CheckFabricConsortiumDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainCode))
            {
                body["DomainCode"] = request.DomainCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckFabricConsortiumDomain",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckFabricConsortiumDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CheckFabricConsortiumDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckFabricConsortiumDomainResponse
         */
        public async Task<CheckFabricConsortiumDomainResponse> CheckFabricConsortiumDomainWithOptionsAsync(CheckFabricConsortiumDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainCode))
            {
                body["DomainCode"] = request.DomainCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckFabricConsortiumDomain",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckFabricConsortiumDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CheckFabricConsortiumDomainRequest
         * @return CheckFabricConsortiumDomainResponse
         */
        public CheckFabricConsortiumDomainResponse CheckFabricConsortiumDomain(CheckFabricConsortiumDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckFabricConsortiumDomainWithOptions(request, runtime);
        }

        /**
         * @param request CheckFabricConsortiumDomainRequest
         * @return CheckFabricConsortiumDomainResponse
         */
        public async Task<CheckFabricConsortiumDomainResponse> CheckFabricConsortiumDomainAsync(CheckFabricConsortiumDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckFabricConsortiumDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CheckFabricOrganizationDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckFabricOrganizationDomainResponse
         */
        public CheckFabricOrganizationDomainResponse CheckFabricOrganizationDomainWithOptions(CheckFabricOrganizationDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainCode))
            {
                body["DomainCode"] = request.DomainCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckFabricOrganizationDomain",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckFabricOrganizationDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CheckFabricOrganizationDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckFabricOrganizationDomainResponse
         */
        public async Task<CheckFabricOrganizationDomainResponse> CheckFabricOrganizationDomainWithOptionsAsync(CheckFabricOrganizationDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainCode))
            {
                body["DomainCode"] = request.DomainCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckFabricOrganizationDomain",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckFabricOrganizationDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CheckFabricOrganizationDomainRequest
         * @return CheckFabricOrganizationDomainResponse
         */
        public CheckFabricOrganizationDomainResponse CheckFabricOrganizationDomain(CheckFabricOrganizationDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckFabricOrganizationDomainWithOptions(request, runtime);
        }

        /**
         * @param request CheckFabricOrganizationDomainRequest
         * @return CheckFabricOrganizationDomainResponse
         */
        public async Task<CheckFabricOrganizationDomainResponse> CheckFabricOrganizationDomainAsync(CheckFabricOrganizationDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckFabricOrganizationDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ConfirmFabricConsortiumMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConfirmFabricConsortiumMemberResponse
         */
        public ConfirmFabricConsortiumMemberResponse ConfirmFabricConsortiumMemberWithOptions(ConfirmFabricConsortiumMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                query["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmFabricConsortiumMember",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmFabricConsortiumMemberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ConfirmFabricConsortiumMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConfirmFabricConsortiumMemberResponse
         */
        public async Task<ConfirmFabricConsortiumMemberResponse> ConfirmFabricConsortiumMemberWithOptionsAsync(ConfirmFabricConsortiumMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                query["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmFabricConsortiumMember",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmFabricConsortiumMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ConfirmFabricConsortiumMemberRequest
         * @return ConfirmFabricConsortiumMemberResponse
         */
        public ConfirmFabricConsortiumMemberResponse ConfirmFabricConsortiumMember(ConfirmFabricConsortiumMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmFabricConsortiumMemberWithOptions(request, runtime);
        }

        /**
         * @param request ConfirmFabricConsortiumMemberRequest
         * @return ConfirmFabricConsortiumMemberResponse
         */
        public async Task<ConfirmFabricConsortiumMemberResponse> ConfirmFabricConsortiumMemberAsync(ConfirmFabricConsortiumMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmFabricConsortiumMemberWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CopyAntChainContractProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyAntChainContractProjectResponse
         */
        public CopyAntChainContractProjectResponse CopyAntChainContractProjectWithOptions(CopyAntChainContractProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectDescription))
            {
                body["ProjectDescription"] = request.ProjectDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectVersion))
            {
                body["ProjectVersion"] = request.ProjectVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyAntChainContractProject",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyAntChainContractProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CopyAntChainContractProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyAntChainContractProjectResponse
         */
        public async Task<CopyAntChainContractProjectResponse> CopyAntChainContractProjectWithOptionsAsync(CopyAntChainContractProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectDescription))
            {
                body["ProjectDescription"] = request.ProjectDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectVersion))
            {
                body["ProjectVersion"] = request.ProjectVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyAntChainContractProject",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyAntChainContractProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CopyAntChainContractProjectRequest
         * @return CopyAntChainContractProjectResponse
         */
        public CopyAntChainContractProjectResponse CopyAntChainContractProject(CopyAntChainContractProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyAntChainContractProjectWithOptions(request, runtime);
        }

        /**
         * @param request CopyAntChainContractProjectRequest
         * @return CopyAntChainContractProjectResponse
         */
        public async Task<CopyAntChainContractProjectResponse> CopyAntChainContractProjectAsync(CopyAntChainContractProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyAntChainContractProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateAntChainAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAntChainAccountResponse
         */
        public CreateAntChainAccountResponse CreateAntChainAccountWithOptions(CreateAntChainAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPubKey))
            {
                body["AccountPubKey"] = request.AccountPubKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountRecoverPubKey))
            {
                body["AccountRecoverPubKey"] = request.AccountRecoverPubKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAntChainAccount",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAntChainAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateAntChainAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAntChainAccountResponse
         */
        public async Task<CreateAntChainAccountResponse> CreateAntChainAccountWithOptionsAsync(CreateAntChainAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPubKey))
            {
                body["AccountPubKey"] = request.AccountPubKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountRecoverPubKey))
            {
                body["AccountRecoverPubKey"] = request.AccountRecoverPubKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAntChainAccount",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAntChainAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateAntChainAccountRequest
         * @return CreateAntChainAccountResponse
         */
        public CreateAntChainAccountResponse CreateAntChainAccount(CreateAntChainAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAntChainAccountWithOptions(request, runtime);
        }

        /**
         * @param request CreateAntChainAccountRequest
         * @return CreateAntChainAccountResponse
         */
        public async Task<CreateAntChainAccountResponse> CreateAntChainAccountAsync(CreateAntChainAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAntChainAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateAntChainAccountWithKeyPairAutoCreationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAntChainAccountWithKeyPairAutoCreationResponse
         */
        public CreateAntChainAccountWithKeyPairAutoCreationResponse CreateAntChainAccountWithKeyPairAutoCreationWithOptions(CreateAntChainAccountWithKeyPairAutoCreationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoverPassword))
            {
                body["RecoverPassword"] = request.RecoverPassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAntChainAccountWithKeyPairAutoCreation",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAntChainAccountWithKeyPairAutoCreationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateAntChainAccountWithKeyPairAutoCreationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAntChainAccountWithKeyPairAutoCreationResponse
         */
        public async Task<CreateAntChainAccountWithKeyPairAutoCreationResponse> CreateAntChainAccountWithKeyPairAutoCreationWithOptionsAsync(CreateAntChainAccountWithKeyPairAutoCreationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoverPassword))
            {
                body["RecoverPassword"] = request.RecoverPassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAntChainAccountWithKeyPairAutoCreation",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAntChainAccountWithKeyPairAutoCreationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateAntChainAccountWithKeyPairAutoCreationRequest
         * @return CreateAntChainAccountWithKeyPairAutoCreationResponse
         */
        public CreateAntChainAccountWithKeyPairAutoCreationResponse CreateAntChainAccountWithKeyPairAutoCreation(CreateAntChainAccountWithKeyPairAutoCreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAntChainAccountWithKeyPairAutoCreationWithOptions(request, runtime);
        }

        /**
         * @param request CreateAntChainAccountWithKeyPairAutoCreationRequest
         * @return CreateAntChainAccountWithKeyPairAutoCreationResponse
         */
        public async Task<CreateAntChainAccountWithKeyPairAutoCreationResponse> CreateAntChainAccountWithKeyPairAutoCreationAsync(CreateAntChainAccountWithKeyPairAutoCreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAntChainAccountWithKeyPairAutoCreationWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateAntChainConsortiumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAntChainConsortiumResponse
         */
        public CreateAntChainConsortiumResponse CreateAntChainConsortiumWithOptions(CreateAntChainConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumDescription))
            {
                body["ConsortiumDescription"] = request.ConsortiumDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumName))
            {
                body["ConsortiumName"] = request.ConsortiumName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAntChainConsortium",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAntChainConsortiumResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateAntChainConsortiumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAntChainConsortiumResponse
         */
        public async Task<CreateAntChainConsortiumResponse> CreateAntChainConsortiumWithOptionsAsync(CreateAntChainConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumDescription))
            {
                body["ConsortiumDescription"] = request.ConsortiumDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumName))
            {
                body["ConsortiumName"] = request.ConsortiumName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAntChainConsortium",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAntChainConsortiumResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateAntChainConsortiumRequest
         * @return CreateAntChainConsortiumResponse
         */
        public CreateAntChainConsortiumResponse CreateAntChainConsortium(CreateAntChainConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAntChainConsortiumWithOptions(request, runtime);
        }

        /**
         * @param request CreateAntChainConsortiumRequest
         * @return CreateAntChainConsortiumResponse
         */
        public async Task<CreateAntChainConsortiumResponse> CreateAntChainConsortiumAsync(CreateAntChainConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAntChainConsortiumWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateAntChainContractContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAntChainContractContentResponse
         */
        public CreateAntChainContractContentResponse CreateAntChainContractContentWithOptions(CreateAntChainContractContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentName))
            {
                body["ContentName"] = request.ContentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDirectory))
            {
                body["IsDirectory"] = request.IsDirectory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentContentId))
            {
                body["ParentContentId"] = request.ParentContentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAntChainContractContent",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAntChainContractContentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateAntChainContractContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAntChainContractContentResponse
         */
        public async Task<CreateAntChainContractContentResponse> CreateAntChainContractContentWithOptionsAsync(CreateAntChainContractContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentName))
            {
                body["ContentName"] = request.ContentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDirectory))
            {
                body["IsDirectory"] = request.IsDirectory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentContentId))
            {
                body["ParentContentId"] = request.ParentContentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAntChainContractContent",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAntChainContractContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateAntChainContractContentRequest
         * @return CreateAntChainContractContentResponse
         */
        public CreateAntChainContractContentResponse CreateAntChainContractContent(CreateAntChainContractContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAntChainContractContentWithOptions(request, runtime);
        }

        /**
         * @param request CreateAntChainContractContentRequest
         * @return CreateAntChainContractContentResponse
         */
        public async Task<CreateAntChainContractContentResponse> CreateAntChainContractContentAsync(CreateAntChainContractContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAntChainContractContentWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateAntChainContractProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAntChainContractProjectResponse
         */
        public CreateAntChainContractProjectResponse CreateAntChainContractProjectWithOptions(CreateAntChainContractProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectDescription))
            {
                body["ProjectDescription"] = request.ProjectDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectVersion))
            {
                body["ProjectVersion"] = request.ProjectVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAntChainContractProject",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAntChainContractProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateAntChainContractProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAntChainContractProjectResponse
         */
        public async Task<CreateAntChainContractProjectResponse> CreateAntChainContractProjectWithOptionsAsync(CreateAntChainContractProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectDescription))
            {
                body["ProjectDescription"] = request.ProjectDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectVersion))
            {
                body["ProjectVersion"] = request.ProjectVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAntChainContractProject",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAntChainContractProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateAntChainContractProjectRequest
         * @return CreateAntChainContractProjectResponse
         */
        public CreateAntChainContractProjectResponse CreateAntChainContractProject(CreateAntChainContractProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAntChainContractProjectWithOptions(request, runtime);
        }

        /**
         * @param request CreateAntChainContractProjectRequest
         * @return CreateAntChainContractProjectResponse
         */
        public async Task<CreateAntChainContractProjectResponse> CreateAntChainContractProjectAsync(CreateAntChainContractProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAntChainContractProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建MyChain托管账户
         *
         * @param request CreateAntChainKmsAccountNewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAntChainKmsAccountNewResponse
         */
        public CreateAntChainKmsAccountNewResponse CreateAntChainKmsAccountNewWithOptions(CreateAntChainKmsAccountNewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAntChainKmsAccountNew",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAntChainKmsAccountNewResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建MyChain托管账户
         *
         * @param request CreateAntChainKmsAccountNewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAntChainKmsAccountNewResponse
         */
        public async Task<CreateAntChainKmsAccountNewResponse> CreateAntChainKmsAccountNewWithOptionsAsync(CreateAntChainKmsAccountNewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAntChainKmsAccountNew",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAntChainKmsAccountNewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建MyChain托管账户
         *
         * @param request CreateAntChainKmsAccountNewRequest
         * @return CreateAntChainKmsAccountNewResponse
         */
        public CreateAntChainKmsAccountNewResponse CreateAntChainKmsAccountNew(CreateAntChainKmsAccountNewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAntChainKmsAccountNewWithOptions(request, runtime);
        }

        /**
         * @summary 创建MyChain托管账户
         *
         * @param request CreateAntChainKmsAccountNewRequest
         * @return CreateAntChainKmsAccountNewResponse
         */
        public async Task<CreateAntChainKmsAccountNewResponse> CreateAntChainKmsAccountNewAsync(CreateAntChainKmsAccountNewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAntChainKmsAccountNewWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateFabricChaincodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFabricChaincodeResponse
         */
        public CreateFabricChaincodeResponse CreateFabricChaincodeWithOptions(CreateFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndorsePolicy))
            {
                body["EndorsePolicy"] = request.EndorsePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                body["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssUrl))
            {
                body["OssUrl"] = request.OssUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFabricChaincode",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFabricChaincodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateFabricChaincodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFabricChaincodeResponse
         */
        public async Task<CreateFabricChaincodeResponse> CreateFabricChaincodeWithOptionsAsync(CreateFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndorsePolicy))
            {
                body["EndorsePolicy"] = request.EndorsePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                body["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssUrl))
            {
                body["OssUrl"] = request.OssUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFabricChaincode",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFabricChaincodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateFabricChaincodeRequest
         * @return CreateFabricChaincodeResponse
         */
        public CreateFabricChaincodeResponse CreateFabricChaincode(CreateFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFabricChaincodeWithOptions(request, runtime);
        }

        /**
         * @param request CreateFabricChaincodeRequest
         * @return CreateFabricChaincodeResponse
         */
        public async Task<CreateFabricChaincodeResponse> CreateFabricChaincodeAsync(CreateFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFabricChaincodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary CreateFabricChaincodePackage
         *
         * @param request CreateFabricChaincodePackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFabricChaincodePackageResponse
         */
        public CreateFabricChaincodePackageResponse CreateFabricChaincodePackageWithOptions(CreateFabricChaincodePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssUrl))
            {
                body["OssUrl"] = request.OssUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFabricChaincodePackage",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFabricChaincodePackageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary CreateFabricChaincodePackage
         *
         * @param request CreateFabricChaincodePackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFabricChaincodePackageResponse
         */
        public async Task<CreateFabricChaincodePackageResponse> CreateFabricChaincodePackageWithOptionsAsync(CreateFabricChaincodePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssUrl))
            {
                body["OssUrl"] = request.OssUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFabricChaincodePackage",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFabricChaincodePackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary CreateFabricChaincodePackage
         *
         * @param request CreateFabricChaincodePackageRequest
         * @return CreateFabricChaincodePackageResponse
         */
        public CreateFabricChaincodePackageResponse CreateFabricChaincodePackage(CreateFabricChaincodePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFabricChaincodePackageWithOptions(request, runtime);
        }

        /**
         * @summary CreateFabricChaincodePackage
         *
         * @param request CreateFabricChaincodePackageRequest
         * @return CreateFabricChaincodePackageResponse
         */
        public async Task<CreateFabricChaincodePackageResponse> CreateFabricChaincodePackageAsync(CreateFabricChaincodePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFabricChaincodePackageWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateFabricChannelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFabricChannelResponse
         */
        public CreateFabricChannelResponse CreateFabricChannelWithOptions(CreateFabricChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelName))
            {
                query["ChannelName"] = request.ChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                query["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchTimeout))
            {
                body["BatchTimeout"] = request.BatchTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxMessageCount))
            {
                body["MaxMessageCount"] = request.MaxMessageCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredMaxBytes))
            {
                body["PreferredMaxBytes"] = request.PreferredMaxBytes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFabricChannel",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFabricChannelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateFabricChannelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFabricChannelResponse
         */
        public async Task<CreateFabricChannelResponse> CreateFabricChannelWithOptionsAsync(CreateFabricChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelName))
            {
                query["ChannelName"] = request.ChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                query["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchTimeout))
            {
                body["BatchTimeout"] = request.BatchTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxMessageCount))
            {
                body["MaxMessageCount"] = request.MaxMessageCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredMaxBytes))
            {
                body["PreferredMaxBytes"] = request.PreferredMaxBytes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFabricChannel",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFabricChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateFabricChannelRequest
         * @return CreateFabricChannelResponse
         */
        public CreateFabricChannelResponse CreateFabricChannel(CreateFabricChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFabricChannelWithOptions(request, runtime);
        }

        /**
         * @param request CreateFabricChannelRequest
         * @return CreateFabricChannelResponse
         */
        public async Task<CreateFabricChannelResponse> CreateFabricChannelAsync(CreateFabricChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFabricChannelWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateFabricChannelMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFabricChannelMemberResponse
         */
        public CreateFabricChannelMemberResponse CreateFabricChannelMemberWithOptions(CreateFabricChannelMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFabricChannelMember",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFabricChannelMemberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateFabricChannelMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFabricChannelMemberResponse
         */
        public async Task<CreateFabricChannelMemberResponse> CreateFabricChannelMemberWithOptionsAsync(CreateFabricChannelMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFabricChannelMember",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFabricChannelMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateFabricChannelMemberRequest
         * @return CreateFabricChannelMemberResponse
         */
        public CreateFabricChannelMemberResponse CreateFabricChannelMember(CreateFabricChannelMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFabricChannelMemberWithOptions(request, runtime);
        }

        /**
         * @param request CreateFabricChannelMemberRequest
         * @return CreateFabricChannelMemberResponse
         */
        public async Task<CreateFabricChannelMemberResponse> CreateFabricChannelMemberAsync(CreateFabricChannelMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFabricChannelMemberWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateFabricConsortiumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFabricConsortiumResponse
         */
        public CreateFabricConsortiumResponse CreateFabricConsortiumWithOptions(CreateFabricConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelPolicy))
            {
                body["ChannelPolicy"] = request.ChannelPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumDescription))
            {
                body["ConsortiumDescription"] = request.ConsortiumDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumName))
            {
                body["ConsortiumName"] = request.ConsortiumName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrdererType))
            {
                body["OrdererType"] = request.OrdererType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderersCount))
            {
                body["OrderersCount"] = request.OrderersCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                body["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDuration))
            {
                body["PaymentDuration"] = request.PaymentDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDurationUnit))
            {
                body["PaymentDurationUnit"] = request.PaymentDurationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeersCount))
            {
                body["PeersCount"] = request.PeersCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecName))
            {
                body["SpecName"] = request.SpecName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFabricConsortium",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFabricConsortiumResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateFabricConsortiumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFabricConsortiumResponse
         */
        public async Task<CreateFabricConsortiumResponse> CreateFabricConsortiumWithOptionsAsync(CreateFabricConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelPolicy))
            {
                body["ChannelPolicy"] = request.ChannelPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumDescription))
            {
                body["ConsortiumDescription"] = request.ConsortiumDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumName))
            {
                body["ConsortiumName"] = request.ConsortiumName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrdererType))
            {
                body["OrdererType"] = request.OrdererType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderersCount))
            {
                body["OrderersCount"] = request.OrderersCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                body["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDuration))
            {
                body["PaymentDuration"] = request.PaymentDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDurationUnit))
            {
                body["PaymentDurationUnit"] = request.PaymentDurationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeersCount))
            {
                body["PeersCount"] = request.PeersCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecName))
            {
                body["SpecName"] = request.SpecName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFabricConsortium",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFabricConsortiumResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateFabricConsortiumRequest
         * @return CreateFabricConsortiumResponse
         */
        public CreateFabricConsortiumResponse CreateFabricConsortium(CreateFabricConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFabricConsortiumWithOptions(request, runtime);
        }

        /**
         * @param request CreateFabricConsortiumRequest
         * @return CreateFabricConsortiumResponse
         */
        public async Task<CreateFabricConsortiumResponse> CreateFabricConsortiumAsync(CreateFabricConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFabricConsortiumWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateFabricConsortiumMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFabricConsortiumMemberResponse
         */
        public CreateFabricConsortiumMemberResponse CreateFabricConsortiumMemberWithOptions(CreateFabricConsortiumMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                query["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFabricConsortiumMember",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFabricConsortiumMemberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateFabricConsortiumMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFabricConsortiumMemberResponse
         */
        public async Task<CreateFabricConsortiumMemberResponse> CreateFabricConsortiumMemberWithOptionsAsync(CreateFabricConsortiumMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                query["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFabricConsortiumMember",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFabricConsortiumMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateFabricConsortiumMemberRequest
         * @return CreateFabricConsortiumMemberResponse
         */
        public CreateFabricConsortiumMemberResponse CreateFabricConsortiumMember(CreateFabricConsortiumMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFabricConsortiumMemberWithOptions(request, runtime);
        }

        /**
         * @param request CreateFabricConsortiumMemberRequest
         * @return CreateFabricConsortiumMemberResponse
         */
        public async Task<CreateFabricConsortiumMemberResponse> CreateFabricConsortiumMemberAsync(CreateFabricConsortiumMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFabricConsortiumMemberWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateFabricOrganizationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFabricOrganizationResponse
         */
        public CreateFabricOrganizationResponse CreateFabricOrganizationWithOptions(CreateFabricOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                query["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationName))
            {
                query["OrganizationName"] = request.OrganizationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecName))
            {
                query["SpecName"] = request.SpecName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDuration))
            {
                body["PaymentDuration"] = request.PaymentDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDurationUnit))
            {
                body["PaymentDurationUnit"] = request.PaymentDurationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeersCount))
            {
                body["PeersCount"] = request.PeersCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFabricOrganization",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFabricOrganizationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateFabricOrganizationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFabricOrganizationResponse
         */
        public async Task<CreateFabricOrganizationResponse> CreateFabricOrganizationWithOptionsAsync(CreateFabricOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                query["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationName))
            {
                query["OrganizationName"] = request.OrganizationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecName))
            {
                query["SpecName"] = request.SpecName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDuration))
            {
                body["PaymentDuration"] = request.PaymentDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDurationUnit))
            {
                body["PaymentDurationUnit"] = request.PaymentDurationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeersCount))
            {
                body["PeersCount"] = request.PeersCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFabricOrganization",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFabricOrganizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateFabricOrganizationRequest
         * @return CreateFabricOrganizationResponse
         */
        public CreateFabricOrganizationResponse CreateFabricOrganization(CreateFabricOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFabricOrganizationWithOptions(request, runtime);
        }

        /**
         * @param request CreateFabricOrganizationRequest
         * @return CreateFabricOrganizationResponse
         */
        public async Task<CreateFabricOrganizationResponse> CreateFabricOrganizationAsync(CreateFabricOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFabricOrganizationWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateFabricOrganizationUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFabricOrganizationUserResponse
         */
        public CreateFabricOrganizationUserResponse CreateFabricOrganizationUserWithOptions(CreateFabricOrganizationUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attrs))
            {
                body["Attrs"] = request.Attrs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFabricOrganizationUser",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFabricOrganizationUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateFabricOrganizationUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFabricOrganizationUserResponse
         */
        public async Task<CreateFabricOrganizationUserResponse> CreateFabricOrganizationUserWithOptionsAsync(CreateFabricOrganizationUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attrs))
            {
                body["Attrs"] = request.Attrs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFabricOrganizationUser",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFabricOrganizationUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateFabricOrganizationUserRequest
         * @return CreateFabricOrganizationUserResponse
         */
        public CreateFabricOrganizationUserResponse CreateFabricOrganizationUser(CreateFabricOrganizationUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFabricOrganizationUserWithOptions(request, runtime);
        }

        /**
         * @param request CreateFabricOrganizationUserRequest
         * @return CreateFabricOrganizationUserResponse
         */
        public async Task<CreateFabricOrganizationUserResponse> CreateFabricOrganizationUserAsync(CreateFabricOrganizationUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFabricOrganizationUserWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteAntChainConsortiumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAntChainConsortiumResponse
         */
        public DeleteAntChainConsortiumResponse DeleteAntChainConsortiumWithOptions(DeleteAntChainConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAntChainConsortium",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAntChainConsortiumResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteAntChainConsortiumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAntChainConsortiumResponse
         */
        public async Task<DeleteAntChainConsortiumResponse> DeleteAntChainConsortiumWithOptionsAsync(DeleteAntChainConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAntChainConsortium",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAntChainConsortiumResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteAntChainConsortiumRequest
         * @return DeleteAntChainConsortiumResponse
         */
        public DeleteAntChainConsortiumResponse DeleteAntChainConsortium(DeleteAntChainConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAntChainConsortiumWithOptions(request, runtime);
        }

        /**
         * @param request DeleteAntChainConsortiumRequest
         * @return DeleteAntChainConsortiumResponse
         */
        public async Task<DeleteAntChainConsortiumResponse> DeleteAntChainConsortiumAsync(DeleteAntChainConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAntChainConsortiumWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteAntChainContractContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAntChainContractContentResponse
         */
        public DeleteAntChainContractContentResponse DeleteAntChainContractContentWithOptions(DeleteAntChainContractContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentId))
            {
                body["ContentId"] = request.ContentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAntChainContractContent",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAntChainContractContentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteAntChainContractContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAntChainContractContentResponse
         */
        public async Task<DeleteAntChainContractContentResponse> DeleteAntChainContractContentWithOptionsAsync(DeleteAntChainContractContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentId))
            {
                body["ContentId"] = request.ContentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAntChainContractContent",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAntChainContractContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteAntChainContractContentRequest
         * @return DeleteAntChainContractContentResponse
         */
        public DeleteAntChainContractContentResponse DeleteAntChainContractContent(DeleteAntChainContractContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAntChainContractContentWithOptions(request, runtime);
        }

        /**
         * @param request DeleteAntChainContractContentRequest
         * @return DeleteAntChainContractContentResponse
         */
        public async Task<DeleteAntChainContractContentResponse> DeleteAntChainContractContentAsync(DeleteAntChainContractContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAntChainContractContentWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteAntChainContractProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAntChainContractProjectResponse
         */
        public DeleteAntChainContractProjectResponse DeleteAntChainContractProjectWithOptions(DeleteAntChainContractProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAntChainContractProject",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAntChainContractProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteAntChainContractProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAntChainContractProjectResponse
         */
        public async Task<DeleteAntChainContractProjectResponse> DeleteAntChainContractProjectWithOptionsAsync(DeleteAntChainContractProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAntChainContractProject",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAntChainContractProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteAntChainContractProjectRequest
         * @return DeleteAntChainContractProjectResponse
         */
        public DeleteAntChainContractProjectResponse DeleteAntChainContractProject(DeleteAntChainContractProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAntChainContractProjectWithOptions(request, runtime);
        }

        /**
         * @param request DeleteAntChainContractProjectRequest
         * @return DeleteAntChainContractProjectResponse
         */
        public async Task<DeleteAntChainContractProjectResponse> DeleteAntChainContractProjectAsync(DeleteAntChainContractProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAntChainContractProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteAntChainMiniAppQRCodeAuthorizedUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAntChainMiniAppQRCodeAuthorizedUserResponse
         */
        public DeleteAntChainMiniAppQRCodeAuthorizedUserResponse DeleteAntChainMiniAppQRCodeAuthorizedUserWithOptions(DeleteAntChainMiniAppQRCodeAuthorizedUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["Phone"] = request.Phone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAntChainMiniAppQRCodeAuthorizedUser",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAntChainMiniAppQRCodeAuthorizedUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteAntChainMiniAppQRCodeAuthorizedUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAntChainMiniAppQRCodeAuthorizedUserResponse
         */
        public async Task<DeleteAntChainMiniAppQRCodeAuthorizedUserResponse> DeleteAntChainMiniAppQRCodeAuthorizedUserWithOptionsAsync(DeleteAntChainMiniAppQRCodeAuthorizedUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["Phone"] = request.Phone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAntChainMiniAppQRCodeAuthorizedUser",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAntChainMiniAppQRCodeAuthorizedUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteAntChainMiniAppQRCodeAuthorizedUserRequest
         * @return DeleteAntChainMiniAppQRCodeAuthorizedUserResponse
         */
        public DeleteAntChainMiniAppQRCodeAuthorizedUserResponse DeleteAntChainMiniAppQRCodeAuthorizedUser(DeleteAntChainMiniAppQRCodeAuthorizedUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAntChainMiniAppQRCodeAuthorizedUserWithOptions(request, runtime);
        }

        /**
         * @param request DeleteAntChainMiniAppQRCodeAuthorizedUserRequest
         * @return DeleteAntChainMiniAppQRCodeAuthorizedUserResponse
         */
        public async Task<DeleteAntChainMiniAppQRCodeAuthorizedUserResponse> DeleteAntChainMiniAppQRCodeAuthorizedUserAsync(DeleteAntChainMiniAppQRCodeAuthorizedUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAntChainMiniAppQRCodeAuthorizedUserWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteFabricChaincodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFabricChaincodeResponse
         */
        public DeleteFabricChaincodeResponse DeleteFabricChaincodeWithOptions(DeleteFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeId))
            {
                body["ChaincodeId"] = request.ChaincodeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFabricChaincode",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFabricChaincodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteFabricChaincodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFabricChaincodeResponse
         */
        public async Task<DeleteFabricChaincodeResponse> DeleteFabricChaincodeWithOptionsAsync(DeleteFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeId))
            {
                body["ChaincodeId"] = request.ChaincodeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFabricChaincode",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFabricChaincodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteFabricChaincodeRequest
         * @return DeleteFabricChaincodeResponse
         */
        public DeleteFabricChaincodeResponse DeleteFabricChaincode(DeleteFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFabricChaincodeWithOptions(request, runtime);
        }

        /**
         * @param request DeleteFabricChaincodeRequest
         * @return DeleteFabricChaincodeResponse
         */
        public async Task<DeleteFabricChaincodeResponse> DeleteFabricChaincodeAsync(DeleteFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFabricChaincodeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainAccountsResponse
         */
        public DescribeAntChainAccountsResponse DescribeAntChainAccountsWithOptions(DescribeAntChainAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainAccounts",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainAccountsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainAccountsResponse
         */
        public async Task<DescribeAntChainAccountsResponse> DescribeAntChainAccountsWithOptionsAsync(DescribeAntChainAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainAccounts",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainAccountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainAccountsRequest
         * @return DescribeAntChainAccountsResponse
         */
        public DescribeAntChainAccountsResponse DescribeAntChainAccounts(DescribeAntChainAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainAccountsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainAccountsRequest
         * @return DescribeAntChainAccountsResponse
         */
        public async Task<DescribeAntChainAccountsResponse> DescribeAntChainAccountsAsync(DescribeAntChainAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainAccountsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainAccountsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainAccountsV2Response
         */
        public DescribeAntChainAccountsV2Response DescribeAntChainAccountsV2WithOptions(DescribeAntChainAccountsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainAccountsV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainAccountsV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainAccountsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainAccountsV2Response
         */
        public async Task<DescribeAntChainAccountsV2Response> DescribeAntChainAccountsV2WithOptionsAsync(DescribeAntChainAccountsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainAccountsV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainAccountsV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainAccountsV2Request
         * @return DescribeAntChainAccountsV2Response
         */
        public DescribeAntChainAccountsV2Response DescribeAntChainAccountsV2(DescribeAntChainAccountsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainAccountsV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainAccountsV2Request
         * @return DescribeAntChainAccountsV2Response
         */
        public async Task<DescribeAntChainAccountsV2Response> DescribeAntChainAccountsV2Async(DescribeAntChainAccountsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainAccountsV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainBlockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainBlockResponse
         */
        public DescribeAntChainBlockResponse DescribeAntChainBlockWithOptions(DescribeAntChainBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["Height"] = request.Height;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainBlock",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainBlockResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainBlockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainBlockResponse
         */
        public async Task<DescribeAntChainBlockResponse> DescribeAntChainBlockWithOptionsAsync(DescribeAntChainBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["Height"] = request.Height;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainBlock",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainBlockResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainBlockRequest
         * @return DescribeAntChainBlockResponse
         */
        public DescribeAntChainBlockResponse DescribeAntChainBlock(DescribeAntChainBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainBlockWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainBlockRequest
         * @return DescribeAntChainBlockResponse
         */
        public async Task<DescribeAntChainBlockResponse> DescribeAntChainBlockAsync(DescribeAntChainBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainBlockWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainBlockV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainBlockV2Response
         */
        public DescribeAntChainBlockV2Response DescribeAntChainBlockV2WithOptions(DescribeAntChainBlockV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["Height"] = request.Height;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainBlockV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainBlockV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainBlockV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainBlockV2Response
         */
        public async Task<DescribeAntChainBlockV2Response> DescribeAntChainBlockV2WithOptionsAsync(DescribeAntChainBlockV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["Height"] = request.Height;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainBlockV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainBlockV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainBlockV2Request
         * @return DescribeAntChainBlockV2Response
         */
        public DescribeAntChainBlockV2Response DescribeAntChainBlockV2(DescribeAntChainBlockV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainBlockV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainBlockV2Request
         * @return DescribeAntChainBlockV2Response
         */
        public async Task<DescribeAntChainBlockV2Response> DescribeAntChainBlockV2Async(DescribeAntChainBlockV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainBlockV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainCertificateApplicationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainCertificateApplicationsResponse
         */
        public DescribeAntChainCertificateApplicationsResponse DescribeAntChainCertificateApplicationsWithOptions(DescribeAntChainCertificateApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainCertificateApplications",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainCertificateApplicationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainCertificateApplicationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainCertificateApplicationsResponse
         */
        public async Task<DescribeAntChainCertificateApplicationsResponse> DescribeAntChainCertificateApplicationsWithOptionsAsync(DescribeAntChainCertificateApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainCertificateApplications",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainCertificateApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainCertificateApplicationsRequest
         * @return DescribeAntChainCertificateApplicationsResponse
         */
        public DescribeAntChainCertificateApplicationsResponse DescribeAntChainCertificateApplications(DescribeAntChainCertificateApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainCertificateApplicationsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainCertificateApplicationsRequest
         * @return DescribeAntChainCertificateApplicationsResponse
         */
        public async Task<DescribeAntChainCertificateApplicationsResponse> DescribeAntChainCertificateApplicationsAsync(DescribeAntChainCertificateApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainCertificateApplicationsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainCertificateApplicationsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainCertificateApplicationsV2Response
         */
        public DescribeAntChainCertificateApplicationsV2Response DescribeAntChainCertificateApplicationsV2WithOptions(DescribeAntChainCertificateApplicationsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainCertificateApplicationsV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainCertificateApplicationsV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainCertificateApplicationsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainCertificateApplicationsV2Response
         */
        public async Task<DescribeAntChainCertificateApplicationsV2Response> DescribeAntChainCertificateApplicationsV2WithOptionsAsync(DescribeAntChainCertificateApplicationsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainCertificateApplicationsV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainCertificateApplicationsV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainCertificateApplicationsV2Request
         * @return DescribeAntChainCertificateApplicationsV2Response
         */
        public DescribeAntChainCertificateApplicationsV2Response DescribeAntChainCertificateApplicationsV2(DescribeAntChainCertificateApplicationsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainCertificateApplicationsV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainCertificateApplicationsV2Request
         * @return DescribeAntChainCertificateApplicationsV2Response
         */
        public async Task<DescribeAntChainCertificateApplicationsV2Response> DescribeAntChainCertificateApplicationsV2Async(DescribeAntChainCertificateApplicationsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainCertificateApplicationsV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainConsortiumsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainConsortiumsResponse
         */
        public DescribeAntChainConsortiumsResponse DescribeAntChainConsortiumsWithOptions(DescribeAntChainConsortiumsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainConsortiums",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainConsortiumsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainConsortiumsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainConsortiumsResponse
         */
        public async Task<DescribeAntChainConsortiumsResponse> DescribeAntChainConsortiumsWithOptionsAsync(DescribeAntChainConsortiumsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainConsortiums",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainConsortiumsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainConsortiumsRequest
         * @return DescribeAntChainConsortiumsResponse
         */
        public DescribeAntChainConsortiumsResponse DescribeAntChainConsortiums(DescribeAntChainConsortiumsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainConsortiumsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainConsortiumsRequest
         * @return DescribeAntChainConsortiumsResponse
         */
        public async Task<DescribeAntChainConsortiumsResponse> DescribeAntChainConsortiumsAsync(DescribeAntChainConsortiumsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainConsortiumsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainConsortiumsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainConsortiumsV2Response
         */
        public DescribeAntChainConsortiumsV2Response DescribeAntChainConsortiumsV2WithOptions(DescribeAntChainConsortiumsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainConsortiumsV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainConsortiumsV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainConsortiumsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainConsortiumsV2Response
         */
        public async Task<DescribeAntChainConsortiumsV2Response> DescribeAntChainConsortiumsV2WithOptionsAsync(DescribeAntChainConsortiumsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainConsortiumsV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainConsortiumsV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainConsortiumsV2Request
         * @return DescribeAntChainConsortiumsV2Response
         */
        public DescribeAntChainConsortiumsV2Response DescribeAntChainConsortiumsV2(DescribeAntChainConsortiumsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainConsortiumsV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainConsortiumsV2Request
         * @return DescribeAntChainConsortiumsV2Response
         */
        public async Task<DescribeAntChainConsortiumsV2Response> DescribeAntChainConsortiumsV2Async(DescribeAntChainConsortiumsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainConsortiumsV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainContractProjectContentTreeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainContractProjectContentTreeResponse
         */
        public DescribeAntChainContractProjectContentTreeResponse DescribeAntChainContractProjectContentTreeWithOptions(DescribeAntChainContractProjectContentTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainContractProjectContentTree",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainContractProjectContentTreeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainContractProjectContentTreeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainContractProjectContentTreeResponse
         */
        public async Task<DescribeAntChainContractProjectContentTreeResponse> DescribeAntChainContractProjectContentTreeWithOptionsAsync(DescribeAntChainContractProjectContentTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainContractProjectContentTree",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainContractProjectContentTreeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainContractProjectContentTreeRequest
         * @return DescribeAntChainContractProjectContentTreeResponse
         */
        public DescribeAntChainContractProjectContentTreeResponse DescribeAntChainContractProjectContentTree(DescribeAntChainContractProjectContentTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainContractProjectContentTreeWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainContractProjectContentTreeRequest
         * @return DescribeAntChainContractProjectContentTreeResponse
         */
        public async Task<DescribeAntChainContractProjectContentTreeResponse> DescribeAntChainContractProjectContentTreeAsync(DescribeAntChainContractProjectContentTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainContractProjectContentTreeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainContractProjectContentTreeV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainContractProjectContentTreeV2Response
         */
        public DescribeAntChainContractProjectContentTreeV2Response DescribeAntChainContractProjectContentTreeV2WithOptions(DescribeAntChainContractProjectContentTreeV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainContractProjectContentTreeV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainContractProjectContentTreeV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainContractProjectContentTreeV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainContractProjectContentTreeV2Response
         */
        public async Task<DescribeAntChainContractProjectContentTreeV2Response> DescribeAntChainContractProjectContentTreeV2WithOptionsAsync(DescribeAntChainContractProjectContentTreeV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainContractProjectContentTreeV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainContractProjectContentTreeV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainContractProjectContentTreeV2Request
         * @return DescribeAntChainContractProjectContentTreeV2Response
         */
        public DescribeAntChainContractProjectContentTreeV2Response DescribeAntChainContractProjectContentTreeV2(DescribeAntChainContractProjectContentTreeV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainContractProjectContentTreeV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainContractProjectContentTreeV2Request
         * @return DescribeAntChainContractProjectContentTreeV2Response
         */
        public async Task<DescribeAntChainContractProjectContentTreeV2Response> DescribeAntChainContractProjectContentTreeV2Async(DescribeAntChainContractProjectContentTreeV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainContractProjectContentTreeV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainContractProjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainContractProjectsResponse
         */
        public DescribeAntChainContractProjectsResponse DescribeAntChainContractProjectsWithOptions(DescribeAntChainContractProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainContractProjects",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainContractProjectsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainContractProjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainContractProjectsResponse
         */
        public async Task<DescribeAntChainContractProjectsResponse> DescribeAntChainContractProjectsWithOptionsAsync(DescribeAntChainContractProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainContractProjects",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainContractProjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainContractProjectsRequest
         * @return DescribeAntChainContractProjectsResponse
         */
        public DescribeAntChainContractProjectsResponse DescribeAntChainContractProjects(DescribeAntChainContractProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainContractProjectsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainContractProjectsRequest
         * @return DescribeAntChainContractProjectsResponse
         */
        public async Task<DescribeAntChainContractProjectsResponse> DescribeAntChainContractProjectsAsync(DescribeAntChainContractProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainContractProjectsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainContractProjectsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainContractProjectsV2Response
         */
        public DescribeAntChainContractProjectsV2Response DescribeAntChainContractProjectsV2WithOptions(DescribeAntChainContractProjectsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainContractProjectsV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainContractProjectsV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainContractProjectsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainContractProjectsV2Response
         */
        public async Task<DescribeAntChainContractProjectsV2Response> DescribeAntChainContractProjectsV2WithOptionsAsync(DescribeAntChainContractProjectsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainContractProjectsV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainContractProjectsV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainContractProjectsV2Request
         * @return DescribeAntChainContractProjectsV2Response
         */
        public DescribeAntChainContractProjectsV2Response DescribeAntChainContractProjectsV2(DescribeAntChainContractProjectsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainContractProjectsV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainContractProjectsV2Request
         * @return DescribeAntChainContractProjectsV2Response
         */
        public async Task<DescribeAntChainContractProjectsV2Response> DescribeAntChainContractProjectsV2Async(DescribeAntChainContractProjectsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainContractProjectsV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainDownloadPathsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainDownloadPathsResponse
         */
        public DescribeAntChainDownloadPathsResponse DescribeAntChainDownloadPathsWithOptions(DescribeAntChainDownloadPathsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainDownloadPaths",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainDownloadPathsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainDownloadPathsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainDownloadPathsResponse
         */
        public async Task<DescribeAntChainDownloadPathsResponse> DescribeAntChainDownloadPathsWithOptionsAsync(DescribeAntChainDownloadPathsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainDownloadPaths",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainDownloadPathsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainDownloadPathsRequest
         * @return DescribeAntChainDownloadPathsResponse
         */
        public DescribeAntChainDownloadPathsResponse DescribeAntChainDownloadPaths(DescribeAntChainDownloadPathsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainDownloadPathsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainDownloadPathsRequest
         * @return DescribeAntChainDownloadPathsResponse
         */
        public async Task<DescribeAntChainDownloadPathsResponse> DescribeAntChainDownloadPathsAsync(DescribeAntChainDownloadPathsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainDownloadPathsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainDownloadPathsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainDownloadPathsV2Response
         */
        public DescribeAntChainDownloadPathsV2Response DescribeAntChainDownloadPathsV2WithOptions(DescribeAntChainDownloadPathsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainDownloadPathsV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainDownloadPathsV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainDownloadPathsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainDownloadPathsV2Response
         */
        public async Task<DescribeAntChainDownloadPathsV2Response> DescribeAntChainDownloadPathsV2WithOptionsAsync(DescribeAntChainDownloadPathsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainDownloadPathsV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainDownloadPathsV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainDownloadPathsV2Request
         * @return DescribeAntChainDownloadPathsV2Response
         */
        public DescribeAntChainDownloadPathsV2Response DescribeAntChainDownloadPathsV2(DescribeAntChainDownloadPathsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainDownloadPathsV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainDownloadPathsV2Request
         * @return DescribeAntChainDownloadPathsV2Response
         */
        public async Task<DescribeAntChainDownloadPathsV2Response> DescribeAntChainDownloadPathsV2Async(DescribeAntChainDownloadPathsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainDownloadPathsV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainInformationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainInformationResponse
         */
        public DescribeAntChainInformationResponse DescribeAntChainInformationWithOptions(DescribeAntChainInformationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainInformation",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainInformationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainInformationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainInformationResponse
         */
        public async Task<DescribeAntChainInformationResponse> DescribeAntChainInformationWithOptionsAsync(DescribeAntChainInformationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainInformation",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainInformationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainInformationRequest
         * @return DescribeAntChainInformationResponse
         */
        public DescribeAntChainInformationResponse DescribeAntChainInformation(DescribeAntChainInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainInformationWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainInformationRequest
         * @return DescribeAntChainInformationResponse
         */
        public async Task<DescribeAntChainInformationResponse> DescribeAntChainInformationAsync(DescribeAntChainInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainInformationWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainInformationV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainInformationV2Response
         */
        public DescribeAntChainInformationV2Response DescribeAntChainInformationV2WithOptions(DescribeAntChainInformationV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainInformationV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainInformationV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainInformationV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainInformationV2Response
         */
        public async Task<DescribeAntChainInformationV2Response> DescribeAntChainInformationV2WithOptionsAsync(DescribeAntChainInformationV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainInformationV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainInformationV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainInformationV2Request
         * @return DescribeAntChainInformationV2Response
         */
        public DescribeAntChainInformationV2Response DescribeAntChainInformationV2(DescribeAntChainInformationV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainInformationV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainInformationV2Request
         * @return DescribeAntChainInformationV2Response
         */
        public async Task<DescribeAntChainInformationV2Response> DescribeAntChainInformationV2Async(DescribeAntChainInformationV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainInformationV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainLatestBlocksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainLatestBlocksResponse
         */
        public DescribeAntChainLatestBlocksResponse DescribeAntChainLatestBlocksWithOptions(DescribeAntChainLatestBlocksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainLatestBlocks",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainLatestBlocksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainLatestBlocksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainLatestBlocksResponse
         */
        public async Task<DescribeAntChainLatestBlocksResponse> DescribeAntChainLatestBlocksWithOptionsAsync(DescribeAntChainLatestBlocksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainLatestBlocks",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainLatestBlocksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainLatestBlocksRequest
         * @return DescribeAntChainLatestBlocksResponse
         */
        public DescribeAntChainLatestBlocksResponse DescribeAntChainLatestBlocks(DescribeAntChainLatestBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainLatestBlocksWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainLatestBlocksRequest
         * @return DescribeAntChainLatestBlocksResponse
         */
        public async Task<DescribeAntChainLatestBlocksResponse> DescribeAntChainLatestBlocksAsync(DescribeAntChainLatestBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainLatestBlocksWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainLatestBlocksV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainLatestBlocksV2Response
         */
        public DescribeAntChainLatestBlocksV2Response DescribeAntChainLatestBlocksV2WithOptions(DescribeAntChainLatestBlocksV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainLatestBlocksV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainLatestBlocksV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainLatestBlocksV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainLatestBlocksV2Response
         */
        public async Task<DescribeAntChainLatestBlocksV2Response> DescribeAntChainLatestBlocksV2WithOptionsAsync(DescribeAntChainLatestBlocksV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainLatestBlocksV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainLatestBlocksV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainLatestBlocksV2Request
         * @return DescribeAntChainLatestBlocksV2Response
         */
        public DescribeAntChainLatestBlocksV2Response DescribeAntChainLatestBlocksV2(DescribeAntChainLatestBlocksV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainLatestBlocksV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainLatestBlocksV2Request
         * @return DescribeAntChainLatestBlocksV2Response
         */
        public async Task<DescribeAntChainLatestBlocksV2Response> DescribeAntChainLatestBlocksV2Async(DescribeAntChainLatestBlocksV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainLatestBlocksV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainLatestTransactionDigestsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainLatestTransactionDigestsResponse
         */
        public DescribeAntChainLatestTransactionDigestsResponse DescribeAntChainLatestTransactionDigestsWithOptions(DescribeAntChainLatestTransactionDigestsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainLatestTransactionDigests",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainLatestTransactionDigestsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainLatestTransactionDigestsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainLatestTransactionDigestsResponse
         */
        public async Task<DescribeAntChainLatestTransactionDigestsResponse> DescribeAntChainLatestTransactionDigestsWithOptionsAsync(DescribeAntChainLatestTransactionDigestsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainLatestTransactionDigests",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainLatestTransactionDigestsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainLatestTransactionDigestsRequest
         * @return DescribeAntChainLatestTransactionDigestsResponse
         */
        public DescribeAntChainLatestTransactionDigestsResponse DescribeAntChainLatestTransactionDigests(DescribeAntChainLatestTransactionDigestsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainLatestTransactionDigestsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainLatestTransactionDigestsRequest
         * @return DescribeAntChainLatestTransactionDigestsResponse
         */
        public async Task<DescribeAntChainLatestTransactionDigestsResponse> DescribeAntChainLatestTransactionDigestsAsync(DescribeAntChainLatestTransactionDigestsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainLatestTransactionDigestsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainLatestTransactionDigestsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainLatestTransactionDigestsV2Response
         */
        public DescribeAntChainLatestTransactionDigestsV2Response DescribeAntChainLatestTransactionDigestsV2WithOptions(DescribeAntChainLatestTransactionDigestsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainLatestTransactionDigestsV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainLatestTransactionDigestsV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainLatestTransactionDigestsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainLatestTransactionDigestsV2Response
         */
        public async Task<DescribeAntChainLatestTransactionDigestsV2Response> DescribeAntChainLatestTransactionDigestsV2WithOptionsAsync(DescribeAntChainLatestTransactionDigestsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainLatestTransactionDigestsV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainLatestTransactionDigestsV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainLatestTransactionDigestsV2Request
         * @return DescribeAntChainLatestTransactionDigestsV2Response
         */
        public DescribeAntChainLatestTransactionDigestsV2Response DescribeAntChainLatestTransactionDigestsV2(DescribeAntChainLatestTransactionDigestsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainLatestTransactionDigestsV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainLatestTransactionDigestsV2Request
         * @return DescribeAntChainLatestTransactionDigestsV2Response
         */
        public async Task<DescribeAntChainLatestTransactionDigestsV2Response> DescribeAntChainLatestTransactionDigestsV2Async(DescribeAntChainLatestTransactionDigestsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainLatestTransactionDigestsV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainMembersResponse
         */
        public DescribeAntChainMembersResponse DescribeAntChainMembersWithOptions(DescribeAntChainMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainMembers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainMembersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainMembersResponse
         */
        public async Task<DescribeAntChainMembersResponse> DescribeAntChainMembersWithOptionsAsync(DescribeAntChainMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainMembers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainMembersRequest
         * @return DescribeAntChainMembersResponse
         */
        public DescribeAntChainMembersResponse DescribeAntChainMembers(DescribeAntChainMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainMembersWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainMembersRequest
         * @return DescribeAntChainMembersResponse
         */
        public async Task<DescribeAntChainMembersResponse> DescribeAntChainMembersAsync(DescribeAntChainMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainMembersWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainMembersV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainMembersV2Response
         */
        public DescribeAntChainMembersV2Response DescribeAntChainMembersV2WithOptions(DescribeAntChainMembersV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainMembersV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainMembersV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainMembersV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainMembersV2Response
         */
        public async Task<DescribeAntChainMembersV2Response> DescribeAntChainMembersV2WithOptionsAsync(DescribeAntChainMembersV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainMembersV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainMembersV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainMembersV2Request
         * @return DescribeAntChainMembersV2Response
         */
        public DescribeAntChainMembersV2Response DescribeAntChainMembersV2(DescribeAntChainMembersV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainMembersV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainMembersV2Request
         * @return DescribeAntChainMembersV2Response
         */
        public async Task<DescribeAntChainMembersV2Response> DescribeAntChainMembersV2Async(DescribeAntChainMembersV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainMembersV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserQRCodeAccessLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainMiniAppBrowserQRCodeAccessLogResponse
         */
        public DescribeAntChainMiniAppBrowserQRCodeAccessLogResponse DescribeAntChainMiniAppBrowserQRCodeAccessLogWithOptions(DescribeAntChainMiniAppBrowserQRCodeAccessLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QRCodeType))
            {
                body["QRCodeType"] = request.QRCodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainMiniAppBrowserQRCodeAccessLog",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserQRCodeAccessLogResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserQRCodeAccessLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainMiniAppBrowserQRCodeAccessLogResponse
         */
        public async Task<DescribeAntChainMiniAppBrowserQRCodeAccessLogResponse> DescribeAntChainMiniAppBrowserQRCodeAccessLogWithOptionsAsync(DescribeAntChainMiniAppBrowserQRCodeAccessLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QRCodeType))
            {
                body["QRCodeType"] = request.QRCodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainMiniAppBrowserQRCodeAccessLog",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserQRCodeAccessLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserQRCodeAccessLogRequest
         * @return DescribeAntChainMiniAppBrowserQRCodeAccessLogResponse
         */
        public DescribeAntChainMiniAppBrowserQRCodeAccessLogResponse DescribeAntChainMiniAppBrowserQRCodeAccessLog(DescribeAntChainMiniAppBrowserQRCodeAccessLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainMiniAppBrowserQRCodeAccessLogWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserQRCodeAccessLogRequest
         * @return DescribeAntChainMiniAppBrowserQRCodeAccessLogResponse
         */
        public async Task<DescribeAntChainMiniAppBrowserQRCodeAccessLogResponse> DescribeAntChainMiniAppBrowserQRCodeAccessLogAsync(DescribeAntChainMiniAppBrowserQRCodeAccessLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainMiniAppBrowserQRCodeAccessLogWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Response
         */
        public DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Response DescribeAntChainMiniAppBrowserQRCodeAccessLogV2WithOptions(DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QRCodeType))
            {
                body["QRCodeType"] = request.QRCodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainMiniAppBrowserQRCodeAccessLogV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Response
         */
        public async Task<DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Response> DescribeAntChainMiniAppBrowserQRCodeAccessLogV2WithOptionsAsync(DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QRCodeType))
            {
                body["QRCodeType"] = request.QRCodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainMiniAppBrowserQRCodeAccessLogV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Request
         * @return DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Response
         */
        public DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Response DescribeAntChainMiniAppBrowserQRCodeAccessLogV2(DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainMiniAppBrowserQRCodeAccessLogV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Request
         * @return DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Response
         */
        public async Task<DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Response> DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Async(DescribeAntChainMiniAppBrowserQRCodeAccessLogV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainMiniAppBrowserQRCodeAccessLogV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponse
         */
        public DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponse DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersWithOptions(DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QRCodeType))
            {
                body["QRCodeType"] = request.QRCodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponse
         */
        public async Task<DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponse> DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersWithOptionsAsync(DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QRCodeType))
            {
                body["QRCodeType"] = request.QRCodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersRequest
         * @return DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponse
         */
        public DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponse DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsers(DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersRequest
         * @return DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponse
         */
        public async Task<DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponse> DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersAsync(DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Response
         */
        public DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Response DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2WithOptions(DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QRCodeType))
            {
                body["QRCodeType"] = request.QRCodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Response
         */
        public async Task<DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Response> DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2WithOptionsAsync(DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QRCodeType))
            {
                body["QRCodeType"] = request.QRCodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Request
         * @return DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Response
         */
        public DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Response DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2(DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Request
         * @return DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Response
         */
        public async Task<DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Response> DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Async(DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserTransactionQRCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainMiniAppBrowserTransactionQRCodeResponse
         */
        public DescribeAntChainMiniAppBrowserTransactionQRCodeResponse DescribeAntChainMiniAppBrowserTransactionQRCodeWithOptions(DescribeAntChainMiniAppBrowserTransactionQRCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionHash))
            {
                body["TransactionHash"] = request.TransactionHash;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainMiniAppBrowserTransactionQRCode",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserTransactionQRCodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserTransactionQRCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainMiniAppBrowserTransactionQRCodeResponse
         */
        public async Task<DescribeAntChainMiniAppBrowserTransactionQRCodeResponse> DescribeAntChainMiniAppBrowserTransactionQRCodeWithOptionsAsync(DescribeAntChainMiniAppBrowserTransactionQRCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionHash))
            {
                body["TransactionHash"] = request.TransactionHash;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainMiniAppBrowserTransactionQRCode",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserTransactionQRCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserTransactionQRCodeRequest
         * @return DescribeAntChainMiniAppBrowserTransactionQRCodeResponse
         */
        public DescribeAntChainMiniAppBrowserTransactionQRCodeResponse DescribeAntChainMiniAppBrowserTransactionQRCode(DescribeAntChainMiniAppBrowserTransactionQRCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainMiniAppBrowserTransactionQRCodeWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserTransactionQRCodeRequest
         * @return DescribeAntChainMiniAppBrowserTransactionQRCodeResponse
         */
        public async Task<DescribeAntChainMiniAppBrowserTransactionQRCodeResponse> DescribeAntChainMiniAppBrowserTransactionQRCodeAsync(DescribeAntChainMiniAppBrowserTransactionQRCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainMiniAppBrowserTransactionQRCodeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserTransactionQRCodeNewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainMiniAppBrowserTransactionQRCodeNewResponse
         */
        public DescribeAntChainMiniAppBrowserTransactionQRCodeNewResponse DescribeAntChainMiniAppBrowserTransactionQRCodeNewWithOptions(DescribeAntChainMiniAppBrowserTransactionQRCodeNewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractId))
            {
                body["ContractId"] = request.ContractId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionHash))
            {
                body["TransactionHash"] = request.TransactionHash;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainMiniAppBrowserTransactionQRCodeNew",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserTransactionQRCodeNewResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserTransactionQRCodeNewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainMiniAppBrowserTransactionQRCodeNewResponse
         */
        public async Task<DescribeAntChainMiniAppBrowserTransactionQRCodeNewResponse> DescribeAntChainMiniAppBrowserTransactionQRCodeNewWithOptionsAsync(DescribeAntChainMiniAppBrowserTransactionQRCodeNewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractId))
            {
                body["ContractId"] = request.ContractId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionHash))
            {
                body["TransactionHash"] = request.TransactionHash;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainMiniAppBrowserTransactionQRCodeNew",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserTransactionQRCodeNewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserTransactionQRCodeNewRequest
         * @return DescribeAntChainMiniAppBrowserTransactionQRCodeNewResponse
         */
        public DescribeAntChainMiniAppBrowserTransactionQRCodeNewResponse DescribeAntChainMiniAppBrowserTransactionQRCodeNew(DescribeAntChainMiniAppBrowserTransactionQRCodeNewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainMiniAppBrowserTransactionQRCodeNewWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainMiniAppBrowserTransactionQRCodeNewRequest
         * @return DescribeAntChainMiniAppBrowserTransactionQRCodeNewResponse
         */
        public async Task<DescribeAntChainMiniAppBrowserTransactionQRCodeNewResponse> DescribeAntChainMiniAppBrowserTransactionQRCodeNewAsync(DescribeAntChainMiniAppBrowserTransactionQRCodeNewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainMiniAppBrowserTransactionQRCodeNewWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainNodesResponse
         */
        public DescribeAntChainNodesResponse DescribeAntChainNodesWithOptions(DescribeAntChainNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainNodes",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainNodesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainNodesResponse
         */
        public async Task<DescribeAntChainNodesResponse> DescribeAntChainNodesWithOptionsAsync(DescribeAntChainNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainNodes",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainNodesRequest
         * @return DescribeAntChainNodesResponse
         */
        public DescribeAntChainNodesResponse DescribeAntChainNodes(DescribeAntChainNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainNodesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainNodesRequest
         * @return DescribeAntChainNodesResponse
         */
        public async Task<DescribeAntChainNodesResponse> DescribeAntChainNodesAsync(DescribeAntChainNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainNodesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainNodesV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainNodesV2Response
         */
        public DescribeAntChainNodesV2Response DescribeAntChainNodesV2WithOptions(DescribeAntChainNodesV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainNodesV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainNodesV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainNodesV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainNodesV2Response
         */
        public async Task<DescribeAntChainNodesV2Response> DescribeAntChainNodesV2WithOptionsAsync(DescribeAntChainNodesV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainNodesV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainNodesV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainNodesV2Request
         * @return DescribeAntChainNodesV2Response
         */
        public DescribeAntChainNodesV2Response DescribeAntChainNodesV2(DescribeAntChainNodesV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainNodesV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainNodesV2Request
         * @return DescribeAntChainNodesV2Response
         */
        public async Task<DescribeAntChainNodesV2Response> DescribeAntChainNodesV2Async(DescribeAntChainNodesV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainNodesV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainQRCodeAuthorizationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainQRCodeAuthorizationResponse
         */
        public DescribeAntChainQRCodeAuthorizationResponse DescribeAntChainQRCodeAuthorizationWithOptions(DescribeAntChainQRCodeAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QRCodeType))
            {
                body["QRCodeType"] = request.QRCodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainQRCodeAuthorization",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainQRCodeAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainQRCodeAuthorizationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainQRCodeAuthorizationResponse
         */
        public async Task<DescribeAntChainQRCodeAuthorizationResponse> DescribeAntChainQRCodeAuthorizationWithOptionsAsync(DescribeAntChainQRCodeAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QRCodeType))
            {
                body["QRCodeType"] = request.QRCodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainQRCodeAuthorization",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainQRCodeAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainQRCodeAuthorizationRequest
         * @return DescribeAntChainQRCodeAuthorizationResponse
         */
        public DescribeAntChainQRCodeAuthorizationResponse DescribeAntChainQRCodeAuthorization(DescribeAntChainQRCodeAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainQRCodeAuthorizationWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainQRCodeAuthorizationRequest
         * @return DescribeAntChainQRCodeAuthorizationResponse
         */
        public async Task<DescribeAntChainQRCodeAuthorizationResponse> DescribeAntChainQRCodeAuthorizationAsync(DescribeAntChainQRCodeAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainQRCodeAuthorizationWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainQRCodeAuthorizationV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainQRCodeAuthorizationV2Response
         */
        public DescribeAntChainQRCodeAuthorizationV2Response DescribeAntChainQRCodeAuthorizationV2WithOptions(DescribeAntChainQRCodeAuthorizationV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QRCodeType))
            {
                body["QRCodeType"] = request.QRCodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainQRCodeAuthorizationV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainQRCodeAuthorizationV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainQRCodeAuthorizationV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainQRCodeAuthorizationV2Response
         */
        public async Task<DescribeAntChainQRCodeAuthorizationV2Response> DescribeAntChainQRCodeAuthorizationV2WithOptionsAsync(DescribeAntChainQRCodeAuthorizationV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QRCodeType))
            {
                body["QRCodeType"] = request.QRCodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainQRCodeAuthorizationV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainQRCodeAuthorizationV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainQRCodeAuthorizationV2Request
         * @return DescribeAntChainQRCodeAuthorizationV2Response
         */
        public DescribeAntChainQRCodeAuthorizationV2Response DescribeAntChainQRCodeAuthorizationV2(DescribeAntChainQRCodeAuthorizationV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainQRCodeAuthorizationV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainQRCodeAuthorizationV2Request
         * @return DescribeAntChainQRCodeAuthorizationV2Response
         */
        public async Task<DescribeAntChainQRCodeAuthorizationV2Response> DescribeAntChainQRCodeAuthorizationV2Async(DescribeAntChainQRCodeAuthorizationV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainQRCodeAuthorizationV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainTransactionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainTransactionResponse
         */
        public DescribeAntChainTransactionResponse DescribeAntChainTransactionWithOptions(DescribeAntChainTransactionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hash))
            {
                body["Hash"] = request.Hash;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainTransaction",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainTransactionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainTransactionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainTransactionResponse
         */
        public async Task<DescribeAntChainTransactionResponse> DescribeAntChainTransactionWithOptionsAsync(DescribeAntChainTransactionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hash))
            {
                body["Hash"] = request.Hash;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainTransaction",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainTransactionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainTransactionRequest
         * @return DescribeAntChainTransactionResponse
         */
        public DescribeAntChainTransactionResponse DescribeAntChainTransaction(DescribeAntChainTransactionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainTransactionWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainTransactionRequest
         * @return DescribeAntChainTransactionResponse
         */
        public async Task<DescribeAntChainTransactionResponse> DescribeAntChainTransactionAsync(DescribeAntChainTransactionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainTransactionWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainTransactionReceiptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainTransactionReceiptResponse
         */
        public DescribeAntChainTransactionReceiptResponse DescribeAntChainTransactionReceiptWithOptions(DescribeAntChainTransactionReceiptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hash))
            {
                body["Hash"] = request.Hash;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainTransactionReceipt",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainTransactionReceiptResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainTransactionReceiptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainTransactionReceiptResponse
         */
        public async Task<DescribeAntChainTransactionReceiptResponse> DescribeAntChainTransactionReceiptWithOptionsAsync(DescribeAntChainTransactionReceiptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hash))
            {
                body["Hash"] = request.Hash;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainTransactionReceipt",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainTransactionReceiptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainTransactionReceiptRequest
         * @return DescribeAntChainTransactionReceiptResponse
         */
        public DescribeAntChainTransactionReceiptResponse DescribeAntChainTransactionReceipt(DescribeAntChainTransactionReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainTransactionReceiptWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainTransactionReceiptRequest
         * @return DescribeAntChainTransactionReceiptResponse
         */
        public async Task<DescribeAntChainTransactionReceiptResponse> DescribeAntChainTransactionReceiptAsync(DescribeAntChainTransactionReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainTransactionReceiptWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainTransactionReceiptV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainTransactionReceiptV2Response
         */
        public DescribeAntChainTransactionReceiptV2Response DescribeAntChainTransactionReceiptV2WithOptions(DescribeAntChainTransactionReceiptV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hash))
            {
                body["Hash"] = request.Hash;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainTransactionReceiptV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainTransactionReceiptV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainTransactionReceiptV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainTransactionReceiptV2Response
         */
        public async Task<DescribeAntChainTransactionReceiptV2Response> DescribeAntChainTransactionReceiptV2WithOptionsAsync(DescribeAntChainTransactionReceiptV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hash))
            {
                body["Hash"] = request.Hash;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainTransactionReceiptV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainTransactionReceiptV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainTransactionReceiptV2Request
         * @return DescribeAntChainTransactionReceiptV2Response
         */
        public DescribeAntChainTransactionReceiptV2Response DescribeAntChainTransactionReceiptV2(DescribeAntChainTransactionReceiptV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainTransactionReceiptV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainTransactionReceiptV2Request
         * @return DescribeAntChainTransactionReceiptV2Response
         */
        public async Task<DescribeAntChainTransactionReceiptV2Response> DescribeAntChainTransactionReceiptV2Async(DescribeAntChainTransactionReceiptV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainTransactionReceiptV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainTransactionStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainTransactionStatisticsResponse
         */
        public DescribeAntChainTransactionStatisticsResponse DescribeAntChainTransactionStatisticsWithOptions(DescribeAntChainTransactionStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainTransactionStatistics",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainTransactionStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainTransactionStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainTransactionStatisticsResponse
         */
        public async Task<DescribeAntChainTransactionStatisticsResponse> DescribeAntChainTransactionStatisticsWithOptionsAsync(DescribeAntChainTransactionStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainTransactionStatistics",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainTransactionStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainTransactionStatisticsRequest
         * @return DescribeAntChainTransactionStatisticsResponse
         */
        public DescribeAntChainTransactionStatisticsResponse DescribeAntChainTransactionStatistics(DescribeAntChainTransactionStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainTransactionStatisticsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainTransactionStatisticsRequest
         * @return DescribeAntChainTransactionStatisticsResponse
         */
        public async Task<DescribeAntChainTransactionStatisticsResponse> DescribeAntChainTransactionStatisticsAsync(DescribeAntChainTransactionStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainTransactionStatisticsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainTransactionStatisticsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainTransactionStatisticsV2Response
         */
        public DescribeAntChainTransactionStatisticsV2Response DescribeAntChainTransactionStatisticsV2WithOptions(DescribeAntChainTransactionStatisticsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainTransactionStatisticsV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainTransactionStatisticsV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainTransactionStatisticsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainTransactionStatisticsV2Response
         */
        public async Task<DescribeAntChainTransactionStatisticsV2Response> DescribeAntChainTransactionStatisticsV2WithOptionsAsync(DescribeAntChainTransactionStatisticsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainTransactionStatisticsV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainTransactionStatisticsV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainTransactionStatisticsV2Request
         * @return DescribeAntChainTransactionStatisticsV2Response
         */
        public DescribeAntChainTransactionStatisticsV2Response DescribeAntChainTransactionStatisticsV2(DescribeAntChainTransactionStatisticsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainTransactionStatisticsV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainTransactionStatisticsV2Request
         * @return DescribeAntChainTransactionStatisticsV2Response
         */
        public async Task<DescribeAntChainTransactionStatisticsV2Response> DescribeAntChainTransactionStatisticsV2Async(DescribeAntChainTransactionStatisticsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainTransactionStatisticsV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainTransactionV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainTransactionV2Response
         */
        public DescribeAntChainTransactionV2Response DescribeAntChainTransactionV2WithOptions(DescribeAntChainTransactionV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hash))
            {
                body["Hash"] = request.Hash;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainTransactionV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainTransactionV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainTransactionV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainTransactionV2Response
         */
        public async Task<DescribeAntChainTransactionV2Response> DescribeAntChainTransactionV2WithOptionsAsync(DescribeAntChainTransactionV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hash))
            {
                body["Hash"] = request.Hash;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainTransactionV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainTransactionV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainTransactionV2Request
         * @return DescribeAntChainTransactionV2Response
         */
        public DescribeAntChainTransactionV2Response DescribeAntChainTransactionV2(DescribeAntChainTransactionV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainTransactionV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainTransactionV2Request
         * @return DescribeAntChainTransactionV2Response
         */
        public async Task<DescribeAntChainTransactionV2Response> DescribeAntChainTransactionV2Async(DescribeAntChainTransactionV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainTransactionV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainsResponse
         */
        public DescribeAntChainsResponse DescribeAntChainsWithOptions(DescribeAntChainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChains",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainsResponse
         */
        public async Task<DescribeAntChainsResponse> DescribeAntChainsWithOptionsAsync(DescribeAntChainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChains",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainsRequest
         * @return DescribeAntChainsResponse
         */
        public DescribeAntChainsResponse DescribeAntChains(DescribeAntChainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainsRequest
         * @return DescribeAntChainsResponse
         */
        public async Task<DescribeAntChainsResponse> DescribeAntChainsAsync(DescribeAntChainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAntChainsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainsV2Response
         */
        public DescribeAntChainsV2Response DescribeAntChainsV2WithOptions(DescribeAntChainsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainsV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainsV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAntChainsV2Response
         */
        public async Task<DescribeAntChainsV2Response> DescribeAntChainsV2WithOptionsAsync(DescribeAntChainsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAntChainsV2",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAntChainsV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeAntChainsV2Request
         * @return DescribeAntChainsV2Response
         */
        public DescribeAntChainsV2Response DescribeAntChainsV2(DescribeAntChainsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainsV2WithOptions(request, runtime);
        }

        /**
         * @param request DescribeAntChainsV2Request
         * @return DescribeAntChainsV2Response
         */
        public async Task<DescribeAntChainsV2Response> DescribeAntChainsV2Async(DescribeAntChainsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainsV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeEthereumDeletableRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEthereumDeletableResponse
         */
        public DescribeEthereumDeletableResponse DescribeEthereumDeletableWithOptions(DescribeEthereumDeletableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EthereumId))
            {
                body["EthereumId"] = request.EthereumId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEthereumDeletable",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEthereumDeletableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeEthereumDeletableRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEthereumDeletableResponse
         */
        public async Task<DescribeEthereumDeletableResponse> DescribeEthereumDeletableWithOptionsAsync(DescribeEthereumDeletableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EthereumId))
            {
                body["EthereumId"] = request.EthereumId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEthereumDeletable",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEthereumDeletableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeEthereumDeletableRequest
         * @return DescribeEthereumDeletableResponse
         */
        public DescribeEthereumDeletableResponse DescribeEthereumDeletable(DescribeEthereumDeletableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEthereumDeletableWithOptions(request, runtime);
        }

        /**
         * @param request DescribeEthereumDeletableRequest
         * @return DescribeEthereumDeletableResponse
         */
        public async Task<DescribeEthereumDeletableResponse> DescribeEthereumDeletableAsync(DescribeEthereumDeletableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEthereumDeletableWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricCandidateOrganizationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricCandidateOrganizationsResponse
         */
        public DescribeFabricCandidateOrganizationsResponse DescribeFabricCandidateOrganizationsWithOptions(DescribeFabricCandidateOrganizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricCandidateOrganizations",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricCandidateOrganizationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricCandidateOrganizationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricCandidateOrganizationsResponse
         */
        public async Task<DescribeFabricCandidateOrganizationsResponse> DescribeFabricCandidateOrganizationsWithOptionsAsync(DescribeFabricCandidateOrganizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricCandidateOrganizations",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricCandidateOrganizationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricCandidateOrganizationsRequest
         * @return DescribeFabricCandidateOrganizationsResponse
         */
        public DescribeFabricCandidateOrganizationsResponse DescribeFabricCandidateOrganizations(DescribeFabricCandidateOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricCandidateOrganizationsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricCandidateOrganizationsRequest
         * @return DescribeFabricCandidateOrganizationsResponse
         */
        public async Task<DescribeFabricCandidateOrganizationsResponse> DescribeFabricCandidateOrganizationsAsync(DescribeFabricCandidateOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricCandidateOrganizationsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary DescribeFabricChaincodeDefinitionTask
         *
         * @param request DescribeFabricChaincodeDefinitionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricChaincodeDefinitionTaskResponse
         */
        public DescribeFabricChaincodeDefinitionTaskResponse DescribeFabricChaincodeDefinitionTaskWithOptions(DescribeFabricChaincodeDefinitionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeId))
            {
                body["ChaincodeId"] = request.ChaincodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricChaincodeDefinitionTask",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricChaincodeDefinitionTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary DescribeFabricChaincodeDefinitionTask
         *
         * @param request DescribeFabricChaincodeDefinitionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricChaincodeDefinitionTaskResponse
         */
        public async Task<DescribeFabricChaincodeDefinitionTaskResponse> DescribeFabricChaincodeDefinitionTaskWithOptionsAsync(DescribeFabricChaincodeDefinitionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeId))
            {
                body["ChaincodeId"] = request.ChaincodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricChaincodeDefinitionTask",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricChaincodeDefinitionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary DescribeFabricChaincodeDefinitionTask
         *
         * @param request DescribeFabricChaincodeDefinitionTaskRequest
         * @return DescribeFabricChaincodeDefinitionTaskResponse
         */
        public DescribeFabricChaincodeDefinitionTaskResponse DescribeFabricChaincodeDefinitionTask(DescribeFabricChaincodeDefinitionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricChaincodeDefinitionTaskWithOptions(request, runtime);
        }

        /**
         * @summary DescribeFabricChaincodeDefinitionTask
         *
         * @param request DescribeFabricChaincodeDefinitionTaskRequest
         * @return DescribeFabricChaincodeDefinitionTaskResponse
         */
        public async Task<DescribeFabricChaincodeDefinitionTaskResponse> DescribeFabricChaincodeDefinitionTaskAsync(DescribeFabricChaincodeDefinitionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricChaincodeDefinitionTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricChaincodeUploadPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricChaincodeUploadPolicyResponse
         */
        public DescribeFabricChaincodeUploadPolicyResponse DescribeFabricChaincodeUploadPolicyWithOptions(DescribeFabricChaincodeUploadPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricChaincodeUploadPolicy",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricChaincodeUploadPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricChaincodeUploadPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricChaincodeUploadPolicyResponse
         */
        public async Task<DescribeFabricChaincodeUploadPolicyResponse> DescribeFabricChaincodeUploadPolicyWithOptionsAsync(DescribeFabricChaincodeUploadPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricChaincodeUploadPolicy",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricChaincodeUploadPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricChaincodeUploadPolicyRequest
         * @return DescribeFabricChaincodeUploadPolicyResponse
         */
        public DescribeFabricChaincodeUploadPolicyResponse DescribeFabricChaincodeUploadPolicy(DescribeFabricChaincodeUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricChaincodeUploadPolicyWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricChaincodeUploadPolicyRequest
         * @return DescribeFabricChaincodeUploadPolicyResponse
         */
        public async Task<DescribeFabricChaincodeUploadPolicyResponse> DescribeFabricChaincodeUploadPolicyAsync(DescribeFabricChaincodeUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricChaincodeUploadPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricChannelMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricChannelMembersResponse
         */
        public DescribeFabricChannelMembersResponse DescribeFabricChannelMembersWithOptions(DescribeFabricChannelMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricChannelMembers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricChannelMembersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricChannelMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricChannelMembersResponse
         */
        public async Task<DescribeFabricChannelMembersResponse> DescribeFabricChannelMembersWithOptionsAsync(DescribeFabricChannelMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricChannelMembers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricChannelMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricChannelMembersRequest
         * @return DescribeFabricChannelMembersResponse
         */
        public DescribeFabricChannelMembersResponse DescribeFabricChannelMembers(DescribeFabricChannelMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricChannelMembersWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricChannelMembersRequest
         * @return DescribeFabricChannelMembersResponse
         */
        public async Task<DescribeFabricChannelMembersResponse> DescribeFabricChannelMembersAsync(DescribeFabricChannelMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricChannelMembersWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricConsortiumAdminStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumAdminStatusResponse
         */
        public DescribeFabricConsortiumAdminStatusResponse DescribeFabricConsortiumAdminStatusWithOptions(DescribeFabricConsortiumAdminStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumAdminStatus",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumAdminStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumAdminStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumAdminStatusResponse
         */
        public async Task<DescribeFabricConsortiumAdminStatusResponse> DescribeFabricConsortiumAdminStatusWithOptionsAsync(DescribeFabricConsortiumAdminStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumAdminStatus",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumAdminStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumAdminStatusRequest
         * @return DescribeFabricConsortiumAdminStatusResponse
         */
        public DescribeFabricConsortiumAdminStatusResponse DescribeFabricConsortiumAdminStatus(DescribeFabricConsortiumAdminStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumAdminStatusWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricConsortiumAdminStatusRequest
         * @return DescribeFabricConsortiumAdminStatusResponse
         */
        public async Task<DescribeFabricConsortiumAdminStatusResponse> DescribeFabricConsortiumAdminStatusAsync(DescribeFabricConsortiumAdminStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumAdminStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricConsortiumChaincodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumChaincodesResponse
         */
        public DescribeFabricConsortiumChaincodesResponse DescribeFabricConsortiumChaincodesWithOptions(DescribeFabricConsortiumChaincodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumChaincodes",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumChaincodesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumChaincodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumChaincodesResponse
         */
        public async Task<DescribeFabricConsortiumChaincodesResponse> DescribeFabricConsortiumChaincodesWithOptionsAsync(DescribeFabricConsortiumChaincodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumChaincodes",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumChaincodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumChaincodesRequest
         * @return DescribeFabricConsortiumChaincodesResponse
         */
        public DescribeFabricConsortiumChaincodesResponse DescribeFabricConsortiumChaincodes(DescribeFabricConsortiumChaincodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumChaincodesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricConsortiumChaincodesRequest
         * @return DescribeFabricConsortiumChaincodesResponse
         */
        public async Task<DescribeFabricConsortiumChaincodesResponse> DescribeFabricConsortiumChaincodesAsync(DescribeFabricConsortiumChaincodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumChaincodesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricConsortiumChannelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumChannelsResponse
         */
        public DescribeFabricConsortiumChannelsResponse DescribeFabricConsortiumChannelsWithOptions(DescribeFabricConsortiumChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                query["ConsortiumId"] = request.ConsortiumId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumChannels",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumChannelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumChannelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumChannelsResponse
         */
        public async Task<DescribeFabricConsortiumChannelsResponse> DescribeFabricConsortiumChannelsWithOptionsAsync(DescribeFabricConsortiumChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                query["ConsortiumId"] = request.ConsortiumId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumChannels",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumChannelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumChannelsRequest
         * @return DescribeFabricConsortiumChannelsResponse
         */
        public DescribeFabricConsortiumChannelsResponse DescribeFabricConsortiumChannels(DescribeFabricConsortiumChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumChannelsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricConsortiumChannelsRequest
         * @return DescribeFabricConsortiumChannelsResponse
         */
        public async Task<DescribeFabricConsortiumChannelsResponse> DescribeFabricConsortiumChannelsAsync(DescribeFabricConsortiumChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumChannelsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricConsortiumConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumConfigResponse
         */
        public DescribeFabricConsortiumConfigResponse DescribeFabricConsortiumConfigWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumConfig",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumConfigResponse
         */
        public async Task<DescribeFabricConsortiumConfigResponse> DescribeFabricConsortiumConfigWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumConfig",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return DescribeFabricConsortiumConfigResponse
         */
        public DescribeFabricConsortiumConfigResponse DescribeFabricConsortiumConfig()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumConfigWithOptions(runtime);
        }

        /**
         * @return DescribeFabricConsortiumConfigResponse
         */
        public async Task<DescribeFabricConsortiumConfigResponse> DescribeFabricConsortiumConfigAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumConfigWithOptionsAsync(runtime);
        }

        /**
         * @param request DescribeFabricConsortiumDeletableRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumDeletableResponse
         */
        public DescribeFabricConsortiumDeletableResponse DescribeFabricConsortiumDeletableWithOptions(DescribeFabricConsortiumDeletableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                query["ConsortiumId"] = request.ConsortiumId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumDeletable",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumDeletableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumDeletableRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumDeletableResponse
         */
        public async Task<DescribeFabricConsortiumDeletableResponse> DescribeFabricConsortiumDeletableWithOptionsAsync(DescribeFabricConsortiumDeletableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                query["ConsortiumId"] = request.ConsortiumId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumDeletable",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumDeletableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumDeletableRequest
         * @return DescribeFabricConsortiumDeletableResponse
         */
        public DescribeFabricConsortiumDeletableResponse DescribeFabricConsortiumDeletable(DescribeFabricConsortiumDeletableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumDeletableWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricConsortiumDeletableRequest
         * @return DescribeFabricConsortiumDeletableResponse
         */
        public async Task<DescribeFabricConsortiumDeletableResponse> DescribeFabricConsortiumDeletableAsync(DescribeFabricConsortiumDeletableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumDeletableWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricConsortiumMemberApprovalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumMemberApprovalResponse
         */
        public DescribeFabricConsortiumMemberApprovalResponse DescribeFabricConsortiumMemberApprovalWithOptions(DescribeFabricConsortiumMemberApprovalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                query["ConsortiumId"] = request.ConsortiumId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumMemberApproval",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumMemberApprovalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumMemberApprovalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumMemberApprovalResponse
         */
        public async Task<DescribeFabricConsortiumMemberApprovalResponse> DescribeFabricConsortiumMemberApprovalWithOptionsAsync(DescribeFabricConsortiumMemberApprovalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                query["ConsortiumId"] = request.ConsortiumId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumMemberApproval",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumMemberApprovalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumMemberApprovalRequest
         * @return DescribeFabricConsortiumMemberApprovalResponse
         */
        public DescribeFabricConsortiumMemberApprovalResponse DescribeFabricConsortiumMemberApproval(DescribeFabricConsortiumMemberApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumMemberApprovalWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricConsortiumMemberApprovalRequest
         * @return DescribeFabricConsortiumMemberApprovalResponse
         */
        public async Task<DescribeFabricConsortiumMemberApprovalResponse> DescribeFabricConsortiumMemberApprovalAsync(DescribeFabricConsortiumMemberApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumMemberApprovalWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricConsortiumMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumMembersResponse
         */
        public DescribeFabricConsortiumMembersResponse DescribeFabricConsortiumMembersWithOptions(DescribeFabricConsortiumMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumMembers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumMembersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumMembersResponse
         */
        public async Task<DescribeFabricConsortiumMembersResponse> DescribeFabricConsortiumMembersWithOptionsAsync(DescribeFabricConsortiumMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumMembers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumMembersRequest
         * @return DescribeFabricConsortiumMembersResponse
         */
        public DescribeFabricConsortiumMembersResponse DescribeFabricConsortiumMembers(DescribeFabricConsortiumMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumMembersWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricConsortiumMembersRequest
         * @return DescribeFabricConsortiumMembersResponse
         */
        public async Task<DescribeFabricConsortiumMembersResponse> DescribeFabricConsortiumMembersAsync(DescribeFabricConsortiumMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumMembersWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricConsortiumOrderersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumOrderersResponse
         */
        public DescribeFabricConsortiumOrderersResponse DescribeFabricConsortiumOrderersWithOptions(DescribeFabricConsortiumOrderersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumOrderers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumOrderersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumOrderersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumOrderersResponse
         */
        public async Task<DescribeFabricConsortiumOrderersResponse> DescribeFabricConsortiumOrderersWithOptionsAsync(DescribeFabricConsortiumOrderersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumOrderers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumOrderersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumOrderersRequest
         * @return DescribeFabricConsortiumOrderersResponse
         */
        public DescribeFabricConsortiumOrderersResponse DescribeFabricConsortiumOrderers(DescribeFabricConsortiumOrderersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumOrderersWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricConsortiumOrderersRequest
         * @return DescribeFabricConsortiumOrderersResponse
         */
        public async Task<DescribeFabricConsortiumOrderersResponse> DescribeFabricConsortiumOrderersAsync(DescribeFabricConsortiumOrderersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumOrderersWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricConsortiumSpecsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumSpecsResponse
         */
        public DescribeFabricConsortiumSpecsResponse DescribeFabricConsortiumSpecsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumSpecs",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumSpecsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumSpecsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumSpecsResponse
         */
        public async Task<DescribeFabricConsortiumSpecsResponse> DescribeFabricConsortiumSpecsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiumSpecs",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumSpecsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return DescribeFabricConsortiumSpecsResponse
         */
        public DescribeFabricConsortiumSpecsResponse DescribeFabricConsortiumSpecs()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumSpecsWithOptions(runtime);
        }

        /**
         * @return DescribeFabricConsortiumSpecsResponse
         */
        public async Task<DescribeFabricConsortiumSpecsResponse> DescribeFabricConsortiumSpecsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumSpecsWithOptionsAsync(runtime);
        }

        /**
         * @param request DescribeFabricConsortiumsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumsResponse
         */
        public DescribeFabricConsortiumsResponse DescribeFabricConsortiumsWithOptions(DescribeFabricConsortiumsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                query["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiums",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricConsortiumsResponse
         */
        public async Task<DescribeFabricConsortiumsResponse> DescribeFabricConsortiumsWithOptionsAsync(DescribeFabricConsortiumsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                query["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricConsortiums",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricConsortiumsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricConsortiumsRequest
         * @return DescribeFabricConsortiumsResponse
         */
        public DescribeFabricConsortiumsResponse DescribeFabricConsortiums(DescribeFabricConsortiumsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricConsortiumsRequest
         * @return DescribeFabricConsortiumsResponse
         */
        public async Task<DescribeFabricConsortiumsResponse> DescribeFabricConsortiumsAsync(DescribeFabricConsortiumsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricExplorerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricExplorerResponse
         */
        public DescribeFabricExplorerResponse DescribeFabricExplorerWithOptions(DescribeFabricExplorerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExBody))
            {
                query["ExBody"] = request.ExBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExMethod))
            {
                query["ExMethod"] = request.ExMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExUrl))
            {
                query["ExUrl"] = request.ExUrl;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricExplorer",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricExplorerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricExplorerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricExplorerResponse
         */
        public async Task<DescribeFabricExplorerResponse> DescribeFabricExplorerWithOptionsAsync(DescribeFabricExplorerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExBody))
            {
                query["ExBody"] = request.ExBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExMethod))
            {
                query["ExMethod"] = request.ExMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExUrl))
            {
                query["ExUrl"] = request.ExUrl;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricExplorer",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricExplorerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricExplorerRequest
         * @return DescribeFabricExplorerResponse
         */
        public DescribeFabricExplorerResponse DescribeFabricExplorer(DescribeFabricExplorerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricExplorerWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricExplorerRequest
         * @return DescribeFabricExplorerResponse
         */
        public async Task<DescribeFabricExplorerResponse> DescribeFabricExplorerAsync(DescribeFabricExplorerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricExplorerWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricInvitationCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricInvitationCodeResponse
         */
        public DescribeFabricInvitationCodeResponse DescribeFabricInvitationCodeWithOptions(DescribeFabricInvitationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricInvitationCode",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricInvitationCodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricInvitationCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricInvitationCodeResponse
         */
        public async Task<DescribeFabricInvitationCodeResponse> DescribeFabricInvitationCodeWithOptionsAsync(DescribeFabricInvitationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricInvitationCode",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricInvitationCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricInvitationCodeRequest
         * @return DescribeFabricInvitationCodeResponse
         */
        public DescribeFabricInvitationCodeResponse DescribeFabricInvitationCode(DescribeFabricInvitationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricInvitationCodeWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricInvitationCodeRequest
         * @return DescribeFabricInvitationCodeResponse
         */
        public async Task<DescribeFabricInvitationCodeResponse> DescribeFabricInvitationCodeAsync(DescribeFabricInvitationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricInvitationCodeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricInviterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricInviterResponse
         */
        public DescribeFabricInviterResponse DescribeFabricInviterWithOptions(DescribeFabricInviterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricInviter",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricInviterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricInviterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricInviterResponse
         */
        public async Task<DescribeFabricInviterResponse> DescribeFabricInviterWithOptionsAsync(DescribeFabricInviterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricInviter",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricInviterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricInviterRequest
         * @return DescribeFabricInviterResponse
         */
        public DescribeFabricInviterResponse DescribeFabricInviter(DescribeFabricInviterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricInviterWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricInviterRequest
         * @return DescribeFabricInviterResponse
         */
        public async Task<DescribeFabricInviterResponse> DescribeFabricInviterAsync(DescribeFabricInviterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricInviterWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricOrdererLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrdererLogsResponse
         */
        public DescribeFabricOrdererLogsResponse DescribeFabricOrdererLogsWithOptions(DescribeFabricOrdererLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                query["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lines))
            {
                query["Lines"] = request.Lines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrdererName))
            {
                query["OrdererName"] = request.OrdererName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrdererLogs",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrdererLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrdererLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrdererLogsResponse
         */
        public async Task<DescribeFabricOrdererLogsResponse> DescribeFabricOrdererLogsWithOptionsAsync(DescribeFabricOrdererLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                query["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lines))
            {
                query["Lines"] = request.Lines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrdererName))
            {
                query["OrdererName"] = request.OrdererName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrdererLogs",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrdererLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrdererLogsRequest
         * @return DescribeFabricOrdererLogsResponse
         */
        public DescribeFabricOrdererLogsResponse DescribeFabricOrdererLogs(DescribeFabricOrdererLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrdererLogsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricOrdererLogsRequest
         * @return DescribeFabricOrdererLogsResponse
         */
        public async Task<DescribeFabricOrdererLogsResponse> DescribeFabricOrdererLogsAsync(DescribeFabricOrdererLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrdererLogsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricOrganizationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationResponse
         */
        public DescribeFabricOrganizationResponse DescribeFabricOrganizationWithOptions(DescribeFabricOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganization",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrganizationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationResponse
         */
        public async Task<DescribeFabricOrganizationResponse> DescribeFabricOrganizationWithOptionsAsync(DescribeFabricOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganization",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrganizationRequest
         * @return DescribeFabricOrganizationResponse
         */
        public DescribeFabricOrganizationResponse DescribeFabricOrganization(DescribeFabricOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricOrganizationRequest
         * @return DescribeFabricOrganizationResponse
         */
        public async Task<DescribeFabricOrganizationResponse> DescribeFabricOrganizationAsync(DescribeFabricOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary DescribeFabricOrganizationChaincodePackage
         *
         * @param request DescribeFabricOrganizationChaincodePackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationChaincodePackageResponse
         */
        public DescribeFabricOrganizationChaincodePackageResponse DescribeFabricOrganizationChaincodePackageWithOptions(DescribeFabricOrganizationChaincodePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizationChaincodePackage",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationChaincodePackageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary DescribeFabricOrganizationChaincodePackage
         *
         * @param request DescribeFabricOrganizationChaincodePackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationChaincodePackageResponse
         */
        public async Task<DescribeFabricOrganizationChaincodePackageResponse> DescribeFabricOrganizationChaincodePackageWithOptionsAsync(DescribeFabricOrganizationChaincodePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizationChaincodePackage",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationChaincodePackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary DescribeFabricOrganizationChaincodePackage
         *
         * @param request DescribeFabricOrganizationChaincodePackageRequest
         * @return DescribeFabricOrganizationChaincodePackageResponse
         */
        public DescribeFabricOrganizationChaincodePackageResponse DescribeFabricOrganizationChaincodePackage(DescribeFabricOrganizationChaincodePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationChaincodePackageWithOptions(request, runtime);
        }

        /**
         * @summary DescribeFabricOrganizationChaincodePackage
         *
         * @param request DescribeFabricOrganizationChaincodePackageRequest
         * @return DescribeFabricOrganizationChaincodePackageResponse
         */
        public async Task<DescribeFabricOrganizationChaincodePackageResponse> DescribeFabricOrganizationChaincodePackageAsync(DescribeFabricOrganizationChaincodePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationChaincodePackageWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricOrganizationChaincodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationChaincodesResponse
         */
        public DescribeFabricOrganizationChaincodesResponse DescribeFabricOrganizationChaincodesWithOptions(DescribeFabricOrganizationChaincodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizationChaincodes",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationChaincodesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrganizationChaincodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationChaincodesResponse
         */
        public async Task<DescribeFabricOrganizationChaincodesResponse> DescribeFabricOrganizationChaincodesWithOptionsAsync(DescribeFabricOrganizationChaincodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizationChaincodes",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationChaincodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrganizationChaincodesRequest
         * @return DescribeFabricOrganizationChaincodesResponse
         */
        public DescribeFabricOrganizationChaincodesResponse DescribeFabricOrganizationChaincodes(DescribeFabricOrganizationChaincodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationChaincodesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricOrganizationChaincodesRequest
         * @return DescribeFabricOrganizationChaincodesResponse
         */
        public async Task<DescribeFabricOrganizationChaincodesResponse> DescribeFabricOrganizationChaincodesAsync(DescribeFabricOrganizationChaincodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationChaincodesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricOrganizationChannelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationChannelsResponse
         */
        public DescribeFabricOrganizationChannelsResponse DescribeFabricOrganizationChannelsWithOptions(DescribeFabricOrganizationChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizationChannels",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationChannelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrganizationChannelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationChannelsResponse
         */
        public async Task<DescribeFabricOrganizationChannelsResponse> DescribeFabricOrganizationChannelsWithOptionsAsync(DescribeFabricOrganizationChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizationChannels",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationChannelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrganizationChannelsRequest
         * @return DescribeFabricOrganizationChannelsResponse
         */
        public DescribeFabricOrganizationChannelsResponse DescribeFabricOrganizationChannels(DescribeFabricOrganizationChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationChannelsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricOrganizationChannelsRequest
         * @return DescribeFabricOrganizationChannelsResponse
         */
        public async Task<DescribeFabricOrganizationChannelsResponse> DescribeFabricOrganizationChannelsAsync(DescribeFabricOrganizationChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationChannelsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricOrganizationDeletableRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationDeletableResponse
         */
        public DescribeFabricOrganizationDeletableResponse DescribeFabricOrganizationDeletableWithOptions(DescribeFabricOrganizationDeletableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizationDeletable",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationDeletableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrganizationDeletableRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationDeletableResponse
         */
        public async Task<DescribeFabricOrganizationDeletableResponse> DescribeFabricOrganizationDeletableWithOptionsAsync(DescribeFabricOrganizationDeletableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizationDeletable",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationDeletableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrganizationDeletableRequest
         * @return DescribeFabricOrganizationDeletableResponse
         */
        public DescribeFabricOrganizationDeletableResponse DescribeFabricOrganizationDeletable(DescribeFabricOrganizationDeletableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationDeletableWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricOrganizationDeletableRequest
         * @return DescribeFabricOrganizationDeletableResponse
         */
        public async Task<DescribeFabricOrganizationDeletableResponse> DescribeFabricOrganizationDeletableAsync(DescribeFabricOrganizationDeletableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationDeletableWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricOrganizationMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationMembersResponse
         */
        public DescribeFabricOrganizationMembersResponse DescribeFabricOrganizationMembersWithOptions(DescribeFabricOrganizationMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizationMembers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationMembersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrganizationMembersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationMembersResponse
         */
        public async Task<DescribeFabricOrganizationMembersResponse> DescribeFabricOrganizationMembersWithOptionsAsync(DescribeFabricOrganizationMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizationMembers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrganizationMembersRequest
         * @return DescribeFabricOrganizationMembersResponse
         */
        public DescribeFabricOrganizationMembersResponse DescribeFabricOrganizationMembers(DescribeFabricOrganizationMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationMembersWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricOrganizationMembersRequest
         * @return DescribeFabricOrganizationMembersResponse
         */
        public async Task<DescribeFabricOrganizationMembersResponse> DescribeFabricOrganizationMembersAsync(DescribeFabricOrganizationMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationMembersWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricOrganizationPeersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationPeersResponse
         */
        public DescribeFabricOrganizationPeersResponse DescribeFabricOrganizationPeersWithOptions(DescribeFabricOrganizationPeersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizationPeers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationPeersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrganizationPeersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationPeersResponse
         */
        public async Task<DescribeFabricOrganizationPeersResponse> DescribeFabricOrganizationPeersWithOptionsAsync(DescribeFabricOrganizationPeersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizationPeers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationPeersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrganizationPeersRequest
         * @return DescribeFabricOrganizationPeersResponse
         */
        public DescribeFabricOrganizationPeersResponse DescribeFabricOrganizationPeers(DescribeFabricOrganizationPeersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationPeersWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricOrganizationPeersRequest
         * @return DescribeFabricOrganizationPeersResponse
         */
        public async Task<DescribeFabricOrganizationPeersResponse> DescribeFabricOrganizationPeersAsync(DescribeFabricOrganizationPeersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationPeersWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricOrganizationSpecsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationSpecsResponse
         */
        public DescribeFabricOrganizationSpecsResponse DescribeFabricOrganizationSpecsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizationSpecs",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationSpecsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrganizationSpecsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationSpecsResponse
         */
        public async Task<DescribeFabricOrganizationSpecsResponse> DescribeFabricOrganizationSpecsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizationSpecs",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationSpecsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return DescribeFabricOrganizationSpecsResponse
         */
        public DescribeFabricOrganizationSpecsResponse DescribeFabricOrganizationSpecs()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationSpecsWithOptions(runtime);
        }

        /**
         * @return DescribeFabricOrganizationSpecsResponse
         */
        public async Task<DescribeFabricOrganizationSpecsResponse> DescribeFabricOrganizationSpecsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationSpecsWithOptionsAsync(runtime);
        }

        /**
         * @param request DescribeFabricOrganizationUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationUsersResponse
         */
        public DescribeFabricOrganizationUsersResponse DescribeFabricOrganizationUsersWithOptions(DescribeFabricOrganizationUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizationUsers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrganizationUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationUsersResponse
         */
        public async Task<DescribeFabricOrganizationUsersResponse> DescribeFabricOrganizationUsersWithOptionsAsync(DescribeFabricOrganizationUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizationUsers",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrganizationUsersRequest
         * @return DescribeFabricOrganizationUsersResponse
         */
        public DescribeFabricOrganizationUsersResponse DescribeFabricOrganizationUsers(DescribeFabricOrganizationUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationUsersWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricOrganizationUsersRequest
         * @return DescribeFabricOrganizationUsersResponse
         */
        public async Task<DescribeFabricOrganizationUsersResponse> DescribeFabricOrganizationUsersAsync(DescribeFabricOrganizationUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricOrganizationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationsResponse
         */
        public DescribeFabricOrganizationsResponse DescribeFabricOrganizationsWithOptions(DescribeFabricOrganizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizations",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrganizationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricOrganizationsResponse
         */
        public async Task<DescribeFabricOrganizationsResponse> DescribeFabricOrganizationsWithOptionsAsync(DescribeFabricOrganizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricOrganizations",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricOrganizationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricOrganizationsRequest
         * @return DescribeFabricOrganizationsResponse
         */
        public DescribeFabricOrganizationsResponse DescribeFabricOrganizations(DescribeFabricOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricOrganizationsRequest
         * @return DescribeFabricOrganizationsResponse
         */
        public async Task<DescribeFabricOrganizationsResponse> DescribeFabricOrganizationsAsync(DescribeFabricOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFabricPeerLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricPeerLogsResponse
         */
        public DescribeFabricPeerLogsResponse DescribeFabricPeerLogsWithOptions(DescribeFabricPeerLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lines))
            {
                query["Lines"] = request.Lines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerName))
            {
                query["PeerName"] = request.PeerName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricPeerLogs",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricPeerLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricPeerLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFabricPeerLogsResponse
         */
        public async Task<DescribeFabricPeerLogsResponse> DescribeFabricPeerLogsWithOptionsAsync(DescribeFabricPeerLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lines))
            {
                query["Lines"] = request.Lines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerName))
            {
                query["PeerName"] = request.PeerName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFabricPeerLogs",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFabricPeerLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeFabricPeerLogsRequest
         * @return DescribeFabricPeerLogsResponse
         */
        public DescribeFabricPeerLogsResponse DescribeFabricPeerLogs(DescribeFabricPeerLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricPeerLogsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFabricPeerLogsRequest
         * @return DescribeFabricPeerLogsResponse
         */
        public async Task<DescribeFabricPeerLogsResponse> DescribeFabricPeerLogsAsync(DescribeFabricPeerLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricPeerLogsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
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
                Action = "DescribeRegions",
                Version = "2018-12-21",
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

        /**
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
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
                Action = "DescribeRegions",
                Version = "2018-12-21",
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

        /**
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRootDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRootDomainResponse
         */
        public DescribeRootDomainResponse DescribeRootDomainWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRootDomain",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRootDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRootDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRootDomainResponse
         */
        public async Task<DescribeRootDomainResponse> DescribeRootDomainWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRootDomain",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRootDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return DescribeRootDomainResponse
         */
        public DescribeRootDomainResponse DescribeRootDomain()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRootDomainWithOptions(runtime);
        }

        /**
         * @return DescribeRootDomainResponse
         */
        public async Task<DescribeRootDomainResponse> DescribeRootDomainAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRootDomainWithOptionsAsync(runtime);
        }

        /**
         * @param request DescribeTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTasksResponse
         */
        public DescribeTasksResponse DescribeTasksWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTasks",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTasksResponse
         */
        public async Task<DescribeTasksResponse> DescribeTasksWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTasks",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return DescribeTasksResponse
         */
        public DescribeTasksResponse DescribeTasks()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTasksWithOptions(runtime);
        }

        /**
         * @return DescribeTasksResponse
         */
        public async Task<DescribeTasksResponse> DescribeTasksAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTasksWithOptionsAsync(runtime);
        }

        /**
         * @param request DownloadFabricOrganizationSDKRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DownloadFabricOrganizationSDKResponse
         */
        public DownloadFabricOrganizationSDKResponse DownloadFabricOrganizationSDKWithOptions(DownloadFabricOrganizationSDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadFabricOrganizationSDK",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadFabricOrganizationSDKResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DownloadFabricOrganizationSDKRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DownloadFabricOrganizationSDKResponse
         */
        public async Task<DownloadFabricOrganizationSDKResponse> DownloadFabricOrganizationSDKWithOptionsAsync(DownloadFabricOrganizationSDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadFabricOrganizationSDK",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadFabricOrganizationSDKResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DownloadFabricOrganizationSDKRequest
         * @return DownloadFabricOrganizationSDKResponse
         */
        public DownloadFabricOrganizationSDKResponse DownloadFabricOrganizationSDK(DownloadFabricOrganizationSDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadFabricOrganizationSDKWithOptions(request, runtime);
        }

        /**
         * @param request DownloadFabricOrganizationSDKRequest
         * @return DownloadFabricOrganizationSDKResponse
         */
        public async Task<DownloadFabricOrganizationSDKResponse> DownloadFabricOrganizationSDKAsync(DownloadFabricOrganizationSDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadFabricOrganizationSDKWithOptionsAsync(request, runtime);
        }

        /**
         * @param request FreezeAntChainAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FreezeAntChainAccountResponse
         */
        public FreezeAntChainAccountResponse FreezeAntChainAccountWithOptions(FreezeAntChainAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FreezeAntChainAccount",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FreezeAntChainAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request FreezeAntChainAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FreezeAntChainAccountResponse
         */
        public async Task<FreezeAntChainAccountResponse> FreezeAntChainAccountWithOptionsAsync(FreezeAntChainAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FreezeAntChainAccount",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FreezeAntChainAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request FreezeAntChainAccountRequest
         * @return FreezeAntChainAccountResponse
         */
        public FreezeAntChainAccountResponse FreezeAntChainAccount(FreezeAntChainAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FreezeAntChainAccountWithOptions(request, runtime);
        }

        /**
         * @param request FreezeAntChainAccountRequest
         * @return FreezeAntChainAccountResponse
         */
        public async Task<FreezeAntChainAccountResponse> FreezeAntChainAccountAsync(FreezeAntChainAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FreezeAntChainAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @param request InstallFabricChaincodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallFabricChaincodeResponse
         */
        public InstallFabricChaincodeResponse InstallFabricChaincodeWithOptions(InstallFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeId))
            {
                body["ChaincodeId"] = request.ChaincodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallFabricChaincode",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallFabricChaincodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request InstallFabricChaincodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallFabricChaincodeResponse
         */
        public async Task<InstallFabricChaincodeResponse> InstallFabricChaincodeWithOptionsAsync(InstallFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeId))
            {
                body["ChaincodeId"] = request.ChaincodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallFabricChaincode",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallFabricChaincodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request InstallFabricChaincodeRequest
         * @return InstallFabricChaincodeResponse
         */
        public InstallFabricChaincodeResponse InstallFabricChaincode(InstallFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallFabricChaincodeWithOptions(request, runtime);
        }

        /**
         * @param request InstallFabricChaincodeRequest
         * @return InstallFabricChaincodeResponse
         */
        public async Task<InstallFabricChaincodeResponse> InstallFabricChaincodeAsync(InstallFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallFabricChaincodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary InstallFabricChaincodePackage
         *
         * @param request InstallFabricChaincodePackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallFabricChaincodePackageResponse
         */
        public InstallFabricChaincodePackageResponse InstallFabricChaincodePackageWithOptions(InstallFabricChaincodePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodePackageId))
            {
                body["ChaincodePackageId"] = request.ChaincodePackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallFabricChaincodePackage",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallFabricChaincodePackageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary InstallFabricChaincodePackage
         *
         * @param request InstallFabricChaincodePackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallFabricChaincodePackageResponse
         */
        public async Task<InstallFabricChaincodePackageResponse> InstallFabricChaincodePackageWithOptionsAsync(InstallFabricChaincodePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodePackageId))
            {
                body["ChaincodePackageId"] = request.ChaincodePackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallFabricChaincodePackage",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallFabricChaincodePackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary InstallFabricChaincodePackage
         *
         * @param request InstallFabricChaincodePackageRequest
         * @return InstallFabricChaincodePackageResponse
         */
        public InstallFabricChaincodePackageResponse InstallFabricChaincodePackage(InstallFabricChaincodePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallFabricChaincodePackageWithOptions(request, runtime);
        }

        /**
         * @summary InstallFabricChaincodePackage
         *
         * @param request InstallFabricChaincodePackageRequest
         * @return InstallFabricChaincodePackageResponse
         */
        public async Task<InstallFabricChaincodePackageResponse> InstallFabricChaincodePackageAsync(InstallFabricChaincodePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallFabricChaincodePackageWithOptionsAsync(request, runtime);
        }

        /**
         * @param request InstantiateFabricChaincodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstantiateFabricChaincodeResponse
         */
        public InstantiateFabricChaincodeResponse InstantiateFabricChaincodeWithOptions(InstantiateFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeId))
            {
                body["ChaincodeId"] = request.ChaincodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectionConfig))
            {
                body["CollectionConfig"] = request.CollectionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndorsePolicy))
            {
                body["EndorsePolicy"] = request.EndorsePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstantiateFabricChaincode",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstantiateFabricChaincodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request InstantiateFabricChaincodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstantiateFabricChaincodeResponse
         */
        public async Task<InstantiateFabricChaincodeResponse> InstantiateFabricChaincodeWithOptionsAsync(InstantiateFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeId))
            {
                body["ChaincodeId"] = request.ChaincodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectionConfig))
            {
                body["CollectionConfig"] = request.CollectionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndorsePolicy))
            {
                body["EndorsePolicy"] = request.EndorsePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstantiateFabricChaincode",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstantiateFabricChaincodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request InstantiateFabricChaincodeRequest
         * @return InstantiateFabricChaincodeResponse
         */
        public InstantiateFabricChaincodeResponse InstantiateFabricChaincode(InstantiateFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstantiateFabricChaincodeWithOptions(request, runtime);
        }

        /**
         * @param request InstantiateFabricChaincodeRequest
         * @return InstantiateFabricChaincodeResponse
         */
        public async Task<InstantiateFabricChaincodeResponse> InstantiateFabricChaincodeAsync(InstantiateFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstantiateFabricChaincodeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request JoinFabricChannelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return JoinFabricChannelResponse
         */
        public JoinFabricChannelResponse JoinFabricChannelWithOptions(JoinFabricChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Do))
            {
                query["Do"] = request.Do;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "JoinFabricChannel",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<JoinFabricChannelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request JoinFabricChannelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return JoinFabricChannelResponse
         */
        public async Task<JoinFabricChannelResponse> JoinFabricChannelWithOptionsAsync(JoinFabricChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Do))
            {
                query["Do"] = request.Do;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "JoinFabricChannel",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<JoinFabricChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request JoinFabricChannelRequest
         * @return JoinFabricChannelResponse
         */
        public JoinFabricChannelResponse JoinFabricChannel(JoinFabricChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JoinFabricChannelWithOptions(request, runtime);
        }

        /**
         * @param request JoinFabricChannelRequest
         * @return JoinFabricChannelResponse
         */
        public async Task<JoinFabricChannelResponse> JoinFabricChannelAsync(JoinFabricChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JoinFabricChannelWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Version = "2018-12-21",
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

        /**
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Version = "2018-12-21",
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

        /**
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /**
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ResetAntChainCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetAntChainCertificateResponse
         */
        public ResetAntChainCertificateResponse ResetAntChainCertificateWithOptions(ResetAntChainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAntChainCertificate",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAntChainCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ResetAntChainCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetAntChainCertificateResponse
         */
        public async Task<ResetAntChainCertificateResponse> ResetAntChainCertificateWithOptionsAsync(ResetAntChainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAntChainCertificate",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAntChainCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ResetAntChainCertificateRequest
         * @return ResetAntChainCertificateResponse
         */
        public ResetAntChainCertificateResponse ResetAntChainCertificate(ResetAntChainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAntChainCertificateWithOptions(request, runtime);
        }

        /**
         * @param request ResetAntChainCertificateRequest
         * @return ResetAntChainCertificateResponse
         */
        public async Task<ResetAntChainCertificateResponse> ResetAntChainCertificateAsync(ResetAntChainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAntChainCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ResetAntChainUserCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetAntChainUserCertificateResponse
         */
        public ResetAntChainUserCertificateResponse ResetAntChainUserCertificateWithOptions(ResetAntChainUserCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAntChainUserCertificate",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAntChainUserCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ResetAntChainUserCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetAntChainUserCertificateResponse
         */
        public async Task<ResetAntChainUserCertificateResponse> ResetAntChainUserCertificateWithOptionsAsync(ResetAntChainUserCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAntChainUserCertificate",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAntChainUserCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ResetAntChainUserCertificateRequest
         * @return ResetAntChainUserCertificateResponse
         */
        public ResetAntChainUserCertificateResponse ResetAntChainUserCertificate(ResetAntChainUserCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAntChainUserCertificateWithOptions(request, runtime);
        }

        /**
         * @param request ResetAntChainUserCertificateRequest
         * @return ResetAntChainUserCertificateResponse
         */
        public async Task<ResetAntChainUserCertificateResponse> ResetAntChainUserCertificateAsync(ResetAntChainUserCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAntChainUserCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ResetFabricOrganizationUserPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetFabricOrganizationUserPasswordResponse
         */
        public ResetFabricOrganizationUserPasswordResponse ResetFabricOrganizationUserPasswordWithOptions(ResetFabricOrganizationUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetFabricOrganizationUserPassword",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetFabricOrganizationUserPasswordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ResetFabricOrganizationUserPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetFabricOrganizationUserPasswordResponse
         */
        public async Task<ResetFabricOrganizationUserPasswordResponse> ResetFabricOrganizationUserPasswordWithOptionsAsync(ResetFabricOrganizationUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetFabricOrganizationUserPassword",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetFabricOrganizationUserPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ResetFabricOrganizationUserPasswordRequest
         * @return ResetFabricOrganizationUserPasswordResponse
         */
        public ResetFabricOrganizationUserPasswordResponse ResetFabricOrganizationUserPassword(ResetFabricOrganizationUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetFabricOrganizationUserPasswordWithOptions(request, runtime);
        }

        /**
         * @param request ResetFabricOrganizationUserPasswordRequest
         * @return ResetFabricOrganizationUserPasswordResponse
         */
        public async Task<ResetFabricOrganizationUserPasswordResponse> ResetFabricOrganizationUserPasswordAsync(ResetFabricOrganizationUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetFabricOrganizationUserPasswordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary SubmitFabricChaincodeDefinition
         *
         * @param request SubmitFabricChaincodeDefinitionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitFabricChaincodeDefinitionResponse
         */
        public SubmitFabricChaincodeDefinitionResponse SubmitFabricChaincodeDefinitionWithOptions(SubmitFabricChaincodeDefinitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodePackageId))
            {
                body["ChaincodePackageId"] = request.ChaincodePackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeVersion))
            {
                body["ChaincodeVersion"] = request.ChaincodeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectionConfig))
            {
                body["CollectionConfig"] = request.CollectionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndorsePolicy))
            {
                body["EndorsePolicy"] = request.EndorsePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitRequired))
            {
                body["InitRequired"] = request.InitRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitFabricChaincodeDefinition",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitFabricChaincodeDefinitionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary SubmitFabricChaincodeDefinition
         *
         * @param request SubmitFabricChaincodeDefinitionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitFabricChaincodeDefinitionResponse
         */
        public async Task<SubmitFabricChaincodeDefinitionResponse> SubmitFabricChaincodeDefinitionWithOptionsAsync(SubmitFabricChaincodeDefinitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodePackageId))
            {
                body["ChaincodePackageId"] = request.ChaincodePackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeVersion))
            {
                body["ChaincodeVersion"] = request.ChaincodeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectionConfig))
            {
                body["CollectionConfig"] = request.CollectionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndorsePolicy))
            {
                body["EndorsePolicy"] = request.EndorsePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitRequired))
            {
                body["InitRequired"] = request.InitRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitFabricChaincodeDefinition",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitFabricChaincodeDefinitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary SubmitFabricChaincodeDefinition
         *
         * @param request SubmitFabricChaincodeDefinitionRequest
         * @return SubmitFabricChaincodeDefinitionResponse
         */
        public SubmitFabricChaincodeDefinitionResponse SubmitFabricChaincodeDefinition(SubmitFabricChaincodeDefinitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitFabricChaincodeDefinitionWithOptions(request, runtime);
        }

        /**
         * @summary SubmitFabricChaincodeDefinition
         *
         * @param request SubmitFabricChaincodeDefinitionRequest
         * @return SubmitFabricChaincodeDefinitionResponse
         */
        public async Task<SubmitFabricChaincodeDefinitionResponse> SubmitFabricChaincodeDefinitionAsync(SubmitFabricChaincodeDefinitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitFabricChaincodeDefinitionWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SynchronizeFabricChaincodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SynchronizeFabricChaincodeResponse
         */
        public SynchronizeFabricChaincodeResponse SynchronizeFabricChaincodeWithOptions(SynchronizeFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeId))
            {
                body["ChaincodeId"] = request.ChaincodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SynchronizeFabricChaincode",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SynchronizeFabricChaincodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SynchronizeFabricChaincodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SynchronizeFabricChaincodeResponse
         */
        public async Task<SynchronizeFabricChaincodeResponse> SynchronizeFabricChaincodeWithOptionsAsync(SynchronizeFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeId))
            {
                body["ChaincodeId"] = request.ChaincodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SynchronizeFabricChaincode",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SynchronizeFabricChaincodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SynchronizeFabricChaincodeRequest
         * @return SynchronizeFabricChaincodeResponse
         */
        public SynchronizeFabricChaincodeResponse SynchronizeFabricChaincode(SynchronizeFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SynchronizeFabricChaincodeWithOptions(request, runtime);
        }

        /**
         * @param request SynchronizeFabricChaincodeRequest
         * @return SynchronizeFabricChaincodeResponse
         */
        public async Task<SynchronizeFabricChaincodeResponse> SynchronizeFabricChaincodeAsync(SynchronizeFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SynchronizeFabricChaincodeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Version = "2018-12-21",
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

        /**
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Version = "2018-12-21",
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

        /**
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /**
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UnfreezeAntChainAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnfreezeAntChainAccountResponse
         */
        public UnfreezeAntChainAccountResponse UnfreezeAntChainAccountWithOptions(UnfreezeAntChainAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnfreezeAntChainAccount",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnfreezeAntChainAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UnfreezeAntChainAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnfreezeAntChainAccountResponse
         */
        public async Task<UnfreezeAntChainAccountResponse> UnfreezeAntChainAccountWithOptionsAsync(UnfreezeAntChainAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnfreezeAntChainAccount",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnfreezeAntChainAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UnfreezeAntChainAccountRequest
         * @return UnfreezeAntChainAccountResponse
         */
        public UnfreezeAntChainAccountResponse UnfreezeAntChainAccount(UnfreezeAntChainAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnfreezeAntChainAccountWithOptions(request, runtime);
        }

        /**
         * @param request UnfreezeAntChainAccountRequest
         * @return UnfreezeAntChainAccountResponse
         */
        public async Task<UnfreezeAntChainAccountResponse> UnfreezeAntChainAccountAsync(UnfreezeAntChainAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnfreezeAntChainAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UntagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
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
                Version = "2018-12-21",
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

        /**
         * @param request UntagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
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
                Version = "2018-12-21",
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

        /**
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /**
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateAntChainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAntChainResponse
         */
        public UpdateAntChainResponse UpdateAntChainWithOptions(UpdateAntChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainName))
            {
                body["AntChainName"] = request.AntChainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAntChain",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAntChainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateAntChainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAntChainResponse
         */
        public async Task<UpdateAntChainResponse> UpdateAntChainWithOptionsAsync(UpdateAntChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainName))
            {
                body["AntChainName"] = request.AntChainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAntChain",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAntChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateAntChainRequest
         * @return UpdateAntChainResponse
         */
        public UpdateAntChainResponse UpdateAntChain(UpdateAntChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAntChainWithOptions(request, runtime);
        }

        /**
         * @param request UpdateAntChainRequest
         * @return UpdateAntChainResponse
         */
        public async Task<UpdateAntChainResponse> UpdateAntChainAsync(UpdateAntChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAntChainWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateAntChainConsortiumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAntChainConsortiumResponse
         */
        public UpdateAntChainConsortiumResponse UpdateAntChainConsortiumWithOptions(UpdateAntChainConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumDescription))
            {
                body["ConsortiumDescription"] = request.ConsortiumDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumName))
            {
                body["ConsortiumName"] = request.ConsortiumName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAntChainConsortium",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAntChainConsortiumResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateAntChainConsortiumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAntChainConsortiumResponse
         */
        public async Task<UpdateAntChainConsortiumResponse> UpdateAntChainConsortiumWithOptionsAsync(UpdateAntChainConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumDescription))
            {
                body["ConsortiumDescription"] = request.ConsortiumDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumName))
            {
                body["ConsortiumName"] = request.ConsortiumName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAntChainConsortium",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAntChainConsortiumResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateAntChainConsortiumRequest
         * @return UpdateAntChainConsortiumResponse
         */
        public UpdateAntChainConsortiumResponse UpdateAntChainConsortium(UpdateAntChainConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAntChainConsortiumWithOptions(request, runtime);
        }

        /**
         * @param request UpdateAntChainConsortiumRequest
         * @return UpdateAntChainConsortiumResponse
         */
        public async Task<UpdateAntChainConsortiumResponse> UpdateAntChainConsortiumAsync(UpdateAntChainConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAntChainConsortiumWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateAntChainContractContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAntChainContractContentResponse
         */
        public UpdateAntChainContractContentResponse UpdateAntChainContractContentWithOptions(UpdateAntChainContractContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentId))
            {
                body["ContentId"] = request.ContentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentName))
            {
                body["ContentName"] = request.ContentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentContentId))
            {
                body["ParentContentId"] = request.ParentContentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAntChainContractContent",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAntChainContractContentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateAntChainContractContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAntChainContractContentResponse
         */
        public async Task<UpdateAntChainContractContentResponse> UpdateAntChainContractContentWithOptionsAsync(UpdateAntChainContractContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentId))
            {
                body["ContentId"] = request.ContentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentName))
            {
                body["ContentName"] = request.ContentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentContentId))
            {
                body["ParentContentId"] = request.ParentContentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAntChainContractContent",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAntChainContractContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateAntChainContractContentRequest
         * @return UpdateAntChainContractContentResponse
         */
        public UpdateAntChainContractContentResponse UpdateAntChainContractContent(UpdateAntChainContractContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAntChainContractContentWithOptions(request, runtime);
        }

        /**
         * @param request UpdateAntChainContractContentRequest
         * @return UpdateAntChainContractContentResponse
         */
        public async Task<UpdateAntChainContractContentResponse> UpdateAntChainContractContentAsync(UpdateAntChainContractContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAntChainContractContentWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateAntChainContractProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAntChainContractProjectResponse
         */
        public UpdateAntChainContractProjectResponse UpdateAntChainContractProjectWithOptions(UpdateAntChainContractProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectDescription))
            {
                body["ProjectDescription"] = request.ProjectDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectVersion))
            {
                body["ProjectVersion"] = request.ProjectVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAntChainContractProject",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAntChainContractProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateAntChainContractProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAntChainContractProjectResponse
         */
        public async Task<UpdateAntChainContractProjectResponse> UpdateAntChainContractProjectWithOptionsAsync(UpdateAntChainContractProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectDescription))
            {
                body["ProjectDescription"] = request.ProjectDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectVersion))
            {
                body["ProjectVersion"] = request.ProjectVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAntChainContractProject",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAntChainContractProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateAntChainContractProjectRequest
         * @return UpdateAntChainContractProjectResponse
         */
        public UpdateAntChainContractProjectResponse UpdateAntChainContractProject(UpdateAntChainContractProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAntChainContractProjectWithOptions(request, runtime);
        }

        /**
         * @param request UpdateAntChainContractProjectRequest
         * @return UpdateAntChainContractProjectResponse
         */
        public async Task<UpdateAntChainContractProjectResponse> UpdateAntChainContractProjectAsync(UpdateAntChainContractProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAntChainContractProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateAntChainMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAntChainMemberResponse
         */
        public UpdateAntChainMemberResponse UpdateAntChainMemberWithOptions(UpdateAntChainMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                body["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                body["MemberName"] = request.MemberName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAntChainMember",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAntChainMemberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateAntChainMemberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAntChainMemberResponse
         */
        public async Task<UpdateAntChainMemberResponse> UpdateAntChainMemberWithOptionsAsync(UpdateAntChainMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsortiumId))
            {
                body["ConsortiumId"] = request.ConsortiumId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                body["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                body["MemberName"] = request.MemberName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAntChainMember",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAntChainMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateAntChainMemberRequest
         * @return UpdateAntChainMemberResponse
         */
        public UpdateAntChainMemberResponse UpdateAntChainMember(UpdateAntChainMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAntChainMemberWithOptions(request, runtime);
        }

        /**
         * @param request UpdateAntChainMemberRequest
         * @return UpdateAntChainMemberResponse
         */
        public async Task<UpdateAntChainMemberResponse> UpdateAntChainMemberAsync(UpdateAntChainMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAntChainMemberWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateAntChainQRCodeAuthorizationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAntChainQRCodeAuthorizationResponse
         */
        public UpdateAntChainQRCodeAuthorizationResponse UpdateAntChainQRCodeAuthorizationWithOptions(UpdateAntChainQRCodeAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationType))
            {
                body["AuthorizationType"] = request.AuthorizationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QRCodeType))
            {
                body["QRCodeType"] = request.QRCodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAntChainQRCodeAuthorization",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAntChainQRCodeAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateAntChainQRCodeAuthorizationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAntChainQRCodeAuthorizationResponse
         */
        public async Task<UpdateAntChainQRCodeAuthorizationResponse> UpdateAntChainQRCodeAuthorizationWithOptionsAsync(UpdateAntChainQRCodeAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AntChainId))
            {
                body["AntChainId"] = request.AntChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationType))
            {
                body["AuthorizationType"] = request.AuthorizationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QRCodeType))
            {
                body["QRCodeType"] = request.QRCodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAntChainQRCodeAuthorization",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAntChainQRCodeAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateAntChainQRCodeAuthorizationRequest
         * @return UpdateAntChainQRCodeAuthorizationResponse
         */
        public UpdateAntChainQRCodeAuthorizationResponse UpdateAntChainQRCodeAuthorization(UpdateAntChainQRCodeAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAntChainQRCodeAuthorizationWithOptions(request, runtime);
        }

        /**
         * @param request UpdateAntChainQRCodeAuthorizationRequest
         * @return UpdateAntChainQRCodeAuthorizationResponse
         */
        public async Task<UpdateAntChainQRCodeAuthorizationResponse> UpdateAntChainQRCodeAuthorizationAsync(UpdateAntChainQRCodeAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAntChainQRCodeAuthorizationWithOptionsAsync(request, runtime);
        }

        /**
         * @description ****
         *
         * @param request UpgradeFabricChaincodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeFabricChaincodeResponse
         */
        public UpgradeFabricChaincodeResponse UpgradeFabricChaincodeWithOptions(UpgradeFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeId))
            {
                body["ChaincodeId"] = request.ChaincodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectionConfig))
            {
                body["CollectionConfig"] = request.CollectionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndorsePolicy))
            {
                body["EndorsePolicy"] = request.EndorsePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeFabricChaincode",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeFabricChaincodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description ****
         *
         * @param request UpgradeFabricChaincodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeFabricChaincodeResponse
         */
        public async Task<UpgradeFabricChaincodeResponse> UpgradeFabricChaincodeWithOptionsAsync(UpgradeFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeId))
            {
                body["ChaincodeId"] = request.ChaincodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectionConfig))
            {
                body["CollectionConfig"] = request.CollectionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndorsePolicy))
            {
                body["EndorsePolicy"] = request.EndorsePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeFabricChaincode",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeFabricChaincodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description ****
         *
         * @param request UpgradeFabricChaincodeRequest
         * @return UpgradeFabricChaincodeResponse
         */
        public UpgradeFabricChaincodeResponse UpgradeFabricChaincode(UpgradeFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeFabricChaincodeWithOptions(request, runtime);
        }

        /**
         * @description ****
         *
         * @param request UpgradeFabricChaincodeRequest
         * @return UpgradeFabricChaincodeResponse
         */
        public async Task<UpgradeFabricChaincodeResponse> UpgradeFabricChaincodeAsync(UpgradeFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeFabricChaincodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary UpgradeFabricChaincodeDefinition
         *
         * @param request UpgradeFabricChaincodeDefinitionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeFabricChaincodeDefinitionResponse
         */
        public UpgradeFabricChaincodeDefinitionResponse UpgradeFabricChaincodeDefinitionWithOptions(UpgradeFabricChaincodeDefinitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeId))
            {
                body["ChaincodeId"] = request.ChaincodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodePackageId))
            {
                body["ChaincodePackageId"] = request.ChaincodePackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeVersion))
            {
                body["ChaincodeVersion"] = request.ChaincodeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectionConfig))
            {
                body["CollectionConfig"] = request.CollectionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndorsePolicy))
            {
                body["EndorsePolicy"] = request.EndorsePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitRequired))
            {
                body["InitRequired"] = request.InitRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeFabricChaincodeDefinition",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeFabricChaincodeDefinitionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary UpgradeFabricChaincodeDefinition
         *
         * @param request UpgradeFabricChaincodeDefinitionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeFabricChaincodeDefinitionResponse
         */
        public async Task<UpgradeFabricChaincodeDefinitionResponse> UpgradeFabricChaincodeDefinitionWithOptionsAsync(UpgradeFabricChaincodeDefinitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeId))
            {
                body["ChaincodeId"] = request.ChaincodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodePackageId))
            {
                body["ChaincodePackageId"] = request.ChaincodePackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChaincodeVersion))
            {
                body["ChaincodeVersion"] = request.ChaincodeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectionConfig))
            {
                body["CollectionConfig"] = request.CollectionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndorsePolicy))
            {
                body["EndorsePolicy"] = request.EndorsePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitRequired))
            {
                body["InitRequired"] = request.InitRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                body["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeFabricChaincodeDefinition",
                Version = "2018-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeFabricChaincodeDefinitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary UpgradeFabricChaincodeDefinition
         *
         * @param request UpgradeFabricChaincodeDefinitionRequest
         * @return UpgradeFabricChaincodeDefinitionResponse
         */
        public UpgradeFabricChaincodeDefinitionResponse UpgradeFabricChaincodeDefinition(UpgradeFabricChaincodeDefinitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeFabricChaincodeDefinitionWithOptions(request, runtime);
        }

        /**
         * @summary UpgradeFabricChaincodeDefinition
         *
         * @param request UpgradeFabricChaincodeDefinitionRequest
         * @return UpgradeFabricChaincodeDefinitionResponse
         */
        public async Task<UpgradeFabricChaincodeDefinitionResponse> UpgradeFabricChaincodeDefinitionAsync(UpgradeFabricChaincodeDefinitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeFabricChaincodeDefinitionWithOptionsAsync(request, runtime);
        }

    }
}
