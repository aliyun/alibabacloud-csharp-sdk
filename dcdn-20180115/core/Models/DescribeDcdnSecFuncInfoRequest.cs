// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSecFuncInfoRequest : TeaModel {
        /// <summary>
        /// <para>The language. Valid values: en and zh. Default value: en.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The type of the drop-down list. Valid values: RobotRuleName and RobotObject.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RobotRuleName</para>
        /// </summary>
        [NameInMap("SecFuncType")]
        [Validation(Required=false)]
        public string SecFuncType { get; set; }

    }

}
