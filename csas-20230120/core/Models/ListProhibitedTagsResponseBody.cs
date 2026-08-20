// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListProhibitedTagsResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>287434FF-344F-565A-8623-439005BA9287</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of prohibited software tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListProhibitedTagsResponseBodyTags> Tags { get; set; }
        public class ListProhibitedTagsResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The time when the prohibited software tag was created, in the yyyy-MM-dd HH:mm:ss format. The time is in the UTC+8 time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-10 11:39:34</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the prohibited software tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>created</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the tag is a system built-in device tag. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: A system built-in device tag.</description></item>
            /// <item><description><b>false</b>: A user-defined device tag.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The name of the prohibited software tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The collection of software prohibition policy IDs that reference the tag.</para>
            /// </summary>
            [NameInMap("PolicyIds")]
            [Validation(Required=false)]
            public List<string> PolicyIds { get; set; }

            /// <summary>
            /// <para>The collection of prohibited software IDs included in the tag.</para>
            /// </summary>
            [NameInMap("SoftwareIds")]
            [Validation(Required=false)]
            public List<string> SoftwareIds { get; set; }

            /// <summary>
            /// <para>The ID of the prohibited software tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-7b2c9e4a1d8f****</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

        }

        /// <summary>
        /// <para>The total number of prohibited software tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
