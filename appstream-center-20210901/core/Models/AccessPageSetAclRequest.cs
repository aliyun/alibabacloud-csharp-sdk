// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class AccessPageSetAclRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FREE_ACCESS</para>
        /// </summary>
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public string AccessMode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a-062wec3cwmayw****</para>
        /// </summary>
        [NameInMap("AccessPageId")]
        [Validation(Required=false)]
        public string AccessPageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>notepad_test</para>
        /// </summary>
        [NameInMap("AccessPageName")]
        [Validation(Required=false)]
        public string AccessPageName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("EffectTime")]
        [Validation(Required=false)]
        public int? EffectTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Day</para>
        /// </summary>
        [NameInMap("Unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}
