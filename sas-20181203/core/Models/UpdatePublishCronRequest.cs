// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdatePublishCronRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 5 10 * * ?</para>
        /// </summary>
        [NameInMap("Cron")]
        [Validation(Required=false)]
        public string Cron { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUN</para>
        /// </summary>
        [NameInMap("CronDay")]
        [Validation(Required=false)]
        public string CronDay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1657407600000</para>
        /// </summary>
        [NameInMap("CronTime")]
        [Validation(Required=false)]
        public long? CronTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("CronType")]
        [Validation(Required=false)]
        public string CronType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

    }

}
