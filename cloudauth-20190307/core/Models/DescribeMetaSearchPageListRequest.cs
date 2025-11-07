// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeMetaSearchPageListRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_CARD_2_META</para>
        /// </summary>
        [NameInMap("Api")]
        [Validation(Required=false)]
        public string Api { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>610*************1181</para>
        /// </summary>
        [NameInMap("BankCard")]
        [Validation(Required=false)]
        public string BankCard { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1739926800000</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>522132197411184XXX</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CTCC</para>
        /// </summary>
        [NameInMap("IspName")]
        [Validation(Required=false)]
        public string IspName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>19127612221</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B012DB99-6C10-5740-81E0-B3A8C1C1B9C1</para>
        /// </summary>
        [NameInMap("ReqId")]
        [Validation(Required=false)]
        public string ReqId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1760198400000</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>205</para>
        /// </summary>
        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("VehicleNum")]
        [Validation(Required=false)]
        public string VehicleNum { get; set; }

    }

}
