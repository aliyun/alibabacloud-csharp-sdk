// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeListFaceVerifyDataRequest : TeaModel {
        /// <summary>
        /// <para>End time of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1760630399999</para>
        /// </summary>
        [NameInMap("GmtEnd")]
        [Validation(Required=false)]
        public long? GmtEnd { get; set; }

        /// <summary>
        /// <para>Start time of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1760025600000</para>
        /// </summary>
        [NameInMap("GmtStart")]
        [Validation(Required=false)]
        public long? GmtStart { get; set; }

        /// <summary>
        /// <para>Product Code, currently deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Liveness</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Scene ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000339</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

    }

}
