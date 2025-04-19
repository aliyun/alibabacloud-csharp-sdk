// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeFingerPrintTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The fingerprint templates.</para>
        /// </summary>
        [NameInMap("FingerPrintTemplates")]
        [Validation(Required=false)]
        public List<DescribeFingerPrintTemplatesResponseBodyFingerPrintTemplates> FingerPrintTemplates { get; set; }
        public class DescribeFingerPrintTemplatesResponseBodyFingerPrintTemplates : TeaModel {
            /// <summary>
            /// <para>The client ID. The system generates a unique ID for each client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2258a3d5-b8f8-4d79-a221-eaecf211****</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The time when the template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-13T13:26:29Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Finger 1</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liming</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// <para>The logon time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-13T13:26:29Z</para>
            /// </summary>
            [NameInMap("LoginTime")]
            [Validation(Required=false)]
            public string LoginTime { get; set; }

            /// <summary>
            /// <para>The office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-074949****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C1D3FBE-84E1-5ABB-AD98-2003AC71****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
