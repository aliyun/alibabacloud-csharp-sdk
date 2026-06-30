// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCensRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// <para>You can specify up to five filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeCensRequestFilter> Filter { get; set; }
        public class DescribeCensRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CenId</b>: The ID of the CEN instance.</para>
            /// </description></item>
            /// <item><description><para><b>Name</b>: The name of the CEN instance.</para>
            /// </description></item>
            /// </list>
            /// <para>The logical relationship among multiple filter conditions is <b>AND</b>. All filter conditions must be met.</para>
            /// <para>You can specify up to five filter conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CenId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value.</para>
            /// <para>Specify the filter value based on the <b>Key</b>. You can specify multiple values for a key. The logical relationship among the values is <b>OR</b>. A resource is a match if it meets any of the specified values.</para>
            /// <para>You can specify up to five filter values for a filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-0xyeagctz5sfg9****</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>1</b> to <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the CEN instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm3unpnuw****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// <para>You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeCensRequestTag> Tag { get; set; }
        public class DescribeCensRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <para>The tag key cannot be an empty string. The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <para>The tag value can be an empty string or a string of up to 128 characters. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each tag key must have a corresponding tag value. You can specify up to 20 tag values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
