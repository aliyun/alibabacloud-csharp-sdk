// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListCrowdsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of crowds.</para>
        /// </summary>
        [NameInMap("Crowds")]
        [Validation(Required=false)]
        public List<ListCrowdsResponseBodyCrowds> Crowds { get; set; }
        public class ListCrowdsResponseBodyCrowds : TeaModel {
            /// <summary>
            /// <para>The ID of the crowd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CrowdId")]
            [Validation(Required=false)]
            public string CrowdId { get; set; }

            /// <summary>
            /// <para>The description of the crowd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a test.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the crowd was created. The time is in ISO 8601 format and includes the time zone offset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The label of the crowd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>os=android</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The name of the crowd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crowd1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The quantity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public string Quantity { get; set; }

            /// <summary>
            /// <para>The source of the crowd.</para>
            /// <list type="bullet">
            /// <item><description>ManualInput: Manual input</description></item>
            /// <item><description>UploadFile: File upload</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ManualInput</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The users included in the crowd. Multiple users are separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1,user2</para>
            /// </summary>
            [NameInMap("Users")]
            [Validation(Required=false)]
            public string Users { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9763624B-5FBB-5E3A-9193-B1ADB554CEAE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of elements in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
