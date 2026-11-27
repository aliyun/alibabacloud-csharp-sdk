// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeUsageAreaDistributionStatDataRequest : TeaModel {
        /// <summary>
        /// <para>APP ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0rbd****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The end time of the query, expressed as a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615910399</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The parent region name. For example, the parent of Hangzhou City is Zhejiang Province, and the parameter should be set to China_Zhejiang Province. An empty parameter indicates statistics at the global scope (country dimension), such as China or the United Kingdom.</para>
        /// 
        /// <b>Example:</b>
        /// <para>中国_浙江省</para>
        /// </summary>
        [NameInMap("ParentArea")]
        [Validation(Required=false)]
        public string ParentArea { get; set; }

        /// <summary>
        /// <para>The start time of the query, expressed as a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615824000</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
