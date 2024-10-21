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
        /// <para>You can specify at most five filter conditions in each call.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeCensRequestFilter> Filter { get; set; }
        public class DescribeCensRequestFilter : TeaModel {
            /// <summary>
            /// <para>The key of the filter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CenId</b>: the ID of a CEN instance.</description></item>
            /// <item><description><b>Name</b>: the name of a CEN instance.</description></item>
            /// </list>
            /// <para>By default, the logical operator among filter conditions is <b>AND</b>. Information about a CEN instance is returned only if the CEN instance matches all filter conditions.</para>
            /// <para>You can specify at most five filter conditions in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CenId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter condition.</para>
            /// <para>Specify a filter value based on the <b>Key</b> parameter. You can specify multiple values for a filter <b>key</b>. The logical operator among multiple filter values is <b>OR</b>. If a CEN instance matches one or more of the values that you specify, the CEN instance matches the filter condition.</para>
            /// <para>You can specify at most five values in each filter condition.</para>
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
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
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
        /// <para>You can specify at most 20 tags in each call.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeCensRequestTag> Tag { get; set; }
        public class DescribeCensRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag keys.</para>
            /// <para>The tag keys cannot be an empty string. The tag keys can be up to 64 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify at most 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag values.</para>
            /// <para>The tag values can be 0 to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each tag key must have a unique tag value. You can specify at most 20 tag values in each call.</para>
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
