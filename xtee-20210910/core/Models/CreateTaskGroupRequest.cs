// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateTaskGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("SampleIds")]
        [Validation(Required=false)]
        public string SampleIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[\&quot;porn\&quot;,\&quot;terrorism\&quot;,\&quot;ad\&quot;]</para>
        /// </summary>
        [NameInMap("Scenes")]
        [Validation(Required=false)]
        public string Scenes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("ServiceCodes")]
        [Validation(Required=false)]
        public string ServiceCodes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("ServiceNames")]
        [Validation(Required=false)]
        public string ServiceNames { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INTERNET</para>
        /// </summary>
        [NameInMap("Tab")]
        [Validation(Required=false)]
        public string Tab { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TeskGroupTest</para>
        /// </summary>
        [NameInMap("TaskGroupName")]
        [Validation(Required=false)]
        public string TaskGroupName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SAF_CONSOLE</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
