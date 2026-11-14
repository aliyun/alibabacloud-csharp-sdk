// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetImageByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. 200 indicates success. If the call fails, the corresponding error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The image information returned by the query.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetImageByIdResponseBodyData Data { get; set; }
        public class GetImageByIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of adapted applications for the image version.</para>
            /// </summary>
            [NameInMap("AdaptorInfoBOList")]
            [Validation(Required=false)]
            public List<GetImageByIdResponseBodyDataAdaptorInfoBOList> AdaptorInfoBOList { get; set; }
            public class GetImageByIdResponseBodyDataAdaptorInfoBOList : TeaModel {
                /// <summary>
                /// <para>The adaptor ID.</para>
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
                /// <para>The execution mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MANUAL</para>
                /// </summary>
                [NameInMap("AdaptorMode")]
                [Validation(Required=false)]
                public string AdaptorMode { get; set; }

                /// <summary>
                /// <para>The execution step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FINISH_ADAPT</para>
                /// </summary>
                [NameInMap("AdaptorStep")]
                [Validation(Required=false)]
                public string AdaptorStep { get; set; }

                /// <summary>
                /// <para>The numeric ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("Aid")]
                [Validation(Required=false)]
                public long? Aid { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the application belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

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
                /// <para>The theme color.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#FFFFFF</para>
                /// </summary>
                [NameInMap("AppThemeColor")]
                [Validation(Required=false)]
                public string AppThemeColor { get; set; }

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
                /// <para>The number of the business line to which the application belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public int? BizType { get; set; }

                /// <summary>
                /// <para>The name of the OSS bucket where the application file is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>appstream-example</para>
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The level-2 category of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public int? CategoryId { get; set; }

                /// <summary>
                /// <para>The level-1 category of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CategoryType")]
                [Validation(Required=false)]
                public int? CategoryType { get; set; }

                /// <summary>
                /// <para>The control parameters that can be configured by tenants and administrators.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("ControlParam")]
                [Validation(Required=false)]
                public string ControlParam { get; set; }

                /// <summary>
                /// <para>The ID of the disk where the application file is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-bp1example****</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// <para>The path of the executable file after the cloud application is installed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc.text</para>
                /// </summary>
                [NameInMap("ExecuteFileAddress")]
                [Validation(Required=false)]
                public string ExecuteFileAddress { get; set; }

                /// <summary>
                /// <para>The extension information of the adapted application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Extend")]
                [Validation(Required=false)]
                public string Extend { get; set; }

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
                /// <para>The file size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102400</para>
                /// </summary>
                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-25 15:13:57</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The last update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-25 15:13:57</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The optimization parameters that can be configured by administrators in the backend.</para>
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
                /// <para>The product type to which the application belongs.</para>
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
                /// <para>Specifies whether to skip installation. This parameter can be configured by tenants and administrators.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("SilenceFlag")]
                [Validation(Required=false)]
                public string SilenceFlag { get; set; }

                /// <summary>
                /// <para>The installation parameters that can be configured by tenants and administrators.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("SilenceParam")]
                [Validation(Required=false)]
                public string SilenceParam { get; set; }

                /// <summary>
                /// <para>The application adaptation status. For example, ADAPT_DONE indicates that the adaptation is complete.</para>
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

            }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the image belongs. The account ID for system images is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The ID of the base image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imgc-xxx</para>
            /// </summary>
            [NameInMap("BaseImageId")]
            [Validation(Required=false)]
            public string BaseImageId { get; set; }

            /// <summary>
            /// <para>The base image version ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iv-xxx</para>
            /// </summary>
            [NameInMap("BaseImageVersion")]
            [Validation(Required=false)]
            public string BaseImageVersion { get; set; }

            /// <summary>
            /// <para>The business line to which the image belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: basic business</description></item>
            /// <item><description>2: personal edition</description></item>
            /// <item><description>3: cloud office</description></item>
            /// <item><description>4: cloud streaming</description></item>
            /// <item><description>10: standard edition</description></item>
            /// </list>
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
            /// <para>appstream-example</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The description of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description</para>
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
            /// <para>2.3.0-xxx</para>
            /// </summary>
            [NameInMap("FotaVersion")]
            [Validation(Required=false)]
            public string FotaVersion { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-25 15:13:57</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-25 15:13:57</para>
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
            /// <para>The image extended information, which includes cloud disk specifications and GPU driver information. For VHD or container images, the extended information of the base image and base version is used.</para>
            /// </summary>
            [NameInMap("ImageExtendInfoModel")]
            [Validation(Required=false)]
            public GetImageByIdResponseBodyDataImageExtendInfoModel ImageExtendInfoModel { get; set; }
            public class GetImageByIdResponseBodyDataImageExtendInfoModel : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the image belongs. The account ID for system images is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

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
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-25 15:13:57</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The last update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-25 15:13:57</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

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
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>imgc-xxxx</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The image package type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Ecs: ECS image</description></item>
                /// <item><description>Vhd: Virtual disk image</description></item>
                /// <item><description>Container: Container image</description></item>
                /// <item><description>Ecs_Container: ECS and container composite image</description></item>
                /// <item><description>K8s_Node: Kubernetes node image</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("PackageType")]
                [Validation(Required=false)]
                public string PackageType { get; set; }

                /// <summary>
                /// <para>The size of the system cloud disk. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

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
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imgc-xxxx</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The name of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DemoImage</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The list of region distribution information for the image version.</para>
            /// </summary>
            [NameInMap("ImageRegionDistributeList")]
            [Validation(Required=false)]
            public List<GetImageByIdResponseBodyDataImageRegionDistributeList> ImageRegionDistributeList { get; set; }
            public class GetImageByIdResponseBodyDataImageRegionDistributeList : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the image belongs. The account ID for system images is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                /// <summary>
                /// <para>The ID of the ECS image corresponding to the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-bp1example****</para>
                /// </summary>
                [NameInMap("EcsImageId")]
                [Validation(Required=false)]
                public string EcsImageId { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-25 15:13:57</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The last update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-25 15:13:57</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>imgc-xxxx</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The processing message reported by the region distribution task.</para>
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
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The region distribution status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CREATING: Distributing</description></item>
                /// <item><description>AVAILABLE: Available</description></item>
                /// <item><description>CREATE_FAILED: Distribution failed</description></item>
                /// <item><description>DELETE: Deleted</description></item>
                /// </list>
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
            /// <para>The list of region IDs supported by the image.</para>
            /// </summary>
            [NameInMap("ImageRegionList")]
            [Validation(Required=false)]
            public List<string> ImageRegionList { get; set; }

            /// <summary>
            /// <para>The source of the image. For example, center indicates the central image service.</para>
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
            /// <item><description>System: system image</description></item>
            /// <item><description>User: custom image</description></item>
            /// <item><description>Shared: shared image</description></item>
            /// <item><description>Community: community image</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <para>The image language. If the packaging type is VHD or Container, this property is inherited from the image with the ECS packaging type in the same image combination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The ID of the latest image version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iv-xxx</para>
            /// </summary>
            [NameInMap("LatestVersionId")]
            [Validation(Required=false)]
            public string LatestVersionId { get; set; }

            /// <summary>
            /// <para>Indicates whether the returned version is the online version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("OnlineVersion")]
            [Validation(Required=false)]
            public bool? OnlineVersion { get; set; }

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
            /// <para>The operating system type of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Windows: Windows system</description></item>
            /// <item><description>Linux: Linux system</description></item>
            /// <item><description>Android: Android system</description></item>
            /// <item><description>Unknown: unknown system</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The image package type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Ecs: ECS image</description></item>
            /// <item><description>Vhd: Virtual disk image</description></item>
            /// <item><description>Container: Container image</description></item>
            /// <item><description>Ecs_Container: ECS and container composite image</description></item>
            /// <item><description>K8s_Node: Kubernetes node image</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// <para>The ID of the parent image, which indicates the image inheritance relationship. System images do not have parent images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imgc-xxx</para>
            /// </summary>
            [NameInMap("ParentImageId")]
            [Validation(Required=false)]
            public string ParentImageId { get; set; }

            /// <summary>
            /// <para>The parent image version ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iv-xxx</para>
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
            /// <para>The name of the operating system platform, which corresponds to Platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows Server 2022</para>
            /// </summary>
            [NameInMap("PlatformName")]
            [Validation(Required=false)]
            public string PlatformName { get; set; }

            /// <summary>
            /// <para>The product type to which the image belongs, such as CloudDesktop (Cloud Desktop), CloudApp (cloud application), and WuyingServer (WUYING Workspace Enterprise Edition workstation).</para>
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
            /// <para>The connection protocol used by the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ASP: Alibaba Cloud Streaming Protocol</description></item>
            /// <item><description>HDX: HDX protocol</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The image status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INIT: Initial.</description></item>
            /// <item><description>CREATING: Creating.</description></item>
            /// <item><description>AVAILABLE: Available.</description></item>
            /// <item><description>CREATE_FAILED: Creation failed.</description></item>
            /// <item><description>DELETE: Deleted.</description></item>
            /// </list>
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
        /// <para>The message returned by the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8737D130-BFD0-5D51-96F6-C08EB1139A25</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
