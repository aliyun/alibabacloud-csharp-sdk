// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageListBySensitiveFileRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The image digest.
        /// > Fuzzy match is supported.
        /// </summary>
        [NameInMap("ImageDigest")]
        [Validation(Required=false)]
        public string ImageDigest { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the container image.
        /// 
        /// > You can call the [ListRepository](~~ListRepository~~) operation to query the IDs of container images from the value of the InstanceId response parameter.
        /// </summary>
        [NameInMap("RepoInstanceId")]
        [Validation(Required=false)]
        public string RepoInstanceId { get; set; }

        /// <summary>
        /// The name of the image repository.
        /// 
        /// > Fuzzy match is supported.
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// The namespace to which the image repository belongs.
        /// > Fuzzy match is supported.
        /// </summary>
        [NameInMap("RepoNamespace")]
        [Validation(Required=false)]
        public string RepoNamespace { get; set; }

        /// <summary>
        /// The risk level of the file. Separate multiple levels with commas (,). Valid values:
        /// 
        /// - **high**
        /// - **medium**
        /// - **low**
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// An array consisting of the types of the assets that you want to scan. Valid values:
        /// - **image**
        /// - **container**
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public List<string> ScanRange { get; set; }

        /// <summary>
        /// The alert type of the sensitive file. Valid values:
        /// 
        /// *   **npm_token**: NPM Token
        /// *   **ftp_cfg**: FTP Config
        /// *   **google\_oauth_key**: Google OAuth Key
        /// *   **planetscale_passwd**: Planetscale password
        /// *   **github\_ssh_key**: Github SSH Key
        /// *   **msbuild\_publish_profile**: MSBuild publish profile
        /// *   **fastly\_cdn_token**: Fastly CDN Token
        /// *   **ssh\_private_key**: SSH Private Key
        /// *   **aws_cli**: AWS CLI Credentials
        /// *   **cpanel\_proftpd**: cPanel ProFTPd Credential
        /// *   **postgresql_passwd**: PostgreSQl Passwd
        /// *   **discord\_client_cred**: Discord Client Credential
        /// *   **rails_database**: Rails Database Config
        /// *   **aws\_access_key**: AWS Access Key
        /// *   **esmtp_cfg**: ESMTP Config
        /// *   **docker\_registry_cfg**: Docker Registry Config
        /// *   **pem**: PEM
        /// *   **common_cred**: Common Credential
        /// *   **sftp_cfg**: SFTP Config
        /// *   **grafana_token**: Grafana Token
        /// *   **slack_token**: Slack Token
        /// *   **ec\_private_key**: EC Private Key
        /// *   **pypi_token**: PyPI Token
        /// *   **finicity_token**: Finicity Token
        /// *   **k8s\_client_key**: Kubernetes Client Key
        /// *   **git_cfg**: Git Config
        /// *   **django_key**: Django Key
        /// *   **jenkins_ssh**: Jenkins SSH Config
        /// *   **openssh\_private_key**: OPENSSH Private Key
        /// *   **square_oauth**: Square OAuth Token
        /// *   **typeform_token**: Typeform Token
        /// *   **common\_database_cfg**: Common Database Config
        /// *   **wordpress\_database_cfg**: Wordpress Database Config
        /// *   **googlecloud\_api_key**: Google Cloud API Key
        /// *   **vscode_sftp**: VSCode SFTP Config
        /// *   **apache_htpasswd**: Apache htpasswd
        /// *   **planetscale_token**: Planetscale Token
        /// *   **contentful\_preview_token**: Contentful Preview Token
        /// *   **php\_database_cfg**: PHP Database Config
        /// *   **atom\_remote_sync**: Atom Remote Sync Config
        /// *   **aws\_session_token**: AWS Session Token
        /// *   **atom\_sftp_cfg**: Atom SFTP Config
        /// *   **asana\_client\_private_key**: Asana Client Private Key
        /// *   **tencentcloud_ak**: Tencent Cloud SecretId
        /// *   **rsa\_private_key**: RSA Private Key
        /// *   **github\_personal_token**: Github Personal Token
        /// *   **pgp**: PGP
        /// *   **stripe_skpk**: Stripe Secret Key
        /// *   **square_token**: Square Token
        /// *   **rails_carrierwave**: Rails Carrierwave Credential
        /// *   **dbeaver\_database_cfg**: DBeaver Database Config
        /// *   **robomongo_cred**: Robomongo Credential
        /// *   **github\_oauth_token**: Github OAuth Token
        /// *   **pulumi_token**: Pulumi Token
        /// *   **ventrilo_voip**: Ventrilo VoIP Server Config
        /// *   **macos_keychain**: macOS Keychain
        /// *   **amazon\_mws_token**: Amazon MWS Token
        /// *   **dynatrace_token**: Dynatrace Token
        /// *   **java_keystore**: Java Keystore
        /// *   **microsoft_sdf**: Microsoft SDF
        /// *   **kubernetes\_dashboard_cred**: Kubernetes Dashboard User Credential
        /// *   **atlassian_token**: Atlassian Token
        /// *   **rdp**: RDP
        /// *   **mailgun_key**: Mailgun Webhook Signing Key
        /// *   **mailchimp\_api_key**: Mailchimp API Key
        /// *   **netrc_cfg**: .netrc config
        /// *   **openvpn_cfg**: OpenVPN Config
        /// *   **github\_refresh_token**: Github Refresh Token
        /// *   **salesforce**: Salesforce Credential
        /// *   **sendinblue**: Sendinblue Token
        /// *   **pkcs\_private_key**: PKCS Private Key
        /// *   **rubyonrails_passwd**: Ruby on Rails Passwd
        /// *   **filezilla_ftp**: FileZilla FTP Config
        /// *   **databricks_token**: Databricks Token
        /// *   **gitLab\_personal_token**: GitLab Personal Token
        /// *   **rails\_master_key**: Rails Master Key
        /// *   **sqlite**: SQLite3/SQLite Database
        /// *   **firefox_logins**: Firefox Login Config
        /// *   **mailgun\_private_token**: Mailgun Private Token
        /// *   **joomla_cfg**: Joomla Config
        /// *   **hashicorp\_terraform_token**: Hashicorp Terraform Token
        /// *   **jetbrains_ides**: Jetbrains IDEs Config
        /// *   **heroku\_api_key**: Heroku API key
        /// *   **messagebird_token**: MessageBird Token
        /// *   **github\_app_token**: Github App Token
        /// *   **hashicorp\_vault_token**: Hashicorp Vault Token
        /// *   **pgp\_private_key**: PGP Private Key
        /// *   **sshpasswd**: SSH password
        /// *   **huaweicloud_ak**: Huaei Cloud Access Key
        /// *   **aws_s3cmd**: AWS S3cmd Config
        /// *   **php_config**: php Config
        /// *   **common\_private_key**: Common Private Key Type
        /// *   **microsoft_mdf**: Microsoft MDF
        /// *   **mediawiki_cfg**: MediaWiki Config
        /// *   **jenkins_cred**: Jenkins Credential
        /// *   **rubygems_cred**: Rubygems Credential
        /// *   **clojars_token**: Clojars Token
        /// *   **phoenix\_web_passwd**: Phoenix Web Credential
        /// *   **puttygen\_private_key**: PuTTYgen Private Key
        /// *   **google\_oauth_token**: Google Oauth Token
        /// *   **rubyonrails_cfg**: Ruby On Rails Database Config
        /// *   **lob\_api_key**: Lob API Key
        /// *   **pkcs_cred**: PKCS#12
        /// *   **otr\_private_key**: OTR Private Key
        /// *   **contentful\_delivery_token**: Contentful Delivery Token
        /// *   **digital\_ocean_tugboat**: Digital Ocean Tugboat Config
        /// *   **dsa\_private_key**: DSA Private Key
        /// *   **rails\_app_token**: Rails App Token
        /// *   **git_cred**: Git User Credential
        /// *   **newrelic\_api_key**: New Relic User API Key
        /// *   **github_hub**: Github Token
        /// *   **rubygem**: Rubygem Token
        /// </summary>
        [NameInMap("SensitiveFileKey")]
        [Validation(Required=false)]
        public string SensitiveFileKey { get; set; }

    }

}
