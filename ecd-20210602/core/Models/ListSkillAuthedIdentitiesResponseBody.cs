// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20210602.Models
{
    public class ListSkillAuthedIdentitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of authorized objects.</para>
        /// </summary>
        [NameInMap("Identities")]
        [Validation(Required=false)]
        public List<ListSkillAuthedIdentitiesResponseBodyIdentities> Identities { get; set; }
        public class ListSkillAuthedIdentitiesResponseBodyIdentities : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic installation is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Automatic installation is enabled.</description></item>
            /// <item><description>false: Automatic installation is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoInstall")]
            [Validation(Required=false)]
            public bool? AutoInstall { get; set; }

            /// <summary>
            /// <para>The ID of the authorized object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-b9ej3xiok4tjbgf9x****</para>
            /// </summary>
            [NameInMap("IdentityId")]
            [Validation(Required=false)]
            public string IdentityId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5CC5E450-FC43-4F5B-B540-9964BD*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
