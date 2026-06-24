// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAppInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The application image ID. You can obtain this value from the Image Management page in the WUYING Cloud Application console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>img-8z4nztpaqvay4****</para>
        /// </summary>
        [NameInMap("AppCenterImageId")]
        [Validation(Required=false)]
        public string AppCenterImageId { get; set; }

        /// <summary>
        /// <para>The delivery group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The delivery group name. Fuzzy match is used for the query. For example, if you set the delivery group name to <c>Office App</c>, all delivery groups whose names contain <c>Office App</c> are returned, such as <c>My Office App</c> and <c>Office App A</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>办公应用</para>
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>The region ID of the delivery group. For more information about supported regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Limits</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ExcludedUserGroupIds")]
        [Validation(Required=false)]
        public List<string> ExcludedUserGroupIds { get; set; }

        /// <summary>
        /// <para>The specification type ID of the purchased resources. You can call the <a href="~~ListNodeInstanceType~~">ListNodeInstanceType</a> operation to obtain this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appstreaming.vgpu.4c8g.2g</para>
        /// </summary>
        [NameInMap("NodeInstanceType")]
        [Validation(Required=false)]
        public string NodeInstanceType { get; set; }

        /// <summary>
        /// <para>The office network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hongkong+dir-643067****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The page number of the query results to display.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of query results per page. Maximum value: <c>100</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        [Obsolete]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of delivery group statuses.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListAppInstanceGroupRequestTag> Tag { get; set; }
        public class ListAppInstanceGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>department</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>design</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

    }

}
