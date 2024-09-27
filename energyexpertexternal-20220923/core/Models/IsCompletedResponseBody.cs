// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class IsCompletedResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public IsCompletedResponseBodyData Data { get; set; }
        public class IsCompletedResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Modified time in milliseconds, e.g. 1711438780000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1711438780000</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <para>The unique key of this generation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>550c2b7b-f2e0-4176-ab0a-53ea4b355721</para>
            /// </summary>
            [NameInMap("taskKey")]
            [Validation(Required=false)]
            public string TaskKey { get; set; }

            /// <summary>
            /// <para>Unused temporarily.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("taskShortResult")]
            [Validation(Required=false)]
            public string TaskShortResult { get; set; }

            /// <summary>
            /// <para>The status of the report generation task. The possible values are <c>running</c>, <c>success</c>, and <c>error</c>, which mean generating, generating succeeded, and generating failed, respectively. If you encounter a result generation failure, check the model, correct the model, and then generate the result again.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The value is unique for each request. This facilitates subsequent troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
