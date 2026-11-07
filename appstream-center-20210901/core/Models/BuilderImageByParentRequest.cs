// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class BuilderImageByParentRequest : TeaModel {
        /// <summary>
        /// <para>The business type to which the image belongs. <b>Required</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Basic product.</description></item>
        /// <item><description><b>2</b>: Personal cloud.</description></item>
        /// <item><description><b>3</b>: Cloud office.</description></item>
        /// <item><description><b>4</b>: Cloud Flow.</description></item>
        /// <item><description><b>10</b>: Personal edition.</description></item>
        /// <item><description><b>20</b>: Business edition.</description></item>
        /// <item><description><b>60</b>: Linggou team edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The capacity of the data cloud disk in the creation environment. Unit: GiB. Specify this parameter when a data cloud disk is required, and ensure that it meets the disk requirements of the selected resource specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DataDiskSize")]
        [Validation(Required=false)]
        public int? DataDiskSize { get; set; }

        /// <summary>
        /// <para>The description of the new image, which facilitates subsequent queries and differentiation of images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business image that includes office applications and standard configurations</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The operating system distribution information of the image. Enter the distribution identifier that is consistent with the parent image used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ubuntu 22.04 64-bit</para>
        /// </summary>
        [NameInMap("Distro")]
        [Validation(Required=false)]
        public string Distro { get; set; }

        /// <summary>
        /// <para>The list of driver IDs used when creating the image. A maximum of 200 items are supported. When you need to specify drivers, enter the IDs of existing drivers that are applicable to the target image.</para>
        /// <para><b>If PropertyMap.DRIVER_LIST is also specified, this parameter overwrites the driver list in it.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;6d4af751-f522-40d7-ab6c-4a0ae587****&quot;,&quot;b5bdf6c0-41de-4878-8963-e8324106****&quot;]</para>
        /// </summary>
        [NameInMap("DriverIdList")]
        [Validation(Required=false)]
        public List<string> DriverIdList { get; set; }

        /// <summary>
        /// <para>The image creation mode. Use the following mode:</para>
        /// <list type="bullet">
        /// <item><description><b>BUILDER_MANUAL</b>: Manually enter the creation environment to install applications and configure the image.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUILDER_MANUAL</para>
        /// </summary>
        [NameInMap("ImageCreateMode")]
        [Validation(Required=false)]
        public string ImageCreateMode { get; set; }

        /// <summary>
        /// <para>The name of the new image. <b>Required</b>. The name must start with a letter or a Chinese character, and can contain letters, digits, Chinese characters, colons (:), underscores (_), periods (.), and hyphens (-). It cannot start with http:// or https://. The length is calculated as 3 for each Chinese character and 1 for each other character. The total length must be 2 to 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OfficeImage_202611</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The language of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh-CN</b>: Simplified Chinese.</description></item>
        /// <item><description><b>zh-HK</b>: Traditional Chinese (Hong Kong).</description></item>
        /// <item><description><b>en-US</b>: English.</description></item>
        /// <item><description><b>ja-JP</b>: Japanese.</description></item>
        /// <item><description><b>CN</b>: Compatible value for Simplified Chinese.</description></item>
        /// <item><description><b>EN</b>: Compatible value for English.</description></item>
        /// <item><description><b>JP</b>: Compatible value for Japanese.</description></item>
        /// <item><description><b>CN-HK</b>: Compatible value for Traditional Chinese (Hong Kong).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The ID of the node specifications for the creation resources. You can invoke ListNodeInstanceType to query the ID. Select a specification that is active in the creation region and under the associated product, and meets the CPU or GPU computing requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appstreaming.general.4c8g</para>
        /// </summary>
        [NameInMap("NodeInstanceType")]
        [Validation(Required=false)]
        public string NodeInstanceType { get; set; }

        /// <summary>
        /// <para>The ID of the office network used by the creation resources. Specify this parameter when a specific office network is required, and ensure that it is consistent with the creation region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-example****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The package type of the image. Keep it consistent with the selected parent image and creation scenario. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Ecs</b>: ECS instance image.</description></item>
        /// <item><description><b>Vhd</b>: VHD application image.</description></item>
        /// <item><description><b>Container</b>: Container image.</description></item>
        /// <item><description><b>Ecs_Container</b>: ECS and container combined image.</description></item>
        /// <item><description><b>K8s_Node</b>: Kubernetes node image.</description></item>
        /// </list>
        /// <para><b>This operation does not provide the BaseImageId parameter. You cannot explicitly specify the Vhd or Container type that requires a base image to be configured separately.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>Ecs</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The ID of the parent image used to create the new image. <b>Required</b>. You can call ListImage to query the ID. An available distribution record of the parent image must exist in the region where the image is created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-bp1parent****</para>
        /// </summary>
        [NameInMap("ParentImageId")]
        [Validation(Required=false)]
        public string ParentImageId { get; set; }

        /// <summary>
        /// <para>The computing type of the creation resources.</para>
        /// <list type="bullet">
        /// <item><description><b>CPU</b>: Uses CPU compute resources.</description></item>
        /// <item><description><b>GPU</b>: Uses GPU compute resources.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPU</para>
        /// </summary>
        [NameInMap("PerformanceType")]
        [Validation(Required=false)]
        public string PerformanceType { get; set; }

        /// <summary>
        /// <para>The product to which the image belongs. <b>Required</b>. Use an activated product and keep it consistent with the selected parent image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CloudGame</b>: Cloud game.</description></item>
        /// <item><description><b>CloudApp</b>: Wuying Cloud App.</description></item>
        /// <item><description><b>CloudBrowser</b>: Secure browser.</description></item>
        /// <item><description><b>CloudDesktop</b>: Wuying Cloud Computer.</description></item>
        /// <item><description><b>ImageBuilder</b>: Image creation resource.</description></item>
        /// <item><description><b>ImageValidate</b>: Image validation resource.</description></item>
        /// <item><description><b>AndroidCloud</b>: Android cloud.</description></item>
        /// <item><description><b>GpuRender</b>: GPU rendering.</description></item>
        /// <item><description><b>AndroidGpuRender</b>: Android cloud GPU rendering.</description></item>
        /// <item><description><b>WuyingServer</b>: Enterprise edition workstation.</description></item>
        /// <item><description><b>GpuProxy</b>: GPU remote rendering proxy.</description></item>
        /// <item><description><b>GpuCache</b>: GPU remote rendering cache.</description></item>
        /// <item><description><b>AIAgent</b>: AI agent service.</description></item>
        /// <item><description><b>HostedDesktop</b>: Hosted computer.</description></item>
        /// <item><description><b>WuyingWorkstation</b>: Personal edition container workstation.</description></item>
        /// <item><description><b>WuyingWorkstationBusiness</b>: Business edition container workstation.</description></item>
        /// <item><description><b>WuyingWorkstationTeam</b>: Linggou container workstation team edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The extended properties of the image. Both keys and values are strings. This parameter can be omitted when no extended configuration is required.</para>
        /// <para>The property key for the driver list is DRIVER_LIST, and the value is a JSON string of an array of driver IDs. We recommend that you specify drivers by using DriverIdList. <b>If both DriverIdList and PropertyMap.DRIVER_LIST are specified, DriverIdList takes precedence.</b> Specify other extended properties only when their purposes and values are confirmed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;DRIVER_LIST&quot;:&quot;[\&quot;6d4af751-f522-40d7-ab6c-4a0ae587****\&quot;,\&quot;b5bdf6c0-41de-4878-8963-e8324106****\&quot;]&quot;}</para>
        /// </summary>
        [NameInMap("PropertyMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> PropertyMap { get; set; }

        /// <summary>
        /// <para>The list of resources required for image creation, such as the download URLs of applications to be installed. A maximum of 100 items are supported. The ResourceType and Resource of each item must correspond to each other.</para>
        /// </summary>
        [NameInMap("ResourceList")]
        [Validation(Required=false)]
        public List<BuilderImageByParentRequestResourceList> ResourceList { get; set; }
        public class BuilderImageByParentRequestResourceList : TeaModel {
            /// <summary>
            /// <para>The resource content corresponding to ResourceType. For the URL type, enter or return an accessible resource URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/apps/business/setup.exe">https://example.com/apps/business/setup.exe</a></para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <para>The provision method of the resource content. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HOSTED</b>: Hosted resource.</description></item>
            /// <item><description><b>TEXT</b>: Text resource.</description></item>
            /// <item><description><b>URL</b>: Resource provided through a URL.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>URL</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The running mode of the image creation environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: Normal running mode.</description></item>
        /// <item><description><b>COMPATIBLE</b>: Compatible running mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

        /// <summary>
        /// <para>The ID of the region where the image is created. The selected parent image must have been distributed to this region. Available regions are also affected by the region configurations of the account and product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// <para>The capacity of the system cloud disk in the creation environment. Unit: GiB. The capacity cannot be smaller than the system cloud disk capacity required by the parent image, and must meet the disk requirements of the selected resource specifications.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The list of vSwitch IDs used by the creation resources. A maximum of 100 items are supported. The vSwitches must belong to the selected office network and be located in the creation region.</para>
        /// </summary>
        [NameInMap("VSwitchIdList")]
        [Validation(Required=false)]
        public List<string> VSwitchIdList { get; set; }

        /// <summary>
        /// <para>The display name of the new image version, which is used to differentiate different versions of the same image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office environment-202611</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
