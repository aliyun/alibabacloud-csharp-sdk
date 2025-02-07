// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetHotSpotUniqListRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735010351000</para>
        /// </summary>
        [NameInMap("beg_end")]
        [Validation(Required=false)]
        public long? BegEnd { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735008551000</para>
        /// </summary>
        [NameInMap("beg_start")]
        [Validation(Required=false)]
        public long? BegStart { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1g2i0siirefgwnnnvy</para>
        /// </summary>
        [NameInMap("instance")]
        [Validation(Required=false)]
        public string Instance { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("pid")]
        [Validation(Required=false)]
        public long? Pid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>prof_on</para>
        /// </summary>
        [NameInMap("table")]
        [Validation(Required=false)]
        public string Table { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("uniq")]
        [Validation(Required=false)]
        public string Uniq { get; set; }

    }

}
