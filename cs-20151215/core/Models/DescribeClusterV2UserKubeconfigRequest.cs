// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterV2UserKubeconfigRequest : Darabonba.Model {
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public bool? PrivateIpAddress { get; set; }

        [NameInMap("TemporaryDurationMinutes")]
        [Validation(Required=false)]
        public long? TemporaryDurationMinutes { get; set; }

    }

}

