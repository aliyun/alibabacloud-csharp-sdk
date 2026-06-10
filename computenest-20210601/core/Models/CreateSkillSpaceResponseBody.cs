// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CreateSkillSpaceResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>13FE89A5-C036-56BF-A0FF-A31C59819FD7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>SkillSpace ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>ss-11111</para>
        /// </summary>
        [NameInMap("SkillSpaceId")]
        [Validation(Required=false)]
        public string SkillSpaceId { get; set; }

    }

}
