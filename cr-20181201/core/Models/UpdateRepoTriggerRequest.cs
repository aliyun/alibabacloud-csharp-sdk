// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateRepoTriggerRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-kmsiwlxxdcva****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The image repository ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-tquyps22md8p****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>The trigger ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crw-k7bdx4kt52ty****</para>
        /// </summary>
        [NameInMap("TriggerId")]
        [Validation(Required=false)]
        public string TriggerId { get; set; }

        /// <summary>
        /// <para>The trigger name. This parameter is optional. You must specify either TriggerName or TriggerUrl.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_trigger</para>
        /// </summary>
        [NameInMap("TriggerName")]
        [Validation(Required=false)]
        public string TriggerName { get; set; }

        /// <summary>
        /// <para>The image version that triggers the trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("TriggerTag")]
        [Validation(Required=false)]
        public string TriggerTag { get; set; }

        /// <summary>
        /// <para>The trigger type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ALL</c>: all.</para>
        /// </description></item>
        /// <item><description><para><c>TAG_LISTTAG</c>: tag list.</para>
        /// </description></item>
        /// <item><description><para><c>TAG_REG_EXP</c>: regular expression.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        /// <summary>
        /// <para>The trigger URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.test.com">https://www.test.com</a></para>
        /// </summary>
        [NameInMap("TriggerUrl")]
        [Validation(Required=false)]
        public string TriggerUrl { get; set; }

    }

}
