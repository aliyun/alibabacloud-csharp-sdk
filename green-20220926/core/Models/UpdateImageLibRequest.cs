// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class UpdateImageLibRequest : TeaModel {
        /// <summary>
        /// <para>Comment information for the library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>备注</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Exemption from review configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FreeInspection")]
        [Validation(Required=false)]
        public int? FreeInspection { get; set; }

        /// <summary>
        /// <para>Library ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom_xxxx</para>
        /// </summary>
        [NameInMap("LibId")]
        [Validation(Required=false)]
        public string LibId { get; set; }

        /// <summary>
        /// <para>Library name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试图库</para>
        /// </summary>
        [NameInMap("LibName")]
        [Validation(Required=false)]
        public string LibName { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
