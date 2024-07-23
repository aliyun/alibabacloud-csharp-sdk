// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateAccessPageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AccessPageName")]
        [Validation(Required=false)]
        public string AccessPageName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c-e-06gdesdaxez****</para>
        /// </summary>
        [NameInMap("CloudEnvId")]
        [Validation(Required=false)]
        public string CloudEnvId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("EffectTime")]
        [Validation(Required=false)]
        public int? EffectTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-065zdecaer07h****</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Day</para>
        /// </summary>
        [NameInMap("Unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}
