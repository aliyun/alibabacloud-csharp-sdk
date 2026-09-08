// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListSmsMetadataRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number. The value ranges from 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The value ranges from 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the scenario. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SATISFACTION_SURVEY: satisfaction survey</para>
        /// </description></item>
        /// <item><description><para>CONTACT_FLOW_NODE: Interactive Voice Response (IVR) flow node</para>
        /// </description></item>
        /// <item><description><para>MISSED_CALL_NOTIFICATION: missed call notification</para>
        /// </description></item>
        /// <item><description><para>FLASH_SMS: Alibaba Cloud flash SMS notification</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;SATISFACTION_SURVEY&quot;,&quot;CONTACT_FLOW_NODE&quot;]</para>
        /// </summary>
        [NameInMap("ScenarioListJson")]
        [Validation(Required=false)]
        public string ScenarioListJson { get; set; }

    }

}
