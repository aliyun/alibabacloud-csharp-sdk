// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetEffectiveImageByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned by the API. A value of 200 indicates success. If the call fails, the corresponding error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The image information returned by the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Object</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEffectiveImageByIdResponseBodyData Data { get; set; }
        public class GetEffectiveImageByIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the image belongs. The account ID for a system image is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100931896542****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The business line to which the image belongs. 1: basic business. 2: Personal Edition. 3: Cloud Office. 4: Cloud Streaming. 10: Standard Edition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            /// <summary>
            /// <para>The image description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The description document of the image in Markdown format.</para>
            /// 
            /// <b>Example:</b>
            /// <h2>this is a test document</h2>
            /// </summary>
            [NameInMap("Document")]
            [Validation(Required=false)]
            public string Document { get; set; }

            /// <summary>
            /// <para>The environment ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eid-***</para>
            /// </summary>
            [NameInMap("EnvironmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// <para>The creation time. The time is in RFC 3339 format. The Z in the example indicates the UTC time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-10T01:33:37Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last update time. The time is in RFC 3339 format. The Z in the example indicates the UTC time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-11T02:19:27Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The URL of the image icon.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.jpg">https://xxx.jpg</a></para>
            /// </summary>
            [NameInMap("ImageIconUrl")]
            [Validation(Required=false)]
            public string ImageIconUrl { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>img-bp1234567890abcde</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The details of the image versions that actually take effect in each region. For the same region, the configured newer version takes precedence.</para>
            /// </summary>
            [NameInMap("ImageInfoRegionModelList")]
            [Validation(Required=false)]
            public List<GetEffectiveImageByIdResponseBodyDataImageInfoRegionModelList> ImageInfoRegionModelList { get; set; }
            public class GetEffectiveImageByIdResponseBodyDataImageInfoRegionModelList : TeaModel {
                /// <summary>
                /// <para>The list of adapted applications for the image version.</para>
                /// </summary>
                [NameInMap("AdaptorInfoBOList")]
                [Validation(Required=false)]
                public List<GetEffectiveImageByIdResponseBodyDataImageInfoRegionModelListAdaptorInfoBOList> AdaptorInfoBOList { get; set; }
                public class GetEffectiveImageByIdResponseBodyDataImageInfoRegionModelListAdaptorInfoBOList : TeaModel {
                    /// <summary>
                    /// <para>The adapter ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>adt-13ff3****</para>
                    /// </summary>
                    [NameInMap("AdaptorId")]
                    [Validation(Required=false)]
                    public string AdaptorId { get; set; }

                    /// <summary>
                    /// <para>The adaptor message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("AdaptorMessage")]
                    [Validation(Required=false)]
                    public string AdaptorMessage { get; set; }

                    /// <summary>
                    /// <para>The adaptation mode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MANUAL</para>
                    /// </summary>
                    [NameInMap("AdaptorMode")]
                    [Validation(Required=false)]
                    public string AdaptorMode { get; set; }

                    /// <summary>
                    /// <para>The adaptation phase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FINISH_ADAPT</para>
                    /// </summary>
                    [NameInMap("AdaptorStep")]
                    [Validation(Required=false)]
                    public string AdaptorStep { get; set; }

                    /// <summary>
                    /// <para>The application icon.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>https://****.jpg</para>
                    /// </summary>
                    [NameInMap("AppIconUrl")]
                    [Validation(Required=false)]
                    public string AppIconUrl { get; set; }

                    /// <summary>
                    /// <para>The application ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>app-0aae4rgle910jh689</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <para>The application name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>idb-ent-console</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    /// <summary>
                    /// <para>The application script.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;param&quot;:&quot;test&quot;, &quot;startCmd&quot;:&quot;test.exe&quot;}</para>
                    /// </summary>
                    [NameInMap("AppScript")]
                    [Validation(Required=false)]
                    public string AppScript { get; set; }

                    /// <summary>
                    /// <para>The application type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>USER_APP</para>
                    /// </summary>
                    [NameInMap("AppType")]
                    [Validation(Required=false)]
                    public string AppType { get; set; }

                    /// <summary>
                    /// <para>The application version ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>apv-****</para>
                    /// </summary>
                    [NameInMap("AppVersionId")]
                    [Validation(Required=false)]
                    public string AppVersionId { get; set; }

                    /// <summary>
                    /// <para>The version name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0</para>
                    /// </summary>
                    [NameInMap("AppVersionName")]
                    [Validation(Required=false)]
                    public string AppVersionName { get; set; }

                    /// <summary>
                    /// <para>The version number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0.0</para>
                    /// </summary>
                    [NameInMap("AppVersionNumber")]
                    [Validation(Required=false)]
                    public string AppVersionNumber { get; set; }

                    /// <summary>
                    /// <para>The business line ID of the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("BizType")]
                    [Validation(Required=false)]
                    public int? BizType { get; set; }

                    /// <summary>
                    /// <para>The name of the OSS bucket where the application files are located.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xiaowutest-j</para>
                    /// </summary>
                    [NameInMap("BucketName")]
                    [Validation(Required=false)]
                    public string BucketName { get; set; }

                    /// <summary>
                    /// <para>The level-2 application category, such as design software, office, and browsers. This parameter is not available to the public.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("CategoryId")]
                    [Validation(Required=false)]
                    public int? CategoryId { get; set; }

                    /// <summary>
                    /// <para>The level-1 application category, such as cloud applications and cloud games. This parameter is not available to the public.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CategoryType")]
                    [Validation(Required=false)]
                    public int? CategoryType { get; set; }

                    /// <summary>
                    /// <para>The control parameters that can be configured by tenants and administrators. This parameter is not available to the public.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("ControlParam")]
                    [Validation(Required=false)]
                    public string ControlParam { get; set; }

                    /// <summary>
                    /// <para>The path of the executable file. This parameter is not available to the public.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>abc.text</para>
                    /// </summary>
                    [NameInMap("ExecuteFileAddress")]
                    [Validation(Required=false)]
                    public string ExecuteFileAddress { get; set; }

                    /// <summary>
                    /// <para>The file name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>filename_install.exe</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <para>The file path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/tenant/123</para>
                    /// </summary>
                    [NameInMap("FilePath")]
                    [Validation(Required=false)]
                    public string FilePath { get; set; }

                    /// <summary>
                    /// <para>The file size. Unit: KB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>102400</para>
                    /// </summary>
                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public long? FileSize { get; set; }

                    /// <summary>
                    /// <para>The optimization parameters configured in the backend by administrators.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("OptimizeParam")]
                    [Validation(Required=false)]
                    public string OptimizeParam { get; set; }

                    /// <summary>
                    /// <para>The original application type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CLIENT_BASE</para>
                    /// </summary>
                    [NameInMap("OriginAppType")]
                    [Validation(Required=false)]
                    public string OriginAppType { get; set; }

                    /// <summary>
                    /// <para>The operating system type applicable to the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Windows</para>
                    /// </summary>
                    [NameInMap("OsType")]
                    [Validation(Required=false)]
                    public string OsType { get; set; }

                    /// <summary>
                    /// <para>The application service port. For applications that require port-based access, specify the actual port number that the application listens on.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9000</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// <para>The product type of the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CloudDesktop</para>
                    /// </summary>
                    [NameInMap("ProductType")]
                    [Validation(Required=false)]
                    public string ProductType { get; set; }

                    /// <summary>
                    /// <para>The runtime environment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WINDOWS_MULTI_SESSION</para>
                    /// </summary>
                    [NameInMap("RuntimeEnv")]
                    [Validation(Required=false)]
                    public string RuntimeEnv { get; set; }

                    /// <summary>
                    /// <para>Specifies whether silent installation is enabled. This parameter can be configured by tenants and administrators, but is not available to the public.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("SilenceFlag")]
                    [Validation(Required=false)]
                    public string SilenceFlag { get; set; }

                    /// <summary>
                    /// <para>The silent installation parameters. This parameter is not available to the public.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("SilenceParam")]
                    [Validation(Required=false)]
                    public string SilenceParam { get; set; }

                    /// <summary>
                    /// <para>The application adaptation status. For example, ADAPT_DONE indicates that the adaptation is completed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ADAPT_DONE</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The sub-application type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SAAS</para>
                    /// </summary>
                    [NameInMap("SubAppType")]
                    [Validation(Required=false)]
                    public string SubAppType { get; set; }

                    /// <summary>
                    /// <para>The URL path suffix for application access. This suffix and the application service port together describe the access entry point.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/index</para>
                    /// </summary>
                    [NameInMap("UrlSuffix")]
                    [Validation(Required=false)]
                    public string UrlSuffix { get; set; }

                }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the image belongs. The account ID for a system image is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13605346******</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                /// <summary>
                /// <para>The application list, which displays only the application names and IDs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("AppList")]
                [Validation(Required=false)]
                public List<GetEffectiveImageByIdResponseBodyDataImageInfoRegionModelListAppList> AppList { get; set; }
                public class GetEffectiveImageByIdResponseBodyDataImageInfoRegionModelListAppList : TeaModel {
                    /// <summary>
                    /// <para>The application ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>app-0aae4rxw78****</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <para>The application name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>idb-ent-console</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                }

                /// <summary>
                /// <para>The base image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>imgc-dewgefwc******</para>
                /// </summary>
                [NameInMap("BaseImageId")]
                [Validation(Required=false)]
                public string BaseImageId { get; set; }

                /// <summary>
                /// <para>The base image version ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iv-adbef134****</para>
                /// </summary>
                [NameInMap("BaseImageVersion")]
                [Validation(Required=false)]
                public string BaseImageVersion { get; set; }

                /// <summary>
                /// <para>The business line to which the image belongs. 1: basic business. 2: Personal Edition. 3: Cloud Office. 4: Cloud Streaming. 10: Standard Edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public int? BizType { get; set; }

                /// <summary>
                /// <para>The name of the OSS bucket where the image file is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>monitor-record-sh-twg2is</para>
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The image description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>this is test image</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The list of feature tags supported by the image.</para>
                /// </summary>
                [NameInMap("FeatureList")]
                [Validation(Required=false)]
                public List<string> FeatureList { get; set; }

                /// <summary>
                /// <para>The FOTA version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.0.11-R-20260624.195825</para>
                /// </summary>
                [NameInMap("FotaVersion")]
                [Validation(Required=false)]
                public string FotaVersion { get; set; }

                /// <summary>
                /// <para>The creation time. The time is in RFC 3339 format. The Z in the example indicates the UTC time zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-09-12T13:01:09Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The last update time. The time is in RFC 3339 format. The Z in the example indicates the UTC time zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-07-16T07:39:43Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The image creation method. For example, BUILDER_MANUAL indicates manual creation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BUILDER_MANUAL</para>
                /// </summary>
                [NameInMap("ImageCreateMode")]
                [Validation(Required=false)]
                public string ImageCreateMode { get; set; }

                /// <summary>
                /// <para>The image extended information, including disk specifications and GPU driver information. VHD or Container images use the extended information of their base image and base version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("ImageExtendInfoModel")]
                [Validation(Required=false)]
                public GetEffectiveImageByIdResponseBodyDataImageInfoRegionModelListImageExtendInfoModel ImageExtendInfoModel { get; set; }
                public class GetEffectiveImageByIdResponseBodyDataImageInfoRegionModelListImageExtendInfoModel : TeaModel {
                    /// <summary>
                    /// <para>The size of the data cloud disk. Unit: GiB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("DataDiskSize")]
                    [Validation(Required=false)]
                    public int? DataDiskSize { get; set; }

                    /// <summary>
                    /// <para>The GPU category.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("GpuCategory")]
                    [Validation(Required=false)]
                    public int? GpuCategory { get; set; }

                    /// <summary>
                    /// <para>The GPU driver version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("GpuDriverVersion")]
                    [Validation(Required=false)]
                    public string GpuDriverVersion { get; set; }

                    /// <summary>
                    /// <para>The size of the system cloud disk. Unit: GiB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("SystemDiskSize")]
                    [Validation(Required=false)]
                    public int? SystemDiskSize { get; set; }

                }

                /// <summary>
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>imgc-0aae4rgk5yaa*****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The image name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image0625</para>
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// <para>The image distribution information for the current region.</para>
                /// </summary>
                [NameInMap("ImageRegionDistribute")]
                [Validation(Required=false)]
                public GetEffectiveImageByIdResponseBodyDataImageInfoRegionModelListImageRegionDistribute ImageRegionDistribute { get; set; }
                public class GetEffectiveImageByIdResponseBodyDataImageInfoRegionModelListImageRegionDistribute : TeaModel {
                    /// <summary>
                    /// <para>The processing information reported by the region distribution task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The distribution progress of the image in the region, expressed as a percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                    /// <summary>
                    /// <para>The ID of the region where the image is distributed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-shanghai</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The region distribution status. Valid values: CREATING: distributing. AVAILABLE: available. CREATE_FAILED: distribution failed. DELETE: deleted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AVAILABLE</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The logical ID of the image on the unit side, which can be different from the central image ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>m-1bdedef****</para>
                    /// </summary>
                    [NameInMap("UnitImageId")]
                    [Validation(Required=false)]
                    public string UnitImageId { get; set; }

                }

                /// <summary>
                /// <para>The image source. For example, center indicates the central image service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>center</para>
                /// </summary>
                [NameInMap("ImageSource")]
                [Validation(Required=false)]
                public string ImageSource { get; set; }

                /// <summary>
                /// <para>The image type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>System: system images.</description></item>
                /// <item><description>User: custom images.</description></item>
                /// <item><description>Shared: shared images.</description></item>
                /// <item><description>Community: community images.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>System</para>
                /// </summary>
                [NameInMap("ImageType")]
                [Validation(Required=false)]
                public string ImageType { get; set; }

                /// <summary>
                /// <para>The image language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh-CN</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <para>The ID of the latest version of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iv-1wder3ere****</para>
                /// </summary>
                [NameInMap("LatestVersionId")]
                [Validation(Required=false)]
                public string LatestVersionId { get; set; }

                /// <summary>
                /// <para>Indicates whether the returned version is the online version. Valid values: true: Yes. false: No.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("OnlineVersion")]
                [Validation(Required=false)]
                public bool? OnlineVersion { get; set; }

                /// <summary>
                /// <para>The ID of the current online version of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iv-1wder3ere****</para>
                /// </summary>
                [NameInMap("OnlineVersionId")]
                [Validation(Required=false)]
                public string OnlineVersionId { get; set; }

                /// <summary>
                /// <para>The operating system type of the image. Windows: Windows system. Linux: Linux system. Android: Android system. Unknown: unknown system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Windows</para>
                /// </summary>
                [NameInMap("OsType")]
                [Validation(Required=false)]
                public string OsType { get; set; }

                /// <summary>
                /// <para>The image packaging type. Ecs: ECS image. Vhd: virtual disk image. Container: container image. Ecs_Container: combined ECS and container image. K8s_Node: Kubernetes node image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("PackageType")]
                [Validation(Required=false)]
                public string PackageType { get; set; }

                /// <summary>
                /// <para>The parent image ID, which indicates the image inheritance relationship. System images do not have parent images.</para>
                /// 
                /// <b>Example:</b>
                /// <para>desktopimage-windows-11-64-asp</para>
                /// </summary>
                [NameInMap("ParentImageId")]
                [Validation(Required=false)]
                public string ParentImageId { get; set; }

                /// <summary>
                /// <para>The parent image version ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iv-12ededgjj***</para>
                /// </summary>
                [NameInMap("ParentImageVersion")]
                [Validation(Required=false)]
                public string ParentImageVersion { get; set; }

                /// <summary>
                /// <para>The operating system platform ID. For example, 33 indicates Windows Server 2022.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33</para>
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public int? Platform { get; set; }

                /// <summary>
                /// <para>The operating system platform name, which corresponds to Platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Windows Server 2022</para>
                /// </summary>
                [NameInMap("PlatformName")]
                [Validation(Required=false)]
                public string PlatformName { get; set; }

                /// <summary>
                /// <para>The product type to which the image belongs, such as CloudDesktop (Cloud Desktop), CloudApp (Cloud App), and WuyingServer (WUYING Workspace Enterprise Edition workstation).</para>
                /// 
                /// <b>Example:</b>
                /// <para>CloudApp</para>
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                /// <summary>
                /// <para>The extended properties of the image version in key-value pairs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("PropertyMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> PropertyMap { get; set; }

                /// <summary>
                /// <para>The connection protocol used by the image. ASP: Alibaba Cloud Streaming Protocol. HDX: HDX protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ASP</para>
                /// </summary>
                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public string ProtocolType { get; set; }

                /// <summary>
                /// <para>The ID of the region to which the image information belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The image status. INIT: initializing. CREATING: creating. AVAILABLE: available. CREATE_FAILED: creation failed. DELETE: deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INIT</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The image version ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iv-xxx</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DemoImage</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The list of region IDs supported by the image.</para>
            /// </summary>
            [NameInMap("ImageRegionList")]
            [Validation(Required=false)]
            public List<string> ImageRegionList { get; set; }

            /// <summary>
            /// <para>The image type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>System: system images.</description></item>
            /// <item><description>User: custom images.</description></item>
            /// <item><description>Shared: shared images.</description></item>
            /// <item><description>Community: community images.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <para>The ID of the latest version of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iv-xxx</para>
            /// </summary>
            [NameInMap("LatestVersionId")]
            [Validation(Required=false)]
            public string LatestVersionId { get; set; }

            /// <summary>
            /// <para>The data cloud disk size of the online version. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("OnlineVersionDataDiskSize")]
            [Validation(Required=false)]
            public int? OnlineVersionDataDiskSize { get; set; }

            /// <summary>
            /// <para>The ID of the current online version of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iv-xxxx</para>
            /// </summary>
            [NameInMap("OnlineVersionId")]
            [Validation(Required=false)]
            public string OnlineVersionId { get; set; }

            /// <summary>
            /// <para>The system cloud disk size of the online version. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("OnlineVersionSystemDiskSize")]
            [Validation(Required=false)]
            public int? OnlineVersionSystemDiskSize { get; set; }

            /// <summary>
            /// <para>Indicates whether disk encryption is enabled for the online version. Valid values: true: Enabled. false: Disabled.</para>
            /// </summary>
            [NameInMap("OnlineVersionVolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? OnlineVersionVolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// <para>The KMS key ID used when disk encryption is enabled for the online version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a7b3c0c8-xxxx</para>
            /// </summary>
            [NameInMap("OnlineVersionVolumeEncryptionKey")]
            [Validation(Required=false)]
            public string OnlineVersionVolumeEncryptionKey { get; set; }

            /// <summary>
            /// <para>The operating system type of the image. Windows: Windows system. Linux: Linux system. Android: Android system. Unknown: unknown system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The image packaging type. Ecs: ECS image. Vhd: virtual disk image. Container: container image. Ecs_Container: combined ECS and container image. K8s_Node: Kubernetes node image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// <para>The parent image ID, which indicates the image inheritance relationship. System images do not have parent images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imgc-xxx</para>
            /// </summary>
            [NameInMap("ParentImageId")]
            [Validation(Required=false)]
            public string ParentImageId { get; set; }

            /// <summary>
            /// <para>The product type to which the image belongs, such as CloudDesktop (Cloud Desktop), CloudApp (Cloud App), and WuyingServer (WUYING Workspace Enterprise Edition workstation).</para>
            /// 
            /// <b>Example:</b>
            /// <para>WuyingServer</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The connection protocol used by the image. ASP: Alibaba Cloud Streaming Protocol. HDX: HDX protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The rating score of the image, with a maximum score of 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>95</para>
            /// </summary>
            [NameInMap("Rating")]
            [Validation(Required=false)]
            public int? Rating { get; set; }

            /// <summary>
            /// <para>The image status. INIT: initializing. CREATING: creating. AVAILABLE: available. CREATE_FAILED: creation failed. DELETE: deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INIT</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of image tags.</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<GetEffectiveImageByIdResponseBodyDataTagList> TagList { get; set; }
            public class GetEffectiveImageByIdResponseBodyDataTagList : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>inner</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The image version ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iv-agde4****</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

        /// <summary>
        /// <para>The message returned by the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50158E8B-992E-1286-B174-**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values: true: Successful. false: Failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
