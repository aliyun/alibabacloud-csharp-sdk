// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListUpgradeClientsResponseBody : TeaModel {
        /// <summary>
        /// <para>The update records of ehpcutil in the cluster.</para>
        /// </summary>
        [NameInMap("ClientRecords")]
        [Validation(Required=false)]
        public List<ListUpgradeClientsResponseBodyClientRecords> ClientRecords { get; set; }
        public class ListUpgradeClientsResponseBodyClientRecords : TeaModel {
            /// <summary>
            /// <para>The version of ehpcutil after the update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.21</para>
            /// </summary>
            [NameInMap("NewVersion")]
            [Validation(Required=false)]
            public string NewVersion { get; set; }

            /// <summary>
            /// <para>The version of ehpcutil before the update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.16</para>
            /// </summary>
            [NameInMap("OldVersion")]
            [Validation(Required=false)]
            public string OldVersion { get; set; }

            /// <summary>
            /// <para>The user ID (UID) whose ehpcutil is updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>129******84</para>
            /// </summary>
            [NameInMap("SubUid")]
            [Validation(Required=false)]
            public string SubUid { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-26T06:26:57.000Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The current version of ehpcutil in the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.21</para>
        /// </summary>
        [NameInMap("CurrentVersion")]
        [Validation(Required=false)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// <para>The latest version of ehpcutil that is released.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.22</para>
        /// </summary>
        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public string LatestVersion { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89A1AC0F-4A6C-4F3D-98F9-BEF9A823****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
