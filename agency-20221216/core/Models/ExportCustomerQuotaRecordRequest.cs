// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class ExportCustomerQuotaRecordRequest : TeaModel {
        /// <summary>
        /// <para>End Date Format:  yyyy-MM-dd</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-24</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>Customer UID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5113766248601929</para>
        /// </summary>
        [NameInMap("EndUserPk")]
        [Validation(Required=false)]
        public long? EndUserPk { get; set; }

        /// <summary>
        /// <para>Multilingual Parameters, the default language is English.</br>
        /// en: English</br>
        /// zh: Chinese</br>
        /// ja: Japanese </br></para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>Operation Type Enum</br>
        /// all All types</br>
        /// quota_create Create quota</br>
        /// quota_amount_adjust Adjust the amount of quota</br></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// <para>Start Date Format:  yyyy-MM-dd</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-11-10</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
