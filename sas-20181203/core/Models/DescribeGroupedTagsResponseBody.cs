// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedTagsResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>An array that consists of the statistics of the asset tags.</para>
        /// </summary>
        [NameInMap("GroupedFileds")]
        [Validation(Required=false)]
        public List<DescribeGroupedTagsResponseBodyGroupedFileds> GroupedFileds { get; set; }
        public class DescribeGroupedTagsResponseBodyGroupedFileds : TeaModel {
            /// <summary>
            /// <para>The number of assets to which the tag is added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>152</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            /// <summary>
            /// <para>The name of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InternetIp</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3252366</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public int? TagId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>151F6EB6-D5F3-417A-AF7B-4D84975DB586</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
