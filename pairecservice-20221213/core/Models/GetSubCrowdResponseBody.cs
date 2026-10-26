// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetSubCrowdResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the crowd was created. The time is in ISO 8601 format and includes the time zone offset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The number of users in the crowd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public string Quantity { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>01D22D08-BA20-5F35-8302-99115F288220</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The source of the crowd. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ManualInput: manual input</description></item>
        /// <item><description>UploadFile: file upload</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ManualInput</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The users in the crowd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1,user2</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public string Users { get; set; }

    }

}
