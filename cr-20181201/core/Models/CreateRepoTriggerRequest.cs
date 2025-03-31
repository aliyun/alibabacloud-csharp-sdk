// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateRepoTriggerRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xkx6vujuhay0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the image repository.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-xwvi3osiy4ff****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>The name of the trigger.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trigger1</para>
        /// </summary>
        [NameInMap("TriggerName")]
        [Validation(Required=false)]
        public string TriggerName { get; set; }

        /// <summary>
        /// <para>The image tag based on which the trigger is set.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If <c>TriggerType</c> is set to <c>ALL</c>, <c>TriggerTag</c> can be set to a string or an array, for example, <c>*</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>TriggerType</c> is set to <c>TAG_LIST</c>, <c>TriggerTag</c> must be set to an array, for example, <c>[1]</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>TriggerType</c> is set to <c>TAG_REG_EXP</c>, <c>TriggerTag</c> must be set to a string, for example, <c>*</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[1]</para>
        /// </summary>
        [NameInMap("TriggerTag")]
        [Validation(Required=false)]
        public string TriggerTag { get; set; }

        /// <summary>
        /// <para>The type of the trigger. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ALL</c>: a trigger that supports both tags and regular expressions.</description></item>
        /// <item><description><c>TAG_LIST</c>: a tag-based trigger.</description></item>
        /// <item><description><c>TAG_REG_EXP</c>: a regular expression-based trigger.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        /// <summary>
        /// <para>The URL of the trigger.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.mysite.com">http://www.mysite.com</a></para>
        /// </summary>
        [NameInMap("TriggerUrl")]
        [Validation(Required=false)]
        public string TriggerUrl { get; set; }

    }

}
