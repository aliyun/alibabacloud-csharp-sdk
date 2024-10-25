// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeServcieScheduleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>474bdef0-d149-4695-abfb-52912d91****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>This parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>android</para>
        /// </summary>
        [NameInMap("PodConfigName")]
        [Validation(Required=false)]
        public string PodConfigName { get; set; }

        /// <summary>
        /// <para>The unique ID of the device.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdm_f022bf160dc69e2d8eb421e508eb****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
