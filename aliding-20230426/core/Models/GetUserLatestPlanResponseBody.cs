// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetUserLatestPlanResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("accountHandleStatus")]
        [Validation(Required=false)]
        public int? AccountHandleStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-02-02</para>
        /// </summary>
        [NameInMap("accountHandleTime")]
        [Validation(Required=false)]
        public string AccountHandleTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("accountType")]
        [Validation(Required=false)]
        public int? AccountType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-02-05</para>
        /// </summary>
        [NameInMap("agreementFirstSignTime")]
        [Validation(Required=false)]
        public string AgreementFirstSignTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-02-06</para>
        /// </summary>
        [NameInMap("agreementLastSignTime")]
        [Validation(Required=false)]
        public string AgreementLastSignTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("agreementStatus")]
        [Validation(Required=false)]
        public int? AgreementStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-02-04</para>
        /// </summary>
        [NameInMap("dataHandleEndTime")]
        [Validation(Required=false)]
        public string DataHandleEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-02-03</para>
        /// </summary>
        [NameInMap("dataHandleStartTime")]
        [Validation(Required=false)]
        public string DataHandleStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("dataHandleStatus")]
        [Validation(Required=false)]
        public int? DataHandleStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("exclusivePlan")]
        [Validation(Required=false)]
        public int? ExclusivePlan { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("newAccountUid")]
        [Validation(Required=false)]
        public long? NewAccountUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
