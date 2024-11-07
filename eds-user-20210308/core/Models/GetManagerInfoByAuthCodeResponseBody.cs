// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class GetManagerInfoByAuthCodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The organization ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678901234****</para>
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// <para>The mobile number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1301234****</para>
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The team name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>devteam</para>
        /// </summary>
        [NameInMap("TeamName")]
        [Validation(Required=false)]
        public string TeamName { get; set; }

        /// <summary>
        /// <para>The tenant name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhangsan</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The ID of the Elastic Desktop Service account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678901234****</para>
        /// </summary>
        [NameInMap("WaId")]
        [Validation(Required=false)]
        public long? WaId { get; set; }

    }

}
