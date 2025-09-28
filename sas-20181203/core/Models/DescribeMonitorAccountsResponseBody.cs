// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeMonitorAccountsResponseBody : TeaModel {
        [NameInMap("AccountIdInfos")]
        [Validation(Required=false)]
        public List<DescribeMonitorAccountsResponseBodyAccountIdInfos> AccountIdInfos { get; set; }
        public class DescribeMonitorAccountsResponseBodyAccountIdInfos : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("AddTime")]
            [Validation(Required=false)]
            public long? AddTime { get; set; }

            [NameInMap("IsCloudSiemAccount")]
            [Validation(Required=false)]
            public string IsCloudSiemAccount { get; set; }

            [NameInMap("IsSasAccount")]
            [Validation(Required=false)]
            public string IsSasAccount { get; set; }

            [NameInMap("OperatorUid")]
            [Validation(Required=false)]
            public string OperatorUid { get; set; }

            [NameInMap("PostBasicService")]
            [Validation(Required=false)]
            public int? PostBasicService { get; set; }

            [NameInMap("SasVersion")]
            [Validation(Required=false)]
            public string SasVersion { get; set; }

            [NameInMap("aliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            [NameInMap("isMarked")]
            [Validation(Required=false)]
            public string IsMarked { get; set; }

        }

        /// <summary>
        /// <para>The IDs of the members.</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<string> AccountIds { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>028CF634-5268-5660-9575-48C9ED6BF880</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
