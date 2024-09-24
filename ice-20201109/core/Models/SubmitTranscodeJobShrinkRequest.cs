// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTranscodeJobShrinkRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputGroup")]
        [Validation(Required=false)]
        public string InputGroupShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>job-name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OutputGroup")]
        [Validation(Required=false)]
        public string OutputGroupShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>job-name</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public string ScheduleConfigShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user-data</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
