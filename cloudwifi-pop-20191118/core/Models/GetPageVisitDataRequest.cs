// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudwifi_pop20191118.Models
{
    public class GetPageVisitDataRequest : TeaModel {
        /// <summary>
        /// <para>appCode</para>
        /// 
        /// <b>Example:</b>
        /// <para>3c0837d5-e65b-11ec-9985-02420bb080c6</para>
        /// </summary>
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        /// <summary>
        /// <para>appName</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLOUD_NETWORK</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>endTime</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-07-11</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>pId</para>
        /// 
        /// <b>Example:</b>
        /// <para>19048</para>
        /// </summary>
        [NameInMap("PId")]
        [Validation(Required=false)]
        public string PId { get; set; }

        /// <summary>
        /// <para>startTime</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-22</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
