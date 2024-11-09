// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ecd20201002.Models;

namespace AlibabaCloud.SDK.Ecd20201002
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ecd", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>允许桌面FOTA升级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveFotaUpdateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApproveFotaUpdateResponse
        /// </returns>
        public ApproveFotaUpdateResponse ApproveFotaUpdateWithOptions(ApproveFotaUpdateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApproveFotaUpdate",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApproveFotaUpdateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>允许桌面FOTA升级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveFotaUpdateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApproveFotaUpdateResponse
        /// </returns>
        public async Task<ApproveFotaUpdateResponse> ApproveFotaUpdateWithOptionsAsync(ApproveFotaUpdateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApproveFotaUpdate",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApproveFotaUpdateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>允许桌面FOTA升级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveFotaUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// ApproveFotaUpdateResponse
        /// </returns>
        public ApproveFotaUpdateResponse ApproveFotaUpdate(ApproveFotaUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApproveFotaUpdateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>允许桌面FOTA升级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveFotaUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// ApproveFotaUpdateResponse
        /// </returns>
        public async Task<ApproveFotaUpdateResponse> ApproveFotaUpdateAsync(ApproveFotaUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApproveFotaUpdateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ChangePasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangePasswordResponse
        /// </returns>
        public ChangePasswordResponse ChangePasswordWithOptions(ChangePasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPassword))
            {
                query["NewPassword"] = request.NewPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldPassword))
            {
                query["OldPassword"] = request.OldPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangePassword",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangePasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangePasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangePasswordResponse
        /// </returns>
        public async Task<ChangePasswordResponse> ChangePasswordWithOptionsAsync(ChangePasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPassword))
            {
                query["NewPassword"] = request.NewPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldPassword))
            {
                query["OldPassword"] = request.OldPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangePassword",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangePasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangePasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangePasswordResponse
        /// </returns>
        public ChangePasswordResponse ChangePassword(ChangePasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangePasswordWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ChangePasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangePasswordResponse
        /// </returns>
        public async Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangePasswordWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteFingerPrintTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFingerPrintTemplateResponse
        /// </returns>
        public DeleteFingerPrintTemplateResponse DeleteFingerPrintTemplateWithOptions(DeleteFingerPrintTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Index))
            {
                query["Index"] = request.Index;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFingerPrintTemplate",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFingerPrintTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteFingerPrintTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFingerPrintTemplateResponse
        /// </returns>
        public async Task<DeleteFingerPrintTemplateResponse> DeleteFingerPrintTemplateWithOptionsAsync(DeleteFingerPrintTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Index))
            {
                query["Index"] = request.Index;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFingerPrintTemplate",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFingerPrintTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteFingerPrintTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFingerPrintTemplateResponse
        /// </returns>
        public DeleteFingerPrintTemplateResponse DeleteFingerPrintTemplate(DeleteFingerPrintTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFingerPrintTemplateWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteFingerPrintTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFingerPrintTemplateResponse
        /// </returns>
        public async Task<DeleteFingerPrintTemplateResponse> DeleteFingerPrintTemplateAsync(DeleteFingerPrintTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFingerPrintTemplateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeDirectoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDirectoriesResponse
        /// </returns>
        public DescribeDirectoriesResponse DescribeDirectoriesWithOptions(DescribeDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
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
                Action = "DescribeDirectories",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDirectoriesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeDirectoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDirectoriesResponse
        /// </returns>
        public async Task<DescribeDirectoriesResponse> DescribeDirectoriesWithOptionsAsync(DescribeDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
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
                Action = "DescribeDirectories",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDirectoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeDirectoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDirectoriesResponse
        /// </returns>
        public DescribeDirectoriesResponse DescribeDirectories(DescribeDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDirectoriesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeDirectoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDirectoriesResponse
        /// </returns>
        public async Task<DescribeDirectoriesResponse> DescribeDirectoriesAsync(DescribeDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDirectoriesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeFingerPrintTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFingerPrintTemplatesResponse
        /// </returns>
        public DescribeFingerPrintTemplatesResponse DescribeFingerPrintTemplatesWithOptions(DescribeFingerPrintTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFingerPrintTemplates",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFingerPrintTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeFingerPrintTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFingerPrintTemplatesResponse
        /// </returns>
        public async Task<DescribeFingerPrintTemplatesResponse> DescribeFingerPrintTemplatesWithOptionsAsync(DescribeFingerPrintTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFingerPrintTemplates",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFingerPrintTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeFingerPrintTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFingerPrintTemplatesResponse
        /// </returns>
        public DescribeFingerPrintTemplatesResponse DescribeFingerPrintTemplates(DescribeFingerPrintTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFingerPrintTemplatesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeFingerPrintTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFingerPrintTemplatesResponse
        /// </returns>
        public async Task<DescribeFingerPrintTemplatesResponse> DescribeFingerPrintTemplatesAsync(DescribeFingerPrintTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFingerPrintTemplatesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeGlobalDesktopsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeGlobalDesktopsResponse
        /// </returns>
        public DescribeGlobalDesktopsResponse DescribeGlobalDesktopsWithOptions(DescribeGlobalDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopAccessType))
            {
                query["DesktopAccessType"] = request.DesktopAccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopName))
            {
                query["DesktopName"] = request.DesktopName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopStatus))
            {
                query["DesktopStatus"] = request.DesktopStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                query["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryFotaUpdate))
            {
                query["QueryFotaUpdate"] = request.QueryFotaUpdate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRegionId))
            {
                query["SearchRegionId"] = request.SearchRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithoutLatency))
            {
                query["WithoutLatency"] = request.WithoutLatency;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGlobalDesktops",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGlobalDesktopsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeGlobalDesktopsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeGlobalDesktopsResponse
        /// </returns>
        public async Task<DescribeGlobalDesktopsResponse> DescribeGlobalDesktopsWithOptionsAsync(DescribeGlobalDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopAccessType))
            {
                query["DesktopAccessType"] = request.DesktopAccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopName))
            {
                query["DesktopName"] = request.DesktopName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopStatus))
            {
                query["DesktopStatus"] = request.DesktopStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                query["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryFotaUpdate))
            {
                query["QueryFotaUpdate"] = request.QueryFotaUpdate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRegionId))
            {
                query["SearchRegionId"] = request.SearchRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithoutLatency))
            {
                query["WithoutLatency"] = request.WithoutLatency;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGlobalDesktops",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGlobalDesktopsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeGlobalDesktopsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeGlobalDesktopsResponse
        /// </returns>
        public DescribeGlobalDesktopsResponse DescribeGlobalDesktops(DescribeGlobalDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGlobalDesktopsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeGlobalDesktopsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeGlobalDesktopsResponse
        /// </returns>
        public async Task<DescribeGlobalDesktopsResponse> DescribeGlobalDesktopsAsync(DescribeGlobalDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGlobalDesktopsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeOfficeSitesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOfficeSitesResponse
        /// </returns>
        public DescribeOfficeSitesResponse DescribeOfficeSitesWithOptions(DescribeOfficeSitesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
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
                Action = "DescribeOfficeSites",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOfficeSitesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeOfficeSitesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOfficeSitesResponse
        /// </returns>
        public async Task<DescribeOfficeSitesResponse> DescribeOfficeSitesWithOptionsAsync(DescribeOfficeSitesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
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
                Action = "DescribeOfficeSites",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOfficeSitesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeOfficeSitesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOfficeSitesResponse
        /// </returns>
        public DescribeOfficeSitesResponse DescribeOfficeSites(DescribeOfficeSitesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOfficeSitesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeOfficeSitesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOfficeSitesResponse
        /// </returns>
        public async Task<DescribeOfficeSitesResponse> DescribeOfficeSitesAsync(DescribeOfficeSitesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOfficeSitesWithOptionsAsync(request, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
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
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
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
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

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
        /// <para>列举快照</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSnapshotsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSnapshotsResponse
        /// </returns>
        public DescribeSnapshotsResponse DescribeSnapshotsWithOptions(DescribeSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSnapshots",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSnapshotsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举快照</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSnapshotsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSnapshotsResponse
        /// </returns>
        public async Task<DescribeSnapshotsResponse> DescribeSnapshotsWithOptionsAsync(DescribeSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSnapshots",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSnapshotsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举快照</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSnapshotsResponse
        /// </returns>
        public DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSnapshotsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举快照</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSnapshotsResponse
        /// </returns>
        public async Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSnapshotsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// EncryptPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EncryptPasswordResponse
        /// </returns>
        public EncryptPasswordResponse EncryptPasswordWithOptions(EncryptPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EncryptPassword",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EncryptPasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// EncryptPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EncryptPasswordResponse
        /// </returns>
        public async Task<EncryptPasswordResponse> EncryptPasswordWithOptionsAsync(EncryptPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EncryptPassword",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EncryptPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// EncryptPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// EncryptPasswordResponse
        /// </returns>
        public EncryptPasswordResponse EncryptPassword(EncryptPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EncryptPasswordWithOptions(request, runtime);
        }

        /// <param name="request">
        /// EncryptPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// EncryptPasswordResponse
        /// </returns>
        public async Task<EncryptPasswordResponse> EncryptPasswordAsync(EncryptPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EncryptPasswordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取无影云盘的免密token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCloudDriveServiceMountTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCloudDriveServiceMountTokenResponse
        /// </returns>
        public GetCloudDriveServiceMountTokenResponse GetCloudDriveServiceMountTokenWithOptions(GetCloudDriveServiceMountTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCloudDriveServiceMountToken",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCloudDriveServiceMountTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取无影云盘的免密token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCloudDriveServiceMountTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCloudDriveServiceMountTokenResponse
        /// </returns>
        public async Task<GetCloudDriveServiceMountTokenResponse> GetCloudDriveServiceMountTokenWithOptionsAsync(GetCloudDriveServiceMountTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCloudDriveServiceMountToken",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCloudDriveServiceMountTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取无影云盘的免密token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCloudDriveServiceMountTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCloudDriveServiceMountTokenResponse
        /// </returns>
        public GetCloudDriveServiceMountTokenResponse GetCloudDriveServiceMountToken(GetCloudDriveServiceMountTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCloudDriveServiceMountTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取无影云盘的免密token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCloudDriveServiceMountTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCloudDriveServiceMountTokenResponse
        /// </returns>
        public async Task<GetCloudDriveServiceMountTokenResponse> GetCloudDriveServiceMountTokenAsync(GetCloudDriveServiceMountTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCloudDriveServiceMountTokenWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetConnectionTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionTicketResponse
        /// </returns>
        public GetConnectionTicketResponse GetConnectionTicketWithOptions(GetConnectionTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandContent))
            {
                query["CommandContent"] = request.CommandContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnectionTicket",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionTicketResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetConnectionTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionTicketResponse
        /// </returns>
        public async Task<GetConnectionTicketResponse> GetConnectionTicketWithOptionsAsync(GetConnectionTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandContent))
            {
                query["CommandContent"] = request.CommandContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnectionTicket",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetConnectionTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionTicketResponse
        /// </returns>
        public GetConnectionTicketResponse GetConnectionTicket(GetConnectionTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConnectionTicketWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetConnectionTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionTicketResponse
        /// </returns>
        public async Task<GetConnectionTicketResponse> GetConnectionTicketAsync(GetConnectionTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConnectionTicketWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains logon credentials.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLoginTokenResponse
        /// </returns>
        public GetLoginTokenResponse GetLoginTokenWithOptions(GetLoginTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationCode))
            {
                query["AuthenticationCode"] = request.AuthenticationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentStage))
            {
                query["CurrentStage"] = request.CurrentStage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepAlive))
            {
                query["KeepAlive"] = request.KeepAlive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepAliveToken))
            {
                query["KeepAliveToken"] = request.KeepAliveToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPassword))
            {
                query["NewPassword"] = request.NewPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldPassword))
            {
                query["OldPassword"] = request.OldPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenCode))
            {
                query["TokenCode"] = request.TokenCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoginToken",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains logon credentials.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLoginTokenResponse
        /// </returns>
        public async Task<GetLoginTokenResponse> GetLoginTokenWithOptionsAsync(GetLoginTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationCode))
            {
                query["AuthenticationCode"] = request.AuthenticationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentStage))
            {
                query["CurrentStage"] = request.CurrentStage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepAlive))
            {
                query["KeepAlive"] = request.KeepAlive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepAliveToken))
            {
                query["KeepAliveToken"] = request.KeepAliveToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPassword))
            {
                query["NewPassword"] = request.NewPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldPassword))
            {
                query["OldPassword"] = request.OldPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenCode))
            {
                query["TokenCode"] = request.TokenCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoginToken",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains logon credentials.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLoginTokenResponse
        /// </returns>
        public GetLoginTokenResponse GetLoginToken(GetLoginTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLoginTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains logon credentials.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLoginTokenResponse
        /// </returns>
        public async Task<GetLoginTokenResponse> GetLoginTokenAsync(GetLoginTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLoginTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>是否保持登录判断接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IsKeepAliveRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IsKeepAliveResponse
        /// </returns>
        public IsKeepAliveResponse IsKeepAliveWithOptions(IsKeepAliveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
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
                Action = "IsKeepAlive",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsKeepAliveResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>是否保持登录判断接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IsKeepAliveRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IsKeepAliveResponse
        /// </returns>
        public async Task<IsKeepAliveResponse> IsKeepAliveWithOptionsAsync(IsKeepAliveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
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
                Action = "IsKeepAlive",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsKeepAliveResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>是否保持登录判断接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IsKeepAliveRequest
        /// </param>
        /// 
        /// <returns>
        /// IsKeepAliveResponse
        /// </returns>
        public IsKeepAliveResponse IsKeepAlive(IsKeepAliveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IsKeepAliveWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>是否保持登录判断接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IsKeepAliveRequest
        /// </param>
        /// 
        /// <returns>
        /// IsKeepAliveResponse
        /// </returns>
        public async Task<IsKeepAliveResponse> IsKeepAliveAsync(IsKeepAliveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IsKeepAliveWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Agent需要上报的配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEdsAgentReportConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEdsAgentReportConfigResponse
        /// </returns>
        public QueryEdsAgentReportConfigResponse QueryEdsAgentReportConfigWithOptions(QueryEdsAgentReportConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                query["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceId))
            {
                query["EcsInstanceId"] = request.EcsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEdsAgentReportConfig",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEdsAgentReportConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Agent需要上报的配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEdsAgentReportConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEdsAgentReportConfigResponse
        /// </returns>
        public async Task<QueryEdsAgentReportConfigResponse> QueryEdsAgentReportConfigWithOptionsAsync(QueryEdsAgentReportConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                query["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceId))
            {
                query["EcsInstanceId"] = request.EcsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEdsAgentReportConfig",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEdsAgentReportConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Agent需要上报的配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEdsAgentReportConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEdsAgentReportConfigResponse
        /// </returns>
        public QueryEdsAgentReportConfigResponse QueryEdsAgentReportConfig(QueryEdsAgentReportConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdsAgentReportConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Agent需要上报的配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEdsAgentReportConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEdsAgentReportConfigResponse
        /// </returns>
        public async Task<QueryEdsAgentReportConfigResponse> QueryEdsAgentReportConfigAsync(QueryEdsAgentReportConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdsAgentReportConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restart cloud computers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebootDesktopsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebootDesktopsResponse
        /// </returns>
        public RebootDesktopsResponse RebootDesktopsWithOptions(RebootDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionToken))
            {
                query["SessionToken"] = request.SessionToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebootDesktops",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebootDesktopsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restart cloud computers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebootDesktopsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebootDesktopsResponse
        /// </returns>
        public async Task<RebootDesktopsResponse> RebootDesktopsWithOptionsAsync(RebootDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionToken))
            {
                query["SessionToken"] = request.SessionToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebootDesktops",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebootDesktopsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restart cloud computers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebootDesktopsRequest
        /// </param>
        /// 
        /// <returns>
        /// RebootDesktopsResponse
        /// </returns>
        public RebootDesktopsResponse RebootDesktops(RebootDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebootDesktopsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restart cloud computers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebootDesktopsRequest
        /// </param>
        /// 
        /// <returns>
        /// RebootDesktopsResponse
        /// </returns>
        public async Task<RebootDesktopsResponse> RebootDesktopsAsync(RebootDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebootDesktopsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RefreshLoginTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshLoginTokenResponse
        /// </returns>
        public RefreshLoginTokenResponse RefreshLoginTokenWithOptions(RefreshLoginTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshLoginToken",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshLoginTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RefreshLoginTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshLoginTokenResponse
        /// </returns>
        public async Task<RefreshLoginTokenResponse> RefreshLoginTokenWithOptionsAsync(RefreshLoginTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshLoginToken",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshLoginTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RefreshLoginTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// RefreshLoginTokenResponse
        /// </returns>
        public RefreshLoginTokenResponse RefreshLoginToken(RefreshLoginTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshLoginTokenWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RefreshLoginTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// RefreshLoginTokenResponse
        /// </returns>
        public async Task<RefreshLoginTokenResponse> RefreshLoginTokenAsync(RefreshLoginTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshLoginTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上报edsAgent的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReportEdsAgentInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReportEdsAgentInfoResponse
        /// </returns>
        public ReportEdsAgentInfoResponse ReportEdsAgentInfoWithOptions(ReportEdsAgentInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                query["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceId))
            {
                query["EcsInstanceId"] = request.EcsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdsAgentInfo))
            {
                query["EdsAgentInfo"] = request.EdsAgentInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportEdsAgentInfo",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportEdsAgentInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上报edsAgent的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReportEdsAgentInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReportEdsAgentInfoResponse
        /// </returns>
        public async Task<ReportEdsAgentInfoResponse> ReportEdsAgentInfoWithOptionsAsync(ReportEdsAgentInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                query["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceId))
            {
                query["EcsInstanceId"] = request.EcsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdsAgentInfo))
            {
                query["EdsAgentInfo"] = request.EdsAgentInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportEdsAgentInfo",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportEdsAgentInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上报edsAgent的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReportEdsAgentInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ReportEdsAgentInfoResponse
        /// </returns>
        public ReportEdsAgentInfoResponse ReportEdsAgentInfo(ReportEdsAgentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportEdsAgentInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上报edsAgent的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReportEdsAgentInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ReportEdsAgentInfoResponse
        /// </returns>
        public async Task<ReportEdsAgentInfoResponse> ReportEdsAgentInfoAsync(ReportEdsAgentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportEdsAgentInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ReportSessionStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReportSessionStatusResponse
        /// </returns>
        public ReportSessionStatusResponse ReportSessionStatusWithOptions(ReportSessionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionChangeTime))
            {
                query["SessionChangeTime"] = request.SessionChangeTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionStatus))
            {
                query["SessionStatus"] = request.SessionStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportSessionStatus",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportSessionStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ReportSessionStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReportSessionStatusResponse
        /// </returns>
        public async Task<ReportSessionStatusResponse> ReportSessionStatusWithOptionsAsync(ReportSessionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionChangeTime))
            {
                query["SessionChangeTime"] = request.SessionChangeTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionStatus))
            {
                query["SessionStatus"] = request.SessionStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportSessionStatus",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportSessionStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ReportSessionStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ReportSessionStatusResponse
        /// </returns>
        public ReportSessionStatusResponse ReportSessionStatus(ReportSessionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportSessionStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ReportSessionStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ReportSessionStatusResponse
        /// </returns>
        public async Task<ReportSessionStatusResponse> ReportSessionStatusAsync(ReportSessionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportSessionStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ResetPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetPasswordResponse
        /// </returns>
        public ResetPasswordResponse ResetPasswordWithOptions(ResetPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["phone"] = request.Phone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetPassword",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetPasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ResetPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetPasswordResponse
        /// </returns>
        public async Task<ResetPasswordResponse> ResetPasswordWithOptionsAsync(ResetPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["phone"] = request.Phone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetPassword",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ResetPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetPasswordResponse
        /// </returns>
        public ResetPasswordResponse ResetPassword(ResetPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetPasswordWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ResetPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetPasswordResponse
        /// </returns>
        public async Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetPasswordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>还原快照</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetSnapshotResponse
        /// </returns>
        public ResetSnapshotResponse ResetSnapshotWithOptions(ResetSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetSnapshot",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetSnapshotResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>还原快照</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetSnapshotResponse
        /// </returns>
        public async Task<ResetSnapshotResponse> ResetSnapshotWithOptionsAsync(ResetSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetSnapshot",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>还原快照</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetSnapshotResponse
        /// </returns>
        public ResetSnapshotResponse ResetSnapshot(ResetSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetSnapshotWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>还原快照</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetSnapshotResponse
        /// </returns>
        public async Task<ResetSnapshotResponse> ResetSnapshotAsync(ResetSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetSnapshotWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SendTokenCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendTokenCodeResponse
        /// </returns>
        public SendTokenCodeResponse SendTokenCodeWithOptions(SendTokenCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenCode))
            {
                query["TokenCode"] = request.TokenCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendTokenCode",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendTokenCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SendTokenCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendTokenCodeResponse
        /// </returns>
        public async Task<SendTokenCodeResponse> SendTokenCodeWithOptionsAsync(SendTokenCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenCode))
            {
                query["TokenCode"] = request.TokenCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendTokenCode",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendTokenCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SendTokenCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// SendTokenCodeResponse
        /// </returns>
        public SendTokenCodeResponse SendTokenCode(SendTokenCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendTokenCodeWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SendTokenCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// SendTokenCodeResponse
        /// </returns>
        public async Task<SendTokenCodeResponse> SendTokenCodeAsync(SendTokenCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendTokenCodeWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SetFingerPrintTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetFingerPrintTemplateResponse
        /// </returns>
        public SetFingerPrintTemplateResponse SetFingerPrintTemplateWithOptions(SetFingerPrintTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedFingerPrintTemplate))
            {
                query["EncryptedFingerPrintTemplate"] = request.EncryptedFingerPrintTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedKey))
            {
                query["EncryptedKey"] = request.EncryptedKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FingerPrintTemplate))
            {
                query["FingerPrintTemplate"] = request.FingerPrintTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetFingerPrintTemplate",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetFingerPrintTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SetFingerPrintTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetFingerPrintTemplateResponse
        /// </returns>
        public async Task<SetFingerPrintTemplateResponse> SetFingerPrintTemplateWithOptionsAsync(SetFingerPrintTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedFingerPrintTemplate))
            {
                query["EncryptedFingerPrintTemplate"] = request.EncryptedFingerPrintTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedKey))
            {
                query["EncryptedKey"] = request.EncryptedKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FingerPrintTemplate))
            {
                query["FingerPrintTemplate"] = request.FingerPrintTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetFingerPrintTemplate",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetFingerPrintTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SetFingerPrintTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// SetFingerPrintTemplateResponse
        /// </returns>
        public SetFingerPrintTemplateResponse SetFingerPrintTemplate(SetFingerPrintTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetFingerPrintTemplateWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SetFingerPrintTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// SetFingerPrintTemplateResponse
        /// </returns>
        public async Task<SetFingerPrintTemplateResponse> SetFingerPrintTemplateAsync(SetFingerPrintTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetFingerPrintTemplateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SetFingerPrintTemplateDescriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetFingerPrintTemplateDescriptionResponse
        /// </returns>
        public SetFingerPrintTemplateDescriptionResponse SetFingerPrintTemplateDescriptionWithOptions(SetFingerPrintTemplateDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Index))
            {
                query["Index"] = request.Index;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetFingerPrintTemplateDescription",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetFingerPrintTemplateDescriptionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SetFingerPrintTemplateDescriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetFingerPrintTemplateDescriptionResponse
        /// </returns>
        public async Task<SetFingerPrintTemplateDescriptionResponse> SetFingerPrintTemplateDescriptionWithOptionsAsync(SetFingerPrintTemplateDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Index))
            {
                query["Index"] = request.Index;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetFingerPrintTemplateDescription",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetFingerPrintTemplateDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SetFingerPrintTemplateDescriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetFingerPrintTemplateDescriptionResponse
        /// </returns>
        public SetFingerPrintTemplateDescriptionResponse SetFingerPrintTemplateDescription(SetFingerPrintTemplateDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetFingerPrintTemplateDescriptionWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SetFingerPrintTemplateDescriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetFingerPrintTemplateDescriptionResponse
        /// </returns>
        public async Task<SetFingerPrintTemplateDescriptionResponse> SetFingerPrintTemplateDescriptionAsync(SetFingerPrintTemplateDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetFingerPrintTemplateDescriptionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Start cloud computers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The cloud computers that you want to start must be in the Stopped state. After you call this operation, the cloud computers enter the Running state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDesktopsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDesktopsResponse
        /// </returns>
        public StartDesktopsResponse StartDesktopsWithOptions(StartDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDesktops",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDesktopsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Start cloud computers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The cloud computers that you want to start must be in the Stopped state. After you call this operation, the cloud computers enter the Running state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDesktopsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDesktopsResponse
        /// </returns>
        public async Task<StartDesktopsResponse> StartDesktopsWithOptionsAsync(StartDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDesktops",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDesktopsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Start cloud computers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The cloud computers that you want to start must be in the Stopped state. After you call this operation, the cloud computers enter the Running state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDesktopsRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDesktopsResponse
        /// </returns>
        public StartDesktopsResponse StartDesktops(StartDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDesktopsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Start cloud computers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The cloud computers that you want to start must be in the Stopped state. After you call this operation, the cloud computers enter the Running state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDesktopsRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDesktopsResponse
        /// </returns>
        public async Task<StartDesktopsResponse> StartDesktopsAsync(StartDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDesktopsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// StartRecordContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartRecordContentResponse
        /// </returns>
        public StartRecordContentResponse StartRecordContentWithOptions(StartRecordContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartRecordContent",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartRecordContentResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// StartRecordContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartRecordContentResponse
        /// </returns>
        public async Task<StartRecordContentResponse> StartRecordContentWithOptionsAsync(StartRecordContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartRecordContent",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartRecordContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// StartRecordContentRequest
        /// </param>
        /// 
        /// <returns>
        /// StartRecordContentResponse
        /// </returns>
        public StartRecordContentResponse StartRecordContent(StartRecordContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRecordContentWithOptions(request, runtime);
        }

        /// <param name="request">
        /// StartRecordContentRequest
        /// </param>
        /// 
        /// <returns>
        /// StartRecordContentResponse
        /// </returns>
        public async Task<StartRecordContentResponse> StartRecordContentAsync(StartRecordContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRecordContentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops cloud computers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The cloud computers that you want to stop must be in the Running state. After you call this operation, the cloud computers enter the Stopped state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDesktopsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDesktopsResponse
        /// </returns>
        public StopDesktopsResponse StopDesktopsWithOptions(StopDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionToken))
            {
                query["SessionToken"] = request.SessionToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDesktops",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDesktopsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops cloud computers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The cloud computers that you want to stop must be in the Running state. After you call this operation, the cloud computers enter the Stopped state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDesktopsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDesktopsResponse
        /// </returns>
        public async Task<StopDesktopsResponse> StopDesktopsWithOptionsAsync(StopDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionToken))
            {
                query["SessionToken"] = request.SessionToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDesktops",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDesktopsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops cloud computers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The cloud computers that you want to stop must be in the Running state. After you call this operation, the cloud computers enter the Stopped state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDesktopsRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDesktopsResponse
        /// </returns>
        public StopDesktopsResponse StopDesktops(StopDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDesktopsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops cloud computers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The cloud computers that you want to stop must be in the Running state. After you call this operation, the cloud computers enter the Stopped state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDesktopsRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDesktopsResponse
        /// </returns>
        public async Task<StopDesktopsResponse> StopDesktopsAsync(StopDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDesktopsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// StopRecordContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopRecordContentResponse
        /// </returns>
        public StopRecordContentResponse StopRecordContentWithOptions(StopRecordContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopRecordContent",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopRecordContentResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// StopRecordContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopRecordContentResponse
        /// </returns>
        public async Task<StopRecordContentResponse> StopRecordContentWithOptionsAsync(StopRecordContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopRecordContent",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopRecordContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// StopRecordContentRequest
        /// </param>
        /// 
        /// <returns>
        /// StopRecordContentResponse
        /// </returns>
        public StopRecordContentResponse StopRecordContent(StopRecordContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopRecordContentWithOptions(request, runtime);
        }

        /// <param name="request">
        /// StopRecordContentRequest
        /// </param>
        /// 
        /// <returns>
        /// StopRecordContentResponse
        /// </returns>
        public async Task<StopRecordContentResponse> StopRecordContentAsync(StopRecordContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopRecordContentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑用户桌面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindUserDesktopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindUserDesktopResponse
        /// </returns>
        public UnbindUserDesktopResponse UnbindUserDesktopWithOptions(UnbindUserDesktopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDesktopId))
            {
                query["UserDesktopId"] = request.UserDesktopId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindUserDesktop",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindUserDesktopResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑用户桌面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindUserDesktopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindUserDesktopResponse
        /// </returns>
        public async Task<UnbindUserDesktopResponse> UnbindUserDesktopWithOptionsAsync(UnbindUserDesktopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDesktopId))
            {
                query["UserDesktopId"] = request.UserDesktopId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindUserDesktop",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindUserDesktopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑用户桌面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindUserDesktopRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindUserDesktopResponse
        /// </returns>
        public UnbindUserDesktopResponse UnbindUserDesktop(UnbindUserDesktopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindUserDesktopWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑用户桌面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindUserDesktopRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindUserDesktopResponse
        /// </returns>
        public async Task<UnbindUserDesktopResponse> UnbindUserDesktopAsync(UnbindUserDesktopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindUserDesktopWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// VerifyCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyCredentialResponse
        /// </returns>
        public VerifyCredentialResponse VerifyCredentialWithOptions(VerifyCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credential))
            {
                query["Credential"] = request.Credential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialType))
            {
                query["CredentialType"] = request.CredentialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedKey))
            {
                query["EncryptedKey"] = request.EncryptedKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyCredential",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// VerifyCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyCredentialResponse
        /// </returns>
        public async Task<VerifyCredentialResponse> VerifyCredentialWithOptionsAsync(VerifyCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credential))
            {
                query["Credential"] = request.Credential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialType))
            {
                query["CredentialType"] = request.CredentialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedKey))
            {
                query["EncryptedKey"] = request.EncryptedKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyCredential",
                Version = "2020-10-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// VerifyCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyCredentialResponse
        /// </returns>
        public VerifyCredentialResponse VerifyCredential(VerifyCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyCredentialWithOptions(request, runtime);
        }

        /// <param name="request">
        /// VerifyCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyCredentialResponse
        /// </returns>
        public async Task<VerifyCredentialResponse> VerifyCredentialAsync(VerifyCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyCredentialWithOptionsAsync(request, runtime);
        }

    }
}
