// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageSensitiveFileListShrinkRequest : TeaModel {
        /// <summary>
        /// The value of the sensitive file type.
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// The number of scans that are performed on the sensitive file.
        /// </summary>
        [NameInMap("CriteriaType")]
        [Validation(Required=false)]
        public string CriteriaType { get; set; }

        /// <summary>
        /// The UUID of the image.
        /// 
        /// >  You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the UUIDs of images from the value of the **ImageUuid** response parameter.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The query type of sensitive files. Valid values:
        /// 
        /// *   **SensitiveFileKey**: the alert type for sensitive files. Valid values:
        /// 
        ///     *   **npm_token**: npm access token
        ///     *   **ftp_cfg**: FTP configuration
        ///     *   **google_oauth_key**: Google OAuth key
        ///     *   **planetscale_passwd**: PlanetScale password
        ///     *   **github_ssh_key**: GitHub SSH key
        ///     *   **msbuild_publish_profile**: MSBuild publish profile
        ///     *   **fastly_cdn_token**: Fastly CDN token
        ///     *   **ssh_private_key**: SSH private key
        ///     *   **aws_cli**: AWS CLI credential
        ///     *   **cpanel_proftpd**: cPanel ProFTPD credential
        ///     *   **postgresql_passwd**: PostgreSQL password file
        ///     *   **discord_client_cred**: Discord client credential
        ///     *   **rails_database**: Rails database configuration
        ///     *   **aws_access_key**: AWS access key
        ///     *   **esmtp_cfg** :configuration of Extended Simple Mail Transfer Protocol (ESMTP)
        ///     *   **docker_registry_cfg**: configuration of a Docker image repository
        ///     *   **pem**: Privacy-Enhanced Mail (PEM)
        ///     *   **common_cred**: common credential
        ///     *   **sftp_cfg**: SFTP connection configuration
        ///     *   **grafana_token**: Grafana token
        ///     *   **slack_token**: Slack token
        ///     *   **ec_private_key**: EC private key
        ///     *   **pypi_token**: upload token for the Python Package Index (PyPI)
        ///     *   **finicity_token**: Finicity token
        ///     *   **k8s_client_key**: Kubernetes private key
        ///     *   **git_cfg**: Git configuration
        ///     *   **django_key**: Django key
        ///     *   **jenkins_ssh**: Jenkins SSH configuration file
        ///     *   **openssh_private_key**: OpenSSL private key
        ///     *   **square_oauth**: OAuth credential for Square
        ///     *   **typeform_token**: Typeform token
        ///     *   **common_database_cfg**: general database connection configuration
        ///     *   **wordpress_database_cfg**: WordPress database configuration
        ///     *   **googlecloud_api_key**: API key for Google Cloud
        ///     *   **vscode_sftp**: VSCode SFTP configuration
        ///     *   **apache_htpasswd**: Apache htpasswd
        ///     *   **planetscale_token**: PlanetScale token
        ///     *   **contentful_preview_token**: preview token for Contentful
        ///     *   **php_database_cfg**: database password for a PHP application
        ///     *   **atom_remote_sync**: Atom remote synchronization configuration
        ///     *   **aws_session_token**: AWS session token
        ///     *   **atom_sftp_cfg**: Atom SFTP configuration
        ///     *   **tencentcloud_ak**: Asana client key
        ///     *   **tencentcloud_ak**: secret ID of a third-party cloud
        ///     *   **rsa_private_key**: RSA private key
        ///     *   **github_personal_token**: personal access token for GitHub
        ///     *   **pgp**: Pretty Good Privacy (PGP) encrypted file
        ///     *   **stripe_skpk**: Stripe secret key
        ///     *   **square_token**: Square access token
        ///     *   **rails_carrierwave**: file upload credential for Rails Carrierwave
        ///     *   **dbeaver_database_cfg**: DBeaver database configuration
        ///     *   **robomongo_cred**: credential for RoboMongo
        ///     *   **github_oauth_token**: OAuth access token for GitHub
        ///     *   **pulumi_token**: Pulumi token
        ///     *   **ventrilo_voip**: configuration of a Ventrilo VoIP server
        ///     *   **macos_keychain**: macOS keychain
        ///     *   **amazon_mws_token**: Amazon MWS token
        ///     *   **dynatrace_token**: Dynatrace token
        ///     *   **java_keystore**: Java KeyStore (JKS)
        ///     *   **microsoft_sdf**: Microsoft SQL Server Compact Edition (CE) database
        ///     *   **kubernetes_dashboard_cred**: user credential for Kubernetes Dashboard
        ///     *   **atlassian_token**: Atlassian token
        ///     *   **rdp**: remote desktop protocol (RDP)
        ///     *   **mailgun_key**: Mailgun webhook signing key
        ///     *   **mailchimp_api_key**: API key for Mailchimp
        ///     *   **netrc_cfg**: .netrc configuration file
        ///     *   **openvpn_cfg**: OpenVPN configuration
        ///     *   **github_refresh_token**: GitHub refresh token
        ///     *   **salesforce**: Salesforce credential
        ///     *   **salesforce**: Sendinblue credential
        ///     *   **pkcs_private_key**: PKCS#12 key
        ///     *   **rubyonrails_passwd**: Ruby on Rails password file
        ///     *   **filezilla_ftp**: FileZilla FTP configuration
        ///     *   **databricks_token**: Databricks token
        ///     *   **gitLab_personal_toke**: personal access token for GitLab
        ///     *   **rails_master_key**: Rails master key
        ///     *   **sqlite**: SQLite3 or SQLite database
        ///     *   **firefox_logins**: Firefox logon configuration
        ///     *   **mailgun_private_token**: Mailgun private token
        ///     *   **joomla_cfg**: Joomla configuration
        ///     *   **hashicorp_terraform_token**: HashiCorp Terraform token
        ///     *   **jetbrains_ides**: JetBrains IDEs configuration
        ///     *   **heroku_api_key**: Heroku API key
        ///     *   **messagebird_token**: MessageBird token
        ///     *   **messagebird_token**: MessageBird token
        ///     *   **hashicorp_vault_token**: HashiCorp Vault token
        ///     *   **pgp_private_key**: PGP private key
        ///     *   **sshpasswd**: SSH password
        ///     *   **huaweicloud_ak**: secret access key of a third-party cloud
        ///     *   **aws_s3cmd**: AWS S3cmd configuration
        ///     *   **php_config**: PHP configuration
        ///     *   **common_private_key**: private key of a common type
        ///     *   **microsoft_mdf**: Microsoft SQL Server database
        ///     *   **mediawiki_cfg**: MediaWiki configuration
        ///     *   **jenkins_cred**: Jenkins credential
        ///     *   **rubygems_cred**: RubyGems credential
        ///     *   **clojars_token**: Clojars token
        ///     *   **phoenix_web_passwd**: Phoenix web credential
        ///     *   **puttygen_private_key**: PuTTYgen private key
        ///     *   **google_oauth_token**: Google OAuth access token
        ///     *   **rubyonrails_cfg**: Ruby On Rails database configuration
        ///     *   **lob_api_key**: Lob API key
        ///     *   **pkcs_cred**: PKCS#12 certificate
        ///     *   **otr_private_key**: Off-the-Record Messaging (OTR) private key
        ///     *   **contentful_delivery_token**: delivery token for Contentful
        ///     *   **digital_ocean_tugboat**: DigitalOcean Tugboat configuration
        ///     *   **dsa_private_key**: Digital Signature Algorithm (DSA) private key
        ///     *   **rails_app_token**: Rails app token
        ///     *   **git_cred**: Git user credential
        ///     *   **newrelic_api_key**: User API key for New Relic
        ///     *   **github_hub**: hub configuration for storing GitHub tokens
        ///     *   **rubygem**: RubyGem token
        /// 
        /// *   **SensitiveFileName**: the name of the alert type for sensitive files.
        /// </summary>
        [NameInMap("ImageUuid")]
        [Validation(Required=false)]
        public string ImageUuid { get; set; }

        /// <summary>
        /// An array that consists of the information about the sensitive files.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The returned information about the sensitive files.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The timestamp when the last scan was performed. Unit: milliseconds.
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// The key of the last data entry.
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public string ScanRangeShrink { get; set; }

    }

}
