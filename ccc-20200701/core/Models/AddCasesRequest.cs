// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class AddCasesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c58b9719-3bc3-441d-a4d3-fc0309ef7066</para>
        /// </summary>
        [NameInMap("CampaignId")]
        [Validation(Required=false)]
        public string CampaignId { get; set; }

        [NameInMap("CaseList")]
        [Validation(Required=false)]
        public List<AddCasesRequestCaseList> CaseList { get; set; }
        public class AddCasesRequestCaseList : TeaModel {
            [NameInMap("Caller")]
            [Validation(Required=false)]
            public string Caller { get; set; }

            [NameInMap("CustomVariables")]
            [Validation(Required=false)]
            public string CustomVariables { get; set; }

            [NameInMap("MaskedCallee")]
            [Validation(Required=false)]
            public string MaskedCallee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>188888****</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("ReferenceId")]
            [Validation(Required=false)]
            public string ReferenceId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
