// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetSubPartnerListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSubPartnerListResponseBodyData Data { get; set; }
        public class GetSubPartnerListResponseBodyData : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ACTIVE_PERIOD</para>
            /// </summary>
            [NameInMap("AgreementStatus")]
            [Validation(Required=false)]
            public string AgreementStatus { get; set; }

            [NameInMap("AgreementStatusDesc")]
            [Validation(Required=false)]
            public string AgreementStatusDesc { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            [NameInMap("Contact")]
            [Validation(Required=false)]
            public string Contact { get; set; }

            [NameInMap("District")]
            [Validation(Required=false)]
            public string District { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-02-28 01:00:00</para>
            /// </summary>
            [NameInMap("JoinTime")]
            [Validation(Required=false)]
            public string JoinTime { get; set; }

            [NameInMap("MasterAccount")]
            [Validation(Required=false)]
            public string MasterAccount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1708588696796450</para>
            /// </summary>
            [NameInMap("MasterUid")]
            [Validation(Required=false)]
            public string MasterUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>P1233453</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
