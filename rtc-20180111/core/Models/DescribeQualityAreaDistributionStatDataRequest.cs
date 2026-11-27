// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeQualityAreaDistributionStatDataRequest : TeaModel {
        /// <summary>
        /// <para>The app ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0rbd****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615910399</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>The name of the parent region. For example, the parent region of Hangzhou is Zhejiang Province, and the parameter is set to China_Zhejiang Province. If this parameter is left empty, the statistics are collected at the country level worldwide, such as China and the United Kingdom.</para>
        /// 
        /// <b>Example:</b>
        /// <para>China_Zhejiang Province</para>
        /// </summary>
        [NameInMap("ParentArea")]
        [Validation(Required=false)]
        public string ParentArea { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615824000</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

    }

}
