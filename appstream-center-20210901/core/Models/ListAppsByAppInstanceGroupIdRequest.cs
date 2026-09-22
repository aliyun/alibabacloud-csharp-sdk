// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAppsByAppInstanceGroupIdRequest : TeaModel {
        /// <summary>
        /// <para>The delivery group ID.</para>
        /// <list type="bullet">
        /// <item><description>WUYING Cloud Application delivery group: call the <a href="~~ListAppInstanceGroup~~">ListAppInstanceGroup</a> operation to obtain the ID.</description></item>
        /// <item><description>Cloud Browser group: specify the Cloud Browser group ID. Call the <a href="~~ListBrowserInstanceGroup~~">ListBrowserInstanceGroup</a> operation to obtain the ID.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is <b>required</b>. If it is not specified, the error code <c>InvalidParameter.AppInstanceGroupId</c> is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of applications to return per page. Valid values: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. The value must match the product type of the delivery group specified by AppInstanceGroupId. Otherwise, the error code <c>InvalidAppInstanceGroup.NotFound</c> is returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: WUYING Cloud Application.</description></item>
        /// <item><description>CloudBrowser: Cloud Browser.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
