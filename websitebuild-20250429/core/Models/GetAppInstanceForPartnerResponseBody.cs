// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppInstanceForPartnerResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why access was denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether retry is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dewuApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message, which is used to replace the <c>%s</c> in the <b>ErrMessage</b> response parameter.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, the value of the <b>DtsJobId</b> request parameter is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://check-result-file-sh.oss-cn-shanghai.aliyuncs.com/gl3d6l3817id8p1/gl3d6l3817id8p1.diff.zip?Expires=1750392068&OSSAccessKeyId=LTAI5tKUErVCETM4ev9SELNb&Signature=Bcj3eohy8nmlSQ7AAGdq7JZoLjM%3D">https://check-result-file-sh.oss-cn-shanghai.aliyuncs.com/gl3d6l3817id8p1/gl3d6l3817id8p1.diff.zip?Expires=1750392068&amp;OSSAccessKeyId=LTAI5tKUErVCETM4ev9SELNb&amp;Signature=Bcj3eohy8nmlSQ7AAGdq7JZoLjM%3D</a></para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error parameters.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetAppInstanceForPartnerResponseBodyModule Module { get; set; }
        public class GetAppInstanceForPartnerResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of AI staff members associated with the application.</para>
            /// </summary>
            [NameInMap("AiStaffList")]
            [Validation(Required=false)]
            public List<GetAppInstanceForPartnerResponseBodyModuleAiStaffList> AiStaffList { get; set; }
            public class GetAppInstanceForPartnerResponseBodyModuleAiStaffList : TeaModel {
                /// <summary>
                /// <para>The staff ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>370196</para>
                /// </summary>
                [NameInMap("StaffId")]
                [Validation(Required=false)]
                public string StaffId { get; set; }

                /// <summary>
                /// <para>The staff name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>StaffName</para>
                /// </summary>
                [NameInMap("StaffName")]
                [Validation(Required=false)]
                public string StaffName { get; set; }

                /// <summary>
                /// <para>The staff type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>StaffType</para>
                /// </summary>
                [NameInMap("StaffType")]
                [Validation(Required=false)]
                public string StaffType { get; set; }

                /// <summary>
                /// <para>The staff status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The design specification associated with the application.</para>
            /// </summary>
            [NameInMap("AppDesignSpec")]
            [Validation(Required=false)]
            public GetAppInstanceForPartnerResponseBodyModuleAppDesignSpec AppDesignSpec { get; set; }
            public class GetAppInstanceForPartnerResponseBodyModuleAppDesignSpec : TeaModel {
                /// <summary>
                /// <para>bill</para>
                /// 
                /// <b>Example:</b>
                /// <para>bilingual</para>
                /// </summary>
                [NameInMap("Bilingual")]
                [Validation(Required=false)]
                public bool? Bilingual { get; set; }

                /// <summary>
                /// <para>The customer business ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WS20250801151731000007</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                /// <summary>
                /// <para>busincessScope</para>
                /// 
                /// <b>Example:</b>
                /// <para>scopre</para>
                /// </summary>
                [NameInMap("BusinessScope")]
                [Validation(Required=false)]
                public string BusinessScope { get; set; }

                /// <summary>
                /// <para>The specified color. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>black</b>: Black.</description></item>
                /// <item><description><b>white</b>: White.</description></item>
                /// <item><description><b>red</b>: Red.</description></item>
                /// <item><description><b>blue</b>: Blue.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>style</para>
                /// </summary>
                [NameInMap("ColorStyle")]
                [Validation(Required=false)]
                public string ColorStyle { get; set; }

                /// <summary>
                /// <para>The company name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bvt_test</para>
                /// </summary>
                [NameInMap("CompanyName")]
                [Validation(Required=false)]
                public string CompanyName { get; set; }

                /// <summary>
                /// <para>The deployment region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HongKong</para>
                /// </summary>
                [NameInMap("DeployArea")]
                [Validation(Required=false)]
                public string DeployArea { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-21T08:27:03Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Wed Sep 10 09:53:35 CST 2025</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The primary key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m1zumwgy6u</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>business</para>
                /// 
                /// <b>Example:</b>
                /// <para>business</para>
                /// </summary>
                [NameInMap("MainBusiness")]
                [Validation(Required=false)]
                public string MainBusiness { get; set; }

                /// <summary>
                /// <para>website</para>
                /// 
                /// <b>Example:</b>
                /// <para>website</para>
                /// </summary>
                [NameInMap("ReferenceWebsite")]
                [Validation(Required=false)]
                public string ReferenceWebsite { get; set; }

                /// <summary>
                /// <para>sitegolas</para>
                /// 
                /// <b>Example:</b>
                /// <para>goals</para>
                /// </summary>
                [NameInMap("SiteGoals")]
                [Validation(Required=false)]
                public string SiteGoals { get; set; }

                /// <summary>
                /// <para>language</para>
                /// 
                /// <b>Example:</b>
                /// <para>sitelanguage</para>
                /// </summary>
                [NameInMap("SiteLanguage")]
                [Validation(Required=false)]
                public string SiteLanguage { get; set; }

                /// <summary>
                /// <para>sitelogo</para>
                /// 
                /// <b>Example:</b>
                /// <para>logo</para>
                /// </summary>
                [NameInMap("SiteLogo")]
                [Validation(Required=false)]
                public string SiteLogo { get; set; }

                /// <summary>
                /// <para>siteslogan</para>
                /// 
                /// <b>Example:</b>
                /// <para>slogan</para>
                /// </summary>
                [NameInMap("SiteSlogan")]
                [Validation(Required=false)]
                public string SiteSlogan { get; set; }

                /// <summary>
                /// <para>sitestyle</para>
                /// 
                /// <b>Example:</b>
                /// <para>style</para>
                /// </summary>
                [NameInMap("SiteStyle")]
                [Validation(Required=false)]
                public string SiteStyle { get; set; }

                /// <summary>
                /// <para>sitetitle</para>
                /// 
                /// <b>Example:</b>
                /// <para>title</para>
                /// </summary>
                [NameInMap("SiteTitle")]
                [Validation(Required=false)]
                public string SiteTitle { get; set; }

                /// <summary>
                /// <para>The application type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>web: Web &amp; H5.</description></item>
                /// <item><description>miniapp: mini program.</description></item>
                /// <item><description>ios: iOS.</description></item>
                /// <item><description>android: Android.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>web</para>
                /// </summary>
                [NameInMap("SiteType")]
                [Validation(Required=false)]
                public string SiteType { get; set; }

                /// <summary>
                /// <para>userid</para>
                /// 
                /// <b>Example:</b>
                /// <para>userid</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The application operation address.</para>
            /// </summary>
            [NameInMap("AppOperationAddress")]
            [Validation(Required=false)]
            public GetAppInstanceForPartnerResponseBodyModuleAppOperationAddress AppOperationAddress { get; set; }
            public class GetAppInstanceForPartnerResponseBodyModuleAppOperationAddress : TeaModel {
                /// <summary>
                /// <para>The list of console action buttons.</para>
                /// </summary>
                [NameInMap("Actions")]
                [Validation(Required=false)]
                public List<GetAppInstanceForPartnerResponseBodyModuleAppOperationAddressActions> Actions { get; set; }
                public class GetAppInstanceForPartnerResponseBodyModuleAppOperationAddressActions : TeaModel {
                    /// <summary>
                    /// <para>The action key that uniquely identifies an operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BeginDialogue</para>
                    /// </summary>
                    [NameInMap("ActionKey")]
                    [Validation(Required=false)]
                    public string ActionKey { get; set; }

                    /// <summary>
                    /// <para>The display text of the action, which is shown as the action name in the interface.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("ActionText")]
                    [Validation(Required=false)]
                    public string ActionText { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the action is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The URL to which the user is redirected when the action is clicked.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("Href")]
                    [Validation(Required=false)]
                    public string Href { get; set; }

                }

                /// <summary>
                /// <para>The URL for customer service design.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("AiCustomerConfigUrl")]
                [Validation(Required=false)]
                public string AiCustomerConfigUrl { get; set; }

                /// <summary>
                /// <para>The URL for AI design.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("AiDesignUrl")]
                [Validation(Required=false)]
                public string AiDesignUrl { get; set; }

                /// <summary>
                /// <para>The URL for application publishing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("AppPublishUrl")]
                [Validation(Required=false)]
                public string AppPublishUrl { get; set; }

                /// <summary>
                /// <para>The list of overview page action buttons.</para>
                /// </summary>
                [NameInMap("DashboardActions")]
                [Validation(Required=false)]
                public List<GetAppInstanceForPartnerResponseBodyModuleAppOperationAddressDashboardActions> DashboardActions { get; set; }
                public class GetAppInstanceForPartnerResponseBodyModuleAppOperationAddressDashboardActions : TeaModel {
                    /// <summary>
                    /// <para>The action key that uniquely identifies an operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CollectedNumber</para>
                    /// </summary>
                    [NameInMap("ActionKey")]
                    [Validation(Required=false)]
                    public string ActionKey { get; set; }

                    /// <summary>
                    /// <para>The display text of the action, which is shown as the action name in the interface.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("ActionText")]
                    [Validation(Required=false)]
                    public string ActionText { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the action is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The URL to which the user is redirected when the action is clicked.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("Href")]
                    [Validation(Required=false)]
                    public string Href { get; set; }

                }

                /// <summary>
                /// <para>The URL for professional design.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("DesignUrl")]
                [Validation(Required=false)]
                public string DesignUrl { get; set; }

                /// <summary>
                /// <para>The logon URL of the application instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("InstanceLoginUrl")]
                [Validation(Required=false)]
                public string InstanceLoginUrl { get; set; }

                /// <summary>
                /// <para>The URL for renewal purchase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("RenewBuyUrl")]
                [Validation(Required=false)]
                public string RenewBuyUrl { get; set; }

                /// <summary>
                /// <para>The URL for service delivery.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("ServerDeliveryUrl")]
                [Validation(Required=false)]
                public string ServerDeliveryUrl { get; set; }

                /// <summary>
                /// <para>The URL for upgrade purchase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("UpgradeBuyUrl")]
                [Validation(Required=false)]
                public string UpgradeBuyUrl { get; set; }

            }

            /// <summary>
            /// <para>The list of service instances associated with the application.</para>
            /// </summary>
            [NameInMap("AppServiceList")]
            [Validation(Required=false)]
            public List<GetAppInstanceForPartnerResponseBodyModuleAppServiceList> AppServiceList { get; set; }
            public class GetAppInstanceForPartnerResponseBodyModuleAppServiceList : TeaModel {
                /// <summary>
                /// <para>The business ID of the application instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WS20251211153330000001</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                /// <summary>
                /// <para>The deletion flag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fase</para>
                /// </summary>
                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public int? Deleted { get; set; }

                /// <summary>
                /// <para>The end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-18T02:23:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>esp bizId</para>
                /// 
                /// <b>Example:</b>
                /// <para>EspBizId</para>
                /// </summary>
                [NameInMap("EspBizId")]
                [Validation(Required=false)]
                public string EspBizId { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-30T02:08:40Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tue Sep 09 10:27:49 CST 2025</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The application operation address.</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public GetAppInstanceForPartnerResponseBodyModuleAppServiceListGroup Group { get; set; }
                public class GetAppInstanceForPartnerResponseBodyModuleAppServiceListGroup : TeaModel {
                    /// <summary>
                    /// <para>The primary key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>d75fvq3ctk</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The website name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mda-sb037wmidshg3w9v.mp4</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>QrCode</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qrcode</para>
                    /// </summary>
                    [NameInMap("QrCode")]
                    [Validation(Required=false)]
                    public string QrCode { get; set; }

                    /// <summary>
                    /// <para>dingtalk wx...</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hive</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The temporary access URL of the image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://static.yipigai.cn/timuocr/tmp_57bc9cb3be1075f4e5cdae87f5cbb86abc54a694aaf10965.jpg">https://static.yipigai.cn/timuocr/tmp_57bc9cb3be1075f4e5cdae87f5cbb86abc54a694aaf10965.jpg</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The associated business ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceBizId</para>
                /// </summary>
                [NameInMap("InstanceBizId")]
                [Validation(Required=false)]
                public string InstanceBizId { get; set; }

                /// <summary>
                /// <para>The service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19609820.png</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The delivery process.</para>
                /// </summary>
                [NameInMap("NodeList")]
                [Validation(Required=false)]
                public List<GetAppInstanceForPartnerResponseBodyModuleAppServiceListNodeList> NodeList { get; set; }
                public class GetAppInstanceForPartnerResponseBodyModuleAppServiceListNodeList : TeaModel {
                    /// <summary>
                    /// <para>The child folder object.</para>
                    /// </summary>
                    [NameInMap("Children")]
                    [Validation(Required=false)]
                    public List<object> Children { get; set; }

                    /// <summary>
                    /// <para>The sequence number of the last node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FinalStepNo</para>
                    /// </summary>
                    [NameInMap("FinalStepNo")]
                    [Validation(Required=false)]
                    public int? FinalStepNo { get; set; }

                    /// <summary>
                    /// <para>The completion timestamp of the baseline instance. This value is returned when FinishStatus is FINISH (completed).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-01-13T07:58:12Z</para>
                    /// </summary>
                    [NameInMap("FinishTime")]
                    [Validation(Required=false)]
                    public long? FinishTime { get; set; }

                    /// <summary>
                    /// <para>IsContainerNode</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>IsContainerNode</para>
                    /// </summary>
                    [NameInMap("IsContainerNode")]
                    [Validation(Required=false)]
                    public bool? IsContainerNode { get; set; }

                    /// <summary>
                    /// <para>The ID of the OBServer node where the resource node resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2927b500-c4e2-4241-bacf-0a2991c4be12</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// <para>&lt;props=&quot;china&quot;&gt;The name of the matrix.
                    /// &lt;props=&quot;intl&quot;&gt;This parameter is not available for public use..</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>单路输出</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    /// <summary>
                    /// <para>The running status of the node. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>UP</b>: The node is running.</description></item>
                    /// <item><description><b>DOWN</b>: The node has failed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NodeStatus</para>
                    /// </summary>
                    [NameInMap("NodeStatus")]
                    [Validation(Required=false)]
                    public string NodeStatus { get; set; }

                    /// <summary>
                    /// <para>The role of the operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OperatorRole</para>
                    /// </summary>
                    [NameInMap("OperatorRole")]
                    [Validation(Required=false)]
                    public string OperatorRole { get; set; }

                    /// <summary>
                    /// <para>The ID of the parent node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dpYLaezmVNRMGX56Cg4gLjrrVrMqPxX6</para>
                    /// </summary>
                    [NameInMap("ParentNodeId")]
                    [Validation(Required=false)]
                    public string ParentNodeId { get; set; }

                    /// <summary>
                    /// <para>The sequence number of the process node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>StepNo</para>
                    /// </summary>
                    [NameInMap("StepNo")]
                    [Validation(Required=false)]
                    public int? StepNo { get; set; }

                }

                /// <summary>
                /// <para>The unique identifier of an operation.</para>
                /// </summary>
                [NameInMap("OperationAddress")]
                [Validation(Required=false)]
                public GetAppInstanceForPartnerResponseBodyModuleAppServiceListOperationAddress OperationAddress { get; set; }
                public class GetAppInstanceForPartnerResponseBodyModuleAppServiceListOperationAddress : TeaModel {
                    /// <summary>
                    /// <para>The list of console action buttons.</para>
                    /// </summary>
                    [NameInMap("Actions")]
                    [Validation(Required=false)]
                    public List<GetAppInstanceForPartnerResponseBodyModuleAppServiceListOperationAddressActions> Actions { get; set; }
                    public class GetAppInstanceForPartnerResponseBodyModuleAppServiceListOperationAddressActions : TeaModel {
                        /// <summary>
                        /// <para>The action key that uniquely identifies an operation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CollectedNumber</para>
                        /// </summary>
                        [NameInMap("ActionKey")]
                        [Validation(Required=false)]
                        public string ActionKey { get; set; }

                        /// <summary>
                        /// <para>The display text of the action, which is shown as the action name in the interface.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ActionText</para>
                        /// </summary>
                        [NameInMap("ActionText")]
                        [Validation(Required=false)]
                        public string ActionText { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the action is enabled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Enable")]
                        [Validation(Required=false)]
                        public bool? Enable { get; set; }

                        /// <summary>
                        /// <para>The URL to which the user is redirected when the action is clicked.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Href</para>
                        /// </summary>
                        [NameInMap("Href")]
                        [Validation(Required=false)]
                        public string Href { get; set; }

                    }

                    /// <summary>
                    /// <para>The URL for customer service design.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AiCustomerConfigUrl</para>
                    /// </summary>
                    [NameInMap("AiCustomerConfigUrl")]
                    [Validation(Required=false)]
                    public string AiCustomerConfigUrl { get; set; }

                    /// <summary>
                    /// <para>The URL for AI design.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AiDesignUrl</para>
                    /// </summary>
                    [NameInMap("AiDesignUrl")]
                    [Validation(Required=false)]
                    public string AiDesignUrl { get; set; }

                    /// <summary>
                    /// <para>The URL for application publishing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AppPublishUrl</para>
                    /// </summary>
                    [NameInMap("AppPublishUrl")]
                    [Validation(Required=false)]
                    public string AppPublishUrl { get; set; }

                    /// <summary>
                    /// <para>The list of overview page action buttons.</para>
                    /// </summary>
                    [NameInMap("DashboardActions")]
                    [Validation(Required=false)]
                    public List<GetAppInstanceForPartnerResponseBodyModuleAppServiceListOperationAddressDashboardActions> DashboardActions { get; set; }
                    public class GetAppInstanceForPartnerResponseBodyModuleAppServiceListOperationAddressDashboardActions : TeaModel {
                        /// <summary>
                        /// <para>The action key that uniquely identifies an operation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AbortDialogue</para>
                        /// </summary>
                        [NameInMap("ActionKey")]
                        [Validation(Required=false)]
                        public string ActionKey { get; set; }

                        /// <summary>
                        /// <para>The display text of the action, which is shown as the action name in the interface.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ActionText</para>
                        /// </summary>
                        [NameInMap("ActionText")]
                        [Validation(Required=false)]
                        public string ActionText { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the action is enabled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Enable")]
                        [Validation(Required=false)]
                        public bool? Enable { get; set; }

                        /// <summary>
                        /// <para>The URL to which the user is redirected when the action is clicked.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Href</para>
                        /// </summary>
                        [NameInMap("Href")]
                        [Validation(Required=false)]
                        public string Href { get; set; }

                    }

                    /// <summary>
                    /// <para>The URL for professional design.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DesignUrl</para>
                    /// </summary>
                    [NameInMap("DesignUrl")]
                    [Validation(Required=false)]
                    public string DesignUrl { get; set; }

                    /// <summary>
                    /// <para>The logon URL of the application instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>InstanceLoginUrl</para>
                    /// </summary>
                    [NameInMap("InstanceLoginUrl")]
                    [Validation(Required=false)]
                    public string InstanceLoginUrl { get; set; }

                    /// <summary>
                    /// <para>The URL for renewal purchase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>renewBuyUrl</para>
                    /// </summary>
                    [NameInMap("RenewBuyUrl")]
                    [Validation(Required=false)]
                    public string RenewBuyUrl { get; set; }

                    /// <summary>
                    /// <para>The URL for service delivery.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ServerDeliveryUrl</para>
                    /// </summary>
                    [NameInMap("ServerDeliveryUrl")]
                    [Validation(Required=false)]
                    public string ServerDeliveryUrl { get; set; }

                    /// <summary>
                    /// <para>The URL for upgrade purchase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UpgradeBuyUrl</para>
                    /// </summary>
                    [NameInMap("UpgradeBuyUrl")]
                    [Validation(Required=false)]
                    public string UpgradeBuyUrl { get; set; }

                }

                /// <summary>
                /// <para>The order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>253790948890026</para>
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The instance service configuration.</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public GetAppInstanceForPartnerResponseBodyModuleAppServiceListProfile Profile { get; set; }
                public class GetAppInstanceForPartnerResponseBodyModuleAppServiceListProfile : TeaModel {
                    /// <summary>
                    /// <para>The business ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WS20250801003834000003</para>
                    /// </summary>
                    [NameInMap("BizId")]
                    [Validation(Required=false)]
                    public string BizId { get; set; }

                    /// <summary>
                    /// <para>The design type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DesignType</para>
                    /// </summary>
                    [NameInMap("DesignType")]
                    [Validation(Required=false)]
                    public string DesignType { get; set; }

                    /// <summary>
                    /// <para>The description of the design type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DesignTypeText</para>
                    /// </summary>
                    [NameInMap("DesignTypeText")]
                    [Validation(Required=false)]
                    public string DesignTypeText { get; set; }

                    /// <summary>
                    /// <para>The creation time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1620711265000</para>
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// <para>The modification time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Mon Sep 25 14:48:49 CST 2023</para>
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// <para>The primary key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>108232</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The Lingxiao instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LxInstanceId</para>
                    /// </summary>
                    [NameInMap("LxInstanceId")]
                    [Validation(Required=false)]
                    public string LxInstanceId { get; set; }

                    /// <summary>
                    /// <para>The order ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>256146659280026</para>
                    /// </summary>
                    [NameInMap("OrderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                    /// <summary>
                    /// <para>The service specification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("ServiceSpec")]
                    [Validation(Required=false)]
                    public string ServiceSpec { get; set; }

                    /// <summary>
                    /// <para>The description of the service specification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ServiceSpecText</para>
                    /// </summary>
                    [NameInMap("ServiceSpecText")]
                    [Validation(Required=false)]
                    public string ServiceSpecText { get; set; }

                    [NameInMap("UpgradeStatus")]
                    [Validation(Required=false)]
                    public string UpgradeStatus { get; set; }

                }

                /// <summary>
                /// <para>The service type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WEBSITE_DESIGN</para>
                /// </summary>
                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public string ServiceType { get; set; }

                /// <summary>
                /// <para>The description of the service type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ServiceTypeText</para>
                /// </summary>
                [NameInMap("ServiceTypeText")]
                [Validation(Required=false)]
                public string ServiceTypeText { get; set; }

                /// <summary>
                /// <para>The application identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Slug</para>
                /// </summary>
                [NameInMap("Slug")]
                [Validation(Required=false)]
                public string Slug { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1754447102000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UserId</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The application subtype.</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeHolder</para>
            /// </summary>
            [NameInMap("AppSubType")]
            [Validation(Required=false)]
            public string AppSubType { get; set; }

            /// <summary>
            /// <para>The application type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TRACE</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <para>The business ID of the application instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WS20250915163734000001</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <para>The build type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeHolder</para>
            /// </summary>
            [NameInMap("BuildType")]
            [Validation(Required=false)]
            public string BuildType { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fase</para>
            /// </summary>
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public int? Deleted { get; set; }

            /// <summary>
            /// <para>The application description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/bak-&gt;serverless.handler(2020091300200279)</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>placeHolder</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeHolder</para>
            /// </summary>
            [NameInMap("DesignSpecBizId")]
            [Validation(Required=false)]
            public string DesignSpecBizId { get; set; }

            /// <summary>
            /// <para>The ID of the design specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeHolder</para>
            /// </summary>
            [NameInMap("DesignSpecId")]
            [Validation(Required=false)]
            public string DesignSpecId { get; set; }

            /// <summary>
            /// <para>The primary domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stxycw.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-05T15:59:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pre</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The associated delivery order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeHolder</para>
            /// </summary>
            [NameInMap("EspBizId")]
            [Validation(Required=false)]
            public string EspBizId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1740479834</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The deletion time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeHolder</para>
            /// </summary>
            [NameInMap("GmtDelete")]
            [Validation(Required=false)]
            public string GmtDelete { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-28T02:25:41Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The publish time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeHolder</para>
            /// </summary>
            [NameInMap("GmtPublish")]
            [Validation(Required=false)]
            public string GmtPublish { get; set; }

            /// <summary>
            /// <para>The application icon URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://yzm.zshud.com:34901/cloud-phone/%E5%85%BB%E7%94%9F_1763631730804.png">https://yzm.zshud.com:34901/cloud-phone/养生_1763631730804.png</a></para>
            /// </summary>
            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文件名</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>250822465990301</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <para>The partner details.</para>
            /// </summary>
            [NameInMap("PartnerDetail")]
            [Validation(Required=false)]
            public GetAppInstanceForPartnerResponseBodyModulePartnerDetail PartnerDetail { get; set; }
            public class GetAppInstanceForPartnerResponseBodyModulePartnerDetail : TeaModel {
                /// <summary>
                /// <para>data</para>
                /// </summary>
                [NameInMap("BindData")]
                [Validation(Required=false)]
                public GetAppInstanceForPartnerResponseBodyModulePartnerDetailBindData BindData { get; set; }
                public class GetAppInstanceForPartnerResponseBodyModulePartnerDetailBindData : TeaModel {
                    /// <summary>
                    /// <para>aliyun_pk</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("AliyunPk")]
                    [Validation(Required=false)]
                    public string AliyunPk { get; set; }

                    /// <summary>
                    /// <para>The external business ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WS20250801153127000002</para>
                    /// </summary>
                    [NameInMap("BizId")]
                    [Validation(Required=false)]
                    public string BizId { get; set; }

                    /// <summary>
                    /// <para>The creation time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1672123722000</para>
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// <para>The modification time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Wed Nov 26 10:15:28 CST 2025</para>
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// <para>The user to whom the ICP filing service code belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>grantAliyunPk</para>
                    /// </summary>
                    [NameInMap("GrantAliyunPk")]
                    [Validation(Required=false)]
                    public string GrantAliyunPk { get; set; }

                    /// <summary>
                    /// <para>The mobile phone number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }

                    /// <summary>
                    /// <para>parent_pk</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1123213</para>
                    /// </summary>
                    [NameInMap("ParentPk")]
                    [Validation(Required=false)]
                    public string ParentPk { get; set; }

                    /// <summary>
                    /// <para>The external association partner ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10001</para>
                    /// </summary>
                    [NameInMap("PartnerId")]
                    [Validation(Required=false)]
                    public string PartnerId { get; set; }

                    /// <summary>
                    /// <para>The display name of the bound user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>diaplayName</para>
                    /// </summary>
                    [NameInMap("UserDisplayName")]
                    [Validation(Required=false)]
                    public string UserDisplayName { get; set; }

                }

                /// <summary>
                /// <para>The ID of the partner. This is an extended parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("PartnerId")]
                [Validation(Required=false)]
                public string PartnerId { get; set; }

                /// <summary>
                /// <para>Valid values: unknown, init, testing, online.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The instance configuration.</para>
            /// </summary>
            [NameInMap("Profile")]
            [Validation(Required=false)]
            public GetAppInstanceForPartnerResponseBodyModuleProfile Profile { get; set; }
            public class GetAppInstanceForPartnerResponseBodyModuleProfile : TeaModel {
                /// <summary>
                /// <para>The admin console URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("AdminUrl")]
                [Validation(Required=false)]
                public string AdminUrl { get; set; }

                /// <summary>
                /// <para>The application type code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PC_WebSite</para>
                /// </summary>
                [NameInMap("ApplicationType")]
                [Validation(Required=false)]
                public string ApplicationType { get; set; }

                /// <summary>
                /// <para>The text description of the application type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("ApplicationTypeText")]
                [Validation(Required=false)]
                public string ApplicationTypeText { get; set; }

                /// <summary>
                /// <para>The bound CNAME record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("BindCname")]
                [Validation(Required=false)]
                public string BindCname { get; set; }

                /// <summary>
                /// <para>The business ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WS20250801152128000005</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                /// <summary>
                /// <para>The commodity code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The customer service information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("CustomerService")]
                [Validation(Required=false)]
                public string CustomerService { get; set; }

                /// <summary>
                /// <para>The deployment region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ChineseMainland</para>
                /// </summary>
                [NameInMap("DeployArea")]
                [Validation(Required=false)]
                public string DeployArea { get; set; }

                /// <summary>
                /// <para>The domain name list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[white:],<em>.eduresource.cn,</em>.dingtalk.com,<em>.aliyun.com,</em>.aliyuncs.com,euser.edu-aliyun.com,s-gm.mmstat.com</para>
                /// </summary>
                [NameInMap("DomainList")]
                [Validation(Required=false)]
                public string DomainList { get; set; }

                /// <summary>
                /// <para>The editor URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("EditorUrl")]
                [Validation(Required=false)]
                public string EditorUrl { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1605280632000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-06T03:07:45Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ICP filing number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("IcpbaNo")]
                [Validation(Required=false)]
                public string IcpbaNo { get; set; }

                /// <summary>
                /// <para>The image list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;Image\&quot;: []}</para>
                /// </summary>
                [NameInMap("ImageList")]
                [Validation(Required=false)]
                public string ImageList { get; set; }

                /// <summary>
                /// <para>The Lingxiao instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("LxInstanceId")]
                [Validation(Required=false)]
                public string LxInstanceId { get; set; }

                /// <summary>
                /// <para>The order placement time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("OrdTime")]
                [Validation(Required=false)]
                public string OrdTime { get; set; }

                /// <summary>
                /// <para>The order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>256146659280026</para>
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The number of orders.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OrderNum")]
                [Validation(Required=false)]
                public int? OrderNum { get; set; }

                /// <summary>
                /// <para>The channel partner business ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100086</para>
                /// </summary>
                [NameInMap("PartnerId")]
                [Validation(Required=false)]
                public string PartnerId { get; set; }

                /// <summary>
                /// <para>The payment time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("PayTime")]
                [Validation(Required=false)]
                public string PayTime { get; set; }

                /// <summary>
                /// <para>The preview URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://preview-lyj.aliyuncs.com/preview/1daacb3ebbb8435d9091fb950c528d0f?subSceneIds=682185">https://preview-lyj.aliyuncs.com/preview/1daacb3ebbb8435d9091fb950c528d0f?subSceneIds=682185</a></para>
                /// </summary>
                [NameInMap("PreviewUrl")]
                [Validation(Required=false)]
                public string PreviewUrl { get; set; }

                /// <summary>
                /// <para>The SEO site information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("SeoSite")]
                [Validation(Required=false)]
                public string SeoSite { get; set; }

                /// <summary>
                /// <para>The site logo.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("SiteLogo")]
                [Validation(Required=false)]
                public string SiteLogo { get; set; }

                /// <summary>
                /// <para>The site version code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Basic_Edition</para>
                /// </summary>
                [NameInMap("SiteVersion")]
                [Validation(Required=false)]
                public string SiteVersion { get; set; }

                /// <summary>
                /// <para>The text description of the site version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("SiteVersionText")]
                [Validation(Required=false)]
                public string SiteVersionText { get; set; }

                /// <summary>
                /// <para>The source information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edasmsc</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The template ETag identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("TemplateEtag")]
                [Validation(Required=false)]
                public string TemplateEtag { get; set; }

                /// <summary>
                /// <para>The template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4644</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <para>The text list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("TextList")]
                [Validation(Required=false)]
                public string TextList { get; set; }

                /// <summary>
                /// <para>The thumbnail.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://aloss-recruit-aiinterview.oss-cn-beijing.aliyuncs.com/thumbnail-1753495551714-10000.png">https://aloss-recruit-aiinterview.oss-cn-beijing.aliyuncs.com/thumbnail-1753495551714-10000.png</a></para>
                /// </summary>
                [NameInMap("Thumbnail")]
                [Validation(Required=false)]
                public string Thumbnail { get; set; }

                [NameInMap("UpgradeStatus")]
                [Validation(Required=false)]
                public string UpgradeStatus { get; set; }

            }

            /// <summary>
            /// <para>The list of instances associated with the application.</para>
            /// </summary>
            [NameInMap("RelatedInstanceList")]
            [Validation(Required=false)]
            public List<GetAppInstanceForPartnerResponseBodyModuleRelatedInstanceList> RelatedInstanceList { get; set; }
            public class GetAppInstanceForPartnerResponseBodyModuleRelatedInstanceList : TeaModel {
                /// <summary>
                /// <para>The application subtype.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("AppSubType")]
                [Validation(Required=false)]
                public string AppSubType { get; set; }

                /// <summary>
                /// <para>The application type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AppType")]
                [Validation(Required=false)]
                public string AppType { get; set; }

                /// <summary>
                /// <para>The business ID of the application instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WS20250929173805000001</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                /// <summary>
                /// <para>The build type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("BuildType")]
                [Validation(Required=false)]
                public string BuildType { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance is deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fase</para>
                /// </summary>
                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public int? Deleted { get; set; }

                /// <summary>
                /// <para>The application description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>base</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>placeHolder</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("DesignSpecBizId")]
                [Validation(Required=false)]
                public string DesignSpecBizId { get; set; }

                /// <summary>
                /// <para>The ID of the design specification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("DesignSpecId")]
                [Validation(Required=false)]
                public string DesignSpecId { get; set; }

                /// <summary>
                /// <para>The primary domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>shikuntech.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-05-23T15:01:25.891Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pre</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                /// <summary>
                /// <para>The associated delivery order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("EspBizId")]
                [Validation(Required=false)]
                public string EspBizId { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-19T07:39:55Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The deletion time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("GmtDelete")]
                [Validation(Required=false)]
                public string GmtDelete { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-14T09:09:57Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The publish time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("GmtPublish")]
                [Validation(Required=false)]
                public string GmtPublish { get; set; }

                /// <summary>
                /// <para>The application icon URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://app-center-icon-prod-shanghai.oss-cn-shanghai.aliyuncs.com/tenant/1617863868712071/1749090558651_%E9%AB%98%E5%BE%B7.png">https://app-center-icon-prod-shanghai.oss-cn-shanghai.aliyuncs.com/tenant/1617863868712071/1749090558651_%E9%AB%98%E5%BE%B7.png</a></para>
                /// </summary>
                [NameInMap("IconUrl")]
                [Validation(Required=false)]
                public string IconUrl { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19609820.png</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>264987642530867,264988827010867,264982589530867,264985058640867,264982290930867,264982387520867,264987147460867,264985752990867,264988432850867</para>
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The instance configuration.</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public GetAppInstanceForPartnerResponseBodyModuleRelatedInstanceListProfile Profile { get; set; }
                public class GetAppInstanceForPartnerResponseBodyModuleRelatedInstanceListProfile : TeaModel {
                    /// <summary>
                    /// <para>The admin console URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("AdminUrl")]
                    [Validation(Required=false)]
                    public string AdminUrl { get; set; }

                    /// <summary>
                    /// <para>The application type code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PC_WebSite</para>
                    /// </summary>
                    [NameInMap("ApplicationType")]
                    [Validation(Required=false)]
                    public string ApplicationType { get; set; }

                    /// <summary>
                    /// <para>The text description of the application type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("ApplicationTypeText")]
                    [Validation(Required=false)]
                    public string ApplicationTypeText { get; set; }

                    /// <summary>
                    /// <para>The bound CNAME record.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("BindCname")]
                    [Validation(Required=false)]
                    public string BindCname { get; set; }

                    /// <summary>
                    /// <para>The business ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WS20250801153127000002</para>
                    /// </summary>
                    [NameInMap("BizId")]
                    [Validation(Required=false)]
                    public string BizId { get; set; }

                    /// <summary>
                    /// <para>The commodity code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sas</para>
                    /// </summary>
                    [NameInMap("CommodityCode")]
                    [Validation(Required=false)]
                    public string CommodityCode { get; set; }

                    /// <summary>
                    /// <para>The customer service information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("CustomerService")]
                    [Validation(Required=false)]
                    public string CustomerService { get; set; }

                    /// <summary>
                    /// <para>The deployment region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ChineseMainland</para>
                    /// </summary>
                    [NameInMap("DeployArea")]
                    [Validation(Required=false)]
                    public string DeployArea { get; set; }

                    /// <summary>
                    /// <para>The domain name list.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[\&quot;activity.syruijia.top\&quot;, \&quot;admin.syruijia.top\&quot;, \&quot;api.syruijia.top\&quot;, \&quot;game-admin.syruijia.top\&quot;, \&quot;h5game.syruijia.top\&quot;, \&quot;home.syruijia.top\&quot;, \&quot;invite.syruijia.top\&quot;]</para>
                    /// </summary>
                    [NameInMap("DomainList")]
                    [Validation(Required=false)]
                    public string DomainList { get; set; }

                    /// <summary>
                    /// <para>The editor URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("EditorUrl")]
                    [Validation(Required=false)]
                    public string EditorUrl { get; set; }

                    /// <summary>
                    /// <para>The creation time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1621734214000</para>
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// <para>The modification time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Thu Oct 24 09:12:31 CST 2024</para>
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// <para>The ICP filing number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("IcpbaNo")]
                    [Validation(Required=false)]
                    public string IcpbaNo { get; set; }

                    /// <summary>
                    /// <para>The image list.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;Image\&quot;: []}</para>
                    /// </summary>
                    [NameInMap("ImageList")]
                    [Validation(Required=false)]
                    public string ImageList { get; set; }

                    /// <summary>
                    /// <para>The Lingxiao instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("LxInstanceId")]
                    [Validation(Required=false)]
                    public string LxInstanceId { get; set; }

                    /// <summary>
                    /// <para>The order placement time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("OrdTime")]
                    [Validation(Required=false)]
                    public string OrdTime { get; set; }

                    /// <summary>
                    /// <para>The order ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>248808934190692</para>
                    /// </summary>
                    [NameInMap("OrderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                    /// <summary>
                    /// <para>The number of orders.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("OrderNum")]
                    [Validation(Required=false)]
                    public int? OrderNum { get; set; }

                    /// <summary>
                    /// <para>The channel partner business ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100086</para>
                    /// </summary>
                    [NameInMap("PartnerId")]
                    [Validation(Required=false)]
                    public string PartnerId { get; set; }

                    /// <summary>
                    /// <para>The payment time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("PayTime")]
                    [Validation(Required=false)]
                    public string PayTime { get; set; }

                    /// <summary>
                    /// <para>The preview URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://preview-lyj.aliyuncs.com/preview/temp/9fb36fc05d0a48cdb92d7397336c214f?subSceneIds=734285&type=interim">https://preview-lyj.aliyuncs.com/preview/temp/9fb36fc05d0a48cdb92d7397336c214f?subSceneIds=734285&amp;type=interim</a></para>
                    /// </summary>
                    [NameInMap("PreviewUrl")]
                    [Validation(Required=false)]
                    public string PreviewUrl { get; set; }

                    /// <summary>
                    /// <para>The SEO site information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("SeoSite")]
                    [Validation(Required=false)]
                    public string SeoSite { get; set; }

                    /// <summary>
                    /// <para>The site logo.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("SiteLogo")]
                    [Validation(Required=false)]
                    public string SiteLogo { get; set; }

                    /// <summary>
                    /// <para>The site version code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Trial_Edition</para>
                    /// </summary>
                    [NameInMap("SiteVersion")]
                    [Validation(Required=false)]
                    public string SiteVersion { get; set; }

                    /// <summary>
                    /// <para>The text description of the site version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("SiteVersionText")]
                    [Validation(Required=false)]
                    public string SiteVersionText { get; set; }

                    /// <summary>
                    /// <para>The source information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.71.130.205</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <para>The template ETag identifier.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("TemplateEtag")]
                    [Validation(Required=false)]
                    public string TemplateEtag { get; set; }

                    /// <summary>
                    /// <para>The template ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4644</para>
                    /// </summary>
                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                    /// <summary>
                    /// <para>The text list.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>placeHolder</para>
                    /// </summary>
                    [NameInMap("TextList")]
                    [Validation(Required=false)]
                    public string TextList { get; set; }

                    /// <summary>
                    /// <para>The thumbnail.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://aloss-recruit-aiinterview.oss-cn-beijing.aliyuncs.com/thumbnail-1766456326256-0.png">https://aloss-recruit-aiinterview.oss-cn-beijing.aliyuncs.com/thumbnail-1766456326256-0.png</a></para>
                    /// </summary>
                    [NameInMap("Thumbnail")]
                    [Validation(Required=false)]
                    public string Thumbnail { get; set; }

                    [NameInMap("UpgradeStatus")]
                    [Validation(Required=false)]
                    public string UpgradeStatus { get; set; }

                }

                /// <summary>
                /// <para>The website domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("SiteHost")]
                [Validation(Required=false)]
                public string SiteHost { get; set; }

                /// <summary>
                /// <para>The application identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("Slug")]
                [Validation(Required=false)]
                public string Slug { get; set; }

                /// <summary>
                /// <para>The source. Example: MARKET_CLOUD_DREAM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MARKET_CLOUD_DREAM</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-22T02:23:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The task status text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("StatusText")]
                [Validation(Required=false)]
                public string StatusText { get; set; }

                /// <summary>
                /// <para>The application thumbnail URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("ThumbnailUrl")]
                [Validation(Required=false)]
                public string ThumbnailUrl { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>placeHolder</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The application instance version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-04-02</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The website domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcd.scd.wanwang.xin</para>
            /// </summary>
            [NameInMap("SiteHost")]
            [Validation(Required=false)]
            public string SiteHost { get; set; }

            /// <summary>
            /// <para>The application identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeHolder</para>
            /// </summary>
            [NameInMap("Slug")]
            [Validation(Required=false)]
            public string Slug { get; set; }

            /// <summary>
            /// <para>The source. Example: MARKET_CLOUD_DREAM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MARKET_CLOUD_DREAM</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-24T10:10Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task status text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FILE_DOWNLOAD_FAILED</para>
            /// </summary>
            [NameInMap("StatusText")]
            [Validation(Required=false)]
            public string StatusText { get; set; }

            /// <summary>
            /// <para>The application thumbnail URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeHolder</para>
            /// </summary>
            [NameInMap("ThumbnailUrl")]
            [Validation(Required=false)]
            public string ThumbnailUrl { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeHolder</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The application instance version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-04-02</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>The exception message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
