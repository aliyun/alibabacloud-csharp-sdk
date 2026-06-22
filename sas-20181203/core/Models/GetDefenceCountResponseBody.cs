// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetDefenceCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of alerts handled by accurate access control in the last 15 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefenceCount15Days")]
        [Validation(Required=false)]
        public int? DefenceCount15Days { get; set; }

        /// <summary>
        /// <para>The total number of alerts handled by accurate access control.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefenceCountTotal")]
        [Validation(Required=false)]
        public int? DefenceCountTotal { get; set; }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89AD16CC-97EE-50F3-9B12-9E28E5C8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of security alerts that have been handled in Security Center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SuspiciousDealtCount")]
        [Validation(Required=false)]
        public int? SuspiciousDealtCount { get; set; }

        /// <summary>
        /// <para>The number of alerting events handled by web tamper-proofing in the last 15 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TamperProof15Days")]
        [Validation(Required=false)]
        public int? TamperProof15Days { get; set; }

        /// <summary>
        /// <para>The total number of alerting events handled by web tamper-proofing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TamperProofTotal")]
        [Validation(Required=false)]
        public int? TamperProofTotal { get; set; }

    }

}
