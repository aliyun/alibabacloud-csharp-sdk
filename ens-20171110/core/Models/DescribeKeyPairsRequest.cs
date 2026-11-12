// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeKeyPairsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the key pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ssh-50cynkq42sgj4ej1tn78t4***</para>
        /// </summary>
        [NameInMap("KeyPairId")]
        [Validation(Required=false)]
        public string KeyPairId { get; set; }

        /// <summary>
        /// <para>The name of the key pair. The name must be 2 to 128 characters in length and can contain letters and Chinese characters. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. It can contain the following characters:</para>
        /// <list type="bullet">
        /// <item><description>Digits</description></item>
        /// <item><description>:</description></item>
        /// <item><description>_</description></item>
        /// <item><description>.</description></item>
        /// </list>
        /// <para>Only a single name is supported. By default, information about all key pairs is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestKeyPairName</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: integers greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The paging Settings for the number of entries per page in a paged query. Valid values: integers greater than 0. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
