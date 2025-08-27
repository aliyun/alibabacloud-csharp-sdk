// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Eds_aic20230930.Models;

namespace AlibabaCloud.SDK.Eds_aic20230930
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("eds-aic", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Attaches an Android Debug Bridge (ADB) key pair to one or more cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can attach to an ADB key pair only to cloud phone instances in the Running state.</para>
        /// <list type="bullet">
        /// <item><description>After you attach an ADB key pair, make sure the private key of the ADB key pair is copied to the ~/.android directory (macOS or Linux operating systems) or the C:\Users\Username.android directory (Windows operating systems). In addition, you must run the adb kill-server command to restart the ADB process to ensure correct ADB connection. Otherwise, ADB connection may fail due to authentication exceptions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachKeyPairResponse
        /// </returns>
        public AttachKeyPairResponse AttachKeyPairWithOptions(AttachKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachKeyPair",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachKeyPairResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches an Android Debug Bridge (ADB) key pair to one or more cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can attach to an ADB key pair only to cloud phone instances in the Running state.</para>
        /// <list type="bullet">
        /// <item><description>After you attach an ADB key pair, make sure the private key of the ADB key pair is copied to the ~/.android directory (macOS or Linux operating systems) or the C:\Users\Username.android directory (Windows operating systems). In addition, you must run the adb kill-server command to restart the ADB process to ensure correct ADB connection. Otherwise, ADB connection may fail due to authentication exceptions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachKeyPairResponse
        /// </returns>
        public async Task<AttachKeyPairResponse> AttachKeyPairWithOptionsAsync(AttachKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachKeyPair",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachKeyPairResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches an Android Debug Bridge (ADB) key pair to one or more cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can attach to an ADB key pair only to cloud phone instances in the Running state.</para>
        /// <list type="bullet">
        /// <item><description>After you attach an ADB key pair, make sure the private key of the ADB key pair is copied to the ~/.android directory (macOS or Linux operating systems) or the C:\Users\Username.android directory (Windows operating systems). In addition, you must run the adb kill-server command to restart the ADB process to ensure correct ADB connection. Otherwise, ADB connection may fail due to authentication exceptions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachKeyPairResponse
        /// </returns>
        public AttachKeyPairResponse AttachKeyPair(AttachKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachKeyPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches an Android Debug Bridge (ADB) key pair to one or more cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can attach to an ADB key pair only to cloud phone instances in the Running state.</para>
        /// <list type="bullet">
        /// <item><description>After you attach an ADB key pair, make sure the private key of the ADB key pair is copied to the ~/.android directory (macOS or Linux operating systems) or the C:\Users\Username.android directory (Windows operating systems). In addition, you must run the adb kill-server command to restart the ADB process to ensure correct ADB connection. Otherwise, ADB connection may fail due to authentication exceptions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachKeyPairResponse
        /// </returns>
        public async Task<AttachKeyPairResponse> AttachKeyPairAsync(AttachKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachKeyPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authorize/unauthorize Android instances for users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Instance states that support user assignment: Available, Shutting Down, Stopped, Starting, Backing Up, Restoring, Backup Failed, Restore Failed.
        /// Instance states that support unassignment: Available, Shutting Down, Stopped, Starting, Backing Up, Restoring, Backup Failed, Restore Failed, Expired, Overdue, Deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AuthorizeAndroidInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeAndroidInstanceResponse
        /// </returns>
        public AuthorizeAndroidInstanceResponse AuthorizeAndroidInstanceWithOptions(AuthorizeAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeUserId))
            {
                query["AuthorizeUserId"] = request.AuthorizeUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnAuthorizeUserId))
            {
                query["UnAuthorizeUserId"] = request.UnAuthorizeUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeAndroidInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authorize/unauthorize Android instances for users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Instance states that support user assignment: Available, Shutting Down, Stopped, Starting, Backing Up, Restoring, Backup Failed, Restore Failed.
        /// Instance states that support unassignment: Available, Shutting Down, Stopped, Starting, Backing Up, Restoring, Backup Failed, Restore Failed, Expired, Overdue, Deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AuthorizeAndroidInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeAndroidInstanceResponse
        /// </returns>
        public async Task<AuthorizeAndroidInstanceResponse> AuthorizeAndroidInstanceWithOptionsAsync(AuthorizeAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeUserId))
            {
                query["AuthorizeUserId"] = request.AuthorizeUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnAuthorizeUserId))
            {
                query["UnAuthorizeUserId"] = request.UnAuthorizeUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeAndroidInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authorize/unauthorize Android instances for users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Instance states that support user assignment: Available, Shutting Down, Stopped, Starting, Backing Up, Restoring, Backup Failed, Restore Failed.
        /// Instance states that support unassignment: Available, Shutting Down, Stopped, Starting, Backing Up, Restoring, Backup Failed, Restore Failed, Expired, Overdue, Deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AuthorizeAndroidInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeAndroidInstanceResponse
        /// </returns>
        public AuthorizeAndroidInstanceResponse AuthorizeAndroidInstance(AuthorizeAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeAndroidInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authorize/unauthorize Android instances for users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Instance states that support user assignment: Available, Shutting Down, Stopped, Starting, Backing Up, Restoring, Backup Failed, Restore Failed.
        /// Instance states that support unassignment: Available, Shutting Down, Stopped, Starting, Backing Up, Restoring, Backup Failed, Restore Failed, Expired, Overdue, Deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AuthorizeAndroidInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeAndroidInstanceResponse
        /// </returns>
        public async Task<AuthorizeAndroidInstanceResponse> AuthorizeAndroidInstanceAsync(AuthorizeAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeAndroidInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates and uploads backup files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to upload only backup files generated by cloud phones to Object Storage Service (OSS) buckets.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BackupFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BackupFileResponse
        /// </returns>
        public BackupFileResponse BackupFileWithOptions(BackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupAll))
            {
                query["BackupAll"] = request.BackupAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFileName))
            {
                query["BackupFileName"] = request.BackupFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFilePath))
            {
                query["BackupFilePath"] = request.BackupFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceAppList))
            {
                query["SourceAppList"] = request.SourceAppList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFilePathList))
            {
                query["SourceFilePathList"] = request.SourceFilePathList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadEndpoint))
            {
                query["UploadEndpoint"] = request.UploadEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["UploadType"] = request.UploadType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BackupFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BackupFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates and uploads backup files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to upload only backup files generated by cloud phones to Object Storage Service (OSS) buckets.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BackupFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BackupFileResponse
        /// </returns>
        public async Task<BackupFileResponse> BackupFileWithOptionsAsync(BackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupAll))
            {
                query["BackupAll"] = request.BackupAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFileName))
            {
                query["BackupFileName"] = request.BackupFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFilePath))
            {
                query["BackupFilePath"] = request.BackupFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceAppList))
            {
                query["SourceAppList"] = request.SourceAppList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFilePathList))
            {
                query["SourceFilePathList"] = request.SourceFilePathList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadEndpoint))
            {
                query["UploadEndpoint"] = request.UploadEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["UploadType"] = request.UploadType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BackupFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BackupFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates and uploads backup files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to upload only backup files generated by cloud phones to Object Storage Service (OSS) buckets.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BackupFileRequest
        /// </param>
        /// 
        /// <returns>
        /// BackupFileResponse
        /// </returns>
        public BackupFileResponse BackupFile(BackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BackupFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates and uploads backup files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to upload only backup files generated by cloud phones to Object Storage Service (OSS) buckets.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BackupFileRequest
        /// </param>
        /// 
        /// <returns>
        /// BackupFileResponse
        /// </returns>
        public async Task<BackupFileResponse> BackupFileAsync(BackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BackupFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves connection tickets in batch.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetAcpConnectionTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetAcpConnectionTicketResponse
        /// </returns>
        public BatchGetAcpConnectionTicketResponse BatchGetAcpConnectionTicketWithOptions(BatchGetAcpConnectionTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTasks))
            {
                query["InstanceTasks"] = request.InstanceTasks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetAcpConnectionTicket",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetAcpConnectionTicketResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves connection tickets in batch.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetAcpConnectionTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetAcpConnectionTicketResponse
        /// </returns>
        public async Task<BatchGetAcpConnectionTicketResponse> BatchGetAcpConnectionTicketWithOptionsAsync(BatchGetAcpConnectionTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTasks))
            {
                query["InstanceTasks"] = request.InstanceTasks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetAcpConnectionTicket",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetAcpConnectionTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves connection tickets in batch.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetAcpConnectionTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetAcpConnectionTicketResponse
        /// </returns>
        public BatchGetAcpConnectionTicketResponse BatchGetAcpConnectionTicket(BatchGetAcpConnectionTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetAcpConnectionTicketWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves connection tickets in batch.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetAcpConnectionTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetAcpConnectionTicketResponse
        /// </returns>
        public async Task<BatchGetAcpConnectionTicketResponse> BatchGetAcpConnectionTicketAsync(BatchGetAcpConnectionTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetAcpConnectionTicketWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改云手机矩阵的配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeCloudPhoneNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeCloudPhoneNodeResponse
        /// </returns>
        public ChangeCloudPhoneNodeResponse ChangeCloudPhoneNodeWithOptions(ChangeCloudPhoneNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownBandwidthLimit))
            {
                query["DownBandwidthLimit"] = request.DownBandwidthLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneCount))
            {
                query["PhoneCount"] = request.PhoneCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneDataVolume))
            {
                query["PhoneDataVolume"] = request.PhoneDataVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpBandwidthLimit))
            {
                query["UpBandwidthLimit"] = request.UpBandwidthLimit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeCloudPhoneNode",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeCloudPhoneNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改云手机矩阵的配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeCloudPhoneNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeCloudPhoneNodeResponse
        /// </returns>
        public async Task<ChangeCloudPhoneNodeResponse> ChangeCloudPhoneNodeWithOptionsAsync(ChangeCloudPhoneNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownBandwidthLimit))
            {
                query["DownBandwidthLimit"] = request.DownBandwidthLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneCount))
            {
                query["PhoneCount"] = request.PhoneCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneDataVolume))
            {
                query["PhoneDataVolume"] = request.PhoneDataVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpBandwidthLimit))
            {
                query["UpBandwidthLimit"] = request.UpBandwidthLimit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeCloudPhoneNode",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeCloudPhoneNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改云手机矩阵的配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeCloudPhoneNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeCloudPhoneNodeResponse
        /// </returns>
        public ChangeCloudPhoneNodeResponse ChangeCloudPhoneNode(ChangeCloudPhoneNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeCloudPhoneNodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改云手机矩阵的配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeCloudPhoneNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeCloudPhoneNodeResponse
        /// </returns>
        public async Task<ChangeCloudPhoneNodeResponse> ChangeCloudPhoneNodeAsync(ChangeCloudPhoneNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeCloudPhoneNodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Check the resource inventory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResourceStockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckResourceStockResponse
        /// </returns>
        public CheckResourceStockResponse CheckResourceStockWithOptions(CheckResourceStockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcpSpecId))
            {
                query["AcpSpecId"] = request.AcpSpecId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuAcceleration))
            {
                query["GpuAcceleration"] = request.GpuAcceleration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckResourceStock",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckResourceStockResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Check the resource inventory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResourceStockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckResourceStockResponse
        /// </returns>
        public async Task<CheckResourceStockResponse> CheckResourceStockWithOptionsAsync(CheckResourceStockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcpSpecId))
            {
                query["AcpSpecId"] = request.AcpSpecId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuAcceleration))
            {
                query["GpuAcceleration"] = request.GpuAcceleration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckResourceStock",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckResourceStockResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Check the resource inventory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResourceStockRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckResourceStockResponse
        /// </returns>
        public CheckResourceStockResponse CheckResourceStock(CheckResourceStockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckResourceStockWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Check the resource inventory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResourceStockRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckResourceStockResponse
        /// </returns>
        public async Task<CheckResourceStockResponse> CheckResourceStockAsync(CheckResourceStockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckResourceStockWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates pay-as-you-go or subscription instance groups.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before creating an instance group, ensure you understand the <a href="https://help.aliyun.com/document_detail/2807121.html">billing methods</a> supported by Cloud Phone.</para>
        /// <list type="bullet">
        /// <item><description>If the billing method of an instance group is PrePaid, AutoPay is set to false by default. In this case, you need to go to <a href="https://usercenter2-intl.aliyun.com/order/list">Expenses and Costs</a> to manually complete the payment.</description></item>
        /// <item><description>You can also set AutoPay to true based on your business requirements.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAndroidInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAndroidInstanceGroupResponse
        /// </returns>
        public CreateAndroidInstanceGroupResponse CreateAndroidInstanceGroupWithOptions(CreateAndroidInstanceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAndroidInstanceGroupShrinkRequest request = new CreateAndroidInstanceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkInfo))
            {
                request.NetworkInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkInfo, "NetworkInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthPackageId))
            {
                query["BandwidthPackageId"] = request.BandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthPackageType))
            {
                query["BandwidthPackageType"] = request.BandwidthPackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIpv6))
            {
                query["EnableIpv6"] = request.EnableIpv6;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuAcceleration))
            {
                query["GpuAcceleration"] = request.GpuAcceleration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupName))
            {
                query["InstanceGroupName"] = request.InstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupSpec))
            {
                query["InstanceGroupSpec"] = request.InstanceGroupSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6Bandwidth))
            {
                query["Ipv6Bandwidth"] = request.Ipv6Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInfoShrink))
            {
                query["NetworkInfo"] = request.NetworkInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberOfInstances))
            {
                query["NumberOfInstances"] = request.NumberOfInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                query["PolicyGroupId"] = request.PolicyGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndroidInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates pay-as-you-go or subscription instance groups.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before creating an instance group, ensure you understand the <a href="https://help.aliyun.com/document_detail/2807121.html">billing methods</a> supported by Cloud Phone.</para>
        /// <list type="bullet">
        /// <item><description>If the billing method of an instance group is PrePaid, AutoPay is set to false by default. In this case, you need to go to <a href="https://usercenter2-intl.aliyun.com/order/list">Expenses and Costs</a> to manually complete the payment.</description></item>
        /// <item><description>You can also set AutoPay to true based on your business requirements.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAndroidInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAndroidInstanceGroupResponse
        /// </returns>
        public async Task<CreateAndroidInstanceGroupResponse> CreateAndroidInstanceGroupWithOptionsAsync(CreateAndroidInstanceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAndroidInstanceGroupShrinkRequest request = new CreateAndroidInstanceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkInfo))
            {
                request.NetworkInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkInfo, "NetworkInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthPackageId))
            {
                query["BandwidthPackageId"] = request.BandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthPackageType))
            {
                query["BandwidthPackageType"] = request.BandwidthPackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIpv6))
            {
                query["EnableIpv6"] = request.EnableIpv6;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuAcceleration))
            {
                query["GpuAcceleration"] = request.GpuAcceleration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupName))
            {
                query["InstanceGroupName"] = request.InstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupSpec))
            {
                query["InstanceGroupSpec"] = request.InstanceGroupSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6Bandwidth))
            {
                query["Ipv6Bandwidth"] = request.Ipv6Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInfoShrink))
            {
                query["NetworkInfo"] = request.NetworkInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberOfInstances))
            {
                query["NumberOfInstances"] = request.NumberOfInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                query["PolicyGroupId"] = request.PolicyGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndroidInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates pay-as-you-go or subscription instance groups.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before creating an instance group, ensure you understand the <a href="https://help.aliyun.com/document_detail/2807121.html">billing methods</a> supported by Cloud Phone.</para>
        /// <list type="bullet">
        /// <item><description>If the billing method of an instance group is PrePaid, AutoPay is set to false by default. In this case, you need to go to <a href="https://usercenter2-intl.aliyun.com/order/list">Expenses and Costs</a> to manually complete the payment.</description></item>
        /// <item><description>You can also set AutoPay to true based on your business requirements.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAndroidInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAndroidInstanceGroupResponse
        /// </returns>
        public CreateAndroidInstanceGroupResponse CreateAndroidInstanceGroup(CreateAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAndroidInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates pay-as-you-go or subscription instance groups.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before creating an instance group, ensure you understand the <a href="https://help.aliyun.com/document_detail/2807121.html">billing methods</a> supported by Cloud Phone.</para>
        /// <list type="bullet">
        /// <item><description>If the billing method of an instance group is PrePaid, AutoPay is set to false by default. In this case, you need to go to <a href="https://usercenter2-intl.aliyun.com/order/list">Expenses and Costs</a> to manually complete the payment.</description></item>
        /// <item><description>You can also set AutoPay to true based on your business requirements.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAndroidInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAndroidInstanceGroupResponse
        /// </returns>
        public async Task<CreateAndroidInstanceGroupResponse> CreateAndroidInstanceGroupAsync(CreateAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAndroidInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Android application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When creating an app, you can provide app information to the system in one of the following ways:</para>
        /// <list type="bullet">
        /// <item><description>Way 1: Apps from the Application Center<list type="bullet">
        /// <item><description>You can use one of the following methods:<list type="bullet">
        /// <item><description>Method 1: Pass in the <c>FileName</c> and <c>FilePath</c> parameters at the same time.</description></item>
        /// <item><description>Method 2: Pass in the <c>OssAppUrl</c> parameter</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Rule: If your app is from the Alibaba Cloud Workspace Application Center, you must use either Method 1 or Method 2. If both are used, Method 1 takes priority.</description></item>
        /// <item><description>Condition: Before you proceed, log on to the <a href="https://eds.console.aliyun.com/osshelp">Elastic Desktop Service (EDS) Enterprise console</a> and follow the on-screen instructions to upload the app file to the Application Center to obtain the values of the <c>FileName</c>, <c>FilePath</c>, and <c>OssAppUrl</c> parameters.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Way 2: Custom apps<list type="bullet">
        /// <item><description>Pass in the <c>CustomAppInfo</c> parameter.</description></item>
        /// <item><description>Rule: If you pass in the <c>CustomAppInfo</c> parameter, all six fields within it are required.<remarks>
        /// <para> If Way 1 and Way 2 are adopted simultaneously, the information from Way 2 takes priority.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppResponse
        /// </returns>
        public CreateAppResponse CreateAppWithOptions(CreateAppRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppShrinkRequest request = new CreateAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomAppInfo))
            {
                request.CustomAppInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomAppInfo, "CustomAppInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAppInfoShrink))
            {
                query["CustomAppInfo"] = request.CustomAppInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconUrl))
            {
                query["IconUrl"] = request.IconUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallParam))
            {
                query["InstallParam"] = request.InstallParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAppUrl))
            {
                query["OssAppUrl"] = request.OssAppUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignApk))
            {
                query["SignApk"] = request.SignApk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Android application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When creating an app, you can provide app information to the system in one of the following ways:</para>
        /// <list type="bullet">
        /// <item><description>Way 1: Apps from the Application Center<list type="bullet">
        /// <item><description>You can use one of the following methods:<list type="bullet">
        /// <item><description>Method 1: Pass in the <c>FileName</c> and <c>FilePath</c> parameters at the same time.</description></item>
        /// <item><description>Method 2: Pass in the <c>OssAppUrl</c> parameter</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Rule: If your app is from the Alibaba Cloud Workspace Application Center, you must use either Method 1 or Method 2. If both are used, Method 1 takes priority.</description></item>
        /// <item><description>Condition: Before you proceed, log on to the <a href="https://eds.console.aliyun.com/osshelp">Elastic Desktop Service (EDS) Enterprise console</a> and follow the on-screen instructions to upload the app file to the Application Center to obtain the values of the <c>FileName</c>, <c>FilePath</c>, and <c>OssAppUrl</c> parameters.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Way 2: Custom apps<list type="bullet">
        /// <item><description>Pass in the <c>CustomAppInfo</c> parameter.</description></item>
        /// <item><description>Rule: If you pass in the <c>CustomAppInfo</c> parameter, all six fields within it are required.<remarks>
        /// <para> If Way 1 and Way 2 are adopted simultaneously, the information from Way 2 takes priority.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppResponse
        /// </returns>
        public async Task<CreateAppResponse> CreateAppWithOptionsAsync(CreateAppRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppShrinkRequest request = new CreateAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomAppInfo))
            {
                request.CustomAppInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomAppInfo, "CustomAppInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAppInfoShrink))
            {
                query["CustomAppInfo"] = request.CustomAppInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconUrl))
            {
                query["IconUrl"] = request.IconUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallParam))
            {
                query["InstallParam"] = request.InstallParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAppUrl))
            {
                query["OssAppUrl"] = request.OssAppUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignApk))
            {
                query["SignApk"] = request.SignApk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Android application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When creating an app, you can provide app information to the system in one of the following ways:</para>
        /// <list type="bullet">
        /// <item><description>Way 1: Apps from the Application Center<list type="bullet">
        /// <item><description>You can use one of the following methods:<list type="bullet">
        /// <item><description>Method 1: Pass in the <c>FileName</c> and <c>FilePath</c> parameters at the same time.</description></item>
        /// <item><description>Method 2: Pass in the <c>OssAppUrl</c> parameter</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Rule: If your app is from the Alibaba Cloud Workspace Application Center, you must use either Method 1 or Method 2. If both are used, Method 1 takes priority.</description></item>
        /// <item><description>Condition: Before you proceed, log on to the <a href="https://eds.console.aliyun.com/osshelp">Elastic Desktop Service (EDS) Enterprise console</a> and follow the on-screen instructions to upload the app file to the Application Center to obtain the values of the <c>FileName</c>, <c>FilePath</c>, and <c>OssAppUrl</c> parameters.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Way 2: Custom apps<list type="bullet">
        /// <item><description>Pass in the <c>CustomAppInfo</c> parameter.</description></item>
        /// <item><description>Rule: If you pass in the <c>CustomAppInfo</c> parameter, all six fields within it are required.<remarks>
        /// <para> If Way 1 and Way 2 are adopted simultaneously, the information from Way 2 takes priority.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAppRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppResponse
        /// </returns>
        public CreateAppResponse CreateApp(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Android application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When creating an app, you can provide app information to the system in one of the following ways:</para>
        /// <list type="bullet">
        /// <item><description>Way 1: Apps from the Application Center<list type="bullet">
        /// <item><description>You can use one of the following methods:<list type="bullet">
        /// <item><description>Method 1: Pass in the <c>FileName</c> and <c>FilePath</c> parameters at the same time.</description></item>
        /// <item><description>Method 2: Pass in the <c>OssAppUrl</c> parameter</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Rule: If your app is from the Alibaba Cloud Workspace Application Center, you must use either Method 1 or Method 2. If both are used, Method 1 takes priority.</description></item>
        /// <item><description>Condition: Before you proceed, log on to the <a href="https://eds.console.aliyun.com/osshelp">Elastic Desktop Service (EDS) Enterprise console</a> and follow the on-screen instructions to upload the app file to the Application Center to obtain the values of the <c>FileName</c>, <c>FilePath</c>, and <c>OssAppUrl</c> parameters.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Way 2: Custom apps<list type="bullet">
        /// <item><description>Pass in the <c>CustomAppInfo</c> parameter.</description></item>
        /// <item><description>Rule: If you pass in the <c>CustomAppInfo</c> parameter, all six fields within it are required.<remarks>
        /// <para> If Way 1 and Way 2 are adopted simultaneously, the information from Way 2 takes priority.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAppRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppResponse
        /// </returns>
        public async Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cloud phone matrix.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateCloudPhoneNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCloudPhoneNodeResponse
        /// </returns>
        public CreateCloudPhoneNodeResponse CreateCloudPhoneNodeWithOptions(CreateCloudPhoneNodeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCloudPhoneNodeShrinkRequest request = new CreateCloudPhoneNodeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DisplayConfig))
            {
                request.DisplayConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DisplayConfig, "DisplayConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkInfo))
            {
                request.NetworkInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkInfo, "NetworkInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthPackageId))
            {
                query["BandwidthPackageId"] = request.BandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthPackageType))
            {
                query["BandwidthPackageType"] = request.BandwidthPackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownBandwidthLimit))
            {
                query["DownBandwidthLimit"] = request.DownBandwidthLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkId))
            {
                query["NetworkId"] = request.NetworkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInfoShrink))
            {
                query["NetworkInfo"] = request.NetworkInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeName))
            {
                query["NodeName"] = request.NodeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneCount))
            {
                query["PhoneCount"] = request.PhoneCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneDataVolume))
            {
                query["PhoneDataVolume"] = request.PhoneDataVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionHeight))
            {
                query["ResolutionHeight"] = request.ResolutionHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionWidth))
            {
                query["ResolutionWidth"] = request.ResolutionWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerShareDataVolume))
            {
                query["ServerShareDataVolume"] = request.ServerShareDataVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerType))
            {
                query["ServerType"] = request.ServerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamMode))
            {
                query["StreamMode"] = request.StreamMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpBandwidthLimit))
            {
                query["UpBandwidthLimit"] = request.UpBandwidthLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseTemplate))
            {
                query["UseTemplate"] = request.UseTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayConfigShrink))
            {
                body["DisplayConfig"] = request.DisplayConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCloudPhoneNode",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCloudPhoneNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cloud phone matrix.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateCloudPhoneNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCloudPhoneNodeResponse
        /// </returns>
        public async Task<CreateCloudPhoneNodeResponse> CreateCloudPhoneNodeWithOptionsAsync(CreateCloudPhoneNodeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCloudPhoneNodeShrinkRequest request = new CreateCloudPhoneNodeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DisplayConfig))
            {
                request.DisplayConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DisplayConfig, "DisplayConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkInfo))
            {
                request.NetworkInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkInfo, "NetworkInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthPackageId))
            {
                query["BandwidthPackageId"] = request.BandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthPackageType))
            {
                query["BandwidthPackageType"] = request.BandwidthPackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownBandwidthLimit))
            {
                query["DownBandwidthLimit"] = request.DownBandwidthLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkId))
            {
                query["NetworkId"] = request.NetworkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInfoShrink))
            {
                query["NetworkInfo"] = request.NetworkInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeName))
            {
                query["NodeName"] = request.NodeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneCount))
            {
                query["PhoneCount"] = request.PhoneCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneDataVolume))
            {
                query["PhoneDataVolume"] = request.PhoneDataVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionHeight))
            {
                query["ResolutionHeight"] = request.ResolutionHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionWidth))
            {
                query["ResolutionWidth"] = request.ResolutionWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerShareDataVolume))
            {
                query["ServerShareDataVolume"] = request.ServerShareDataVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerType))
            {
                query["ServerType"] = request.ServerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamMode))
            {
                query["StreamMode"] = request.StreamMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpBandwidthLimit))
            {
                query["UpBandwidthLimit"] = request.UpBandwidthLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseTemplate))
            {
                query["UseTemplate"] = request.UseTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayConfigShrink))
            {
                body["DisplayConfig"] = request.DisplayConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCloudPhoneNode",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCloudPhoneNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cloud phone matrix.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCloudPhoneNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCloudPhoneNodeResponse
        /// </returns>
        public CreateCloudPhoneNodeResponse CreateCloudPhoneNode(CreateCloudPhoneNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCloudPhoneNodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cloud phone matrix.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCloudPhoneNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCloudPhoneNodeResponse
        /// </returns>
        public async Task<CreateCloudPhoneNodeResponse> CreateCloudPhoneNodeAsync(CreateCloudPhoneNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCloudPhoneNodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom image from a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomImageResponse
        /// </returns>
        public CreateCustomImageResponse CreateCustomImageWithOptions(CreateCustomImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomImage",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom image from a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomImageResponse
        /// </returns>
        public async Task<CreateCustomImageResponse> CreateCustomImageWithOptionsAsync(CreateCustomImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomImage",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom image from a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomImageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomImageResponse
        /// </returns>
        public CreateCustomImageResponse CreateCustomImage(CreateCustomImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom image from a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomImageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomImageResponse
        /// </returns>
        public async Task<CreateCustomImageResponse> CreateCustomImageAsync(CreateCustomImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomImageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Android Debug Bridge (ADB) key pair. The system retains the public key and provides a PEM-encoded private key in PKCS#8 format, adhering to the ADB connection specification. You must securely store the private key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In addition to using the CreateKeyPair operation to generate a key pair, you can also create one by using the ADB tool and upload it to the Cloud Phone console. The usage of this key pair is identical to that of a system-generated key pair.
        /// Each tenant can create up to 500 key pairs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyPairResponse
        /// </returns>
        public CreateKeyPairResponse CreateKeyPairWithOptions(CreateKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKeyPair",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKeyPairResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Android Debug Bridge (ADB) key pair. The system retains the public key and provides a PEM-encoded private key in PKCS#8 format, adhering to the ADB connection specification. You must securely store the private key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In addition to using the CreateKeyPair operation to generate a key pair, you can also create one by using the ADB tool and upload it to the Cloud Phone console. The usage of this key pair is identical to that of a system-generated key pair.
        /// Each tenant can create up to 500 key pairs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyPairResponse
        /// </returns>
        public async Task<CreateKeyPairResponse> CreateKeyPairWithOptionsAsync(CreateKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKeyPair",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKeyPairResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Android Debug Bridge (ADB) key pair. The system retains the public key and provides a PEM-encoded private key in PKCS#8 format, adhering to the ADB connection specification. You must securely store the private key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In addition to using the CreateKeyPair operation to generate a key pair, you can also create one by using the ADB tool and upload it to the Cloud Phone console. The usage of this key pair is identical to that of a system-generated key pair.
        /// Each tenant can create up to 500 key pairs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyPairResponse
        /// </returns>
        public CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKeyPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Android Debug Bridge (ADB) key pair. The system retains the public key and provides a PEM-encoded private key in PKCS#8 format, adhering to the ADB connection specification. You must securely store the private key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In addition to using the CreateKeyPair operation to generate a key pair, you can also create one by using the ADB tool and upload it to the Cloud Phone console. The usage of this key pair is identical to that of a system-generated key pair.
        /// Each tenant can create up to 500 key pairs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyPairResponse
        /// </returns>
        public async Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKeyPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a policy.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePolicyGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyGroupResponse
        /// </returns>
        public CreatePolicyGroupResponse CreatePolicyGroupWithOptions(CreatePolicyGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePolicyGroupShrinkRequest request = new CreatePolicyGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetRedirectPolicy))
            {
                request.NetRedirectPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetRedirectPolicy, "NetRedirectPolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Watermark))
            {
                request.WatermarkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Watermark, "Watermark", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CameraRedirect))
            {
                body["CameraRedirect"] = request.CameraRedirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clipboard))
            {
                body["Clipboard"] = request.Clipboard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Html5FileTransfer))
            {
                body["Html5FileTransfer"] = request.Html5FileTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalDrive))
            {
                body["LocalDrive"] = request.LocalDrive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockResolution))
            {
                body["LockResolution"] = request.LockResolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetRedirectPolicyShrink))
            {
                body["NetRedirectPolicy"] = request.NetRedirectPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupName))
            {
                body["PolicyGroupName"] = request.PolicyGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                body["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionHeight))
            {
                body["ResolutionHeight"] = request.ResolutionHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionWidth))
            {
                body["ResolutionWidth"] = request.ResolutionWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkShrink))
            {
                body["Watermark"] = request.WatermarkShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicyGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a policy.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePolicyGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyGroupResponse
        /// </returns>
        public async Task<CreatePolicyGroupResponse> CreatePolicyGroupWithOptionsAsync(CreatePolicyGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePolicyGroupShrinkRequest request = new CreatePolicyGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetRedirectPolicy))
            {
                request.NetRedirectPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetRedirectPolicy, "NetRedirectPolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Watermark))
            {
                request.WatermarkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Watermark, "Watermark", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CameraRedirect))
            {
                body["CameraRedirect"] = request.CameraRedirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clipboard))
            {
                body["Clipboard"] = request.Clipboard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Html5FileTransfer))
            {
                body["Html5FileTransfer"] = request.Html5FileTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalDrive))
            {
                body["LocalDrive"] = request.LocalDrive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockResolution))
            {
                body["LockResolution"] = request.LockResolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetRedirectPolicyShrink))
            {
                body["NetRedirectPolicy"] = request.NetRedirectPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupName))
            {
                body["PolicyGroupName"] = request.PolicyGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                body["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionHeight))
            {
                body["ResolutionHeight"] = request.ResolutionHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionWidth))
            {
                body["ResolutionWidth"] = request.ResolutionWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkShrink))
            {
                body["Watermark"] = request.WatermarkShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicyGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePolicyGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyGroupResponse
        /// </returns>
        public CreatePolicyGroupResponse CreatePolicyGroup(CreatePolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolicyGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePolicyGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyGroupResponse
        /// </returns>
        public async Task<CreatePolicyGroupResponse> CreatePolicyGroupAsync(CreatePolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolicyGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a screenshot of a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create a screenshot of a cloud phone instance and upload it to the default Object Storage Service (OSS) bucket. The operation returns a task ID, which you can use with the DescribeTasks operation to get the download link for the screenshot.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateScreenshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScreenshotResponse
        /// </returns>
        public CreateScreenshotResponse CreateScreenshotWithOptions(CreateScreenshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                query["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipCheckPolicyConfig))
            {
                query["SkipCheckPolicyConfig"] = request.SkipCheckPolicyConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScreenshot",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScreenshotResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a screenshot of a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create a screenshot of a cloud phone instance and upload it to the default Object Storage Service (OSS) bucket. The operation returns a task ID, which you can use with the DescribeTasks operation to get the download link for the screenshot.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateScreenshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScreenshotResponse
        /// </returns>
        public async Task<CreateScreenshotResponse> CreateScreenshotWithOptionsAsync(CreateScreenshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                query["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipCheckPolicyConfig))
            {
                query["SkipCheckPolicyConfig"] = request.SkipCheckPolicyConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScreenshot",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScreenshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a screenshot of a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create a screenshot of a cloud phone instance and upload it to the default Object Storage Service (OSS) bucket. The operation returns a task ID, which you can use with the DescribeTasks operation to get the download link for the screenshot.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateScreenshotRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScreenshotResponse
        /// </returns>
        public CreateScreenshotResponse CreateScreenshot(CreateScreenshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScreenshotWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a screenshot of a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to create a screenshot of a cloud phone instance and upload it to the default Object Storage Service (OSS) bucket. The operation returns a task ID, which you can use with the DescribeTasks operation to get the download link for the screenshot.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateScreenshotRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScreenshotResponse
        /// </returns>
        public async Task<CreateScreenshotResponse> CreateScreenshotAsync(CreateScreenshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScreenshotWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建系统属性模板</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSystemPropertyTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSystemPropertyTemplateResponse
        /// </returns>
        public CreateSystemPropertyTemplateResponse CreateSystemPropertyTemplateWithOptions(CreateSystemPropertyTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSystemPropertyTemplateShrinkRequest request = new CreateSystemPropertyTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SystemPropertyInfo))
            {
                request.SystemPropertyInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SystemPropertyInfo, "SystemPropertyInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuto))
            {
                query["EnableAuto"] = request.EnableAuto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemPropertyInfoShrink))
            {
                query["SystemPropertyInfo"] = request.SystemPropertyInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSystemPropertyTemplate",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSystemPropertyTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建系统属性模板</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSystemPropertyTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSystemPropertyTemplateResponse
        /// </returns>
        public async Task<CreateSystemPropertyTemplateResponse> CreateSystemPropertyTemplateWithOptionsAsync(CreateSystemPropertyTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSystemPropertyTemplateShrinkRequest request = new CreateSystemPropertyTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SystemPropertyInfo))
            {
                request.SystemPropertyInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SystemPropertyInfo, "SystemPropertyInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuto))
            {
                query["EnableAuto"] = request.EnableAuto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemPropertyInfoShrink))
            {
                query["SystemPropertyInfo"] = request.SystemPropertyInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSystemPropertyTemplate",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSystemPropertyTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建系统属性模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSystemPropertyTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSystemPropertyTemplateResponse
        /// </returns>
        public CreateSystemPropertyTemplateResponse CreateSystemPropertyTemplate(CreateSystemPropertyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSystemPropertyTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建系统属性模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSystemPropertyTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSystemPropertyTemplateResponse
        /// </returns>
        public async Task<CreateSystemPropertyTemplateResponse> CreateSystemPropertyTemplateAsync(CreateSystemPropertyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSystemPropertyTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete an instance group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete only pay-as-you-go instance groups.
        /// You can delete subscription instance groups only after they expire.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAndroidInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAndroidInstanceGroupResponse
        /// </returns>
        public DeleteAndroidInstanceGroupResponse DeleteAndroidInstanceGroupWithOptions(DeleteAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAndroidInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete an instance group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete only pay-as-you-go instance groups.
        /// You can delete subscription instance groups only after they expire.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAndroidInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAndroidInstanceGroupResponse
        /// </returns>
        public async Task<DeleteAndroidInstanceGroupResponse> DeleteAndroidInstanceGroupWithOptionsAsync(DeleteAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAndroidInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete an instance group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete only pay-as-you-go instance groups.
        /// You can delete subscription instance groups only after they expire.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAndroidInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAndroidInstanceGroupResponse
        /// </returns>
        public DeleteAndroidInstanceGroupResponse DeleteAndroidInstanceGroup(DeleteAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAndroidInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete an instance group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete only pay-as-you-go instance groups.
        /// You can delete subscription instance groups only after they expire.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAndroidInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAndroidInstanceGroupResponse
        /// </returns>
        public async Task<DeleteAndroidInstanceGroupResponse> DeleteAndroidInstanceGroupAsync(DeleteAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAndroidInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application. Before you delete an application, make sure that the application is not installed on any instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppsResponse
        /// </returns>
        public DeleteAppsResponse DeleteAppsWithOptions(DeleteAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                query["AppIdList"] = request.AppIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApps",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application. Before you delete an application, make sure that the application is not installed on any instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppsResponse
        /// </returns>
        public async Task<DeleteAppsResponse> DeleteAppsWithOptionsAsync(DeleteAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                query["AppIdList"] = request.AppIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApps",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application. Before you delete an application, make sure that the application is not installed on any instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppsResponse
        /// </returns>
        public DeleteAppsResponse DeleteApps(DeleteAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application. Before you delete an application, make sure that the application is not installed on any instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppsResponse
        /// </returns>
        public async Task<DeleteAppsResponse> DeleteAppsAsync(DeleteAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除备份文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBackupFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupFileResponse
        /// </returns>
        public DeleteBackupFileResponse DeleteBackupFileWithOptions(DeleteBackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFileIdList))
            {
                query["BackupFileIdList"] = request.BackupFileIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBackupFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBackupFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除备份文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBackupFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupFileResponse
        /// </returns>
        public async Task<DeleteBackupFileResponse> DeleteBackupFileWithOptionsAsync(DeleteBackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFileIdList))
            {
                query["BackupFileIdList"] = request.BackupFileIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBackupFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBackupFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除备份文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBackupFileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupFileResponse
        /// </returns>
        public DeleteBackupFileResponse DeleteBackupFile(DeleteBackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBackupFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除备份文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBackupFileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupFileResponse
        /// </returns>
        public async Task<DeleteBackupFileResponse> DeleteBackupFileAsync(DeleteBackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBackupFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a cloud phone matrix.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you proceed, make sure that the cloud phone matrix that you want to delete expired.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCloudPhoneNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCloudPhoneNodesResponse
        /// </returns>
        public DeleteCloudPhoneNodesResponse DeleteCloudPhoneNodesWithOptions(DeleteCloudPhoneNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                body["NodeIds"] = request.NodeIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCloudPhoneNodes",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCloudPhoneNodesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a cloud phone matrix.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you proceed, make sure that the cloud phone matrix that you want to delete expired.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCloudPhoneNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCloudPhoneNodesResponse
        /// </returns>
        public async Task<DeleteCloudPhoneNodesResponse> DeleteCloudPhoneNodesWithOptionsAsync(DeleteCloudPhoneNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                body["NodeIds"] = request.NodeIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCloudPhoneNodes",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCloudPhoneNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a cloud phone matrix.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you proceed, make sure that the cloud phone matrix that you want to delete expired.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCloudPhoneNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCloudPhoneNodesResponse
        /// </returns>
        public DeleteCloudPhoneNodesResponse DeleteCloudPhoneNodes(DeleteCloudPhoneNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCloudPhoneNodesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a cloud phone matrix.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you proceed, make sure that the cloud phone matrix that you want to delete expired.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCloudPhoneNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCloudPhoneNodesResponse
        /// </returns>
        public async Task<DeleteCloudPhoneNodesResponse> DeleteCloudPhoneNodesAsync(DeleteCloudPhoneNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCloudPhoneNodesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot delete an image that is currently in use by an instance group.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteImagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteImagesResponse
        /// </returns>
        public DeleteImagesResponse DeleteImagesWithOptions(DeleteImagesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteImagesShrinkRequest request = new DeleteImagesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageIds))
            {
                request.ImageIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageIds, "ImageIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIdsShrink))
            {
                body["ImageIds"] = request.ImageIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteImages",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImagesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot delete an image that is currently in use by an instance group.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteImagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteImagesResponse
        /// </returns>
        public async Task<DeleteImagesResponse> DeleteImagesWithOptionsAsync(DeleteImagesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteImagesShrinkRequest request = new DeleteImagesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageIds))
            {
                request.ImageIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageIds, "ImageIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIdsShrink))
            {
                body["ImageIds"] = request.ImageIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteImages",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot delete an image that is currently in use by an instance group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteImagesResponse
        /// </returns>
        public DeleteImagesResponse DeleteImages(DeleteImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot delete an image that is currently in use by an instance group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteImagesResponse
        /// </returns>
        public async Task<DeleteImagesResponse> DeleteImagesAsync(DeleteImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes Android Debug Bridge (ADB) key pairs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If a cloud phone instance is currently associated with the ADB key pair you intend to delete, the ADB key pair cannot be deleted.</para>
        /// <list type="bullet">
        /// <item><description>Once an ADB key pair is deleted, it cannot be retrieved or queried by using the DescribeKeyPairs operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteKeyPairsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKeyPairsResponse
        /// </returns>
        public DeleteKeyPairsResponse DeleteKeyPairsWithOptions(DeleteKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairIds))
            {
                query["KeyPairIds"] = request.KeyPairIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKeyPairs",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKeyPairsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes Android Debug Bridge (ADB) key pairs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If a cloud phone instance is currently associated with the ADB key pair you intend to delete, the ADB key pair cannot be deleted.</para>
        /// <list type="bullet">
        /// <item><description>Once an ADB key pair is deleted, it cannot be retrieved or queried by using the DescribeKeyPairs operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteKeyPairsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKeyPairsResponse
        /// </returns>
        public async Task<DeleteKeyPairsResponse> DeleteKeyPairsWithOptionsAsync(DeleteKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairIds))
            {
                query["KeyPairIds"] = request.KeyPairIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKeyPairs",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKeyPairsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes Android Debug Bridge (ADB) key pairs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If a cloud phone instance is currently associated with the ADB key pair you intend to delete, the ADB key pair cannot be deleted.</para>
        /// <list type="bullet">
        /// <item><description>Once an ADB key pair is deleted, it cannot be retrieved or queried by using the DescribeKeyPairs operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteKeyPairsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKeyPairsResponse
        /// </returns>
        public DeleteKeyPairsResponse DeleteKeyPairs(DeleteKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteKeyPairsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes Android Debug Bridge (ADB) key pairs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If a cloud phone instance is currently associated with the ADB key pair you intend to delete, the ADB key pair cannot be deleted.</para>
        /// <list type="bullet">
        /// <item><description>Once an ADB key pair is deleted, it cannot be retrieved or queried by using the DescribeKeyPairs operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteKeyPairsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKeyPairsResponse
        /// </returns>
        public async Task<DeleteKeyPairsResponse> DeleteKeyPairsAsync(DeleteKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteKeyPairsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePolicyGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyGroupResponse
        /// </returns>
        public DeletePolicyGroupResponse DeletePolicyGroupWithOptions(DeletePolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupIds))
            {
                query["PolicyGroupIds"] = request.PolicyGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicyGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePolicyGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyGroupResponse
        /// </returns>
        public async Task<DeletePolicyGroupResponse> DeletePolicyGroupWithOptionsAsync(DeletePolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupIds))
            {
                query["PolicyGroupIds"] = request.PolicyGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicyGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePolicyGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyGroupResponse
        /// </returns>
        public DeletePolicyGroupResponse DeletePolicyGroup(DeletePolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePolicyGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyGroupResponse
        /// </returns>
        public async Task<DeletePolicyGroupResponse> DeletePolicyGroupAsync(DeletePolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除系统属性模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSystemPropertyTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSystemPropertyTemplatesResponse
        /// </returns>
        public DeleteSystemPropertyTemplatesResponse DeleteSystemPropertyTemplatesWithOptions(DeleteSystemPropertyTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                query["TemplateIds"] = request.TemplateIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSystemPropertyTemplates",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSystemPropertyTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除系统属性模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSystemPropertyTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSystemPropertyTemplatesResponse
        /// </returns>
        public async Task<DeleteSystemPropertyTemplatesResponse> DeleteSystemPropertyTemplatesWithOptionsAsync(DeleteSystemPropertyTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                query["TemplateIds"] = request.TemplateIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSystemPropertyTemplates",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSystemPropertyTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除系统属性模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSystemPropertyTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSystemPropertyTemplatesResponse
        /// </returns>
        public DeleteSystemPropertyTemplatesResponse DeleteSystemPropertyTemplates(DeleteSystemPropertyTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSystemPropertyTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除系统属性模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSystemPropertyTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSystemPropertyTemplatesResponse
        /// </returns>
        public async Task<DeleteSystemPropertyTemplatesResponse> DeleteSystemPropertyTemplatesAsync(DeleteSystemPropertyTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSystemPropertyTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an instance group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAndroidInstanceGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAndroidInstanceGroupsResponse
        /// </returns>
        public DescribeAndroidInstanceGroupsResponse DescribeAndroidInstanceGroupsWithOptions(DescribeAndroidInstanceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupName))
            {
                query["InstanceGroupName"] = request.InstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                query["PolicyGroupId"] = request.PolicyGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "DescribeAndroidInstanceGroups",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAndroidInstanceGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an instance group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAndroidInstanceGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAndroidInstanceGroupsResponse
        /// </returns>
        public async Task<DescribeAndroidInstanceGroupsResponse> DescribeAndroidInstanceGroupsWithOptionsAsync(DescribeAndroidInstanceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupName))
            {
                query["InstanceGroupName"] = request.InstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                query["PolicyGroupId"] = request.PolicyGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "DescribeAndroidInstanceGroups",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAndroidInstanceGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an instance group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAndroidInstanceGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAndroidInstanceGroupsResponse
        /// </returns>
        public DescribeAndroidInstanceGroupsResponse DescribeAndroidInstanceGroups(DescribeAndroidInstanceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAndroidInstanceGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an instance group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAndroidInstanceGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAndroidInstanceGroupsResponse
        /// </returns>
        public async Task<DescribeAndroidInstanceGroupsResponse> DescribeAndroidInstanceGroupsAsync(DescribeAndroidInstanceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAndroidInstanceGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries cloud phone instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAndroidInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAndroidInstancesResponse
        /// </returns>
        public DescribeAndroidInstancesResponse DescribeAndroidInstancesWithOptions(DescribeAndroidInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceName))
            {
                query["AndroidInstanceName"] = request.AndroidInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppManagePolicyId))
            {
                query["AppManagePolicyId"] = request.AppManagePolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedUserId))
            {
                query["AuthorizedUserId"] = request.AuthorizedUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupName))
            {
                query["InstanceGroupName"] = request.InstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeName))
            {
                query["NodeName"] = request.NodeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteIds))
            {
                query["OfficeSiteIds"] = request.OfficeSiteIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosRuleIds))
            {
                query["QosRuleIds"] = request.QosRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "DescribeAndroidInstances",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAndroidInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries cloud phone instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAndroidInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAndroidInstancesResponse
        /// </returns>
        public async Task<DescribeAndroidInstancesResponse> DescribeAndroidInstancesWithOptionsAsync(DescribeAndroidInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceName))
            {
                query["AndroidInstanceName"] = request.AndroidInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppManagePolicyId))
            {
                query["AppManagePolicyId"] = request.AppManagePolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedUserId))
            {
                query["AuthorizedUserId"] = request.AuthorizedUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupName))
            {
                query["InstanceGroupName"] = request.InstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeName))
            {
                query["NodeName"] = request.NodeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteIds))
            {
                query["OfficeSiteIds"] = request.OfficeSiteIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosRuleIds))
            {
                query["QosRuleIds"] = request.QosRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "DescribeAndroidInstances",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAndroidInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries cloud phone instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAndroidInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAndroidInstancesResponse
        /// </returns>
        public DescribeAndroidInstancesResponse DescribeAndroidInstances(DescribeAndroidInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAndroidInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries cloud phone instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAndroidInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAndroidInstancesResponse
        /// </returns>
        public async Task<DescribeAndroidInstancesResponse> DescribeAndroidInstancesAsync(DescribeAndroidInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAndroidInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppsResponse
        /// </returns>
        public DescribeAppsResponse DescribeAppsWithOptions(DescribeAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                query["AppIdList"] = request.AppIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallationStatus))
            {
                query["InstallationStatus"] = request.InstallationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MD5))
            {
                query["MD5"] = request.MD5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "DescribeApps",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppsResponse
        /// </returns>
        public async Task<DescribeAppsResponse> DescribeAppsWithOptionsAsync(DescribeAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                query["AppIdList"] = request.AppIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallationStatus))
            {
                query["InstallationStatus"] = request.InstallationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MD5))
            {
                query["MD5"] = request.MD5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "DescribeApps",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppsResponse
        /// </returns>
        public DescribeAppsResponse DescribeApps(DescribeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppsResponse
        /// </returns>
        public async Task<DescribeAppsResponse> DescribeAppsAsync(DescribeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries backup files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to query only backup files generated by cloud phones that are stored in Object Storage Service (OSS) buckets.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBackupFilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupFilesResponse
        /// </returns>
        public DescribeBackupFilesResponse DescribeBackupFilesWithOptions(DescribeBackupFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceId))
            {
                query["AndroidInstanceId"] = request.AndroidInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceName))
            {
                query["AndroidInstanceName"] = request.AndroidInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupAll))
            {
                query["BackupAll"] = request.BackupAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFileId))
            {
                query["BackupFileId"] = request.BackupFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFileName))
            {
                query["BackupFileName"] = request.BackupFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["StatusList"] = request.StatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupFiles",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupFilesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries backup files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to query only backup files generated by cloud phones that are stored in Object Storage Service (OSS) buckets.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBackupFilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupFilesResponse
        /// </returns>
        public async Task<DescribeBackupFilesResponse> DescribeBackupFilesWithOptionsAsync(DescribeBackupFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceId))
            {
                query["AndroidInstanceId"] = request.AndroidInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceName))
            {
                query["AndroidInstanceName"] = request.AndroidInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupAll))
            {
                query["BackupAll"] = request.BackupAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFileId))
            {
                query["BackupFileId"] = request.BackupFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFileName))
            {
                query["BackupFileName"] = request.BackupFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["StatusList"] = request.StatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupFiles",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries backup files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to query only backup files generated by cloud phones that are stored in Object Storage Service (OSS) buckets.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBackupFilesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupFilesResponse
        /// </returns>
        public DescribeBackupFilesResponse DescribeBackupFiles(DescribeBackupFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupFilesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries backup files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to query only backup files generated by cloud phones that are stored in Object Storage Service (OSS) buckets.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBackupFilesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupFilesResponse
        /// </returns>
        public async Task<DescribeBackupFilesResponse> DescribeBackupFilesAsync(DescribeBackupFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupFilesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a cloud phone matrix.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudPhoneNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudPhoneNodesResponse
        /// </returns>
        public DescribeCloudPhoneNodesResponse DescribeCloudPhoneNodesWithOptions(DescribeCloudPhoneNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthPackageId))
            {
                query["BandwidthPackageId"] = request.BandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                query["NodeIds"] = request.NodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeName))
            {
                query["NodeName"] = request.NodeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerType))
            {
                query["ServerType"] = request.ServerType;
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
                Action = "DescribeCloudPhoneNodes",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudPhoneNodesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a cloud phone matrix.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudPhoneNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudPhoneNodesResponse
        /// </returns>
        public async Task<DescribeCloudPhoneNodesResponse> DescribeCloudPhoneNodesWithOptionsAsync(DescribeCloudPhoneNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthPackageId))
            {
                query["BandwidthPackageId"] = request.BandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                query["NodeIds"] = request.NodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeName))
            {
                query["NodeName"] = request.NodeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerType))
            {
                query["ServerType"] = request.ServerType;
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
                Action = "DescribeCloudPhoneNodes",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudPhoneNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a cloud phone matrix.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudPhoneNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudPhoneNodesResponse
        /// </returns>
        public DescribeCloudPhoneNodesResponse DescribeCloudPhoneNodes(DescribeCloudPhoneNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudPhoneNodesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a cloud phone matrix.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudPhoneNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudPhoneNodesResponse
        /// </returns>
        public async Task<DescribeCloudPhoneNodesResponse> DescribeCloudPhoneNodesAsync(DescribeCloudPhoneNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudPhoneNodesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询显示设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDisplayConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDisplayConfigResponse
        /// </returns>
        public DescribeDisplayConfigResponse DescribeDisplayConfigWithOptions(DescribeDisplayConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                body["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDisplayConfig",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDisplayConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询显示设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDisplayConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDisplayConfigResponse
        /// </returns>
        public async Task<DescribeDisplayConfigResponse> DescribeDisplayConfigWithOptionsAsync(DescribeDisplayConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                body["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDisplayConfig",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDisplayConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询显示设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDisplayConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDisplayConfigResponse
        /// </returns>
        public DescribeDisplayConfigResponse DescribeDisplayConfig(DescribeDisplayConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDisplayConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询显示设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDisplayConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDisplayConfigResponse
        /// </returns>
        public async Task<DescribeDisplayConfigResponse> DescribeDisplayConfigAsync(DescribeDisplayConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDisplayConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries images.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImageListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageListResponse
        /// </returns>
        public DescribeImageListResponse DescribeImageListWithOptions(DescribeImageListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageBizTags))
            {
                query["ImageBizTags"] = request.ImageBizTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePackageType))
            {
                query["ImagePackageType"] = request.ImagePackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                body["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImageList",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImageListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries images.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImageListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageListResponse
        /// </returns>
        public async Task<DescribeImageListResponse> DescribeImageListWithOptionsAsync(DescribeImageListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageBizTags))
            {
                query["ImageBizTags"] = request.ImageBizTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePackageType))
            {
                query["ImagePackageType"] = request.ImagePackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                body["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImageList",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImageListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries images.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImageListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageListResponse
        /// </returns>
        public DescribeImageListResponse DescribeImageList(DescribeImageListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries images.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImageListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageListResponse
        /// </returns>
        public async Task<DescribeImageListResponse> DescribeImageListAsync(DescribeImageListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution results of commands.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInvocationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvocationsResponse
        /// </returns>
        public DescribeInvocationsResponse DescribeInvocationsWithOptions(DescribeInvocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationId))
            {
                query["InvocationId"] = request.InvocationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInvocations",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInvocationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution results of commands.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInvocationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvocationsResponse
        /// </returns>
        public async Task<DescribeInvocationsResponse> DescribeInvocationsWithOptionsAsync(DescribeInvocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationId))
            {
                query["InvocationId"] = request.InvocationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInvocations",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInvocationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution results of commands.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInvocationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvocationsResponse
        /// </returns>
        public DescribeInvocationsResponse DescribeInvocations(DescribeInvocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInvocationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution results of commands.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInvocationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvocationsResponse
        /// </returns>
        public async Task<DescribeInvocationsResponse> DescribeInvocationsAsync(DescribeInvocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInvocationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more key pairs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeKeyPairsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeKeyPairsResponse
        /// </returns>
        public DescribeKeyPairsResponse DescribeKeyPairsWithOptions(DescribeKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairIds))
            {
                query["KeyPairIds"] = request.KeyPairIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKeyPairs",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeKeyPairsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more key pairs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeKeyPairsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeKeyPairsResponse
        /// </returns>
        public async Task<DescribeKeyPairsResponse> DescribeKeyPairsWithOptionsAsync(DescribeKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairIds))
            {
                query["KeyPairIds"] = request.KeyPairIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKeyPairs",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeKeyPairsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more key pairs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeKeyPairsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeKeyPairsResponse
        /// </returns>
        public DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKeyPairsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more key pairs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeKeyPairsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeKeyPairsResponse
        /// </returns>
        public async Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(DescribeKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKeyPairsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定监控项的最新监控数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMetricLastRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetricLastResponse
        /// </returns>
        public DescribeMetricLastResponse DescribeMetricLastWithOptions(DescribeMetricLastRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                body["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                body["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricNames))
            {
                body["MetricNames"] = request.MetricNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetricLast",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricLastResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定监控项的最新监控数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMetricLastRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetricLastResponse
        /// </returns>
        public async Task<DescribeMetricLastResponse> DescribeMetricLastWithOptionsAsync(DescribeMetricLastRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                body["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                body["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricNames))
            {
                body["MetricNames"] = request.MetricNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetricLast",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricLastResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定监控项的最新监控数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMetricLastRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetricLastResponse
        /// </returns>
        public DescribeMetricLastResponse DescribeMetricLast(DescribeMetricLastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricLastWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定监控项的最新监控数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMetricLastRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetricLastResponse
        /// </returns>
        public async Task<DescribeMetricLastResponse> DescribeMetricLastAsync(DescribeMetricLastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricLastWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query available regions.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2023-09-30",
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
        /// <para>Query available regions.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2023-09-30",
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
        /// <para>Query available regions.</para>
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
        /// <para>Query available regions.</para>
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
        /// <para>Query available specifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSpecResponse
        /// </returns>
        public DescribeSpecResponse DescribeSpecWithOptions(DescribeSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatrixSpec))
            {
                query["MatrixSpec"] = request.MatrixSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecIds))
            {
                query["SpecIds"] = request.SpecIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecStatus))
            {
                query["SpecStatus"] = request.SpecStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSpec",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSpecResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query available specifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSpecResponse
        /// </returns>
        public async Task<DescribeSpecResponse> DescribeSpecWithOptionsAsync(DescribeSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatrixSpec))
            {
                query["MatrixSpec"] = request.MatrixSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecIds))
            {
                query["SpecIds"] = request.SpecIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecStatus))
            {
                query["SpecStatus"] = request.SpecStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSpec",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query available specifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSpecResponse
        /// </returns>
        public DescribeSpecResponse DescribeSpec(DescribeSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSpecWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query available specifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSpecResponse
        /// </returns>
        public async Task<DescribeSpecResponse> DescribeSpecAsync(DescribeSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSpecWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询系统属性模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSystemPropertyTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSystemPropertyTemplatesResponse
        /// </returns>
        public DescribeSystemPropertyTemplatesResponse DescribeSystemPropertyTemplatesWithOptions(DescribeSystemPropertyTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                query["TemplateIds"] = request.TemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSystemPropertyTemplates",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSystemPropertyTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询系统属性模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSystemPropertyTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSystemPropertyTemplatesResponse
        /// </returns>
        public async Task<DescribeSystemPropertyTemplatesResponse> DescribeSystemPropertyTemplatesWithOptionsAsync(DescribeSystemPropertyTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                query["TemplateIds"] = request.TemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSystemPropertyTemplates",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSystemPropertyTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询系统属性模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSystemPropertyTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSystemPropertyTemplatesResponse
        /// </returns>
        public DescribeSystemPropertyTemplatesResponse DescribeSystemPropertyTemplates(DescribeSystemPropertyTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSystemPropertyTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询系统属性模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSystemPropertyTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSystemPropertyTemplatesResponse
        /// </returns>
        public async Task<DescribeSystemPropertyTemplatesResponse> DescribeSystemPropertyTemplatesAsync(DescribeSystemPropertyTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSystemPropertyTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tasks created for a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call the DescribeTasks operation to query the tasks created for one or more cloud phone instances.</para>
        /// <list type="bullet">
        /// <item><description>The system currently supports various tasks, including starting, stopping, restarting, and resetting cloud phone instances; backing up and restoring data; installing apps; and executing remote commands.</description></item>
        /// <item><description>You can use the Level field to specify the type of task. If Level is set to 1, it represents a batch task. If Level is set to 2, it represents an instance-level task.
        /// <b>Example</b>
        /// Assume you restart two cloud phone instances with the instance IDs acp-25nt4kk9whhok\<em>\</em>\<em>\</em> and acp-j2taq887orj8l\<em>\</em>\<em>\</em>, and the returned request ID is B8ED2BA9-0C6A-5643-818F-B5D60A64\<em>\</em>\<em>\</em>. If you want to check the operation outcomes of the two cloud phone instances, you can call the DescribeTasks operation. You need to set the InvokeId request parameter to B8ED2BA9-0C6A-5643-818F-B5D60A64\<em>\</em>\<em>\</em>. If you only want to check the cloud phone instance with the ID acp-25nt4kk9whhok\<em>\</em>\<em>\</em>, you must set the ParentTaskId request parameter to the ID of the batch task and the AndroidInstanceId request parameter to acp-25nt4kk9whhok\<em>\</em>\<em>\</em> when calling the DescribeTasks operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTasksResponse
        /// </returns>
        public DescribeTasksResponse DescribeTasksWithOptions(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeId))
            {
                query["InvokeId"] = request.InvokeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                query["Param"] = request.Param;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentTaskId))
            {
                query["ParentTaskId"] = request.ParentTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                query["TaskIds"] = request.TaskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                query["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatuses))
            {
                query["TaskStatuses"] = request.TaskStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTypes))
            {
                query["TaskTypes"] = request.TaskTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTasks",
                Version = "2023-09-30",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tasks created for a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call the DescribeTasks operation to query the tasks created for one or more cloud phone instances.</para>
        /// <list type="bullet">
        /// <item><description>The system currently supports various tasks, including starting, stopping, restarting, and resetting cloud phone instances; backing up and restoring data; installing apps; and executing remote commands.</description></item>
        /// <item><description>You can use the Level field to specify the type of task. If Level is set to 1, it represents a batch task. If Level is set to 2, it represents an instance-level task.
        /// <b>Example</b>
        /// Assume you restart two cloud phone instances with the instance IDs acp-25nt4kk9whhok\<em>\</em>\<em>\</em> and acp-j2taq887orj8l\<em>\</em>\<em>\</em>, and the returned request ID is B8ED2BA9-0C6A-5643-818F-B5D60A64\<em>\</em>\<em>\</em>. If you want to check the operation outcomes of the two cloud phone instances, you can call the DescribeTasks operation. You need to set the InvokeId request parameter to B8ED2BA9-0C6A-5643-818F-B5D60A64\<em>\</em>\<em>\</em>. If you only want to check the cloud phone instance with the ID acp-25nt4kk9whhok\<em>\</em>\<em>\</em>, you must set the ParentTaskId request parameter to the ID of the batch task and the AndroidInstanceId request parameter to acp-25nt4kk9whhok\<em>\</em>\<em>\</em> when calling the DescribeTasks operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTasksResponse
        /// </returns>
        public async Task<DescribeTasksResponse> DescribeTasksWithOptionsAsync(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeId))
            {
                query["InvokeId"] = request.InvokeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                query["Param"] = request.Param;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentTaskId))
            {
                query["ParentTaskId"] = request.ParentTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                query["TaskIds"] = request.TaskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                query["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatuses))
            {
                query["TaskStatuses"] = request.TaskStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTypes))
            {
                query["TaskTypes"] = request.TaskTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTasks",
                Version = "2023-09-30",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tasks created for a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call the DescribeTasks operation to query the tasks created for one or more cloud phone instances.</para>
        /// <list type="bullet">
        /// <item><description>The system currently supports various tasks, including starting, stopping, restarting, and resetting cloud phone instances; backing up and restoring data; installing apps; and executing remote commands.</description></item>
        /// <item><description>You can use the Level field to specify the type of task. If Level is set to 1, it represents a batch task. If Level is set to 2, it represents an instance-level task.
        /// <b>Example</b>
        /// Assume you restart two cloud phone instances with the instance IDs acp-25nt4kk9whhok\<em>\</em>\<em>\</em> and acp-j2taq887orj8l\<em>\</em>\<em>\</em>, and the returned request ID is B8ED2BA9-0C6A-5643-818F-B5D60A64\<em>\</em>\<em>\</em>. If you want to check the operation outcomes of the two cloud phone instances, you can call the DescribeTasks operation. You need to set the InvokeId request parameter to B8ED2BA9-0C6A-5643-818F-B5D60A64\<em>\</em>\<em>\</em>. If you only want to check the cloud phone instance with the ID acp-25nt4kk9whhok\<em>\</em>\<em>\</em>, you must set the ParentTaskId request parameter to the ID of the batch task and the AndroidInstanceId request parameter to acp-25nt4kk9whhok\<em>\</em>\<em>\</em> when calling the DescribeTasks operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTasksResponse
        /// </returns>
        public DescribeTasksResponse DescribeTasks(DescribeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tasks created for a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call the DescribeTasks operation to query the tasks created for one or more cloud phone instances.</para>
        /// <list type="bullet">
        /// <item><description>The system currently supports various tasks, including starting, stopping, restarting, and resetting cloud phone instances; backing up and restoring data; installing apps; and executing remote commands.</description></item>
        /// <item><description>You can use the Level field to specify the type of task. If Level is set to 1, it represents a batch task. If Level is set to 2, it represents an instance-level task.
        /// <b>Example</b>
        /// Assume you restart two cloud phone instances with the instance IDs acp-25nt4kk9whhok\<em>\</em>\<em>\</em> and acp-j2taq887orj8l\<em>\</em>\<em>\</em>, and the returned request ID is B8ED2BA9-0C6A-5643-818F-B5D60A64\<em>\</em>\<em>\</em>. If you want to check the operation outcomes of the two cloud phone instances, you can call the DescribeTasks operation. You need to set the InvokeId request parameter to B8ED2BA9-0C6A-5643-818F-B5D60A64\<em>\</em>\<em>\</em>. If you only want to check the cloud phone instance with the ID acp-25nt4kk9whhok\<em>\</em>\<em>\</em>, you must set the ParentTaskId request parameter to the ID of the batch task and the AndroidInstanceId request parameter to acp-25nt4kk9whhok\<em>\</em>\<em>\</em> when calling the DescribeTasks operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTasksResponse
        /// </returns>
        public async Task<DescribeTasksResponse> DescribeTasksAsync(DescribeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detaches an Android Debug Bridge (ADB) key pair from one or more cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you detach an ADB key pair from a cloud phone instance, the ADB connection will fail. This occurs because the system can no longer authenticate using a valid ADB public key, leading to authentication errors.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachKeyPairResponse
        /// </returns>
        public DetachKeyPairResponse DetachKeyPairWithOptions(DetachKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachKeyPair",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachKeyPairResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detaches an Android Debug Bridge (ADB) key pair from one or more cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you detach an ADB key pair from a cloud phone instance, the ADB connection will fail. This occurs because the system can no longer authenticate using a valid ADB public key, leading to authentication errors.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachKeyPairResponse
        /// </returns>
        public async Task<DetachKeyPairResponse> DetachKeyPairWithOptionsAsync(DetachKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachKeyPair",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachKeyPairResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detaches an Android Debug Bridge (ADB) key pair from one or more cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you detach an ADB key pair from a cloud phone instance, the ADB connection will fail. This occurs because the system can no longer authenticate using a valid ADB public key, leading to authentication errors.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachKeyPairResponse
        /// </returns>
        public DetachKeyPairResponse DetachKeyPair(DetachKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachKeyPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detaches an Android Debug Bridge (ADB) key pair from one or more cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you detach an ADB key pair from a cloud phone instance, the ADB connection will fail. This occurs because the system can no longer authenticate using a valid ADB public key, leading to authentication errors.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachKeyPairResponse
        /// </returns>
        public async Task<DetachKeyPairResponse> DetachKeyPairAsync(DetachKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachKeyPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实例断开连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisconnectAndroidInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisconnectAndroidInstanceResponse
        /// </returns>
        public DisconnectAndroidInstanceResponse DisconnectAndroidInstanceWithOptions(DisconnectAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisconnectAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisconnectAndroidInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实例断开连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisconnectAndroidInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisconnectAndroidInstanceResponse
        /// </returns>
        public async Task<DisconnectAndroidInstanceResponse> DisconnectAndroidInstanceWithOptionsAsync(DisconnectAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisconnectAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisconnectAndroidInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实例断开连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisconnectAndroidInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DisconnectAndroidInstanceResponse
        /// </returns>
        public DisconnectAndroidInstanceResponse DisconnectAndroidInstance(DisconnectAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisconnectAndroidInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实例断开连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisconnectAndroidInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DisconnectAndroidInstanceResponse
        /// </returns>
        public async Task<DisconnectAndroidInstanceResponse> DisconnectAndroidInstanceAsync(DisconnectAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisconnectAndroidInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Distributes an image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you distribute an image in supported regions, the distribution cannot be canceled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DistributeImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DistributeImageResponse
        /// </returns>
        public DistributeImageResponse DistributeImageWithOptions(DistributeImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributeRegionList))
            {
                body["DistributeRegionList"] = request.DistributeRegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DistributeImage",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DistributeImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Distributes an image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you distribute an image in supported regions, the distribution cannot be canceled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DistributeImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DistributeImageResponse
        /// </returns>
        public async Task<DistributeImageResponse> DistributeImageWithOptionsAsync(DistributeImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributeRegionList))
            {
                body["DistributeRegionList"] = request.DistributeRegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DistributeImage",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DistributeImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Distributes an image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you distribute an image in supported regions, the distribution cannot be canceled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DistributeImageRequest
        /// </param>
        /// 
        /// <returns>
        /// DistributeImageResponse
        /// </returns>
        public DistributeImageResponse DistributeImage(DistributeImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DistributeImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Distributes an image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you distribute an image in supported regions, the distribution cannot be canceled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DistributeImageRequest
        /// </param>
        /// 
        /// <returns>
        /// DistributeImageResponse
        /// </returns>
        public async Task<DistributeImageResponse> DistributeImageAsync(DistributeImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DistributeImageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Downgrades an instance group. Currently, this operation allows you to only delete specific cloud phone instances from an instance group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation only allows you to scale down an instance group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DowngradeAndroidInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DowngradeAndroidInstanceGroupResponse
        /// </returns>
        public DowngradeAndroidInstanceGroupResponse DowngradeAndroidInstanceGroupWithOptions(DowngradeAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DowngradeAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DowngradeAndroidInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Downgrades an instance group. Currently, this operation allows you to only delete specific cloud phone instances from an instance group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation only allows you to scale down an instance group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DowngradeAndroidInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DowngradeAndroidInstanceGroupResponse
        /// </returns>
        public async Task<DowngradeAndroidInstanceGroupResponse> DowngradeAndroidInstanceGroupWithOptionsAsync(DowngradeAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DowngradeAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DowngradeAndroidInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Downgrades an instance group. Currently, this operation allows you to only delete specific cloud phone instances from an instance group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation only allows you to scale down an instance group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DowngradeAndroidInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DowngradeAndroidInstanceGroupResponse
        /// </returns>
        public DowngradeAndroidInstanceGroupResponse DowngradeAndroidInstanceGroup(DowngradeAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DowngradeAndroidInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Downgrades an instance group. Currently, this operation allows you to only delete specific cloud phone instances from an instance group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation only allows you to scale down an instance group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DowngradeAndroidInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DowngradeAndroidInstanceGroupResponse
        /// </returns>
        public async Task<DowngradeAndroidInstanceGroupResponse> DowngradeAndroidInstanceGroupAsync(DowngradeAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DowngradeAndroidInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>结束协同</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EndCoordinationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EndCoordinationResponse
        /// </returns>
        public EndCoordinationResponse EndCoordinationWithOptions(EndCoordinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoordinatorUserId))
            {
                query["CoordinatorUserId"] = request.CoordinatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                query["OwnerUserId"] = request.OwnerUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EndCoordination",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EndCoordinationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>结束协同</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EndCoordinationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EndCoordinationResponse
        /// </returns>
        public async Task<EndCoordinationResponse> EndCoordinationWithOptionsAsync(EndCoordinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoordinatorUserId))
            {
                query["CoordinatorUserId"] = request.CoordinatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                query["OwnerUserId"] = request.OwnerUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EndCoordination",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EndCoordinationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>结束协同</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EndCoordinationRequest
        /// </param>
        /// 
        /// <returns>
        /// EndCoordinationResponse
        /// </returns>
        public EndCoordinationResponse EndCoordination(EndCoordinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EndCoordinationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>结束协同</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EndCoordinationRequest
        /// </param>
        /// 
        /// <returns>
        /// EndCoordinationResponse
        /// </returns>
        public async Task<EndCoordinationResponse> EndCoordinationAsync(EndCoordinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EndCoordinationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>存储扩容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExpandDataVolumeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExpandDataVolumeResponse
        /// </returns>
        public ExpandDataVolumeResponse ExpandDataVolumeWithOptions(ExpandDataVolumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                query["NodeIds"] = request.NodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneDataVolume))
            {
                query["PhoneDataVolume"] = request.PhoneDataVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareDataVolume))
            {
                query["ShareDataVolume"] = request.ShareDataVolume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExpandDataVolume",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExpandDataVolumeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>存储扩容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExpandDataVolumeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExpandDataVolumeResponse
        /// </returns>
        public async Task<ExpandDataVolumeResponse> ExpandDataVolumeWithOptionsAsync(ExpandDataVolumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                query["NodeIds"] = request.NodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneDataVolume))
            {
                query["PhoneDataVolume"] = request.PhoneDataVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareDataVolume))
            {
                query["ShareDataVolume"] = request.ShareDataVolume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExpandDataVolume",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExpandDataVolumeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>存储扩容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExpandDataVolumeRequest
        /// </param>
        /// 
        /// <returns>
        /// ExpandDataVolumeResponse
        /// </returns>
        public ExpandDataVolumeResponse ExpandDataVolume(ExpandDataVolumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExpandDataVolumeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>存储扩容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExpandDataVolumeRequest
        /// </param>
        /// 
        /// <returns>
        /// ExpandDataVolumeResponse
        /// </returns>
        public async Task<ExpandDataVolumeResponse> ExpandDataVolumeAsync(ExpandDataVolumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExpandDataVolumeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pulls a file from a cloud phone instance and stores it in Object Storage Service (OSS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to retrieve files or folders from cloud phone instances and save them directly to OSS.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// FetchFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FetchFileResponse
        /// </returns>
        public FetchFileResponse FetchFileWithOptions(FetchFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFilePath))
            {
                query["SourceFilePath"] = request.SourceFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadEndpoint))
            {
                query["UploadEndpoint"] = request.UploadEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["UploadType"] = request.UploadType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadUrl))
            {
                query["UploadUrl"] = request.UploadUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pulls a file from a cloud phone instance and stores it in Object Storage Service (OSS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to retrieve files or folders from cloud phone instances and save them directly to OSS.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// FetchFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FetchFileResponse
        /// </returns>
        public async Task<FetchFileResponse> FetchFileWithOptionsAsync(FetchFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFilePath))
            {
                query["SourceFilePath"] = request.SourceFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadEndpoint))
            {
                query["UploadEndpoint"] = request.UploadEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["UploadType"] = request.UploadType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadUrl))
            {
                query["UploadUrl"] = request.UploadUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pulls a file from a cloud phone instance and stores it in Object Storage Service (OSS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to retrieve files or folders from cloud phone instances and save them directly to OSS.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// FetchFileRequest
        /// </param>
        /// 
        /// <returns>
        /// FetchFileResponse
        /// </returns>
        public FetchFileResponse FetchFile(FetchFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FetchFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pulls a file from a cloud phone instance and stores it in Object Storage Service (OSS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to retrieve files or folders from cloud phone instances and save them directly to OSS.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// FetchFileRequest
        /// </param>
        /// 
        /// <returns>
        /// FetchFileResponse
        /// </returns>
        public async Task<FetchFileResponse> FetchFileAsync(FetchFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FetchFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a collaboration code for the cloud phone being accessed by using the current convenience account, and shares this code with other convenience accounts to allow them to access the same cloud phone.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to generate a collaboration code for a cloud phone accessed by your current account and share this code with other convenience users to allow them to access the same cloud phone over the desktop, mobile, or web client.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateCoordinationCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateCoordinationCodeResponse
        /// </returns>
        public GenerateCoordinationCodeResponse GenerateCoordinationCodeWithOptions(GenerateCoordinationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                query["OwnerUserId"] = request.OwnerUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateCoordinationCode",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCoordinationCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a collaboration code for the cloud phone being accessed by using the current convenience account, and shares this code with other convenience accounts to allow them to access the same cloud phone.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to generate a collaboration code for a cloud phone accessed by your current account and share this code with other convenience users to allow them to access the same cloud phone over the desktop, mobile, or web client.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateCoordinationCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateCoordinationCodeResponse
        /// </returns>
        public async Task<GenerateCoordinationCodeResponse> GenerateCoordinationCodeWithOptionsAsync(GenerateCoordinationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                query["OwnerUserId"] = request.OwnerUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateCoordinationCode",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCoordinationCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a collaboration code for the cloud phone being accessed by using the current convenience account, and shares this code with other convenience accounts to allow them to access the same cloud phone.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to generate a collaboration code for a cloud phone accessed by your current account and share this code with other convenience users to allow them to access the same cloud phone over the desktop, mobile, or web client.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateCoordinationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateCoordinationCodeResponse
        /// </returns>
        public GenerateCoordinationCodeResponse GenerateCoordinationCode(GenerateCoordinationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateCoordinationCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a collaboration code for the cloud phone being accessed by using the current convenience account, and shares this code with other convenience accounts to allow them to access the same cloud phone.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to generate a collaboration code for a cloud phone accessed by your current account and share this code with other convenience users to allow them to access the same cloud phone over the desktop, mobile, or web client.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateCoordinationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateCoordinationCodeResponse
        /// </returns>
        public async Task<GenerateCoordinationCodeResponse> GenerateCoordinationCodeAsync(GenerateCoordinationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateCoordinationCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取属性模板信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstancePropertiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstancePropertiesResponse
        /// </returns>
        public GetInstancePropertiesResponse GetInstancePropertiesWithOptions(GetInstancePropertiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceProperties",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstancePropertiesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取属性模板信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstancePropertiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstancePropertiesResponse
        /// </returns>
        public async Task<GetInstancePropertiesResponse> GetInstancePropertiesWithOptionsAsync(GetInstancePropertiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceProperties",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstancePropertiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取属性模板信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstancePropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstancePropertiesResponse
        /// </returns>
        public GetInstancePropertiesResponse GetInstanceProperties(GetInstancePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstancePropertiesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取属性模板信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstancePropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstancePropertiesResponse
        /// </returns>
        public async Task<GetInstancePropertiesResponse> GetInstancePropertiesAsync(GetInstancePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstancePropertiesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports the public key of an Android Debug Bridge (ADB) key pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To avoid authorization errors that could cause ADB connection failures, you must import the public key of an ADB key pair.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportKeyPairResponse
        /// </returns>
        public ImportKeyPairResponse ImportKeyPairWithOptions(ImportKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicKeyBody))
            {
                query["PublicKeyBody"] = request.PublicKeyBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportKeyPair",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportKeyPairResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports the public key of an Android Debug Bridge (ADB) key pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To avoid authorization errors that could cause ADB connection failures, you must import the public key of an ADB key pair.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportKeyPairResponse
        /// </returns>
        public async Task<ImportKeyPairResponse> ImportKeyPairWithOptionsAsync(ImportKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicKeyBody))
            {
                query["PublicKeyBody"] = request.PublicKeyBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportKeyPair",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportKeyPairResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports the public key of an Android Debug Bridge (ADB) key pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To avoid authorization errors that could cause ADB connection failures, you must import the public key of an ADB key pair.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportKeyPairResponse
        /// </returns>
        public ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportKeyPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports the public key of an Android Debug Bridge (ADB) key pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To avoid authorization errors that could cause ADB connection failures, you must import the public key of an ADB key pair.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportKeyPairResponse
        /// </returns>
        public async Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportKeyPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an app on multiple cloud phone instances at the same time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation runs asynchronously. To check the operation result, visit the Task Center. To retrieve task details, call the <a href="~~DescribeTasks~~">DescribeTasks</a> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallAppResponse
        /// </returns>
        public InstallAppResponse InstallAppWithOptions(InstallAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                query["AppIdList"] = request.AppIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIdList))
            {
                query["InstanceGroupIdList"] = request.InstanceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an app on multiple cloud phone instances at the same time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation runs asynchronously. To check the operation result, visit the Task Center. To retrieve task details, call the <a href="~~DescribeTasks~~">DescribeTasks</a> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallAppResponse
        /// </returns>
        public async Task<InstallAppResponse> InstallAppWithOptionsAsync(InstallAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                query["AppIdList"] = request.AppIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIdList))
            {
                query["InstanceGroupIdList"] = request.InstanceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an app on multiple cloud phone instances at the same time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation runs asynchronously. To check the operation result, visit the Task Center. To retrieve task details, call the <a href="~~DescribeTasks~~">DescribeTasks</a> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAppRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallAppResponse
        /// </returns>
        public InstallAppResponse InstallApp(InstallAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an app on multiple cloud phone instances at the same time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation runs asynchronously. To check the operation result, visit the Task Center. To retrieve task details, call the <a href="~~DescribeTasks~~">DescribeTasks</a> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAppRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallAppResponse
        /// </returns>
        public async Task<InstallAppResponse> InstallAppAsync(InstallAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装监控插件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallMonitorAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallMonitorAgentResponse
        /// </returns>
        public InstallMonitorAgentResponse InstallMonitorAgentWithOptions(InstallMonitorAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                body["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                body["SaleMode"] = request.SaleMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallMonitorAgent",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallMonitorAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装监控插件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallMonitorAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallMonitorAgentResponse
        /// </returns>
        public async Task<InstallMonitorAgentResponse> InstallMonitorAgentWithOptionsAsync(InstallMonitorAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                body["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                body["SaleMode"] = request.SaleMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallMonitorAgent",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallMonitorAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装监控插件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallMonitorAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallMonitorAgentResponse
        /// </returns>
        public InstallMonitorAgentResponse InstallMonitorAgent(InstallMonitorAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallMonitorAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装监控插件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallMonitorAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallMonitorAgentResponse
        /// </returns>
        public async Task<InstallMonitorAgentResponse> InstallMonitorAgentAsync(InstallMonitorAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallMonitorAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicyGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPolicyGroupsResponse
        /// </returns>
        public ListPolicyGroupsResponse ListPolicyGroupsWithOptions(ListPolicyGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupIds))
            {
                body["PolicyGroupIds"] = request.PolicyGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupName))
            {
                body["PolicyGroupName"] = request.PolicyGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                body["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicyGroups",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicyGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicyGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPolicyGroupsResponse
        /// </returns>
        public async Task<ListPolicyGroupsResponse> ListPolicyGroupsWithOptionsAsync(ListPolicyGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupIds))
            {
                body["PolicyGroupIds"] = request.PolicyGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupName))
            {
                body["PolicyGroupName"] = request.PolicyGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                body["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicyGroups",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicyGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicyGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPolicyGroupsResponse
        /// </returns>
        public ListPolicyGroupsResponse ListPolicyGroups(ListPolicyGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPolicyGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicyGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPolicyGroupsResponse
        /// </returns>
        public async Task<ListPolicyGroupsResponse> ListPolicyGroupsAsync(ListPolicyGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPolicyGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资源标签</para>
        /// </summary>
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
                Version = "2023-09-30",
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
        /// <para>查询资源标签</para>
        /// </summary>
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
                Version = "2023-09-30",
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
        /// <para>查询资源标签</para>
        /// </summary>
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
        /// <para>查询资源标签</para>
        /// </summary>
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
        /// <para>Modifies attributes of a cloud phone instance. Currently, this operation allows you to modify only the name of a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAndroidInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAndroidInstanceResponse
        /// </returns>
        public ModifyAndroidInstanceResponse ModifyAndroidInstanceWithOptions(ModifyAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceId))
            {
                query["AndroidInstanceId"] = request.AndroidInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownBandwidthLimit))
            {
                query["DownBandwidthLimit"] = request.DownBandwidthLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewAndroidInstanceName))
            {
                query["NewAndroidInstanceName"] = request.NewAndroidInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpBandwidthLimit))
            {
                query["UpBandwidthLimit"] = request.UpBandwidthLimit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAndroidInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies attributes of a cloud phone instance. Currently, this operation allows you to modify only the name of a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAndroidInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAndroidInstanceResponse
        /// </returns>
        public async Task<ModifyAndroidInstanceResponse> ModifyAndroidInstanceWithOptionsAsync(ModifyAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceId))
            {
                query["AndroidInstanceId"] = request.AndroidInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownBandwidthLimit))
            {
                query["DownBandwidthLimit"] = request.DownBandwidthLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewAndroidInstanceName))
            {
                query["NewAndroidInstanceName"] = request.NewAndroidInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpBandwidthLimit))
            {
                query["UpBandwidthLimit"] = request.UpBandwidthLimit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAndroidInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies attributes of a cloud phone instance. Currently, this operation allows you to modify only the name of a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAndroidInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAndroidInstanceResponse
        /// </returns>
        public ModifyAndroidInstanceResponse ModifyAndroidInstance(ModifyAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAndroidInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies attributes of a cloud phone instance. Currently, this operation allows you to modify only the name of a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAndroidInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAndroidInstanceResponse
        /// </returns>
        public async Task<ModifyAndroidInstanceResponse> ModifyAndroidInstanceAsync(ModifyAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAndroidInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies attributes of an instance group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAndroidInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAndroidInstanceGroupResponse
        /// </returns>
        public ModifyAndroidInstanceGroupResponse ModifyAndroidInstanceGroupWithOptions(ModifyAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewInstanceGroupName))
            {
                query["NewInstanceGroupName"] = request.NewInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                query["PolicyGroupId"] = request.PolicyGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAndroidInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies attributes of an instance group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAndroidInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAndroidInstanceGroupResponse
        /// </returns>
        public async Task<ModifyAndroidInstanceGroupResponse> ModifyAndroidInstanceGroupWithOptionsAsync(ModifyAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewInstanceGroupName))
            {
                query["NewInstanceGroupName"] = request.NewInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                query["PolicyGroupId"] = request.PolicyGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAndroidInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies attributes of an instance group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAndroidInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAndroidInstanceGroupResponse
        /// </returns>
        public ModifyAndroidInstanceGroupResponse ModifyAndroidInstanceGroup(ModifyAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAndroidInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies attributes of an instance group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAndroidInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAndroidInstanceGroupResponse
        /// </returns>
        public async Task<ModifyAndroidInstanceGroupResponse> ModifyAndroidInstanceGroupAsync(ModifyAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAndroidInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify attributes of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppResponse
        /// </returns>
        public ModifyAppResponse ModifyAppWithOptions(ModifyAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconUrl))
            {
                query["IconUrl"] = request.IconUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify attributes of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppResponse
        /// </returns>
        public async Task<ModifyAppResponse> ModifyAppWithOptionsAsync(ModifyAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconUrl))
            {
                query["IconUrl"] = request.IconUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify attributes of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppResponse
        /// </returns>
        public ModifyAppResponse ModifyApp(ModifyAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify attributes of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppResponse
        /// </returns>
        public async Task<ModifyAppResponse> ModifyAppAsync(ModifyAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a cloud phone matrix. Currently, you can only modify the name of a cloud phone matrix.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCloudPhoneNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCloudPhoneNodeResponse
        /// </returns>
        public ModifyCloudPhoneNodeResponse ModifyCloudPhoneNodeWithOptions(ModifyCloudPhoneNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewNodeName))
            {
                query["NewNodeName"] = request.NewNodeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamMode))
            {
                query["StreamMode"] = request.StreamMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCloudPhoneNode",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCloudPhoneNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a cloud phone matrix. Currently, you can only modify the name of a cloud phone matrix.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCloudPhoneNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCloudPhoneNodeResponse
        /// </returns>
        public async Task<ModifyCloudPhoneNodeResponse> ModifyCloudPhoneNodeWithOptionsAsync(ModifyCloudPhoneNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewNodeName))
            {
                query["NewNodeName"] = request.NewNodeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamMode))
            {
                query["StreamMode"] = request.StreamMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCloudPhoneNode",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCloudPhoneNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a cloud phone matrix. Currently, you can only modify the name of a cloud phone matrix.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCloudPhoneNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCloudPhoneNodeResponse
        /// </returns>
        public ModifyCloudPhoneNodeResponse ModifyCloudPhoneNode(ModifyCloudPhoneNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCloudPhoneNodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a cloud phone matrix. Currently, you can only modify the name of a cloud phone matrix.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCloudPhoneNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCloudPhoneNodeResponse
        /// </returns>
        public async Task<ModifyCloudPhoneNodeResponse> ModifyCloudPhoneNodeAsync(ModifyCloudPhoneNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCloudPhoneNodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改显示设置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyDisplayConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDisplayConfigResponse
        /// </returns>
        public ModifyDisplayConfigResponse ModifyDisplayConfigWithOptions(ModifyDisplayConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyDisplayConfigShrinkRequest request = new ModifyDisplayConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DisplayConfig))
            {
                request.DisplayConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DisplayConfig, "DisplayConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                body["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayConfigShrink))
            {
                body["DisplayConfig"] = request.DisplayConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDisplayConfig",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDisplayConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改显示设置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyDisplayConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDisplayConfigResponse
        /// </returns>
        public async Task<ModifyDisplayConfigResponse> ModifyDisplayConfigWithOptionsAsync(ModifyDisplayConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyDisplayConfigShrinkRequest request = new ModifyDisplayConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DisplayConfig))
            {
                request.DisplayConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DisplayConfig, "DisplayConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                body["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayConfigShrink))
            {
                body["DisplayConfig"] = request.DisplayConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDisplayConfig",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDisplayConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改显示设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDisplayConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDisplayConfigResponse
        /// </returns>
        public ModifyDisplayConfigResponse ModifyDisplayConfig(ModifyDisplayConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDisplayConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改显示设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDisplayConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDisplayConfigResponse
        /// </returns>
        public async Task<ModifyDisplayConfigResponse> ModifyDisplayConfigAsync(ModifyDisplayConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDisplayConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the billing method. Currently, this operation only allows you to change the billing method from pay-as-you-go to subscription.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceChargeTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceChargeTypeResponse
        /// </returns>
        public ModifyInstanceChargeTypeResponse ModifyInstanceChargeTypeWithOptions(ModifyInstanceChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceChargeType",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceChargeTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the billing method. Currently, this operation only allows you to change the billing method from pay-as-you-go to subscription.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceChargeTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceChargeTypeResponse
        /// </returns>
        public async Task<ModifyInstanceChargeTypeResponse> ModifyInstanceChargeTypeWithOptionsAsync(ModifyInstanceChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceChargeType",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceChargeTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the billing method. Currently, this operation only allows you to change the billing method from pay-as-you-go to subscription.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceChargeTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceChargeTypeResponse
        /// </returns>
        public ModifyInstanceChargeTypeResponse ModifyInstanceChargeType(ModifyInstanceChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceChargeTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the billing method. Currently, this operation only allows you to change the billing method from pay-as-you-go to subscription.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceChargeTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceChargeTypeResponse
        /// </returns>
        public async Task<ModifyInstanceChargeTypeResponse> ModifyInstanceChargeTypeAsync(ModifyInstanceChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceChargeTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies Android Debug Bridge (ADB) key pairs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyKeyPairNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyKeyPairNameResponse
        /// </returns>
        public ModifyKeyPairNameResponse ModifyKeyPairNameWithOptions(ModifyKeyPairNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewKeyPairName))
            {
                query["NewKeyPairName"] = request.NewKeyPairName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyKeyPairName",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyKeyPairNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies Android Debug Bridge (ADB) key pairs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyKeyPairNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyKeyPairNameResponse
        /// </returns>
        public async Task<ModifyKeyPairNameResponse> ModifyKeyPairNameWithOptionsAsync(ModifyKeyPairNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewKeyPairName))
            {
                query["NewKeyPairName"] = request.NewKeyPairName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyKeyPairName",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyKeyPairNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies Android Debug Bridge (ADB) key pairs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyKeyPairNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyKeyPairNameResponse
        /// </returns>
        public ModifyKeyPairNameResponse ModifyKeyPairName(ModifyKeyPairNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyKeyPairNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies Android Debug Bridge (ADB) key pairs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyKeyPairNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyKeyPairNameResponse
        /// </returns>
        public async Task<ModifyKeyPairNameResponse> ModifyKeyPairNameAsync(ModifyKeyPairNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyKeyPairNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a policy.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyPolicyGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPolicyGroupResponse
        /// </returns>
        public ModifyPolicyGroupResponse ModifyPolicyGroupWithOptions(ModifyPolicyGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyPolicyGroupShrinkRequest request = new ModifyPolicyGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetRedirectPolicy))
            {
                request.NetRedirectPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetRedirectPolicy, "NetRedirectPolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Watermark))
            {
                request.WatermarkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Watermark, "Watermark", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CameraRedirect))
            {
                body["CameraRedirect"] = request.CameraRedirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clipboard))
            {
                body["Clipboard"] = request.Clipboard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Html5FileTransfer))
            {
                body["Html5FileTransfer"] = request.Html5FileTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalDrive))
            {
                body["LocalDrive"] = request.LocalDrive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockResolution))
            {
                body["LockResolution"] = request.LockResolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetRedirectPolicyShrink))
            {
                body["NetRedirectPolicy"] = request.NetRedirectPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                body["PolicyGroupId"] = request.PolicyGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupName))
            {
                body["PolicyGroupName"] = request.PolicyGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionHeight))
            {
                body["ResolutionHeight"] = request.ResolutionHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionWidth))
            {
                body["ResolutionWidth"] = request.ResolutionWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkShrink))
            {
                body["Watermark"] = request.WatermarkShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPolicyGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPolicyGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a policy.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyPolicyGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPolicyGroupResponse
        /// </returns>
        public async Task<ModifyPolicyGroupResponse> ModifyPolicyGroupWithOptionsAsync(ModifyPolicyGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyPolicyGroupShrinkRequest request = new ModifyPolicyGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetRedirectPolicy))
            {
                request.NetRedirectPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetRedirectPolicy, "NetRedirectPolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Watermark))
            {
                request.WatermarkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Watermark, "Watermark", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CameraRedirect))
            {
                body["CameraRedirect"] = request.CameraRedirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clipboard))
            {
                body["Clipboard"] = request.Clipboard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Html5FileTransfer))
            {
                body["Html5FileTransfer"] = request.Html5FileTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalDrive))
            {
                body["LocalDrive"] = request.LocalDrive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockResolution))
            {
                body["LockResolution"] = request.LockResolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetRedirectPolicyShrink))
            {
                body["NetRedirectPolicy"] = request.NetRedirectPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                body["PolicyGroupId"] = request.PolicyGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupName))
            {
                body["PolicyGroupName"] = request.PolicyGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionHeight))
            {
                body["ResolutionHeight"] = request.ResolutionHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionWidth))
            {
                body["ResolutionWidth"] = request.ResolutionWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkShrink))
            {
                body["Watermark"] = request.WatermarkShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPolicyGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPolicyGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPolicyGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPolicyGroupResponse
        /// </returns>
        public ModifyPolicyGroupResponse ModifyPolicyGroup(ModifyPolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPolicyGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPolicyGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPolicyGroupResponse
        /// </returns>
        public async Task<ModifyPolicyGroupResponse> ModifyPolicyGroupAsync(ModifyPolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPolicyGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改属性模板</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifySystemPropertyTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySystemPropertyTemplateResponse
        /// </returns>
        public ModifySystemPropertyTemplateResponse ModifySystemPropertyTemplateWithOptions(ModifySystemPropertyTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifySystemPropertyTemplateShrinkRequest request = new ModifySystemPropertyTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SystemPropertyInfo))
            {
                request.SystemPropertyInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SystemPropertyInfo, "SystemPropertyInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuto))
            {
                query["EnableAuto"] = request.EnableAuto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemPropertyInfoShrink))
            {
                query["SystemPropertyInfo"] = request.SystemPropertyInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySystemPropertyTemplate",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySystemPropertyTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改属性模板</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifySystemPropertyTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySystemPropertyTemplateResponse
        /// </returns>
        public async Task<ModifySystemPropertyTemplateResponse> ModifySystemPropertyTemplateWithOptionsAsync(ModifySystemPropertyTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifySystemPropertyTemplateShrinkRequest request = new ModifySystemPropertyTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SystemPropertyInfo))
            {
                request.SystemPropertyInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SystemPropertyInfo, "SystemPropertyInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuto))
            {
                query["EnableAuto"] = request.EnableAuto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemPropertyInfoShrink))
            {
                query["SystemPropertyInfo"] = request.SystemPropertyInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySystemPropertyTemplate",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySystemPropertyTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改属性模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySystemPropertyTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySystemPropertyTemplateResponse
        /// </returns>
        public ModifySystemPropertyTemplateResponse ModifySystemPropertyTemplate(ModifySystemPropertyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySystemPropertyTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改属性模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySystemPropertyTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySystemPropertyTemplateResponse
        /// </returns>
        public async Task<ModifySystemPropertyTemplateResponse> ModifySystemPropertyTemplateAsync(ModifySystemPropertyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySystemPropertyTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Operates apps in a cloud phone, such as opening, closing, and reopening apps.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation runs asynchronously. To check the operation result, visit the Task Center. To retrieve task details, call the <a href="~~DescribeTasks~~">DescribeTasks</a> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OperateAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateAppResponse
        /// </returns>
        public OperateAppResponse OperateAppWithOptions(OperateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Operates apps in a cloud phone, such as opening, closing, and reopening apps.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation runs asynchronously. To check the operation result, visit the Task Center. To retrieve task details, call the <a href="~~DescribeTasks~~">DescribeTasks</a> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OperateAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateAppResponse
        /// </returns>
        public async Task<OperateAppResponse> OperateAppWithOptionsAsync(OperateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Operates apps in a cloud phone, such as opening, closing, and reopening apps.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation runs asynchronously. To check the operation result, visit the Task Center. To retrieve task details, call the <a href="~~DescribeTasks~~">DescribeTasks</a> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OperateAppRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateAppResponse
        /// </returns>
        public OperateAppResponse OperateApp(OperateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Operates apps in a cloud phone, such as opening, closing, and reopening apps.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation runs asynchronously. To check the operation result, visit the Task Center. To retrieve task details, call the <a href="~~DescribeTasks~~">DescribeTasks</a> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OperateAppRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateAppResponse
        /// </returns>
        public async Task<OperateAppResponse> OperateAppAsync(OperateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts one or more cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you restart a cloud phone instance, make sure it is in one of the following states: <b>Available, Abnormal, Backup failure, and Restoration failure</b>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RebootAndroidInstancesInGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebootAndroidInstancesInGroupResponse
        /// </returns>
        public RebootAndroidInstancesInGroupResponse RebootAndroidInstancesInGroupWithOptions(RebootAndroidInstancesInGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceStop))
            {
                query["ForceStop"] = request.ForceStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebootAndroidInstancesInGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebootAndroidInstancesInGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts one or more cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you restart a cloud phone instance, make sure it is in one of the following states: <b>Available, Abnormal, Backup failure, and Restoration failure</b>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RebootAndroidInstancesInGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebootAndroidInstancesInGroupResponse
        /// </returns>
        public async Task<RebootAndroidInstancesInGroupResponse> RebootAndroidInstancesInGroupWithOptionsAsync(RebootAndroidInstancesInGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceStop))
            {
                query["ForceStop"] = request.ForceStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebootAndroidInstancesInGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebootAndroidInstancesInGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts one or more cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you restart a cloud phone instance, make sure it is in one of the following states: <b>Available, Abnormal, Backup failure, and Restoration failure</b>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RebootAndroidInstancesInGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RebootAndroidInstancesInGroupResponse
        /// </returns>
        public RebootAndroidInstancesInGroupResponse RebootAndroidInstancesInGroup(RebootAndroidInstancesInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebootAndroidInstancesInGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts one or more cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you restart a cloud phone instance, make sure it is in one of the following states: <b>Available, Abnormal, Backup failure, and Restoration failure</b>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RebootAndroidInstancesInGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RebootAndroidInstancesInGroupResponse
        /// </returns>
        public async Task<RebootAndroidInstancesInGroupResponse> RebootAndroidInstancesInGroupAsync(RebootAndroidInstancesInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebootAndroidInstancesInGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores backup files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to restore only backup files generated by cloud phones that are stored in Object Storage Service (OSS) buckets.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RecoveryFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecoveryFileResponse
        /// </returns>
        public RecoveryFileResponse RecoveryFileWithOptions(RecoveryFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupAll))
            {
                query["BackupAll"] = request.BackupAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFileId))
            {
                query["BackupFileId"] = request.BackupFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFilePath))
            {
                query["BackupFilePath"] = request.BackupFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadEndpoint))
            {
                query["UploadEndpoint"] = request.UploadEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["UploadType"] = request.UploadType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoveryFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecoveryFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores backup files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to restore only backup files generated by cloud phones that are stored in Object Storage Service (OSS) buckets.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RecoveryFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecoveryFileResponse
        /// </returns>
        public async Task<RecoveryFileResponse> RecoveryFileWithOptionsAsync(RecoveryFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupAll))
            {
                query["BackupAll"] = request.BackupAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFileId))
            {
                query["BackupFileId"] = request.BackupFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFilePath))
            {
                query["BackupFilePath"] = request.BackupFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadEndpoint))
            {
                query["UploadEndpoint"] = request.UploadEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["UploadType"] = request.UploadType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoveryFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecoveryFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores backup files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to restore only backup files generated by cloud phones that are stored in Object Storage Service (OSS) buckets.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RecoveryFileRequest
        /// </param>
        /// 
        /// <returns>
        /// RecoveryFileResponse
        /// </returns>
        public RecoveryFileResponse RecoveryFile(RecoveryFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecoveryFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores backup files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to restore only backup files generated by cloud phones that are stored in Object Storage Service (OSS) buckets.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RecoveryFileRequest
        /// </param>
        /// 
        /// <returns>
        /// RecoveryFileResponse
        /// </returns>
        public async Task<RecoveryFileResponse> RecoveryFileAsync(RecoveryFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecoveryFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews instance groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewAndroidInstanceGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewAndroidInstanceGroupsResponse
        /// </returns>
        public RenewAndroidInstanceGroupsResponse RenewAndroidInstanceGroupsWithOptions(RenewAndroidInstanceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewAndroidInstanceGroups",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewAndroidInstanceGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews instance groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewAndroidInstanceGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewAndroidInstanceGroupsResponse
        /// </returns>
        public async Task<RenewAndroidInstanceGroupsResponse> RenewAndroidInstanceGroupsWithOptionsAsync(RenewAndroidInstanceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewAndroidInstanceGroups",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewAndroidInstanceGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews instance groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewAndroidInstanceGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewAndroidInstanceGroupsResponse
        /// </returns>
        public RenewAndroidInstanceGroupsResponse RenewAndroidInstanceGroups(RenewAndroidInstanceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewAndroidInstanceGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews instance groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewAndroidInstanceGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewAndroidInstanceGroupsResponse
        /// </returns>
        public async Task<RenewAndroidInstanceGroupsResponse> RenewAndroidInstanceGroupsAsync(RenewAndroidInstanceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewAndroidInstanceGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a cloud mobile matrix.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewCloudPhoneNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewCloudPhoneNodesResponse
        /// </returns>
        public RenewCloudPhoneNodesResponse RenewCloudPhoneNodesWithOptions(RenewCloudPhoneNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                body["NodeIds"] = request.NodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["PeriodUnit"] = request.PeriodUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewCloudPhoneNodes",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewCloudPhoneNodesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a cloud mobile matrix.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewCloudPhoneNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewCloudPhoneNodesResponse
        /// </returns>
        public async Task<RenewCloudPhoneNodesResponse> RenewCloudPhoneNodesWithOptionsAsync(RenewCloudPhoneNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                body["NodeIds"] = request.NodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["PeriodUnit"] = request.PeriodUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewCloudPhoneNodes",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewCloudPhoneNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a cloud mobile matrix.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewCloudPhoneNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewCloudPhoneNodesResponse
        /// </returns>
        public RenewCloudPhoneNodesResponse RenewCloudPhoneNodes(RenewCloudPhoneNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewCloudPhoneNodesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a cloud mobile matrix.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewCloudPhoneNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewCloudPhoneNodesResponse
        /// </returns>
        public async Task<RenewCloudPhoneNodesResponse> RenewCloudPhoneNodesAsync(RenewCloudPhoneNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewCloudPhoneNodesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets one or more cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you reset a cloud phone instance, make sure it is in one of the following states: <b>Available, Stopped, Abnormal, Backup failure, and Restoration failure</b>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetAndroidInstancesInGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetAndroidInstancesInGroupResponse
        /// </returns>
        public ResetAndroidInstancesInGroupResponse ResetAndroidInstancesInGroupWithOptions(ResetAndroidInstancesInGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingResetType))
            {
                query["SettingResetType"] = request.SettingResetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAndroidInstancesInGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAndroidInstancesInGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets one or more cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you reset a cloud phone instance, make sure it is in one of the following states: <b>Available, Stopped, Abnormal, Backup failure, and Restoration failure</b>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetAndroidInstancesInGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetAndroidInstancesInGroupResponse
        /// </returns>
        public async Task<ResetAndroidInstancesInGroupResponse> ResetAndroidInstancesInGroupWithOptionsAsync(ResetAndroidInstancesInGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingResetType))
            {
                query["SettingResetType"] = request.SettingResetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAndroidInstancesInGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAndroidInstancesInGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets one or more cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you reset a cloud phone instance, make sure it is in one of the following states: <b>Available, Stopped, Abnormal, Backup failure, and Restoration failure</b>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetAndroidInstancesInGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetAndroidInstancesInGroupResponse
        /// </returns>
        public ResetAndroidInstancesInGroupResponse ResetAndroidInstancesInGroup(ResetAndroidInstancesInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAndroidInstancesInGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets one or more cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you reset a cloud phone instance, make sure it is in one of the following states: <b>Available, Stopped, Abnormal, Backup failure, and Restoration failure</b>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetAndroidInstancesInGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetAndroidInstancesInGroupResponse
        /// </returns>
        public async Task<ResetAndroidInstancesInGroupResponse> ResetAndroidInstancesInGroupAsync(ResetAndroidInstancesInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAndroidInstancesInGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a command on a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCommandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCommandResponse
        /// </returns>
        public RunCommandResponse RunCommandWithOptions(RunCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandContent))
            {
                query["CommandContent"] = request.CommandContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentEncoding))
            {
                query["ContentEncoding"] = request.ContentEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCommand",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCommandResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a command on a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCommandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCommandResponse
        /// </returns>
        public async Task<RunCommandResponse> RunCommandWithOptionsAsync(RunCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandContent))
            {
                query["CommandContent"] = request.CommandContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentEncoding))
            {
                query["ContentEncoding"] = request.ContentEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCommand",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCommandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a command on a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCommandRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCommandResponse
        /// </returns>
        public RunCommandResponse RunCommand(RunCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunCommandWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a command on a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCommandRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCommandResponse
        /// </returns>
        public async Task<RunCommandResponse> RunCommandAsync(RunCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunCommandWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pushes files from Object Storage Service (OSS) buckets to cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to only push files or folders from OSS buckets to cloud phone instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendFileResponse
        /// </returns>
        public SendFileResponse SendFileWithOptions(SendFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoInstall))
            {
                query["AutoInstall"] = request.AutoInstall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFilePath))
            {
                query["SourceFilePath"] = request.SourceFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFileName))
            {
                query["TargetFileName"] = request.TargetFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadEndpoint))
            {
                query["UploadEndpoint"] = request.UploadEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["UploadType"] = request.UploadType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadUrl))
            {
                query["UploadUrl"] = request.UploadUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pushes files from Object Storage Service (OSS) buckets to cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to only push files or folders from OSS buckets to cloud phone instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendFileResponse
        /// </returns>
        public async Task<SendFileResponse> SendFileWithOptionsAsync(SendFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoInstall))
            {
                query["AutoInstall"] = request.AutoInstall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFilePath))
            {
                query["SourceFilePath"] = request.SourceFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFileName))
            {
                query["TargetFileName"] = request.TargetFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadEndpoint))
            {
                query["UploadEndpoint"] = request.UploadEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["UploadType"] = request.UploadType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadUrl))
            {
                query["UploadUrl"] = request.UploadUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pushes files from Object Storage Service (OSS) buckets to cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to only push files or folders from OSS buckets to cloud phone instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendFileRequest
        /// </param>
        /// 
        /// <returns>
        /// SendFileResponse
        /// </returns>
        public SendFileResponse SendFile(SendFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pushes files from Object Storage Service (OSS) buckets to cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to only push files or folders from OSS buckets to cloud phone instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendFileRequest
        /// </param>
        /// 
        /// <returns>
        /// SendFileResponse
        /// </returns>
        public async Task<SendFileResponse> SendFileAsync(SendFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送属性模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendSystemPropertyTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendSystemPropertyTemplateResponse
        /// </returns>
        public SendSystemPropertyTemplateResponse SendSystemPropertyTemplateWithOptions(SendSystemPropertyTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                query["TemplateIds"] = request.TemplateIds;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                body["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendSystemPropertyTemplate",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendSystemPropertyTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送属性模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendSystemPropertyTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendSystemPropertyTemplateResponse
        /// </returns>
        public async Task<SendSystemPropertyTemplateResponse> SendSystemPropertyTemplateWithOptionsAsync(SendSystemPropertyTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                query["TemplateIds"] = request.TemplateIds;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                body["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendSystemPropertyTemplate",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendSystemPropertyTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送属性模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendSystemPropertyTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// SendSystemPropertyTemplateResponse
        /// </returns>
        public SendSystemPropertyTemplateResponse SendSystemPropertyTemplate(SendSystemPropertyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendSystemPropertyTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送属性模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendSystemPropertyTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// SendSystemPropertyTemplateResponse
        /// </returns>
        public async Task<SendSystemPropertyTemplateResponse> SendSystemPropertyTemplateAsync(SendSystemPropertyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendSystemPropertyTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the authentication status for cloud phone instances. If you enable Android Debug Bridge (ADB) authentication for cloud phone instances, the system will verify the validity of the ADB key pairs provided by end users when they connect to the instances over ADB. To ensure successful authentication and a proper connection, we recommend that you attach ADB key pairs to cloud phone instances. If you disable ADB authentication for cloud phone instances, the system will no longer verify the validity of any ADB key pairs. As a result, end users can connect to the cloud phone instances over ADB without authentication, provided the network connection is functioning properly.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that the desired cloud phone instance is in the Running state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetAdbSecureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetAdbSecureResponse
        /// </returns>
        public SetAdbSecureResponse SetAdbSecureWithOptions(SetAdbSecureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "SetAdbSecure",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAdbSecureResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the authentication status for cloud phone instances. If you enable Android Debug Bridge (ADB) authentication for cloud phone instances, the system will verify the validity of the ADB key pairs provided by end users when they connect to the instances over ADB. To ensure successful authentication and a proper connection, we recommend that you attach ADB key pairs to cloud phone instances. If you disable ADB authentication for cloud phone instances, the system will no longer verify the validity of any ADB key pairs. As a result, end users can connect to the cloud phone instances over ADB without authentication, provided the network connection is functioning properly.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that the desired cloud phone instance is in the Running state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetAdbSecureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetAdbSecureResponse
        /// </returns>
        public async Task<SetAdbSecureResponse> SetAdbSecureWithOptionsAsync(SetAdbSecureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "SetAdbSecure",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAdbSecureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the authentication status for cloud phone instances. If you enable Android Debug Bridge (ADB) authentication for cloud phone instances, the system will verify the validity of the ADB key pairs provided by end users when they connect to the instances over ADB. To ensure successful authentication and a proper connection, we recommend that you attach ADB key pairs to cloud phone instances. If you disable ADB authentication for cloud phone instances, the system will no longer verify the validity of any ADB key pairs. As a result, end users can connect to the cloud phone instances over ADB without authentication, provided the network connection is functioning properly.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that the desired cloud phone instance is in the Running state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetAdbSecureRequest
        /// </param>
        /// 
        /// <returns>
        /// SetAdbSecureResponse
        /// </returns>
        public SetAdbSecureResponse SetAdbSecure(SetAdbSecureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAdbSecureWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the authentication status for cloud phone instances. If you enable Android Debug Bridge (ADB) authentication for cloud phone instances, the system will verify the validity of the ADB key pairs provided by end users when they connect to the instances over ADB. To ensure successful authentication and a proper connection, we recommend that you attach ADB key pairs to cloud phone instances. If you disable ADB authentication for cloud phone instances, the system will no longer verify the validity of any ADB key pairs. As a result, end users can connect to the cloud phone instances over ADB without authentication, provided the network connection is functioning properly.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that the desired cloud phone instance is in the Running state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetAdbSecureRequest
        /// </param>
        /// 
        /// <returns>
        /// SetAdbSecureResponse
        /// </returns>
        public async Task<SetAdbSecureResponse> SetAdbSecureAsync(SetAdbSecureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAdbSecureWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Start instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only supports starting when the instance is in the <b>Stopped, Backup Failed, or Recovery Failed</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartAndroidInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartAndroidInstanceResponse
        /// </returns>
        public StartAndroidInstanceResponse StartAndroidInstanceWithOptions(StartAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAndroidInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Start instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only supports starting when the instance is in the <b>Stopped, Backup Failed, or Recovery Failed</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartAndroidInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartAndroidInstanceResponse
        /// </returns>
        public async Task<StartAndroidInstanceResponse> StartAndroidInstanceWithOptionsAsync(StartAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAndroidInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Start instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only supports starting when the instance is in the <b>Stopped, Backup Failed, or Recovery Failed</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartAndroidInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartAndroidInstanceResponse
        /// </returns>
        public StartAndroidInstanceResponse StartAndroidInstance(StartAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartAndroidInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Start instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only supports starting when the instance is in the <b>Stopped, Backup Failed, or Recovery Failed</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartAndroidInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartAndroidInstanceResponse
        /// </returns>
        public async Task<StartAndroidInstanceResponse> StartAndroidInstanceAsync(StartAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartAndroidInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you stop a cloud phone instance, make sure it is in one of the following states: <b>Available, Backup failure, and Restoration failure</b>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopAndroidInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopAndroidInstanceResponse
        /// </returns>
        public StopAndroidInstanceResponse StopAndroidInstanceWithOptions(StopAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceStop))
            {
                query["ForceStop"] = request.ForceStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAndroidInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you stop a cloud phone instance, make sure it is in one of the following states: <b>Available, Backup failure, and Restoration failure</b>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopAndroidInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopAndroidInstanceResponse
        /// </returns>
        public async Task<StopAndroidInstanceResponse> StopAndroidInstanceWithOptionsAsync(StopAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceStop))
            {
                query["ForceStop"] = request.ForceStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAndroidInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you stop a cloud phone instance, make sure it is in one of the following states: <b>Available, Backup failure, and Restoration failure</b>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopAndroidInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StopAndroidInstanceResponse
        /// </returns>
        public StopAndroidInstanceResponse StopAndroidInstance(StopAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopAndroidInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a cloud phone instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you stop a cloud phone instance, make sure it is in one of the following states: <b>Available, Backup failure, and Restoration failure</b>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopAndroidInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StopAndroidInstanceResponse
        /// </returns>
        public async Task<StopAndroidInstanceResponse> StopAndroidInstanceAsync(StopAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopAndroidInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>给资源打标签</para>
        /// </summary>
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
                Version = "2023-09-30",
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
        /// <para>给资源打标签</para>
        /// </summary>
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
                Version = "2023-09-30",
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
        /// <para>给资源打标签</para>
        /// </summary>
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
        /// <para>给资源打标签</para>
        /// </summary>
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
        /// <para>Uninstalls an app from multiple cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation runs asynchronously. To check the operation result, you can visit the Task Center. To retrieve task details, call the <a href="~~DescribeTasks~~">DescribeTasks</a> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallAppResponse
        /// </returns>
        public UninstallAppResponse UninstallAppWithOptions(UninstallAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                query["AppIdList"] = request.AppIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIdList))
            {
                query["InstanceGroupIdList"] = request.InstanceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls an app from multiple cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation runs asynchronously. To check the operation result, you can visit the Task Center. To retrieve task details, call the <a href="~~DescribeTasks~~">DescribeTasks</a> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallAppResponse
        /// </returns>
        public async Task<UninstallAppResponse> UninstallAppWithOptionsAsync(UninstallAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                query["AppIdList"] = request.AppIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIdList))
            {
                query["InstanceGroupIdList"] = request.InstanceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls an app from multiple cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation runs asynchronously. To check the operation result, you can visit the Task Center. To retrieve task details, call the <a href="~~DescribeTasks~~">DescribeTasks</a> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallAppRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallAppResponse
        /// </returns>
        public UninstallAppResponse UninstallApp(UninstallAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UninstallAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls an app from multiple cloud phone instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation runs asynchronously. To check the operation result, you can visit the Task Center. To retrieve task details, call the <a href="~~DescribeTasks~~">DescribeTasks</a> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallAppRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallAppResponse
        /// </returns>
        public async Task<UninstallAppResponse> UninstallAppAsync(UninstallAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UninstallAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>卸载监控插件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UninstallMonitorAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallMonitorAgentResponse
        /// </returns>
        public UninstallMonitorAgentResponse UninstallMonitorAgentWithOptions(UninstallMonitorAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                body["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                body["SaleMode"] = request.SaleMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallMonitorAgent",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallMonitorAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>卸载监控插件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UninstallMonitorAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallMonitorAgentResponse
        /// </returns>
        public async Task<UninstallMonitorAgentResponse> UninstallMonitorAgentWithOptionsAsync(UninstallMonitorAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                body["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                body["SaleMode"] = request.SaleMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallMonitorAgent",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallMonitorAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>卸载监控插件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UninstallMonitorAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallMonitorAgentResponse
        /// </returns>
        public UninstallMonitorAgentResponse UninstallMonitorAgent(UninstallMonitorAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UninstallMonitorAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>卸载监控插件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UninstallMonitorAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallMonitorAgentResponse
        /// </returns>
        public async Task<UninstallMonitorAgentResponse> UninstallMonitorAgentAsync(UninstallMonitorAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UninstallMonitorAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除资源标签</para>
        /// </summary>
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
                Version = "2023-09-30",
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
        /// <para>删除资源标签</para>
        /// </summary>
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
                Version = "2023-09-30",
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
        /// <para>删除资源标签</para>
        /// </summary>
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
        /// <para>删除资源标签</para>
        /// </summary>
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
        /// <para>Updates the name of a custom image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomImageNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomImageNameResponse
        /// </returns>
        public UpdateCustomImageNameResponse UpdateCustomImageNameWithOptions(UpdateCustomImageNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomImageName",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomImageNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name of a custom image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomImageNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomImageNameResponse
        /// </returns>
        public async Task<UpdateCustomImageNameResponse> UpdateCustomImageNameWithOptionsAsync(UpdateCustomImageNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomImageName",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomImageNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name of a custom image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomImageNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomImageNameResponse
        /// </returns>
        public UpdateCustomImageNameResponse UpdateCustomImageName(UpdateCustomImageNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomImageNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name of a custom image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomImageNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomImageNameResponse
        /// </returns>
        public async Task<UpdateCustomImageNameResponse> UpdateCustomImageNameAsync(UpdateCustomImageNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomImageNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the image of an instance group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure the image is in the Available state and the region of the image is included in the region list of the desired instance group. In addition, the instance group itself is available.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceGroupImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceGroupImageResponse
        /// </returns>
        public UpdateInstanceGroupImageResponse UpdateInstanceGroupImageWithOptions(UpdateInstanceGroupImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                body["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceGroupImage",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceGroupImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the image of an instance group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure the image is in the Available state and the region of the image is included in the region list of the desired instance group. In addition, the instance group itself is available.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceGroupImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceGroupImageResponse
        /// </returns>
        public async Task<UpdateInstanceGroupImageResponse> UpdateInstanceGroupImageWithOptionsAsync(UpdateInstanceGroupImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                body["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceGroupImage",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceGroupImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the image of an instance group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure the image is in the Available state and the region of the image is included in the region list of the desired instance group. In addition, the instance group itself is available.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceGroupImageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceGroupImageResponse
        /// </returns>
        public UpdateInstanceGroupImageResponse UpdateInstanceGroupImage(UpdateInstanceGroupImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceGroupImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the image of an instance group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure the image is in the Available state and the region of the image is included in the region list of the desired instance group. In addition, the instance group itself is available.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceGroupImageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceGroupImageResponse
        /// </returns>
        public async Task<UpdateInstanceGroupImageResponse> UpdateInstanceGroupImageAsync(UpdateInstanceGroupImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceGroupImageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实例镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceImageResponse
        /// </returns>
        public UpdateInstanceImageResponse UpdateInstanceImageWithOptions(UpdateInstanceImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reset))
            {
                query["Reset"] = request.Reset;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceImage",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实例镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceImageResponse
        /// </returns>
        public async Task<UpdateInstanceImageResponse> UpdateInstanceImageWithOptionsAsync(UpdateInstanceImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reset))
            {
                query["Reset"] = request.Reset;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceImage",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实例镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceImageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceImageResponse
        /// </returns>
        public UpdateInstanceImageResponse UpdateInstanceImage(UpdateInstanceImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实例镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceImageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceImageResponse
        /// </returns>
        public async Task<UpdateInstanceImageResponse> UpdateInstanceImageAsync(UpdateInstanceImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceImageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades an instance group. Currently, this operation allows you to only increase the number of instances in an instance group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to only increase the size of an instance group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeAndroidInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeAndroidInstanceGroupResponse
        /// </returns>
        public UpgradeAndroidInstanceGroupResponse UpgradeAndroidInstanceGroupWithOptions(UpgradeAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncreaseNumberOfInstance))
            {
                query["IncreaseNumberOfInstance"] = request.IncreaseNumberOfInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeAndroidInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades an instance group. Currently, this operation allows you to only increase the number of instances in an instance group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to only increase the size of an instance group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeAndroidInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeAndroidInstanceGroupResponse
        /// </returns>
        public async Task<UpgradeAndroidInstanceGroupResponse> UpgradeAndroidInstanceGroupWithOptionsAsync(UpgradeAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncreaseNumberOfInstance))
            {
                query["IncreaseNumberOfInstance"] = request.IncreaseNumberOfInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeAndroidInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades an instance group. Currently, this operation allows you to only increase the number of instances in an instance group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to only increase the size of an instance group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeAndroidInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeAndroidInstanceGroupResponse
        /// </returns>
        public UpgradeAndroidInstanceGroupResponse UpgradeAndroidInstanceGroup(UpgradeAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeAndroidInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades an instance group. Currently, this operation allows you to only increase the number of instances in an instance group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, this operation allows you to only increase the size of an instance group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeAndroidInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeAndroidInstanceGroupResponse
        /// </returns>
        public async Task<UpgradeAndroidInstanceGroupResponse> UpgradeAndroidInstanceGroupAsync(UpgradeAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeAndroidInstanceGroupWithOptionsAsync(request, runtime);
        }

    }
}
