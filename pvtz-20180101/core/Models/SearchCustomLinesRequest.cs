// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class SearchCustomLinesRequest : TeaModel {
        /// <summary>
        /// <para>The end of the creation time range. This value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672136518234</para>
        /// </summary>
        [NameInMap("CreateTimestampEnd")]
        [Validation(Required=false)]
        public long? CreateTimestampEnd { get; set; }

        /// <summary>
        /// <para>The start of the creation time range. This value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672136518123</para>
        /// </summary>
        [NameInMap("CreateTimestampStart")]
        [Validation(Required=false)]
        public long? CreateTimestampStart { get; set; }

        /// <summary>
        /// <para>The list of creator IDs.</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public List<string> Creator { get; set; }

        /// <summary>
        /// <para>The IPv4 address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.1.1</para>
        /// </summary>
        [NameInMap("Ipv4")]
        [Validation(Required=false)]
        public string Ipv4 { get; set; }

        /// <summary>
        /// <para>The language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the custom ACL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number. The value starts from <b>1</b>. The default value is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. The maximum value is <b>100</b>. The default value is <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The end of the update time range. This value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672136518000</para>
        /// </summary>
        [NameInMap("UpdateTimestampEnd")]
        [Validation(Required=false)]
        public long? UpdateTimestampEnd { get; set; }

        /// <summary>
        /// <para>The start of the update time range. This value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672136515000</para>
        /// </summary>
        [NameInMap("UpdateTimestampStart")]
        [Validation(Required=false)]
        public long? UpdateTimestampStart { get; set; }

    }

}
