// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dbs20210101.Models;

namespace AlibabaCloud.SDK.Dbs20210101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-beijing", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-chengdu", "dbs-api.cn-chengdu.aliyuncs.com"},
                {"cn-zhangjiakou", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-huhehaote", "dbs-api.cn-huhehaote.aliyuncs.com"},
                {"cn-hangzhou", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-hongkong", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"ap-southeast-1", "dbs-api.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "dbs-api.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "dbs-api.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-5", "dbs-api.ap-southeast-5.aliyuncs.com"},
                {"ap-northeast-1", "dbs-api.ap-northeast-1.aliyuncs.com"},
                {"us-west-1", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"us-east-1", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"eu-central-1", "dbs-api.eu-central-1.aliyuncs.com"},
                {"cn-hangzhou-finance", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai-finance-1", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"ap-south-1", "dbs-api.ap-south-1.aliyuncs.com"},
                {"eu-west-1", "dbs-api.eu-west-1.aliyuncs.com"},
                {"me-east-1", "dbs-api.me-east-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("dbs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Moves a resource from one resource group to another.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moves a resource from one resource group to another.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moves a resource from one resource group to another.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moves a resource from one resource group to another.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置备份集信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfigureBackupSetInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigureBackupSetInfoResponse
        /// </returns>
        public ConfigureBackupSetInfoResponse ConfigureBackupSetInfoWithOptions(ConfigureBackupSetInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMethod))
            {
                query["BackupMethod"] = request.BackupMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMode))
            {
                query["BackupMode"] = request.BackupMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetName))
            {
                query["BackupSetName"] = request.BackupSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupType))
            {
                query["BackupType"] = request.BackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckSum))
            {
                query["CheckSum"] = request.CheckSum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraMeta))
            {
                query["ExtraMeta"] = request.ExtraMeta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadStatus))
            {
                query["UploadStatus"] = request.UploadStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureBackupSetInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureBackupSetInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置备份集信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfigureBackupSetInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigureBackupSetInfoResponse
        /// </returns>
        public async Task<ConfigureBackupSetInfoResponse> ConfigureBackupSetInfoWithOptionsAsync(ConfigureBackupSetInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMethod))
            {
                query["BackupMethod"] = request.BackupMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMode))
            {
                query["BackupMode"] = request.BackupMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetName))
            {
                query["BackupSetName"] = request.BackupSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupType))
            {
                query["BackupType"] = request.BackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckSum))
            {
                query["CheckSum"] = request.CheckSum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraMeta))
            {
                query["ExtraMeta"] = request.ExtraMeta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadStatus))
            {
                query["UploadStatus"] = request.UploadStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureBackupSetInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureBackupSetInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置备份集信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfigureBackupSetInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigureBackupSetInfoResponse
        /// </returns>
        public ConfigureBackupSetInfoResponse ConfigureBackupSetInfo(ConfigureBackupSetInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureBackupSetInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置备份集信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfigureBackupSetInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigureBackupSetInfoResponse
        /// </returns>
        public async Task<ConfigureBackupSetInfoResponse> ConfigureBackupSetInfoAsync(ConfigureBackupSetInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureBackupSetInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an advanced backup policy for a PolarDB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <para>PolarDB for MySQL</para>
        /// <remarks>
        /// <para> This API operation is available only to specific customers. If you want to call this API operation, join the Database Backup (DBS) DingTalk group (ID 35585947) for customer consultation to request permissions.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAdvancedPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAdvancedPolicyResponse
        /// </returns>
        public CreateAdvancedPolicyResponse CreateAdvancedPolicyWithOptions(CreateAdvancedPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAdvancedPolicy",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAdvancedPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an advanced backup policy for a PolarDB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <para>PolarDB for MySQL</para>
        /// <remarks>
        /// <para> This API operation is available only to specific customers. If you want to call this API operation, join the Database Backup (DBS) DingTalk group (ID 35585947) for customer consultation to request permissions.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAdvancedPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAdvancedPolicyResponse
        /// </returns>
        public async Task<CreateAdvancedPolicyResponse> CreateAdvancedPolicyWithOptionsAsync(CreateAdvancedPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAdvancedPolicy",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAdvancedPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an advanced backup policy for a PolarDB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <para>PolarDB for MySQL</para>
        /// <remarks>
        /// <para> This API operation is available only to specific customers. If you want to call this API operation, join the Database Backup (DBS) DingTalk group (ID 35585947) for customer consultation to request permissions.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAdvancedPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAdvancedPolicyResponse
        /// </returns>
        public CreateAdvancedPolicyResponse CreateAdvancedPolicy(CreateAdvancedPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAdvancedPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an advanced backup policy for a PolarDB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <para>PolarDB for MySQL</para>
        /// <remarks>
        /// <para> This API operation is available only to specific customers. If you want to call this API operation, join the Database Backup (DBS) DingTalk group (ID 35585947) for customer consultation to request permissions.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAdvancedPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAdvancedPolicyResponse
        /// </returns>
        public async Task<CreateAdvancedPolicyResponse> CreateAdvancedPolicyAsync(CreateAdvancedPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAdvancedPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an advanced download task for an ApsaraDB RDS for MySQL instance, an ApsaraDB RDS for PostgreSQL instance, or a PolarDB for MySQL cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// <h3><a href="#"></a>References</h3>
        /// <para>For the instances that meet your business requirements, you can create an advanced download task by point in time or backup set. You can set the download destination to a URL or directly upload the downloaded backup set to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving.</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/98819.html">Download the backup files of an ApsaraDB RDS for MySQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/96774.html">Download the backup files of an ApsaraDB RDS for PostgreSQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2627635.html">Download the backup files of a PolarDB for MySQL cluster</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDownloadRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDownloadResponse
        /// </returns>
        public CreateDownloadResponse CreateDownloadWithOptions(CreateDownloadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminDatabase))
            {
                query["AdminDatabase"] = request.AdminDatabase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BakSetId))
            {
                query["BakSetId"] = request.BakSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BakSetSize))
            {
                query["BakSetSize"] = request.BakSetSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BakSetType))
            {
                query["BakSetType"] = request.BakSetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadPointInTime))
            {
                query["DownloadPointInTime"] = request.DownloadPointInTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatType))
            {
                query["FormatType"] = request.FormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCluster))
            {
                query["IsCluster"] = request.IsCluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPhysical))
            {
                query["IsPhysical"] = request.IsPhysical;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKeyTypeOnly))
            {
                query["PrimaryKeyTypeOnly"] = request.PrimaryKeyTypeOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetBucket))
            {
                query["TargetBucket"] = request.TargetBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetOssRegion))
            {
                query["TargetOssRegion"] = request.TargetOssRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPath))
            {
                query["TargetPath"] = request.TargetPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseZstd))
            {
                query["UseZstd"] = request.UseZstd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDownload",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDownloadResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an advanced download task for an ApsaraDB RDS for MySQL instance, an ApsaraDB RDS for PostgreSQL instance, or a PolarDB for MySQL cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// <h3><a href="#"></a>References</h3>
        /// <para>For the instances that meet your business requirements, you can create an advanced download task by point in time or backup set. You can set the download destination to a URL or directly upload the downloaded backup set to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving.</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/98819.html">Download the backup files of an ApsaraDB RDS for MySQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/96774.html">Download the backup files of an ApsaraDB RDS for PostgreSQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2627635.html">Download the backup files of a PolarDB for MySQL cluster</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDownloadRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDownloadResponse
        /// </returns>
        public async Task<CreateDownloadResponse> CreateDownloadWithOptionsAsync(CreateDownloadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminDatabase))
            {
                query["AdminDatabase"] = request.AdminDatabase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BakSetId))
            {
                query["BakSetId"] = request.BakSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BakSetSize))
            {
                query["BakSetSize"] = request.BakSetSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BakSetType))
            {
                query["BakSetType"] = request.BakSetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadPointInTime))
            {
                query["DownloadPointInTime"] = request.DownloadPointInTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatType))
            {
                query["FormatType"] = request.FormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCluster))
            {
                query["IsCluster"] = request.IsCluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPhysical))
            {
                query["IsPhysical"] = request.IsPhysical;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKeyTypeOnly))
            {
                query["PrimaryKeyTypeOnly"] = request.PrimaryKeyTypeOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetBucket))
            {
                query["TargetBucket"] = request.TargetBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetOssRegion))
            {
                query["TargetOssRegion"] = request.TargetOssRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPath))
            {
                query["TargetPath"] = request.TargetPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseZstd))
            {
                query["UseZstd"] = request.UseZstd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDownload",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDownloadResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an advanced download task for an ApsaraDB RDS for MySQL instance, an ApsaraDB RDS for PostgreSQL instance, or a PolarDB for MySQL cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// <h3><a href="#"></a>References</h3>
        /// <para>For the instances that meet your business requirements, you can create an advanced download task by point in time or backup set. You can set the download destination to a URL or directly upload the downloaded backup set to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving.</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/98819.html">Download the backup files of an ApsaraDB RDS for MySQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/96774.html">Download the backup files of an ApsaraDB RDS for PostgreSQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2627635.html">Download the backup files of a PolarDB for MySQL cluster</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDownloadRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDownloadResponse
        /// </returns>
        public CreateDownloadResponse CreateDownload(CreateDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDownloadWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an advanced download task for an ApsaraDB RDS for MySQL instance, an ApsaraDB RDS for PostgreSQL instance, or a PolarDB for MySQL cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// <h3><a href="#"></a>References</h3>
        /// <para>For the instances that meet your business requirements, you can create an advanced download task by point in time or backup set. You can set the download destination to a URL or directly upload the downloaded backup set to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving.</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/98819.html">Download the backup files of an ApsaraDB RDS for MySQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/96774.html">Download the backup files of an ApsaraDB RDS for PostgreSQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2627635.html">Download the backup files of a PolarDB for MySQL cluster</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDownloadRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDownloadResponse
        /// </returns>
        public async Task<CreateDownloadResponse> CreateDownloadAsync(CreateDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDownloadWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a sandbox instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSandboxInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSandboxInstanceResponse
        /// </returns>
        public DeleteSandboxInstanceResponse DeleteSandboxInstanceWithOptions(DeleteSandboxInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteSandboxInstance",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSandboxInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a sandbox instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSandboxInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSandboxInstanceResponse
        /// </returns>
        public async Task<DeleteSandboxInstanceResponse> DeleteSandboxInstanceWithOptionsAsync(DeleteSandboxInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteSandboxInstance",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSandboxInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a sandbox instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSandboxInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSandboxInstanceResponse
        /// </returns>
        public DeleteSandboxInstanceResponse DeleteSandboxInstance(DeleteSandboxInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSandboxInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a sandbox instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSandboxInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSandboxInstanceResponse
        /// </returns>
        public async Task<DeleteSandboxInstanceResponse> DeleteSandboxInstanceAsync(DeleteSandboxInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSandboxInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the backup data of a PolarDB for MySQL cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engine</h3>
        /// <para>PolarDB for MySQL</para>
        /// <remarks>
        /// <para> This API operation is available only to specific customers. If you want to call this API operation, join the Database Backup (DBS) DingTalk group (ID: 35585947) for customer consultation to request permissions.</para>
        /// </remarks>
        /// <h3><a href="#"></a>References</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/88172.html">Back up data of PolarDB for MySQL</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBackupDataListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupDataListResponse
        /// </returns>
        public DescribeBackupDataListResponse DescribeBackupDataListWithOptions(DescribeBackupDataListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMethod))
            {
                query["BackupMethod"] = request.BackupMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMode))
            {
                query["BackupMode"] = request.BackupMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupScale))
            {
                query["BackupScale"] = request.BackupScale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStatus))
            {
                query["BackupStatus"] = request.BackupStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupType))
            {
                query["BackupType"] = request.BackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIsDeleted))
            {
                query["InstanceIsDeleted"] = request.InstanceIsDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceRegion))
            {
                query["InstanceRegion"] = request.InstanceRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
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
                Action = "DescribeBackupDataList",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupDataListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the backup data of a PolarDB for MySQL cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engine</h3>
        /// <para>PolarDB for MySQL</para>
        /// <remarks>
        /// <para> This API operation is available only to specific customers. If you want to call this API operation, join the Database Backup (DBS) DingTalk group (ID: 35585947) for customer consultation to request permissions.</para>
        /// </remarks>
        /// <h3><a href="#"></a>References</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/88172.html">Back up data of PolarDB for MySQL</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBackupDataListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupDataListResponse
        /// </returns>
        public async Task<DescribeBackupDataListResponse> DescribeBackupDataListWithOptionsAsync(DescribeBackupDataListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMethod))
            {
                query["BackupMethod"] = request.BackupMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMode))
            {
                query["BackupMode"] = request.BackupMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupScale))
            {
                query["BackupScale"] = request.BackupScale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStatus))
            {
                query["BackupStatus"] = request.BackupStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupType))
            {
                query["BackupType"] = request.BackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIsDeleted))
            {
                query["InstanceIsDeleted"] = request.InstanceIsDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceRegion))
            {
                query["InstanceRegion"] = request.InstanceRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
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
                Action = "DescribeBackupDataList",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupDataListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the backup data of a PolarDB for MySQL cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engine</h3>
        /// <para>PolarDB for MySQL</para>
        /// <remarks>
        /// <para> This API operation is available only to specific customers. If you want to call this API operation, join the Database Backup (DBS) DingTalk group (ID: 35585947) for customer consultation to request permissions.</para>
        /// </remarks>
        /// <h3><a href="#"></a>References</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/88172.html">Back up data of PolarDB for MySQL</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBackupDataListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupDataListResponse
        /// </returns>
        public DescribeBackupDataListResponse DescribeBackupDataList(DescribeBackupDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupDataListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the backup data of a PolarDB for MySQL cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engine</h3>
        /// <para>PolarDB for MySQL</para>
        /// <remarks>
        /// <para> This API operation is available only to specific customers. If you want to call this API operation, join the Database Backup (DBS) DingTalk group (ID: 35585947) for customer consultation to request permissions.</para>
        /// </remarks>
        /// <h3><a href="#"></a>References</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/88172.html">Back up data of PolarDB for MySQL</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBackupDataListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupDataListResponse
        /// </returns>
        public async Task<DescribeBackupDataListResponse> DescribeBackupDataListAsync(DescribeBackupDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupDataListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the backup policy of a PolarDB for MySQL instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engine</h3>
        /// <para>PolarDB for MySQL</para>
        /// <remarks>
        /// <para> The API operation is available only to specific customers. If you want to call this API operation, request permissions by joining the Database Backup (DBS) DingTalk group (ID 35585947) for customer consultation.</para>
        /// </remarks>
        /// <h3><a href="#"></a>References</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/280422.html">Topics related to backup policies of PolarDB for MySQL instances</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBackupPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPolicyResponse
        /// </returns>
        public DescribeBackupPolicyResponse DescribeBackupPolicyWithOptions(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPolicy",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the backup policy of a PolarDB for MySQL instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engine</h3>
        /// <para>PolarDB for MySQL</para>
        /// <remarks>
        /// <para> The API operation is available only to specific customers. If you want to call this API operation, request permissions by joining the Database Backup (DBS) DingTalk group (ID 35585947) for customer consultation.</para>
        /// </remarks>
        /// <h3><a href="#"></a>References</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/280422.html">Topics related to backup policies of PolarDB for MySQL instances</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBackupPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPolicyResponse
        /// </returns>
        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyWithOptionsAsync(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPolicy",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the backup policy of a PolarDB for MySQL instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engine</h3>
        /// <para>PolarDB for MySQL</para>
        /// <remarks>
        /// <para> The API operation is available only to specific customers. If you want to call this API operation, request permissions by joining the Database Backup (DBS) DingTalk group (ID 35585947) for customer consultation.</para>
        /// </remarks>
        /// <h3><a href="#"></a>References</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/280422.html">Topics related to backup policies of PolarDB for MySQL instances</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBackupPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPolicyResponse
        /// </returns>
        public DescribeBackupPolicyResponse DescribeBackupPolicy(DescribeBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the backup policy of a PolarDB for MySQL instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engine</h3>
        /// <para>PolarDB for MySQL</para>
        /// <remarks>
        /// <para> The API operation is available only to specific customers. If you want to call this API operation, request permissions by joining the Database Backup (DBS) DingTalk group (ID 35585947) for customer consultation.</para>
        /// </remarks>
        /// <h3><a href="#"></a>References</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/280422.html">Topics related to backup policies of PolarDB for MySQL instances</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBackupPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPolicyResponse
        /// </returns>
        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyAsync(DescribeBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询存储介质访问详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBakDataSourceStorageAccessInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBakDataSourceStorageAccessInfoResponse
        /// </returns>
        public DescribeBakDataSourceStorageAccessInfoResponse DescribeBakDataSourceStorageAccessInfoWithOptions(DescribeBakDataSourceStorageAccessInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupType))
            {
                query["BackupType"] = request.BackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                query["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBakDataSourceStorageAccessInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBakDataSourceStorageAccessInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询存储介质访问详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBakDataSourceStorageAccessInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBakDataSourceStorageAccessInfoResponse
        /// </returns>
        public async Task<DescribeBakDataSourceStorageAccessInfoResponse> DescribeBakDataSourceStorageAccessInfoWithOptionsAsync(DescribeBakDataSourceStorageAccessInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupType))
            {
                query["BackupType"] = request.BackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                query["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBakDataSourceStorageAccessInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBakDataSourceStorageAccessInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询存储介质访问详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBakDataSourceStorageAccessInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBakDataSourceStorageAccessInfoResponse
        /// </returns>
        public DescribeBakDataSourceStorageAccessInfoResponse DescribeBakDataSourceStorageAccessInfo(DescribeBakDataSourceStorageAccessInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBakDataSourceStorageAccessInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询存储介质访问详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBakDataSourceStorageAccessInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBakDataSourceStorageAccessInfoResponse
        /// </returns>
        public async Task<DescribeBakDataSourceStorageAccessInfoResponse> DescribeBakDataSourceStorageAccessInfoAsync(DescribeBakDataSourceStorageAccessInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBakDataSourceStorageAccessInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据dbs实例id获取费用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCostInfoByDbsInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostInfoByDbsInstanceResponse
        /// </returns>
        public DescribeCostInfoByDbsInstanceResponse DescribeCostInfoByDbsInstanceWithOptions(DescribeCostInfoByDbsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCostInfoByDbsInstance",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCostInfoByDbsInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据dbs实例id获取费用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCostInfoByDbsInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostInfoByDbsInstanceResponse
        /// </returns>
        public async Task<DescribeCostInfoByDbsInstanceResponse> DescribeCostInfoByDbsInstanceWithOptionsAsync(DescribeCostInfoByDbsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCostInfoByDbsInstance",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCostInfoByDbsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据dbs实例id获取费用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCostInfoByDbsInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostInfoByDbsInstanceResponse
        /// </returns>
        public DescribeCostInfoByDbsInstanceResponse DescribeCostInfoByDbsInstance(DescribeCostInfoByDbsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCostInfoByDbsInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据dbs实例id获取费用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCostInfoByDbsInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostInfoByDbsInstanceResponse
        /// </returns>
        public async Task<DescribeCostInfoByDbsInstanceResponse> DescribeCostInfoByDbsInstanceAsync(DescribeCostInfoByDbsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCostInfoByDbsInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查库表恢复可用的备份集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBTablesRecoveryBackupSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBTablesRecoveryBackupSetResponse
        /// </returns>
        public DescribeDBTablesRecoveryBackupSetResponse DescribeDBTablesRecoveryBackupSetWithOptions(DescribeDBTablesRecoveryBackupSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBTablesRecoveryBackupSet",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBTablesRecoveryBackupSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查库表恢复可用的备份集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBTablesRecoveryBackupSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBTablesRecoveryBackupSetResponse
        /// </returns>
        public async Task<DescribeDBTablesRecoveryBackupSetResponse> DescribeDBTablesRecoveryBackupSetWithOptionsAsync(DescribeDBTablesRecoveryBackupSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBTablesRecoveryBackupSet",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBTablesRecoveryBackupSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查库表恢复可用的备份集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBTablesRecoveryBackupSetRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBTablesRecoveryBackupSetResponse
        /// </returns>
        public DescribeDBTablesRecoveryBackupSetResponse DescribeDBTablesRecoveryBackupSet(DescribeDBTablesRecoveryBackupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBTablesRecoveryBackupSetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查库表恢复可用的备份集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBTablesRecoveryBackupSetRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBTablesRecoveryBackupSetResponse
        /// </returns>
        public async Task<DescribeDBTablesRecoveryBackupSetResponse> DescribeDBTablesRecoveryBackupSetAsync(DescribeDBTablesRecoveryBackupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBTablesRecoveryBackupSetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查库表恢复状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBTablesRecoveryStateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBTablesRecoveryStateResponse
        /// </returns>
        public DescribeDBTablesRecoveryStateResponse DescribeDBTablesRecoveryStateWithOptions(DescribeDBTablesRecoveryStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBTablesRecoveryState",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBTablesRecoveryStateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查库表恢复状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBTablesRecoveryStateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBTablesRecoveryStateResponse
        /// </returns>
        public async Task<DescribeDBTablesRecoveryStateResponse> DescribeDBTablesRecoveryStateWithOptionsAsync(DescribeDBTablesRecoveryStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBTablesRecoveryState",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBTablesRecoveryStateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查库表恢复状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBTablesRecoveryStateRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBTablesRecoveryStateResponse
        /// </returns>
        public DescribeDBTablesRecoveryStateResponse DescribeDBTablesRecoveryState(DescribeDBTablesRecoveryStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBTablesRecoveryStateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查库表恢复状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBTablesRecoveryStateRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBTablesRecoveryStateResponse
        /// </returns>
        public async Task<DescribeDBTablesRecoveryStateResponse> DescribeDBTablesRecoveryStateAsync(DescribeDBTablesRecoveryStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBTablesRecoveryStateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查库表恢复可恢复的时间范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBTablesRecoveryTimeRangeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBTablesRecoveryTimeRangeResponse
        /// </returns>
        public DescribeDBTablesRecoveryTimeRangeResponse DescribeDBTablesRecoveryTimeRangeWithOptions(DescribeDBTablesRecoveryTimeRangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBTablesRecoveryTimeRange",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBTablesRecoveryTimeRangeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查库表恢复可恢复的时间范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBTablesRecoveryTimeRangeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBTablesRecoveryTimeRangeResponse
        /// </returns>
        public async Task<DescribeDBTablesRecoveryTimeRangeResponse> DescribeDBTablesRecoveryTimeRangeWithOptionsAsync(DescribeDBTablesRecoveryTimeRangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBTablesRecoveryTimeRange",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBTablesRecoveryTimeRangeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查库表恢复可恢复的时间范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBTablesRecoveryTimeRangeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBTablesRecoveryTimeRangeResponse
        /// </returns>
        public DescribeDBTablesRecoveryTimeRangeResponse DescribeDBTablesRecoveryTimeRange(DescribeDBTablesRecoveryTimeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBTablesRecoveryTimeRangeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查库表恢复可恢复的时间范围</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBTablesRecoveryTimeRangeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBTablesRecoveryTimeRangeResponse
        /// </returns>
        public async Task<DescribeDBTablesRecoveryTimeRangeResponse> DescribeDBTablesRecoveryTimeRangeAsync(DescribeDBTablesRecoveryTimeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBTablesRecoveryTimeRangeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage information of a downloaded backup set.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL that uses Enterprise SSDs (ESSDs)</description></item>
        /// <item><description>RDS PostgreSQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// <h3><a href="#"></a>References</h3>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/98819.html">Download the backup files of an ApsaraDB RDS for MySQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/96774.html">Download the backup files of an ApsaraDB RDS for PostgreSQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2627635.html">Download the backup files of a PolarDB for MySQL cluster</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDownloadBackupSetStorageInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadBackupSetStorageInfoResponse
        /// </returns>
        public DescribeDownloadBackupSetStorageInfoResponse DescribeDownloadBackupSetStorageInfoWithOptions(DescribeDownloadBackupSetStorageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDownloadBackupSetStorageInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadBackupSetStorageInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage information of a downloaded backup set.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL that uses Enterprise SSDs (ESSDs)</description></item>
        /// <item><description>RDS PostgreSQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// <h3><a href="#"></a>References</h3>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/98819.html">Download the backup files of an ApsaraDB RDS for MySQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/96774.html">Download the backup files of an ApsaraDB RDS for PostgreSQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2627635.html">Download the backup files of a PolarDB for MySQL cluster</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDownloadBackupSetStorageInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadBackupSetStorageInfoResponse
        /// </returns>
        public async Task<DescribeDownloadBackupSetStorageInfoResponse> DescribeDownloadBackupSetStorageInfoWithOptionsAsync(DescribeDownloadBackupSetStorageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDownloadBackupSetStorageInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadBackupSetStorageInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage information of a downloaded backup set.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL that uses Enterprise SSDs (ESSDs)</description></item>
        /// <item><description>RDS PostgreSQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// <h3><a href="#"></a>References</h3>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/98819.html">Download the backup files of an ApsaraDB RDS for MySQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/96774.html">Download the backup files of an ApsaraDB RDS for PostgreSQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2627635.html">Download the backup files of a PolarDB for MySQL cluster</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDownloadBackupSetStorageInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadBackupSetStorageInfoResponse
        /// </returns>
        public DescribeDownloadBackupSetStorageInfoResponse DescribeDownloadBackupSetStorageInfo(DescribeDownloadBackupSetStorageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDownloadBackupSetStorageInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage information of a downloaded backup set.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL that uses Enterprise SSDs (ESSDs)</description></item>
        /// <item><description>RDS PostgreSQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// <h3><a href="#"></a>References</h3>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/98819.html">Download the backup files of an ApsaraDB RDS for MySQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/96774.html">Download the backup files of an ApsaraDB RDS for PostgreSQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2627635.html">Download the backup files of a PolarDB for MySQL cluster</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDownloadBackupSetStorageInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadBackupSetStorageInfoResponse
        /// </returns>
        public async Task<DescribeDownloadBackupSetStorageInfoResponse> DescribeDownloadBackupSetStorageInfoAsync(DescribeDownloadBackupSetStorageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDownloadBackupSetStorageInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether an instance supports the advanced download feature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// <h3><a href="#"></a>References</h3>
        /// <para>You can create an advanced download task by point in time or backup set. You can set the download destination to a URL or directly upload the downloaded backup set to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving.</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/98819.html">Download the backup files of an ApsaraDB RDS for MySQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/96774.html">Download the backup files of an ApsaraDB RDS for PostgreSQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2627635.html">Download the backup files of a PolarDB for MySQL cluster</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDownloadSupportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadSupportResponse
        /// </returns>
        public DescribeDownloadSupportResponse DescribeDownloadSupportWithOptions(DescribeDownloadSupportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDownloadSupport",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadSupportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether an instance supports the advanced download feature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// <h3><a href="#"></a>References</h3>
        /// <para>You can create an advanced download task by point in time or backup set. You can set the download destination to a URL or directly upload the downloaded backup set to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving.</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/98819.html">Download the backup files of an ApsaraDB RDS for MySQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/96774.html">Download the backup files of an ApsaraDB RDS for PostgreSQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2627635.html">Download the backup files of a PolarDB for MySQL cluster</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDownloadSupportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadSupportResponse
        /// </returns>
        public async Task<DescribeDownloadSupportResponse> DescribeDownloadSupportWithOptionsAsync(DescribeDownloadSupportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDownloadSupport",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadSupportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether an instance supports the advanced download feature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// <h3><a href="#"></a>References</h3>
        /// <para>You can create an advanced download task by point in time or backup set. You can set the download destination to a URL or directly upload the downloaded backup set to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving.</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/98819.html">Download the backup files of an ApsaraDB RDS for MySQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/96774.html">Download the backup files of an ApsaraDB RDS for PostgreSQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2627635.html">Download the backup files of a PolarDB for MySQL cluster</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDownloadSupportRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadSupportResponse
        /// </returns>
        public DescribeDownloadSupportResponse DescribeDownloadSupport(DescribeDownloadSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDownloadSupportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether an instance supports the advanced download feature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// <h3><a href="#"></a>References</h3>
        /// <para>You can create an advanced download task by point in time or backup set. You can set the download destination to a URL or directly upload the downloaded backup set to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving.</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/98819.html">Download the backup files of an ApsaraDB RDS for MySQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/96774.html">Download the backup files of an ApsaraDB RDS for PostgreSQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2627635.html">Download the backup files of a PolarDB for MySQL cluster</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDownloadSupportRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadSupportResponse
        /// </returns>
        public async Task<DescribeDownloadSupportResponse> DescribeDownloadSupportAsync(DescribeDownloadSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDownloadSupportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the advanced download tasks for an ApsaraDB RDS for MySQL instance, an ApsaraDB RDS for PostgreSQL instance, or a PolarDB for MySQL cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// <h3><a href="#"></a>References</h3>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/98819.html">Download the backup files of an ApsaraDB RDS for MySQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/96774.html">Download the backup files of an ApsaraDB RDS for PostgreSQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2627635.html">Download the backup files of a PolarDB for MySQL cluster</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDownloadTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadTaskResponse
        /// </returns>
        public DescribeDownloadTaskResponse DescribeDownloadTaskWithOptions(DescribeDownloadTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceId))
            {
                query["DatasourceId"] = request.DatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["OrderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirect))
            {
                query["OrderDirect"] = request.OrderDirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDownloadTask",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the advanced download tasks for an ApsaraDB RDS for MySQL instance, an ApsaraDB RDS for PostgreSQL instance, or a PolarDB for MySQL cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// <h3><a href="#"></a>References</h3>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/98819.html">Download the backup files of an ApsaraDB RDS for MySQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/96774.html">Download the backup files of an ApsaraDB RDS for PostgreSQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2627635.html">Download the backup files of a PolarDB for MySQL cluster</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDownloadTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadTaskResponse
        /// </returns>
        public async Task<DescribeDownloadTaskResponse> DescribeDownloadTaskWithOptionsAsync(DescribeDownloadTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceId))
            {
                query["DatasourceId"] = request.DatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["OrderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirect))
            {
                query["OrderDirect"] = request.OrderDirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDownloadTask",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the advanced download tasks for an ApsaraDB RDS for MySQL instance, an ApsaraDB RDS for PostgreSQL instance, or a PolarDB for MySQL cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// <h3><a href="#"></a>References</h3>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/98819.html">Download the backup files of an ApsaraDB RDS for MySQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/96774.html">Download the backup files of an ApsaraDB RDS for PostgreSQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2627635.html">Download the backup files of a PolarDB for MySQL cluster</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDownloadTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadTaskResponse
        /// </returns>
        public DescribeDownloadTaskResponse DescribeDownloadTask(DescribeDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDownloadTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the advanced download tasks for an ApsaraDB RDS for MySQL instance, an ApsaraDB RDS for PostgreSQL instance, or a PolarDB for MySQL cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// <h3><a href="#"></a>References</h3>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/98819.html">Download the backup files of an ApsaraDB RDS for MySQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/96774.html">Download the backup files of an ApsaraDB RDS for PostgreSQL instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/2627635.html">Download the backup files of a PolarDB for MySQL cluster</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDownloadTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDownloadTaskResponse
        /// </returns>
        public async Task<DescribeDownloadTaskResponse> DescribeDownloadTaskAsync(DescribeDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDownloadTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the snapshots of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/203154.html">Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance</a> or <a href="https://help.aliyun.com/document_detail/185577.html">Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database</a>. This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSandboxBackupSetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSandboxBackupSetsResponse
        /// </returns>
        public DescribeSandboxBackupSetsResponse DescribeSandboxBackupSetsWithOptions(DescribeSandboxBackupSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSandboxBackupSets",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSandboxBackupSetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the snapshots of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/203154.html">Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance</a> or <a href="https://help.aliyun.com/document_detail/185577.html">Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database</a>. This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSandboxBackupSetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSandboxBackupSetsResponse
        /// </returns>
        public async Task<DescribeSandboxBackupSetsResponse> DescribeSandboxBackupSetsWithOptionsAsync(DescribeSandboxBackupSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSandboxBackupSets",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSandboxBackupSetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the snapshots of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/203154.html">Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance</a> or <a href="https://help.aliyun.com/document_detail/185577.html">Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database</a>. This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSandboxBackupSetsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSandboxBackupSetsResponse
        /// </returns>
        public DescribeSandboxBackupSetsResponse DescribeSandboxBackupSets(DescribeSandboxBackupSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSandboxBackupSetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the snapshots of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/203154.html">Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance</a> or <a href="https://help.aliyun.com/document_detail/185577.html">Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database</a>. This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSandboxBackupSetsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSandboxBackupSetsResponse
        /// </returns>
        public async Task<DescribeSandboxBackupSetsResponse> DescribeSandboxBackupSetsAsync(DescribeSandboxBackupSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSandboxBackupSetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries sandbox instances that are created within an account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSandboxInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSandboxInstancesResponse
        /// </returns>
        public DescribeSandboxInstancesResponse DescribeSandboxInstancesWithOptions(DescribeSandboxInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSandboxInstances",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSandboxInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries sandbox instances that are created within an account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSandboxInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSandboxInstancesResponse
        /// </returns>
        public async Task<DescribeSandboxInstancesResponse> DescribeSandboxInstancesWithOptionsAsync(DescribeSandboxInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSandboxInstances",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSandboxInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries sandbox instances that are created within an account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSandboxInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSandboxInstancesResponse
        /// </returns>
        public DescribeSandboxInstancesResponse DescribeSandboxInstances(DescribeSandboxInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSandboxInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries sandbox instances that are created within an account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSandboxInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSandboxInstancesResponse
        /// </returns>
        public async Task<DescribeSandboxInstancesResponse> DescribeSandboxInstancesAsync(DescribeSandboxInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSandboxInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the recoverable time range of a sandbox instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/203154.html">Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance</a> or <a href="https://help.aliyun.com/document_detail/185577.html">Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database</a>. This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSandboxRecoveryTimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSandboxRecoveryTimeResponse
        /// </returns>
        public DescribeSandboxRecoveryTimeResponse DescribeSandboxRecoveryTimeWithOptions(DescribeSandboxRecoveryTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSandboxRecoveryTime",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSandboxRecoveryTimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the recoverable time range of a sandbox instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/203154.html">Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance</a> or <a href="https://help.aliyun.com/document_detail/185577.html">Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database</a>. This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSandboxRecoveryTimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSandboxRecoveryTimeResponse
        /// </returns>
        public async Task<DescribeSandboxRecoveryTimeResponse> DescribeSandboxRecoveryTimeWithOptionsAsync(DescribeSandboxRecoveryTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSandboxRecoveryTime",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSandboxRecoveryTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the recoverable time range of a sandbox instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/203154.html">Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance</a> or <a href="https://help.aliyun.com/document_detail/185577.html">Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database</a>. This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSandboxRecoveryTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSandboxRecoveryTimeResponse
        /// </returns>
        public DescribeSandboxRecoveryTimeResponse DescribeSandboxRecoveryTime(DescribeSandboxRecoveryTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSandboxRecoveryTimeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the recoverable time range of a sandbox instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/203154.html">Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance</a> or <a href="https://help.aliyun.com/document_detail/185577.html">Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database</a>. This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSandboxRecoveryTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSandboxRecoveryTimeResponse
        /// </returns>
        public async Task<DescribeSandboxRecoveryTimeResponse> DescribeSandboxRecoveryTimeAsync(DescribeSandboxRecoveryTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSandboxRecoveryTimeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the backup policy of a PolarDB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <para>PolarDB for MySQL</para>
        /// <remarks>
        /// <para> This API operation is available only to specific customers. If you want to call this API operation, join the Database Backup (DBS) DingTalk group (ID 35585947) for customer consultation to request permissions.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyBackupPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupPolicyResponse
        /// </returns>
        public ModifyBackupPolicyResponse ModifyBackupPolicyWithOptions(ModifyBackupPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyBackupPolicyShrinkRequest request = new ModifyBackupPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdvanceDataPolicies))
            {
                request.AdvanceDataPoliciesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdvanceDataPolicies, "AdvanceDataPolicies", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdvanceIncPolicies))
            {
                request.AdvanceIncPoliciesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdvanceIncPolicies, "AdvanceIncPolicies", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdvanceLogPolicies))
            {
                request.AdvanceLogPoliciesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdvanceLogPolicies, "AdvanceLogPolicies", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvanceDataPoliciesShrink))
            {
                query["AdvanceDataPolicies"] = request.AdvanceDataPoliciesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvanceIncPoliciesShrink))
            {
                query["AdvanceIncPolicies"] = request.AdvanceIncPoliciesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvanceLogPoliciesShrink))
            {
                query["AdvanceLogPolicies"] = request.AdvanceLogPoliciesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMethod))
            {
                query["BackupMethod"] = request.BackupMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPriority))
            {
                query["BackupPriority"] = request.BackupPriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRetentionPolicyOnClusterDeletion))
            {
                query["BackupRetentionPolicyOnClusterDeletion"] = request.BackupRetentionPolicyOnClusterDeletion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIncBackup))
            {
                query["EnableIncBackup"] = request.EnableIncBackup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredBackupWindowBegin))
            {
                query["PreferredBackupWindowBegin"] = request.PreferredBackupWindowBegin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupPolicy",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the backup policy of a PolarDB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <para>PolarDB for MySQL</para>
        /// <remarks>
        /// <para> This API operation is available only to specific customers. If you want to call this API operation, join the Database Backup (DBS) DingTalk group (ID 35585947) for customer consultation to request permissions.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyBackupPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupPolicyResponse
        /// </returns>
        public async Task<ModifyBackupPolicyResponse> ModifyBackupPolicyWithOptionsAsync(ModifyBackupPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyBackupPolicyShrinkRequest request = new ModifyBackupPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdvanceDataPolicies))
            {
                request.AdvanceDataPoliciesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdvanceDataPolicies, "AdvanceDataPolicies", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdvanceIncPolicies))
            {
                request.AdvanceIncPoliciesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdvanceIncPolicies, "AdvanceIncPolicies", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdvanceLogPolicies))
            {
                request.AdvanceLogPoliciesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdvanceLogPolicies, "AdvanceLogPolicies", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvanceDataPoliciesShrink))
            {
                query["AdvanceDataPolicies"] = request.AdvanceDataPoliciesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvanceIncPoliciesShrink))
            {
                query["AdvanceIncPolicies"] = request.AdvanceIncPoliciesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvanceLogPoliciesShrink))
            {
                query["AdvanceLogPolicies"] = request.AdvanceLogPoliciesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMethod))
            {
                query["BackupMethod"] = request.BackupMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPriority))
            {
                query["BackupPriority"] = request.BackupPriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRetentionPolicyOnClusterDeletion))
            {
                query["BackupRetentionPolicyOnClusterDeletion"] = request.BackupRetentionPolicyOnClusterDeletion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIncBackup))
            {
                query["EnableIncBackup"] = request.EnableIncBackup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredBackupWindowBegin))
            {
                query["PreferredBackupWindowBegin"] = request.PreferredBackupWindowBegin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupPolicy",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the backup policy of a PolarDB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <para>PolarDB for MySQL</para>
        /// <remarks>
        /// <para> This API operation is available only to specific customers. If you want to call this API operation, join the Database Backup (DBS) DingTalk group (ID 35585947) for customer consultation to request permissions.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyBackupPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupPolicyResponse
        /// </returns>
        public ModifyBackupPolicyResponse ModifyBackupPolicy(ModifyBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the backup policy of a PolarDB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Supported database engines</h3>
        /// <para>PolarDB for MySQL</para>
        /// <remarks>
        /// <para> This API operation is available only to specific customers. If you want to call this API operation, join the Database Backup (DBS) DingTalk group (ID 35585947) for customer consultation to request permissions.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyBackupPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupPolicyResponse
        /// </returns>
        public async Task<ModifyBackupPolicyResponse> ModifyBackupPolicyAsync(ModifyBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改库表恢复状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDBTablesRecoveryStateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDBTablesRecoveryStateResponse
        /// </returns>
        public ModifyDBTablesRecoveryStateResponse ModifyDBTablesRecoveryStateWithOptions(ModifyDBTablesRecoveryStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retention))
            {
                query["Retention"] = request.Retention;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBTablesRecoveryState",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBTablesRecoveryStateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改库表恢复状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDBTablesRecoveryStateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDBTablesRecoveryStateResponse
        /// </returns>
        public async Task<ModifyDBTablesRecoveryStateResponse> ModifyDBTablesRecoveryStateWithOptionsAsync(ModifyDBTablesRecoveryStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retention))
            {
                query["Retention"] = request.Retention;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBTablesRecoveryState",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBTablesRecoveryStateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改库表恢复状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDBTablesRecoveryStateRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDBTablesRecoveryStateResponse
        /// </returns>
        public ModifyDBTablesRecoveryStateResponse ModifyDBTablesRecoveryState(ModifyDBTablesRecoveryStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBTablesRecoveryStateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改库表恢复状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDBTablesRecoveryStateRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDBTablesRecoveryStateResponse
        /// </returns>
        public async Task<ModifyDBTablesRecoveryStateResponse> ModifyDBTablesRecoveryStateAsync(ModifyDBTablesRecoveryStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBTablesRecoveryStateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重试高级下载任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetryDownloadTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetryDownloadTaskResponse
        /// </returns>
        public RetryDownloadTaskResponse RetryDownloadTaskWithOptions(RetryDownloadTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryDownloadTask",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryDownloadTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重试高级下载任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetryDownloadTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetryDownloadTaskResponse
        /// </returns>
        public async Task<RetryDownloadTaskResponse> RetryDownloadTaskWithOptionsAsync(RetryDownloadTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryDownloadTask",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryDownloadTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重试高级下载任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetryDownloadTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// RetryDownloadTaskResponse
        /// </returns>
        public RetryDownloadTaskResponse RetryDownloadTask(RetryDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetryDownloadTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重试高级下载任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetryDownloadTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// RetryDownloadTaskResponse
        /// </returns>
        public async Task<RetryDownloadTaskResponse> RetryDownloadTaskAsync(RetryDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetryDownloadTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询是否支持库表恢复</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SupportDBTableRecoveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SupportDBTableRecoveryResponse
        /// </returns>
        public SupportDBTableRecoveryResponse SupportDBTableRecoveryWithOptions(SupportDBTableRecoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SupportDBTableRecovery",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupportDBTableRecoveryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询是否支持库表恢复</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SupportDBTableRecoveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SupportDBTableRecoveryResponse
        /// </returns>
        public async Task<SupportDBTableRecoveryResponse> SupportDBTableRecoveryWithOptionsAsync(SupportDBTableRecoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SupportDBTableRecovery",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupportDBTableRecoveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询是否支持库表恢复</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SupportDBTableRecoveryRequest
        /// </param>
        /// 
        /// <returns>
        /// SupportDBTableRecoveryResponse
        /// </returns>
        public SupportDBTableRecoveryResponse SupportDBTableRecovery(SupportDBTableRecoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SupportDBTableRecoveryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询是否支持库表恢复</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SupportDBTableRecoveryRequest
        /// </param>
        /// 
        /// <returns>
        /// SupportDBTableRecoveryResponse
        /// </returns>
        public async Task<SupportDBTableRecoveryResponse> SupportDBTableRecoveryAsync(SupportDBTableRecoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SupportDBTableRecoveryWithOptionsAsync(request, runtime);
        }

    }
}
