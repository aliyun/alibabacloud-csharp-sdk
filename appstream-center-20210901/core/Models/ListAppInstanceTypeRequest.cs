// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAppInstanceTypeRequest : TeaModel {
        /// <summary>
        /// <para>The application image ID. The current session specification query does not filter based on this parameter. Omit this parameter. Do not infer image compatibility based on whether this parameter is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>img-8z4nztpaqvay4****</para>
        /// </summary>
        [NameInMap("AppCenterImageId")]
        [Validation(Required=false)]
        public string AppCenterImageId { get; set; }

        /// <summary>
        /// <para>The session specification code. Exact match is performed based on the complete code. If this parameter and <c>AppInstanceTypeList</c> are specified at the same time, the results are filtered by intersection. You can perform a conditional query without this parameter by using this operation first, and then select the returned codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appstreaming.vgpu.4c8g</para>
        /// </summary>
        [NameInMap("AppInstanceType")]
        [Validation(Required=false)]
        public string AppInstanceType { get; set; }

        /// <summary>
        /// <para>The specification family code. Exact match is performed based on the complete code. Use the specification family value from the query results. Do not extract it from the specification name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6</para>
        /// </summary>
        [NameInMap("AppInstanceTypeFamily")]
        [Validation(Required=false)]
        public string AppInstanceTypeFamily { get; set; }

        /// <summary>
        /// <para>The list of session specification codes. Up to 100 items are supported. This parameter takes effect by intersection with other filtering conditions. If this parameter and <c>AppInstanceType</c> are specified at the same time, the results must also match the single code.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AppInstanceTypeList")]
        [Validation(Required=false)]
        public List<string> AppInstanceTypeList { get; set; }

        /// <summary>
        /// <para>The business region ID. If this parameter is omitted, the region of the current request is used. The specifications that can be queried may vary by region and account. You can call <a href="https://api.aliyun.com/document/appstream-center/2021-09-01/ListRegions">ListRegions</a> to obtain the business region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The specification category filtering condition. If this parameter is omitted, no category filtering condition is added. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Cpu</c>: CPU specification.</description></item>
        /// <item><description><c>Gpu</c>: GPU specification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Gpu</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The billing method for filtering available specifications. If this parameter is omitted, no billing method condition is added. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>PrePaid</c>: Subscription.</description></item>
        /// <item><description><c>PostPaid</c>: Pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The number of CPU cores for exact filtering. Use a decimal numeric string. Unit: cores. If this parameter is omitted, the number of CPU cores is not limited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public string Cpu { get; set; }

        /// <summary>
        /// <para>The GPU memory capacity for exact filtering. Unit: MB. If this parameter is omitted, the GPU memory capacity is not limited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("GpuMemory")]
        [Validation(Required=false)]
        public int? GpuMemory { get; set; }

        /// <summary>
        /// <para>The language for the specification name.</para>
        /// <list type="bullet">
        /// <item><description><c>zh-CN</c>: Use the Chinese name of the specification.</description></item>
        /// <item><description>Other values or omitted: Use the specification code as the name.</description></item>
        /// </list>
        /// <para>This parameter only affects the display of <c>InstanceTypeName</c> and does not change the specification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The memory capacity for exact filtering. Unit: MB. If this parameter is omitted, the memory capacity is not limited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8192</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The operating system type. Use the following value for the Wuying Cloud Application (CloudApp) scenario:</para>
        /// <list type="bullet">
        /// <item><description><c>Windows</c>: Windows operating system.</description></item>
        /// </list>
        /// <para>If this parameter is omitted, no operating system filtering condition is added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The page number. Explicitly specify a page number starting from 1. If this parameter is omitted, the default value 0 is used to query the first batch of results. For subsequent pages, request in the order of 1, 2, and 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of specifications returned per page. Unit: entries. Default value: 200. Explicitly set a positive integer that meets your business needs. The default value here does not represent the maximum value allowed by the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. Set the value to the following fixed value when you call this operation:</para>
        /// <list type="bullet">
        /// <item><description><c>CloudApp</c>: Wuying Cloud Application.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the specification inventory at the same time. Default value: <c>false</c>.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Queries the inventory and returns InventoryInfo when inventory information is available.</description></item>
        /// <item><description><c>false</c>: Queries only the specifications and does not query the inventory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("QueryInventory")]
        [Validation(Required=false)]
        public bool? QueryInventory { get; set; }

    }

}
