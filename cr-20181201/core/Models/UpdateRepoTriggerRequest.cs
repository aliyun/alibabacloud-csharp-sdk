// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateRepoTriggerRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-kmsiwlxxdcva****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the image repository.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-tquyps22md8p****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>The ID of the trigger.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crw-k7bdx4kt52ty****</para>
        /// </summary>
        [NameInMap("TriggerId")]
        [Validation(Required=false)]
        public string TriggerId { get; set; }

        /// <summary>
        /// <para>The name of the trigger.</para>
        /// <para>You can specify the TriggerName or TriggerUrl parameter. The TriggerName parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_trigger</para>
        /// </summary>
        [NameInMap("TriggerName")]
        [Validation(Required=false)]
        public string TriggerName { get; set; }

        /// <summary>
        /// <para>The image tag based on which the trigger is set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("TriggerTag")]
        [Validation(Required=false)]
        public string TriggerTag { get; set; }

        /// <summary>
        /// <para>The type of the trigger. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ALL</c>: a trigger that supports both tags and regular expressions.</description></item>
        /// <item><description><c>TAG_LISTTAG</c>: a tag-based trigger.</description></item>
        /// <item><description><c>TAG_REG_EXP</c>: a regular expression-based trigger.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TAG_LIST</para>
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        /// <summary>
        /// <para>The URL of the trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.test.com">https://www.test.com</a></para>
        /// </summary>
        [NameInMap("TriggerUrl")]
        [Validation(Required=false)]
        public string TriggerUrl { get; set; }

    }

}
