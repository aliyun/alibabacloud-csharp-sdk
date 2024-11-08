// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListInstancePatchesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The information about the patch.</para>
        /// </summary>
        [NameInMap("Patches")]
        [Validation(Required=false)]
        public List<ListInstancePatchesResponseBodyPatches> Patches { get; set; }
        public class ListInstancePatchesResponseBodyPatches : TeaModel {
            /// <summary>
            /// <para>The classification of the patch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("Classification")]
            [Validation(Required=false)]
            public string Classification { get; set; }

            /// <summary>
            /// <para>The time when the patch was installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-28T07:07:20Z</para>
            /// </summary>
            [NameInMap("InstalledTime")]
            [Validation(Required=false)]
            public string InstalledTime { get; set; }

            /// <summary>
            /// <para>The Id of KBId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apt-utils.amd64</para>
            /// </summary>
            [NameInMap("KBId")]
            [Validation(Required=false)]
            public string KBId { get; set; }

            /// <summary>
            /// <para>The level of the severity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>important</para>
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// <para>The status of the installation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Installed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the patch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>isc-dhcp-common.amd64:4.3.5-3ubuntu7.3</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A615755-9C86-5EA6-BF9E-6E8F1AFF9403</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
