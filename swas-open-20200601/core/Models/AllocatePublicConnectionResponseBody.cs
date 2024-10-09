// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class AllocatePublicConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The public endpoint that is assigned to the Simple Database Service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db-38263fa955774501a2ae1bdaed6f****.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("PublicConnection")]
        [Validation(Required=false)]
        public string PublicConnection { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30637AD6-D977-4833-A54C-CC89483E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
