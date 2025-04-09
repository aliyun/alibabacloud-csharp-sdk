// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyGlobalQuestionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Answers")]
        [Validation(Required=false)]
        public string Answers { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ad80de88-1661-445a-92ec-bf88dc45d581</para>
        /// </summary>
        [NameInMap("GlobalQuestionId")]
        [Validation(Required=false)]
        public string GlobalQuestionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("GlobalQuestionName")]
        [Validation(Required=false)]
        public string GlobalQuestionName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMMON</para>
        /// </summary>
        [NameInMap("GlobalQuestionType")]
        [Validation(Required=false)]
        public string GlobalQuestionType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8fa1953f-4a84-46d8-b80c-8ce9cf684fb3</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Questions")]
        [Validation(Required=false)]
        public string Questions { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19ac2375-53e3-477f-abe9-6cd334227981</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

    }

}
